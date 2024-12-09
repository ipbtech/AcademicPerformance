namespace AcademicPerformance.DTO.Reports
{
    public class TotalGradesDto
    {
        public int StudentsTotal { get; set; }
        public int SubjectsTotal { get; set; }
        public double AvarageGrade { get; set; }
        public double[] GradeValues { get; set; } = { };
        public string[] GradeNames { get; set; } = { };
    }
}
