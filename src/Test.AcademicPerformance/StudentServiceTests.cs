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
    public class StudentServiceTests : TestContext
    {
        private ILogger<StudentService> _loggerStudents;
        private readonly IStudentService _studentService;

        private ILogger<SubjectService> _loggerSubjects;
        private readonly ISubjectService _subjectService;

        public StudentServiceTests() : base()
        {
            _loggerStudents = new Mock<ILogger<StudentService>>().Object;
            _studentService = new StudentService(dbContext, mapper, _loggerStudents);

            _loggerSubjects = new Mock<ILogger<SubjectService>>().Object;
            _subjectService = new SubjectService(dbContext, mapper, _loggerSubjects);
        }


        [Fact, TestPriority(1)]
        public async Task GetAll_Success()
        {
            //Arrange
            var count = TestData.Students.Count();

            //Act
            var students = await _studentService.GetAllAsync();

            //Assert
            Assert.NotNull(students);
            Assert.Equal(count, students.Count());
        }


        [Fact, TestPriority(2)]
        public async Task GetStudentScores_Success()
        {
            //Arrange
            var first = TestData.Students.First();
            var scoresArrange = TestData.Scores.Where(sc => sc.StudentId == first.Id);

            //Act
            var scores = await _studentService.GetStudentScoresAsync(first.Id);

            //Assert
            Assert.NotNull(scores);
            Assert.Equal(scoresArrange.Count(), scores.Count());
        }


        [Fact, TestPriority(3)]
        public async Task GetById_Success()
        {
            //Arrange
            var first = TestData.Students.First();

            //Act
            var student = await _studentService.GetByIdAsync(first.Id);

            //Assert
            Assert.Equal(first.Id, student.Id);
        }


        [Fact, TestPriority(4)]
        public async Task GetById_IsNotExist()
        {
            //Arrange
            var notExistId = 777;

            //Act
            var student = await _studentService.GetByIdAsync(notExistId);

            //Assert
            Assert.Null(student);
        }


        [Fact, TestPriority(5)]
        public async Task Create_Success()
        {
            //Arrange
            var firstSubj = TestData.Subjects.First();
            var firstSubjDto = mapper.Map<SubjectDto>(firstSubj);

            var lastSubj = TestData.Subjects.First();
            var lastSubjDto = mapper.Map<SubjectDto>(lastSubj);

            var dto = new StudentDto 
            { 
                Name = "TestCreate", 
                BirthDate = new DateTime(2008, 01, 01),
                Scores = new List<ScoreDto>()
                {
                    new ScoreDto { Score = 4, SubjectId = firstSubj.Id },
                    new ScoreDto { Score = 5, SubjectId = lastSubj.Id }
                }
            };


            //Act
            await _studentService.CreateAsync(dto);
            var students = await _studentService.GetAllAsync();
            var createdStudent = students.FirstOrDefault(s => s.Name == dto.Name);

            var subjs = await _subjectService.GetAllWithScoresAsync();
            var updatedSubj = subjs.FirstOrDefault(s => s.Id == firstSubj.Id);

            //Assert
            Assert.NotNull(createdStudent);
            Assert.NotEqual(0, createdStudent.AverageGrade);
            Assert.NotEqual(0, createdStudent.Age);
            Assert.NotEqual(firstSubjDto.AverageGrade, updatedSubj.AverageGrade);
        }


        [Fact, TestPriority(6)]
        public async Task Update_Success()
        {
            //Arrange
            var first = TestData.Students.First();
            var dto = mapper.Map<StudentDto>(first);
            dto.Name = "TestUpdate";

            //Act
            await _studentService.UpdateAsync(first.Id, dto);
            var subjs = await _studentService.GetAllAsync();

            //Assert
            Assert.NotNull(subjs.FirstOrDefault(s => s.Name == dto.Name));
        }


        [Fact, TestPriority(7)]
        public async Task UpdateStudentScores_Success()
        {
            //Arrange
            var lastSubj = TestData.Subjects.Last();
            var lastSubjDto = mapper.Map<SubjectDto>(lastSubj);

            var firstModel = TestData.Students.First();
            var firstDto = mapper.Map<StudentDto>(firstModel);
            var dto = new List<ScoreDto>
            {
                new ScoreDto
                {
                    Score = 1,
                    StudentId = firstModel.Id,
                    SubjectId = lastSubj.Id,
                }
            };

            //Act
            await _studentService.UpdateStudentScoresAsync(dto);
            var updatedStudent = await _studentService.GetByIdAsync(firstModel.Id);

            var subjs = await _subjectService.GetAllWithScoresAsync();
            var updatedSubj = subjs.FirstOrDefault(s => s.Id == lastSubj.Id);

            //Assert
            Assert.NotEqual(firstDto.AverageGrade, updatedStudent.AverageGrade);
            Assert.NotEqual(lastSubjDto.AverageGrade, updatedSubj.AverageGrade);
        }


        [Fact, TestPriority(8)]
        public async Task Delete_Success()
        {
            //Arrange
            var first = TestData.Students.First();

            //Act
            await _studentService.DeleteAsync(first.Id);
            var students = await _studentService.GetAllAsync();

            //Assert
            Assert.True(!students.Any(s => s.Id == first.Id));
        }
    }
}
