using AcademicPerformance.DAL;
using AcademicPerformance.Services.Helpers;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Test.AcademicPerformance.Base
{
    public abstract class TestContext : IDisposable
    {
        protected readonly IMapper mapper;
        protected readonly AppDbContext dbContext;

        public TestContext()
        {
            mapper = new Mapper(new MapperConfiguration(c => c.AddProfile(new MappingProfile())));

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning))
                .Options;

            dbContext = new AppDbContext(options);
            dbContext.Database.EnsureCreated();
            IntializeTestData();
        }

        private void IntializeTestData()
        {
            dbContext.Subjects.AddRange(TestData.Subjects);
            dbContext.Students.AddRange(TestData.Students);
            dbContext.Scores.AddRange(TestData.Scores);
            dbContext.SaveChanges();
        }

        public void Dispose()
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Dispose();
        }
    }
}
