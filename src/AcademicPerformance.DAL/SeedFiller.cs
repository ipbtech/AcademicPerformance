using AcademicPerformance.Entities;
using AcademicPerformance.Entities.Enums;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace AcademicPerformance.DAL
{
    public static class SeedFiller
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Randomizer.Seed = new Random(123);
            int fakeStudentsCount = 27;

            var subjects = new List<Subject>()
            {
                new Subject
                {
                    Id = 1,
                    Name = "Math"
                },
                new Subject
                {
                    Id = 2,
                    Name = "English"
                },
                new Subject
                {
                    Id = 3,
                    Name = "IT"
                },
                new Subject
                {
                    Id = 4,
                    Name = "Geography"
                },
                new Subject
                {
                    Id = 5,
                    Name = "History"
                }
            };

            var studentIdsIncrement = 1;
            var studentRules = new Faker<Student>()
                .RuleFor(s => s.Id, f => studentIdsIncrement++)
                .RuleFor(s => s.Name, f => string.Join(" ", f.Name.FirstName(), f.Name.LastName()))
                .RuleFor(s => s.BirthDate, f => f.Date.Between(DateTime.Now.AddYears(-30), DateTime.Now.AddYears(-14)));
            var students = studentRules.Generate(fakeStudentsCount);

            var scoresIdsIncrement = 1;
            var scoreRandom = new Randomizer();
            var scores = new List<Score>();
            foreach(var student in students)
            {
                foreach(var subject in subjects)
                {
                    var score = new Score
                    {
                        Id = scoresIdsIncrement,
                        ScoreValue = scoreRandom.Enum<ScoreValue>(),
                        StudentId = student.Id,
                        SubjectId = subject.Id,
                    };
                    scoresIdsIncrement++;
                    scores.Add(score);
                }
            }

            modelBuilder.Entity<Subject>().HasData(subjects);
            modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<Score>().HasData(scores);
        }
    }
}
