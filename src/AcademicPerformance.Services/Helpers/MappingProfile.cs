using AcademicPerformance.DTO;
using AcademicPerformance.Entities;
using AutoMapper;

namespace AcademicPerformance.Services.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SubjectDto, Subject>();
            CreateMap<Subject, SubjectDto>()
                .ForMember(dto => dto.AverageGrade, opt =>
                    opt.MapFrom(src => src.Scores.Any() ?
                        Math.Round(src.Scores.Select(s => (int)s.ScoreValue).Average(), 1) : 0));

            CreateMap<StudentDto, Student>()
                .ForMember(dto => dto.Scores, opt => opt.Ignore());
            CreateMap<Student, StudentDto>()
                .ForMember(dto => dto.Scores, opt => opt.Ignore())
                .ForMember(dto => dto.Age, opt => opt.MapFrom(src => DateTime.Today.Year - src.BirthDate.Year))
                .ForMember(dto => dto.AverageGrade, opt =>
                    opt.MapFrom(src => src.Scores.Any() ?
                        Math.Round(src.Scores.Select(s => (int)s.ScoreValue).Average(), 1) : 0));

            CreateMap<ScoreDto, Score>()
                .ForMember(model => model.ScoreValue, opt => opt.MapFrom(dto => dto.Score))
                .ReverseMap();
        }
    }
}
