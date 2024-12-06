using AcademicPerformance.Entities.Base;

namespace AcademicPerformance.Entities
{
    public class Subject : BaseItem
    {
        public ICollection<Score> Scores { get; set; } = [];
    }
}
