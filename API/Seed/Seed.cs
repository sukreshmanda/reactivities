using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Seed;
public static class Seed
{
    public static DataContext SeedActivities(this DataContext dataContext)
    {
        if (dataContext.Activities.Any()) return dataContext;
        
        dataContext.Activities.Add(new Activity
        {
            Title = "Simple Activity",
            Date = DateTime.UtcNow,
            Desciption = "Random desciption for the activity",
            Category = "SimpleCategory",
            City = "Hyderabad",
            Venue = "Ramoji Film City"
        });
        return dataContext;
    }
}