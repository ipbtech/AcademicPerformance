using AcademicPerformance.Contracts;
using AcademicPerformance.DAL;
using AcademicPerformance.DTO.Reports;
using AcademicPerformance.Entities.Enums;
using AcademicPerformance.Entities.Projections;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AcademicPerformance.Services
{
    public class ReportService : IReportService
    {
        private readonly AppDbContext _dbContext;
        private readonly ILogger<ReportService> _logger;

        public ReportService(AppDbContext dbContext, ILogger<ReportService> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<TotalGradesDto> GetTotalGradesAsync()
        {
            try
            {
                var scores = await _dbContext.Scores.AsNoTracking()
                    .Select(s => s.ScoreValue).ToListAsync();

                var gradeValues = scores.OrderBy(s => s).GroupBy(s => s)
                    .Select(s => s.Select(x => (double)x).Sum()).ToArray();
                var gradeNames = scores.OrderBy(s => s).Distinct()
                    .Select(s => s.ToString()).ToArray();

                var studentsCount = await _dbContext.Students.AsNoTracking().CountAsync();
                var subjectsCount = await _dbContext.Subjects.AsNoTracking().CountAsync();

                return new TotalGradesDto()
                {
                    StudentsTotal = studentsCount,
                    SubjectsTotal = subjectsCount,
                    AvarageGrade = Math.Round(scores.Select(s => (int)s).Average(), 1),
                    GradeValues = gradeValues,
                    GradeNames = gradeNames,
                };
            }
            catch (Exception ex)
            {
                _logger.LogError("Unhandled {@Exception} was occurs with message:{@Message}", ex, ex.Message);
                throw;
            }
        }

        public async Task<GradesBySubjectsDto> GetGradesBySubjectsAsync()
        {
            try
            {
                var gradesBySubjs = await _dbContext.Subjects.AsNoTracking().Include(s => s.Scores)
                    .GroupBy(subj => subj.Id)
                    .Select(subj => new SubjectScoresView
                    {
                        SubjectName = subj.First().Name,
                        ScoreValues = subj.SelectMany(s => s.Scores.Select(s => s.ScoreValue)).ToList()
                    }).ToListAsync();

                var labels = gradesBySubjs.Select(subj => subj.SubjectName).ToArray();
                var series = CalculateGradeValues(gradesBySubjs);
                return new GradesBySubjectsDto
                {
                    SubjectNames = labels,
                    GradeValues = series,
                };
            }
            catch (Exception ex)
            {
                _logger.LogError("Unhandled {@Exception} was occurs with message:{@Message}", ex, ex.Message);
                throw;
            }
        }

        private GradeValuesDto[] CalculateGradeValues(List<SubjectScoresView> subjectScoresViews)
        {
            var gradesByLabel = subjectScoresViews.Select(subj => subj.ScoreValues
                .OrderBy(s => s).GroupBy(s => s)
                .Select(s => new
                {
                    Score = s.Key,
                    GradesCount = s.Count()
                })).ToList();

            List<GradeValuesDto> valuesDto = new();
            foreach (var scoreValue in Enum.GetValues<ScoreValue>())
            {
                List<double> gradeValues = new();
                foreach (var labelGrades in gradesByLabel)
                {
                    var grade = labelGrades.FirstOrDefault(s => s.Score == scoreValue);
                    if (grade is not null)
                        gradeValues.Add(grade.GradesCount);
                    else
                        gradeValues.Add(0);
                }
                valuesDto.Add(new GradeValuesDto
                {
                    Name = scoreValue.ToString(),
                    Values = gradeValues.ToArray()
                });
            }
            return valuesDto.ToArray();
        }
    }
}
