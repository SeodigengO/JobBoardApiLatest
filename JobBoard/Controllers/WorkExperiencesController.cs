using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class WorkExperienceController : ControllerBase
{
    private readonly WorkExperienceService service;

    public WorkExperienceController(WorkExperienceService service)
    {
        this.service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var data = await service.GetAllWorkExperiencesAsync();
        return Ok(data);
    }
}