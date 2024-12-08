using AcademicPerformance.Contracts;
using AcademicPerformance.DAL;
using AcademicPerformance.DTO;
using AcademicPerformance.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AcademicPerformance.Services
{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<SubjectService> _logger;

        public StudentService(AppDbContext dbContext, IMapper mapper, ILogger<SubjectService> logger)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<StudentDto>> GetAllAsync()
        {
            try
            {
                var students = await _dbContext.Students.AsNoTracking()
                    .Include(s => s.Scores).ToListAsync();

                return _mapper.Map<IEnumerable<StudentDto>>(students);
            }
            catch (Exception ex)
            {
                _logger.LogError("Unhandled {@Exception} was occurs with message:{@Message}", ex, ex.Message);
                throw;
            }
        }

        public async Task<StudentDto?> GetByIdAsync(int id)
        {
            try
            {
                var student = await _dbContext.Students.FindAsync(id);
                return _mapper.Map<StudentDto>(student);
            }
            catch (Exception ex)
            {
                _logger.LogError("Unhandled {@Exception} was occurs with message:{@Message}", ex, ex.Message);
                throw;
            }
        }

        public async Task<IEnumerable<ScoreDto>> GetStudentScoresAsync(int studentId)
        {
            try
            {
                var scores = await _dbContext.Scores.AsNoTracking()
                    .Where(sc => sc.StudentId == studentId).ToListAsync();

                return _mapper.Map<IEnumerable<ScoreDto>>(scores);
            }
            catch (Exception ex)
            {
                _logger.LogError("Unhandled {@Exception} was occurs with message:{@Message}", ex, ex.Message);
                throw;
            }
        }

        public async Task CreateAsync(StudentDto dto)
        {
            using (var trans = await _dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var student = _mapper.Map<Student>(dto);
                    await _dbContext.Students.AddAsync(student);
                    await _dbContext.SaveChangesAsync();

                    var scores = _mapper.Map<List<Score>>(dto.Scores);
                    scores.ForEach(s => s.StudentId = student.Id);
                    await _dbContext.Scores.AddRangeAsync(scores);
                    await _dbContext.SaveChangesAsync();
                    await trans.CommitAsync();
                    _logger.LogInformation("Student with Id:{@StudentId} was created", student.Id);
                }
                catch (Exception ex)
                {
                    await trans.RollbackAsync();
                    _logger.LogError("Unhandled {@Exception} was occurs with message:{@Message}", ex, ex.Message);
                    throw;
                }
            }
        }

        public async Task UpdateAsync(int id, StudentDto studentDto)
        {
            try
            {
                var student = await _dbContext.Students.FindAsync(id);
                _mapper.Map(studentDto, student);

                _dbContext.Students.Update(student);
                await _dbContext.SaveChangesAsync();
                _logger.LogInformation("Student with Id:{@StudentId} was updated", student.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError("Unhandled {@Exception} was occurs with message:{@Message}", ex, ex.Message);
                throw;
            }
        }

        public async Task UpdateStudentScoresAsync(IEnumerable<ScoreDto> scoresDto)
        {
            try
            {
                var scores = _mapper.Map<IEnumerable<Score>>(scoresDto);
                
                _dbContext.Scores.UpdateRange(scores);
                await _dbContext.SaveChangesAsync();
                _logger.LogInformation("Scores for student with Id:{@StudentId} were updated", scores.FirstOrDefault()?.StudentId);
            }
            catch (Exception ex)
            {
                _logger.LogError("Unhandled {@Exception} was occurs with message:{@Message}", ex, ex.Message);
                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var student = await _dbContext.Students.FindAsync(id);
                if (student is not null)
                {
                    _dbContext.Students.Remove(student);
                    await _dbContext.SaveChangesAsync();
                    _logger.LogInformation("Student with Id:{@StudentId} was deleted", id);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Unhandled {@Exception} was occurs with message:{@Message}", ex, ex.Message);
                throw;
            }
        }
    }
}
