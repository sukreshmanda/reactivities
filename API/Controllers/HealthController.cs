using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class HealthController(ILogger<HealthController> logger) : BaseController
{
    private readonly ILogger<HealthController> logger = logger;

    [HttpGet(Name = "health")]
    public IActionResult Index() => Ok(new
    {
        Status = HttpStatusCode.OK,
        Reason = "Everything is fscked up"
    });
}