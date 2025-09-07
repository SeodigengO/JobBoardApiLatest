using JobBoard.Models;
using Microsoft.EntityFrameworkCore;

public class CompanyRepository : ICompanyRepository

{
  private readonly JobBoardDbContext dbContext;
  public CompanyRepository(JobBoardDbContext dbContext)
  {
    this.dbContext = dbContext;
  }

  public async Task<List<Company>> GetAllCompanies()
  {
    return await dbContext.Companies.ToListAsync();
  }
}