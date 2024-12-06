namespace AcademicPerformance.Entities
{
    public class Student : BaseItem
    {
        public DateTime BirthDate { get; set; }
        public ICollection<SubjectScore> Scores { get; set; } = [];
    }
}
