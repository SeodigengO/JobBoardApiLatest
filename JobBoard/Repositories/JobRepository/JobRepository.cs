using JobBoard.Models;
using JobBoard.Repositories.JobRepository;
using Microsoft.EntityFrameworkCore;

public class JobRepository : IJobRepository
{
  private readonly JobBoardDbContext dbContext;

  public JobRepository(JobBoardDbContext dbContext)
  {
    this.dbContext = dbContext;
  }


  public async Task<List<Job>> GetAllJobs(JobFilterParameters jobFilterParameters)
  {
    var jobs = dbContext.Jobs.Include(j => j.Company).AsQueryable();

     if (!string.IsNullOrWhiteSpace(jobFilterParameters.search))
    {
        jobs = SearchHelper.ApplySearchFilter(jobs, jobFilterParameters.search.Trim().ToLower());
    }

  jobs = jobs.Paginate(jobFilterParameters.start, jobFilterParameters.end);

    return await jobs.ToListAsync();
  
  }

}