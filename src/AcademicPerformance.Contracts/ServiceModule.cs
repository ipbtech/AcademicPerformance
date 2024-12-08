using AcademicPerformance.DTO;

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
}
