using AcademicPerformance.Entities;
using AcademicPerformance.Entities.Enums;

namespace Test.AcademicPerformance.Base
{
    internal static class TestData
    {
        internal static IEnumerable<Subject> Subjects = new List<Subject>()
        {
            new Subject { Id = 1, Name = "Math" },
            new Subject { Id = 2, Name = "English" },
            new Subject { Id = 3, Name = "IT" },
            new Subject { Id = 4, Name = "Geography" },
            new Subject { Id = 5, Name = "History" }
        };
        internal static IEnumerable<Student> Students = new List<Student>()
        {
            new Student { Id = 1, Name = "TestUser1", BirthDate = new DateTime(2005, 10, 20) },
            new Student { Id = 2, Name = "TestUser2", BirthDate = new DateTime(2004, 10, 20) },
            new Student { Id = 3, Name = "TestUser3", BirthDate = new DateTime(2003, 10, 20) },
            new Student { Id = 4, Name = "TestUser4", BirthDate = new DateTime(2002, 10, 20) },
            new Student { Id = 5, Name = "TestUser5", BirthDate = new DateTime(2001, 10, 20) },
        };
        internal static IEnumerable<Score> Scores = new List<Score>()
        {
            new Score { Id = 1, StudentId = 1, SubjectId = 1, ScoreValue = ScoreValue.VeryBad },
            new Score { Id = 2, StudentId = 1, SubjectId = 2, ScoreValue = ScoreValue.Bad },
            new Score { Id = 3, StudentId = 1, SubjectId = 3, ScoreValue = ScoreValue.OK },

            new Score { Id = 4, StudentId = 2, SubjectId = 2, ScoreValue = ScoreValue.Bad },
            new Score { Id = 5, StudentId = 2, SubjectId = 3, ScoreValue = ScoreValue.OK },
            new Score { Id = 6, StudentId = 2, SubjectId = 4, ScoreValue = ScoreValue.Good },

            new Score { Id = 7, StudentId = 3, SubjectId = 3, ScoreValue = ScoreValue.VeryBad },
            new Score { Id = 8, StudentId = 3, SubjectId = 4, ScoreValue = ScoreValue.Bad },
            new Score { Id = 9, StudentId = 3, SubjectId = 5, ScoreValue = ScoreValue.OK },

            new Score { Id = 10, StudentId = 4, SubjectId = 4, ScoreValue = ScoreValue.Excellent },
            new Score { Id = 11, StudentId = 4, SubjectId = 5, ScoreValue = ScoreValue.Good },
            new Score { Id = 12, StudentId = 4, SubjectId = 1, ScoreValue = ScoreValue.OK },

            new Score { Id = 13, StudentId = 5, SubjectId = 5, ScoreValue = ScoreValue.Good },
            new Score { Id = 14, StudentId = 5, SubjectId = 1, ScoreValue = ScoreValue.OK },
            new Score { Id = 15, StudentId = 5, SubjectId = 2, ScoreValue = ScoreValue.Excellent },
        };
    }
}
