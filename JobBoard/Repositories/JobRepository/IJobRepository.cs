using JobBoard.Models;

namespace JobBoard.Repositories.JobRepository;

public interface IJobRepository
{
  Task<List<Job>> GetAllJobs(JobFilterParameters jobFilterParameters);
}

