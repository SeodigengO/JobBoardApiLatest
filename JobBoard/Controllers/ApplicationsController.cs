using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ApplicationController : ControllerBase
{
    private readonly ApplicationService applicationService;

    public ApplicationController(ApplicationService applicationService)
    {
        this.applicationService = applicationService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var data = await applicationService.GetAllApplicationsAsync();
        return Ok(data);
    }

    
}
