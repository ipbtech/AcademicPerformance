using AcademicPerformance.Entities.Enums;

namespace AcademicPerformance.Entities.Projections
{
    public class SubjectScoresView
    {
        public string SubjectName { get; set; }
        public ICollection<ScoreValue> ScoreValues { get; set; } = [];
    }
}
