using Domain;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Persistence;

namespace API.Controllers;

public class ActivityController(DataContext dataContext) : BaseCrudController<Activity>
{
    private readonly DataContext context = dataContext;

    public override async Task<ActionResult<Activity>> Get(Guid id)
    {
        return await context.Activities.FirstAsync(a => a.Id.Equals(id));
    }

    public override ActionResult<IEnumerable<Activity>> GetAll()
    {
        return context.Activities.AsAsyncEnumerable()
                .ToBlockingEnumerable()
                .ToList();
    }
}