namespace AcademicPerformance.Entities
{
    public enum Score
    {
        Bad = 2,
        OK = 3,
        Good = 4,
        Excellent = 5
    }

    public class SubjectScore : BaseItem
    {
        public Score Score { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
