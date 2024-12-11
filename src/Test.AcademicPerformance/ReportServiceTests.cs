using AcademicPerformance.Contracts;
using AcademicPerformance.Entities.Enums;
using AcademicPerformance.Services;
using Microsoft.Extensions.Logging;
using Moq;
using Test.AcademicPerformance.Base;

namespace Test.AcademicPerformance
{
    public class ReportServiceTests : TestContext
    { 
        private ILogger<ReportService> _logger;
        private readonly IReportService _reportService;
        
        public ReportServiceTests() : base()
        {
            _logger = new Mock<ILogger<ReportService>>().Object;
            _reportService = new ReportService(dbContext, _logger);
        }

        [Fact]
        public async Task GetTotalGrades_Success()
        {
            //Arrange
            var studentsCount = TestData.Students.Count();
            var subjectsCount = TestData.Subjects.Count();
            var averageGrade = Math.Round(TestData.Scores.Select(s => (int)s.ScoreValue).Average(), 1);
            var gradeValues = TestData.Scores.Select(s => (int)s.ScoreValue)
                .OrderBy(s => s).GroupBy(s => s).Select(s => s.Select(x => (double)x).Sum()).ToList();
            var gradeNames = TestData.Scores.Select(s => s.ScoreValue)
                .Distinct().Select(s => s.ToString()).ToList();

            //Act
            var totalGrades = await _reportService.GetTotalGradesAsync();

            //Assert
            Assert.Equal(studentsCount, totalGrades.StudentsTotal);
            Assert.Equal(subjectsCount, totalGrades.SubjectsTotal);
            Assert.Equal(averageGrade, totalGrades.AvarageGrade);
            Assert.True(totalGrades.GradeNames.All(gradeNames.Contains));
            Assert.True(totalGrades.GradeValues.All(gradeValues.Contains));
        }

        [Fact]
        public async Task GetGradesBySubjects_Success()
        {
            //Arrange
            var subjs = TestData.Subjects.Select(x => x.Name).ToList();
            var gradesEnumCount = Enum.GetValues<ScoreValue>().Length;

            //Act
            var grades = await _reportService.GetGradesBySubjectsAsync();

            //Assert
            Assert.Equal(gradesEnumCount, grades.GradeValues.Length);
            Assert.Equal(subjs.Count(), grades.SubjectNames.Count());
            Assert.True(subjs.All(grades.SubjectNames.Contains));
        }
    }
}
