using JobBoard.Models;
using Microsoft.EntityFrameworkCore;

public class WorkExperienceRepository : IWorkExperienceRepository
{
    private readonly JobBoardDbContext dbContext;

    public WorkExperienceRepository(JobBoardDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<WorkExperience>> GetAllWorkExperiencesAsync()
    {
        return await dbContext.WorkExperiences
            .Include(w => w.Applicant) 
            .ToListAsync();
    }
}