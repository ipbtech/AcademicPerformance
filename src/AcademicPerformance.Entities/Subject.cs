namespace AcademicPerformance.Entities
{
    public class Subject : BaseItem
    {
        public ICollection<SubjectScore> Scores { get; set; } = [];
    }
}
