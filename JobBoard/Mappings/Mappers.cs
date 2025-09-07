using AutoMapper;
using JobBoard.Models;
using JobBoard.Models.Dto;

namespace JobBoard.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Applicant -> DTOs
            CreateMap<Job, JobDtoResponse>()
            .ForMember(dest => dest.CompanyResponseDto, opt => opt.MapFrom(src => src.Company));
            ;
            CreateMap<Company, CompanyResponseDto>();

            // Applicant mapping
            CreateMap<PostApplicantDto, Applicant>()
                .ForMember(dest => dest.ApplicantId, opt => opt.Ignore())
                .ForMember(dest => dest.EducationHistory, opt => opt.MapFrom(src => src.EducationHistory))
                .ForMember(dest => dest.WorkExperiences, opt => opt.MapFrom(src => src.WorkExperiences));


            // Education mapping
            CreateMap<PostEducationDto, Education>()
                .ForMember(dest => dest.EducationId, opt => opt.Ignore())
                .ForMember(dest => dest.ApplicantId, opt => opt.Ignore())
                .ForMember(dest => dest.Applicant, opt => opt.Ignore());

            // WorkExperience mapping
            CreateMap<PostWorkExperienceDto, WorkExperience>()
                .ForMember(dest => dest.WorkExperienceId, opt => opt.Ignore())
                .ForMember(dest => dest.ApplicantId, opt => opt.Ignore())
                .ForMember(dest => dest.Applicant, opt => opt.Ignore());

            CreateMap<Applicant, ResponseApplicantDto>()
            .ForMember(dest => dest.EducationHistory, opt => opt.MapFrom(src => src.EducationHistory))
            .ForMember(dest => dest.WorkExperiences, opt => opt.MapFrom(src => src.WorkExperiences));

            CreateMap<Education, PostEducationDto>();
            CreateMap<WorkExperience, PostWorkExperienceDto>();

            CreateMap<Application, ApplicationResponseDto>()
            .ForMember(dest => dest.Job, opt => opt.MapFrom(src => src.Job))
            .ForMember(dest => dest.Applicant, opt => opt.MapFrom(src => src.Applicant));

            CreateMap<Job, JobDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.JobTitle))
            .ForMember(dest => dest.Company, opt => opt.MapFrom(src => src.Company));

            CreateMap<Applicant, ApplicantDto>();
            CreateMap<Company, CompanyDto>()
            .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.CompanyName));


    }
    }
}
