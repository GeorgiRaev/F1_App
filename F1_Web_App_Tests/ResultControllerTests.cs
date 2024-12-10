using F1_Web_App.Controllers;
using F1_Web_App.Data;
using F1_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace F1_Web_App_Tests
{
    public class ResultControllerTests
    {
        [Fact]
        public async Task IndexAsync_ReturnsViewResult_WithResultListViewModel()
        {
            // Arrange
            using var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new ResultController(context);
            var eventId = context.Events.First().Id;

            // Act
            var result = await controller.IndexAsync(eventId);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<ResultListViewModel>(viewResult.Model);
            Assert.Equal(context.Events.First(e => e.Id == eventId).Circuit.Name, model.CircuitName);
        }

        [Fact]
        public async Task Edit_Get_ReturnsViewResult_WithResultEditViewModel()
        {
            // Arrange
            using var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new ResultController(context);
            var resultId = context.Results.First().Id;

            // Act
            var result = await controller.Edit(resultId);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<ResultEditViewModel>>(viewResult.Model);
            Assert.Contains(model, r => r.Id == resultId);
        }

        [Fact]
        public async Task Edit_Post_ThrowsNotImplementedException()
        {
            // Arrange
            using var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new ResultController(context);
            var model = new ResultsEditViewModel();

            // Act & Assert
            await Assert.ThrowsAsync<System.NotImplementedException>(() => controller.Edit(model));
        }
    }
}

