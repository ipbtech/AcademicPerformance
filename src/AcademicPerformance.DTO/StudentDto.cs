namespace AcademicPerformance.DTO
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public double AverageGrade { get; set; }
        public bool ShowDetails { get; set; } = false;
        public IEnumerable<ScoreDto> Scores { get; set; } = new List<ScoreDto>();  
    }
}
