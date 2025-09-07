
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class EducationController : ControllerBase
{
    private readonly EducationService service;

    public EducationController(EducationService service)
    {
        this.service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var data = await service.GetAllEducationAsync();
        return Ok(data);
    }
}
