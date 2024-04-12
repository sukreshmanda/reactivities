using Domain;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Persistence;

namespace API.Controllers;

public class ActivitiesController(DataContext dataContext) : BaseCrudController<Activity>
{
    private readonly DataContext _context = dataContext;

    [HttpGet("{id}")]
    public override async Task<ActionResult<Activity>> Get(Guid id)
    {
        return await _context.Activities.FirstAsync(a => a.Id.Equals(id));
    }

    [HttpGet]
    public override async Task<ActionResult<IEnumerable<Activity>>> GetAll()
    {
        return await _context.Activities.ToListAsync();
    }
}