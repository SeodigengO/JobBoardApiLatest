using AutoMapper;

public class EducationService
{
    private readonly IEducationRepository repository;
    private readonly IMapper mapper;

    public EducationService(IEducationRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public async Task<List<PostEducationDto>> GetAllEducationAsync()
    {
        var educationList = await repository.GetAllEducationAsync();
        return mapper.Map<List<PostEducationDto>>(educationList);
    }
}