using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]

public class JobsController(JobBoardDbContext dbContext, JobService jobService) : ControllerBase
{
  private readonly JobBoardDbContext dbContext = dbContext;
  private readonly JobService jobService = jobService;

  [HttpGet]
  public async Task<IActionResult> GetAllJobs([FromQuery] JobFilterParameters jobFilterParameters)
  {
    using var transaction = await dbContext.Database.BeginTransactionAsync();
    try
    {

      var jobs = await jobService.GetAllJobsAsync(jobFilterParameters);
      await dbContext.SaveChangesAsync();
      await transaction.CommitAsync();
      return Ok(new { data = jobs });
    }

    catch (Exception ex)
    {
      return BadRequest(new { message = ex.Message });
    }
    
  }
}