

using JobBoard.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationRepository : IApplicationRepository
{
    private readonly JobBoardDbContext dbContext;

    public ApplicationRepository(JobBoardDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<Application>> GetAllApplicationsAsync()
    {
        return await dbContext.Applications
            .Include(a => a.Job).ThenInclude(j => j.Company)
            .Include(a => a.Applicant)
            .ToListAsync();
    }


}
