using AutoMapper;
using JobBoard.Models;
using JobBoard.Models.Dto;
using JobBoard.Repositories.JobRepository;

public class JobService
{
  private readonly IJobRepository jobRepository;
  private readonly IMapper mapper;

  public JobService(IJobRepository jobRepository, IMapper mapper)
  {
    this.jobRepository = jobRepository;
    this.mapper = mapper;
  }

  public async Task<List<JobDtoResponse>> GetAllJobsAsync(JobFilterParameters jobFilterParameters)
  {

    {
      var jobResults = await jobRepository.GetAllJobs(jobFilterParameters);
      return mapper.Map<List<JobDtoResponse>>(jobResults);
    }
  }
}