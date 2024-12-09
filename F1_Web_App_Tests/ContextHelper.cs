using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using F1_Web_App.Data;
using F1_Web_App.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace F1_Web_App_Tests
{
    public static class ContextHelper
    {
        public static ApplicationDbContext GetContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var context = new ApplicationDbContext(optionsBuilder.Options);
            return context;
        }

        public static ApplicationDbContext SeedData(this ApplicationDbContext context)
        {
            var countries = new List<Country>()
            {
                new Country
                {
                   Id = 1,
                   Name = "Bulgaria"
                 }
            };

            var teams = new List<Team>
            {
                new Team
                {
                   Id = 1,
                   Name = "Ferrai",
                   ImageUrl =  "https://test.jpg"
                }
            };


            var drivers = new List<Driver>
            {
                new Driver
                {
                   Id = 1,
                   DriverNumber = 1,
                   Name = "Shumaher",
                   TeamId =  1,
                   Team = teams[0],
                   ImageUrl =  "https://test.jpg"
                },
                 new Driver
                {
                   Id = 2,
                   DriverNumber = 1,
                   Name = "Old driver",
                   TeamId =  1,
                   Team = teams[0],
                   ImageUrl =  "https://test.jpg",
                   IsRetired = true
                },
            };



            var cuircuits = new List<Circuit>
            {
                new Circuit
                {
                   Id = 1,
                   Name = "Track 1",
                   ImageUrl =  "https://test.jpg"
                },
            };

            var events = new List<Event>
            {
                new Event
                {
                    Id = 1,
                    CircuitId = 1,
                    Circuit = cuircuits[0],
                    EventDate = DateTime.Now,
                }
            };

            var results = new List<Result>
            {
                new Result
                {
                    DriverId = 1,
                    Points = 10,
                    Driver = drivers[0],
                    EventId = 1,
                    Event = events[0]
                }
            };

            context.Countries.AddRange(countries);
            context.Teams.AddRange(teams);
            context.Drivers.AddRange(drivers);
            context.Circuits.AddRange(cuircuits);
            context.Events.AddRange(events);
            context.Results.AddRange(results);
           
            context.SaveChanges();

            return context;
        }
    }
}
