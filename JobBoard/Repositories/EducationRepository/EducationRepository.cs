
// EducationRepository.cs
using JobBoard.Models;
using Microsoft.EntityFrameworkCore;

public class EducationRepository : IEducationRepository
{
    private readonly JobBoardDbContext dbContext;

    public EducationRepository(JobBoardDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<Education>> GetAllEducationAsync()
    {
        return await dbContext.EducationRecords.ToListAsync();
    }
}
