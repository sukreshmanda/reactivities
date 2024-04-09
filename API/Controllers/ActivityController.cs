using API.Controllers;

public class ActivityController(ILogger<ActivityController> logger) : BaseController
{
    private readonly ILogger<ActivityController> logger = logger;
}