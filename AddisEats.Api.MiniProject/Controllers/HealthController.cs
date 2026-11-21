using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1[Controller]")]

public class HealthController : ControllerBase
{
    private readonly DateTime _ClockService;

    [HttpGet("Health")]
    public IActionResult GetHealth
    {
        var result = _ClockService.CheckTime;

        return Ok(result app.Enviroment); 
    }

} 