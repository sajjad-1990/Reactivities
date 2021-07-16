using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if(context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Pass Activity 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "The best ciyy in england",
                    Category = "Drinks",
                    City = "Londen",
                    Venue = "Pub"
                },
                new Activity
                {
                    Title = "Pass Activity 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "The best ciyy in France",
                    Category = "Culture",
                    City = "Paris",
                    Venue = "Louvre"
                },
                 new Activity
                {
                    Title = "Pass Activity 3",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "The best ciyy in iran",
                    Category = "Food",
                    City = "Tehran",
                    Venue = "Tajrish"
                },
                 new Activity
                {
                    Title = "Pass Activity 4",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "The best ciyy in iran",
                    Category = "Gardesh",
                    City = "Ghome",
                    Venue = "Haram"
                },
                 new Activity
                {
                    Title = "Pass Activity 5",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "The best ciyy in iran",
                    Category = "Gaz",
                    City = "Esfehan",
                    Venue = "Alighapo"
                },
                 new Activity
                {
                    Title = "Pass Activity 6",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "The best ciyy in iran",
                    Category = "Ziyarat",
                    City = "Mashhad",
                    Venue = "Markaz"
                },
                 new Activity
                {
                    Title = "Pass Activity 7",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "The best ciyy in iran",
                    Category = "Kurdish",
                    City = "Kurdestan",
                    Venue = "kurd-markaz"
                },
                 new Activity
                {
                    Title = "Pass Activity 8",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "The best ciyy in iran",
                    Category = "Charm",
                    City = "Tabriz",
                    Venue = "Shahgoli"
                },
                 new Activity
                {
                    Title = "Pass Activity 9",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "The best ciyy in iran",
                    Category = "Swim",
                    City = "Bandar-abas",
                    Venue = "kish"
                },
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}