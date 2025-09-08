using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]

public class ApplicantsController : ControllerBase
{
  
  private readonly ApplicantService applicantService;

  public ApplicantsController(ApplicantService applicantService)
  {
    
    this.applicantService = applicantService;
  }

 [HttpPost]
  public async Task<IActionResult> PostApplicant([FromBody] PostApplicantDto applicantDto)
  {
    return Ok(await applicantService.AddApplicant(applicantDto));
  }
}