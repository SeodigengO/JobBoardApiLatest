using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]

public class CompaniesController : ControllerBase
{
  private readonly JobBoardDbContext dbContext;
  private readonly CompanyService companyService;

  public CompaniesController(JobBoardDbContext dbContext, CompanyService companyService)
  {
    this.companyService = companyService;
    this.dbContext = dbContext;
  }

  [HttpGet]
  public async Task<IActionResult> GetAllAssets()
  {
    using var transaction = await dbContext.Database.BeginTransactionAsync();
    try
    {

      var companies = await companyService.GetAllCompanies();
      await dbContext.SaveChangesAsync();
      await transaction.CommitAsync();
      return Ok(new { data = companies });
    }

    catch (Exception ex)
    {
      return BadRequest(new { message = ex.Message });
    }
    
  }
}