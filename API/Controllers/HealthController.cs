using System.Net;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("health")]
public class HealthController(ILogger<HealthController> logger) : ControllerBase
{
    private readonly ILogger<HealthController> logger = logger;

    [HttpGet(Name = "health")]
    public IActionResult Index() => Ok(new
    {
        Status = HttpStatusCode.OK,
        Reason = "Everything is fscked up"
    });
}