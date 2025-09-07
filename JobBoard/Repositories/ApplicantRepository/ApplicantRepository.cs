using JobBoard.Models;
using Microsoft.EntityFrameworkCore.Storage;

public class ApplicantRepository : IApplicantRepository
{
    private readonly JobBoardDbContext dbContext;

    public ApplicantRepository(JobBoardDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<Applicant> AddApplicant(Applicant applicant)
    {
        // Begin transaction
        using (IDbContextTransaction transaction = await dbContext.Database.BeginTransactionAsync())
        {
            try
            {
               
                await dbContext.Applicants.AddAsync(applicant);
                await dbContext.SaveChangesAsync();

                await transaction.CommitAsync();
                return applicant;
            }
            catch
            {
                await transaction.RollbackAsync();
                throw; 
            }
        }
    }
}
