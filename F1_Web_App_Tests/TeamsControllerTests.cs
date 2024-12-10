using F1_Web_App.Controllers;
using F1_Web_App.Data;
using F1_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace F1_Web_App_Tests
{
    public class TeamsControllerTests
    {
        [Fact]
        public async Task List_ReturnsViewResult_WithListOfTeams()
        {
            // Arrange
            using var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new TeamsController(context);

            // Act
            var result = await controller.List();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<TeamListViewModel>>(viewResult.Model);
            Assert.Equal(context.Teams.Count(), model.Count);
        }

        [Fact]
        public async Task List_IncludesDriversInTeams()
        {
            // Arrange
            using var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new TeamsController(context);

            // Act
            var result = await controller.List();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<TeamListViewModel>>(viewResult.Model);
            foreach (var team in model)
            {
                var expectedTeam = context.Teams.Include(t => t.Drivers).First(t => t.Name == team.TeamName);
                Assert.Equal(expectedTeam.Drivers.Count, team.Drivers.Count);
                foreach (var driver in team.Drivers)
                {
                    Assert.Contains(expectedTeam.Drivers, d => d.Id == driver.Id);
                }
            }
        }
    }
}
