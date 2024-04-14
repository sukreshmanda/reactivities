using Domain;

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
        dataContext.Activities.Add(new Activity
        {
            Title = "Another Simple Activity",
            Date = DateTime.UtcNow,
            Desciption = "Random 2 desciption for the activity",
            Category = "SimpleCategoryAnother",
            City = "Nellore",
            Venue = "Ramoji City"
        });
        dataContext.Activities.Add(new Activity
        {
            Title = "Yet Another Simple Activity",
            Date = DateTime.UtcNow,
            Desciption = "Random desciption for the activity yet",
            Category = "SimpleCategory3",
            City = "Bangalore",
            Venue = "Film City"
        });
        return dataContext;
    }
}