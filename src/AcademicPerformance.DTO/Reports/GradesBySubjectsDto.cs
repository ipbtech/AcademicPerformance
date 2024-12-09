namespace AcademicPerformance.DTO.Reports
{
    public class GradesBySubjectsDto
    {
        public string[] SubjectNames { get; set; } = { };
        public GradeValuesDto[] GradeValues { get; set; } = { };
    }

    public class GradeValuesDto
    {
        public string Name { get; set; }
        public double[] Values { get; set; }
    }
}
