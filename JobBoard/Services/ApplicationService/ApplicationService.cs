using AutoMapper;

public class ApplicationService
{
    private readonly IApplicationRepository repository;
    private readonly IMapper mapper;

    public ApplicationService(IApplicationRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public async Task<List<ApplicationResponseDto>> GetAllApplicationsAsync()
    {
        var applications = await repository.GetAllApplicationsAsync();
        return mapper.Map<List<ApplicationResponseDto>>(applications);
    }

  
}
