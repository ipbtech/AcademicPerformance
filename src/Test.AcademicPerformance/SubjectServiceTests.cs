using AcademicPerformance.Contracts;
using AcademicPerformance.DTO;
using AcademicPerformance.Services;
using Microsoft.Extensions.Logging;
using Moq;
using Test.AcademicPerformance.Base;

namespace Test.AcademicPerformance
{
    [TestCaseOrderer(
        "Test.AcademicPerformance.Base.PriorityOrderer",
        "Test.AcademicPerformance")]
    public class SubjectServiceTests : TestContext
    { 
        private ILogger<SubjectService> _logger;
        private readonly ISubjectService _subjectService;
        
        public SubjectServiceTests() : base()
        {
            _logger = new Mock<ILogger<SubjectService>>().Object;
            _subjectService = new SubjectService(dbContext, mapper, _logger);
        }


        [Fact, TestPriority(1)]
        public async Task GetAll_Success()
        {
            //Arrange
            var count = TestData.Subjects.Count();

            //Act
            var subjs = await _subjectService.GetAllAsync();

            //Assert
            Assert.NotNull(subjs);
            Assert.Equal(count, subjs.Count());
            Assert.True(subjs.Select(s => s.Score).Any(s => s == 0));
        }


        [Fact, TestPriority(2)]
        public async Task GetAllWithScores_Success()
        {
            //Arrange
            var count = TestData.Subjects.Count();

            //Act
            var subjs = await _subjectService.GetAllWithScoresAsync();

            //Assert
            Assert.NotNull(subjs);
            Assert.Equal(count, subjs.Count());
        }


        [Fact, TestPriority(3)]
        public async Task GetById_Success()
        {
            //Arrange
            var first = TestData.Subjects.First();

            //Act
            var subj = await _subjectService.GetByIdAsync(first.Id);

            //Assert
            Assert.Equal(first.Id, subj.Id);
        }


        [Fact, TestPriority(4)]
        public async Task GetById_IsNotExist()
        {
            //Arrange
            var notExistId = 777;

            //Act
            var subj = await _subjectService.GetByIdAsync(notExistId);

            //Assert
            Assert.Null(subj);
        }


        [Fact, TestPriority(5)]
        public async Task Create_Success()
        {
            //Arrange
            var dto = new SubjectDto { Name = "TestCreate" };

            //Act
            await _subjectService.CreateAsync(dto);
            var subjs = await _subjectService.GetAllAsync();

            //Assert
            Assert.NotNull(subjs.FirstOrDefault(s => s.Name == dto.Name));
        }


        [Fact, TestPriority(6)]
        public async Task Update_Success()
        {
            //Arrange
            var first = TestData.Subjects.First();
            var dto = mapper.Map<SubjectDto>(first);
            dto.Name = "TestUpdate";

            //Act
            await _subjectService.UpdateAsync(first.Id, dto);
            var subjs = await _subjectService.GetAllAsync();

            //Assert
            Assert.NotNull(subjs.FirstOrDefault(s => s.Name == dto.Name));
        }


        [Fact, TestPriority(7)]
        public async Task Delete_Success()
        {
            //Arrange
            var first = TestData.Subjects.First();

            //Act
            await _subjectService.DeleteAsync(first.Id);
            var subjs = await _subjectService.GetAllAsync();

            //Assert
            Assert.True(!subjs.Any(s => s.Id == first.Id));
        }
    }
}
