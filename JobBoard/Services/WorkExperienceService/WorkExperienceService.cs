using AutoMapper;

public class WorkExperienceService
{
    private readonly IWorkExperienceRepository repository;
    private readonly IMapper mapper;

    public WorkExperienceService(IWorkExperienceRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public async Task<List<PostWorkExperienceDto>> GetAllWorkExperiencesAsync()
    {
        var workExperiences = await repository.GetAllWorkExperiencesAsync();
        return mapper.Map<List<PostWorkExperienceDto>>(workExperiences);
    }
}


