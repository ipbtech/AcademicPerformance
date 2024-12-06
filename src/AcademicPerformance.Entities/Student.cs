using AcademicPerformance.Entities.Base;

namespace AcademicPerformance.Entities
{
    public class Student : BaseItem
    {
        public DateTime BirthDate { get; set; }
        public ICollection<Score> Scores { get; set; } = [];
    }
}
