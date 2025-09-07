using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]

public class ApplicantsController : ControllerBase
{
  // private readonly JobBoardDbContext dbContext;
  private readonly ApplicantService applicantService;

  public ApplicantsController(ApplicantService applicantService)
  {
    // this.dbContext = dbContext;
    this.applicantService = applicantService;
  }

 [HttpPost]
  public async Task<IActionResult> PostApplicant([FromBody] PostApplicantDto applicantDto)
  {
    return Ok(await applicantService.AddApplicant(applicantDto));
  }
}