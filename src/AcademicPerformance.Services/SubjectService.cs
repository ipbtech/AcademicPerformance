using AcademicPerformance.Contracts;
using AcademicPerformance.DAL;
using AcademicPerformance.DTO;
using AcademicPerformance.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AcademicPerformance.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<SubjectService> _logger;

        public SubjectService(AppDbContext dbContext, IMapper mapper, ILogger<SubjectService> logger)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<SubjectDto>> GetAllAsync()
        {
            try
            {
                var subjects = await _dbContext.Subjects.AsNoTracking().ToListAsync();
                return _mapper.Map<IEnumerable<SubjectDto>>(subjects);
            }
            catch (Exception ex) 
            {
                _logger.LogError("Unhandled {@Exception} was occurs with message:{@Message}", ex, ex.Message);
                throw;
            }
        }


        public async Task<IEnumerable<SubjectDto>> GetAllWithScoresAsync()
        {
            try
            {
                var subjects = await _dbContext.Subjects.AsNoTracking()
                    .Include(s => s.Scores).ToListAsync();

                return _mapper.Map<IEnumerable<SubjectDto>>(subjects);
            }
            catch (Exception ex)
            {
                _logger.LogError("Unhandled {@Exception} was occurs with message:{@Message}", ex, ex.Message);
                throw;
            }
        }

        public async Task<SubjectDto?> GetByIdAsync(int id)
        {
            try
            {
                var subject = await _dbContext.Subjects.FindAsync(id);
                return _mapper.Map<SubjectDto>(subject);
            }
            catch (Exception ex)
            {
                _logger.LogError("Unhandled {@Exception} was occurs with message:{@Message}", ex, ex.Message);
                throw;
            }
        }

        public async Task CreateAsync(SubjectDto subjectDto)
        {
            try
            {
                var subject = _mapper.Map<Subject>(subjectDto);
                await _dbContext.Subjects.AddAsync(subject);
                await _dbContext.SaveChangesAsync();
                _logger.LogInformation("New subject with Id:{@SubjectId} was created", subject.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError("Unhandled {@Exception} was occurs with message:{@Message}", ex, ex.Message);
                throw;
            }
        }

        public async Task UpdateAsync(int id, SubjectDto subjectDto)
        {
            try
            {
                var subject = await _dbContext.Subjects.FindAsync(id);
                _mapper.Map(subjectDto, subject);

                _dbContext.Subjects.Update(subject);
                await _dbContext.SaveChangesAsync();
                _logger.LogInformation("Subject with Id:{@SubjectId} was updated", subject.Id);
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
                var subject = await _dbContext.Subjects.FindAsync(id);
                if (subject is not null)
                {
                    _dbContext.Subjects.Remove(subject);
                    await _dbContext.SaveChangesAsync();
                    _logger.LogInformation("Subject with Id:{@SubjectId} was deleted", id);
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
