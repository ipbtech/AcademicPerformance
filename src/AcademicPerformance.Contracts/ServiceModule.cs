using AcademicPerformance.DTO;
using AcademicPerformance.DTO.Reports;

namespace AcademicPerformance.Contracts
{
    public interface ISubjectService : IService<SubjectDto>
    {
        public Task<IEnumerable<SubjectDto>> GetAllWithScoresAsync();
    }

    public interface IStudentService : IService<StudentDto> 
    {
        public Task<IEnumerable<ScoreDto>> GetStudentScoresAsync(int studentId);
        public Task UpdateStudentScoresAsync(IEnumerable<ScoreDto> scores);
    }

    public interface IReportService
    {
        public Task<TotalGradesDto> GetTotalGradesAsync();
        public Task<GradesBySubjectsDto> GetGradesBySubjectsAsync();
    }
}
