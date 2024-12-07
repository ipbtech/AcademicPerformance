using AcademicPerformance.DTO;
using AcademicPerformance.Entities;
using AutoMapper;

namespace AcademicPerformance.Services
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
        }
    }
}
