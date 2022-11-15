
/*
using global::TaskDelegatingApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using TaskDelegatingApp.Data;
namespace TaskDelegatingApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TaskDelegatingAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TaskDelegatingAppContext>>()))
            {
                // Look for any movies.
                if (context.Person.Any())
                {
                    return;   // DB has been seeded
                }
                context.Person.AddRange(
                    new Person
                    {
                        Name = "Kade",
                        Email = "ks@gmail.com",
                        AvailableFriday = true,
                        AvailableMonday = true,
                        AvailableTuesday = true,
                        AvailableWednsday = true,
                        AvailableThursday = true,
                        AvailableSaturday = true,
                        AvailableSunday = true,
                        
                    }


                );
                context.SaveChanges();
            }
        }
    }
}

*/