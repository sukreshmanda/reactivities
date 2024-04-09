using Domain;

using Persistence;

namespace API.Controllers;

public class ActivityController(DataContext dataContext) : BaseCrudController<Activity>
{
    private readonly DataContext context = dataContext;

    public override Activity Get(Guid id)
    {
        return context.Activities.First(a => a.Id.Equals(id));
    }

    public override IEnumerable<Activity> GetAll()
    {
        return context.Activities;
    }
}