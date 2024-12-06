using AcademicPerformance.Entities.Base;
using AcademicPerformance.Entities.Enums;

namespace AcademicPerformance.Entities
{
    public class Score : BaseItem
    {
        public ScoreValue ScoreValue { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
