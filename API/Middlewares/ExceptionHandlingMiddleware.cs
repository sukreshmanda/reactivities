
using System.Net;

namespace API.Middlewares;

public class ExceptionHandlingMiddleware(
    RequestDelegate next,
    ILogger<ExceptionHandlingMiddleware> logger)
{
    private readonly RequestDelegate next = next;
    private readonly ILogger<ExceptionHandlingMiddleware> logger = logger;

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await next(httpContext);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occured while processing request");
            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            httpContext.Response.ContentType = "application/json";
            await httpContext.Response.WriteAsJsonAsync(new
            {
                message = "Error occured",
                statusCode = StatusCodes.Status500InternalServerError
            });
        }
        await Task.CompletedTask;
    }
}