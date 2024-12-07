using AcademicPerformance.DTO;

namespace AcademicPerformance.Contacts
{
    public interface ISubjectService
    {
        public Task<IEnumerable<SubjectDto>> GetAllAsync();
        public Task<SubjectDto?> GetByIdAsync(int id);
        public Task CreateAsync(SubjectDto subjectDto);
        public Task UpdateAsync(int id, SubjectDto subjectDto);
        public Task DeleteAsync(int subjectId);
    }
}
