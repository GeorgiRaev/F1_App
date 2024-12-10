using F1_Web_App.Controllers;
using F1_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace F1_Web_App_Tests
{
    public class DriversControllerTests
    {
        [Fact]
        public async Task ListDrivers_ReturnsAllDrivers()
        {
            using var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);
            var result = await controller.ListDrivers();

            var okResult = result as ViewResult;
            Assert.NotNull(okResult);
            var model = okResult.Model as List<DriverListViewModel>;
            Assert.NotNull(model);

            Assert.Equal(model.Count, context.Drivers.Count());
        }

        [Fact]
        public async Task StatusActiveOrAllDrivers_WhenShowActiveOnlyIsTrue_ReturnOnlyActive()
        {
            using var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);
            var result = await controller.StatusActiveOrAllDrivers(true);

            var okResult = result as ViewResult;
            Assert.NotNull(okResult);
            var model = okResult.Model as List<DriverListViewModel>;
            Assert.NotNull(model);

            Assert.Equal(model.Count, context.Drivers.Where(x => !x.IsRetired).Count());
            Assert.True(model.All(x => x.IsRetired == false));
        }

        [Fact]
        public async Task StatusActiveOrAllDrivers_WhenShowActiveOnlyIsFalse_ReturnAll()
        {
            using var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);
            var result = await controller.StatusActiveOrAllDrivers(false);

            var okResult = result as ViewResult;
            Assert.NotNull(okResult);
            var model = okResult.Model as List<DriverListViewModel>;
            Assert.NotNull(model);

            Assert.Equal(model.Count, context.Drivers.Count());
        }

        [Fact]
        public async Task EditGetReturnsDriverEditViewModel()
        {
            var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);
            var driverId = context.Drivers.First().Id;

            var result = await controller.Edit(driverId);

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<DriverEditViewModel>(viewResult.Model);
            Assert.Equal(driverId, model.Id);
        }

        [Fact]
        public async Task EditPostValidModelUpdatesDriver()
        {
            var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);
            var driver = context.Drivers.First();
            var model = new DriverEditViewModel
            {
                Id = driver.Id,
                DriverName = "Updated Name",
                DriverNumber = driver.DriverNumber,
                TeamId = driver.TeamId,
                ImageUrl = driver.ImageUrl
            };

            var result = await controller.Edit(driver.Id, model);

            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal(nameof(controller.ListDrivers), redirectToActionResult.ActionName);
            var updatedDriver = await context.Drivers.FindAsync(driver.Id);
            Assert.NotNull(updatedDriver);
            Assert.Equal("Updated Name", updatedDriver.Name);
        }

        [Fact]
        public async Task EditPostInvalidModelReturnsViewWithModel()
        {
            var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);
            var driver = context.Drivers.First();
            var model = new DriverEditViewModel
            {
                Id = driver.Id,
                DriverName = "", // Invalid name
                DriverNumber = driver.DriverNumber,
                TeamId = driver.TeamId,
                ImageUrl = driver.ImageUrl
            };
            controller.ModelState.AddModelError("DriverName", "Required");

            var result = await controller.Edit(driver.Id, model);

            var viewResult = Assert.IsType<ViewResult>(result);
            var returnedModel = Assert.IsType<DriverEditViewModel>(viewResult.Model);
            Assert.Equal(model.Id, returnedModel.Id);
            Assert.False(controller.ModelState.IsValid);
        }

        [Fact]
        public void CreateDriver_Get_ReturnsViewWithDriverEditViewModel()
        {
            var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);

            var result = controller.CreateDriver();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<DriverEditViewModel>(viewResult.Model);
            Assert.NotNull(model.Teams);
            Assert.Equal(context.Teams.Count(), model.Teams.Count);
        }

        [Fact]
        public async Task CreateDriver_Post_ValidModel_AddsDriver()
        {
            var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);
            var model = new DriverEditViewModel
            {
                DriverName = "New Driver",
                DriverNumber = 99,
                TeamId = context.Teams.First().Id,
                ImageUrl = "http://example.com/image.jpg"
            };

            var result = await controller.CreateDriver(model);

            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal(nameof(controller.ListDrivers), redirectToActionResult.ActionName);
            var driver = await context.Drivers.FirstOrDefaultAsync(d => d.DriverNumber == model.DriverNumber);
            Assert.NotNull(driver);
            Assert.Equal("New Driver", driver.Name);
        }

        [Fact]
        public async Task CreateDriver_Post_InvalidModel_ReturnsViewWithModel()
        {
            var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);
            var model = new DriverEditViewModel
            {
                DriverName = "", // Invalid name
                DriverNumber = 99,
                TeamId = context.Teams.First().Id,
                ImageUrl = "http://example.com/image.jpg"
            };
            controller.ModelState.AddModelError("DriverName", "Required");

            var result = await controller.CreateDriver(model);

            var viewResult = Assert.IsType<ViewResult>(result);
            var returnedModel = Assert.IsType<DriverEditViewModel>(viewResult.Model);
            Assert.Equal(model.DriverNumber, returnedModel.DriverNumber);
            Assert.False(controller.ModelState.IsValid);
        }

        [Fact]
        public async Task CreateDriver_Post_DuplicateDriverNumber_ReturnsViewWithModelError()
        {
            var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);
            var existingDriver = context.Drivers.First();
            var model = new DriverEditViewModel
            {
                DriverName = "New Driver",
                DriverNumber = existingDriver.DriverNumber, // Duplicate driver number
                TeamId = context.Teams.First().Id,
                ImageUrl = "http://example.com/image.jpg"
            };

            var result = await controller.CreateDriver(model);

            var viewResult = Assert.IsType<ViewResult>(result);
            var returnedModel = Assert.IsType<DriverEditViewModel>(viewResult.Model);
            Assert.Equal(model.DriverNumber, returnedModel.DriverNumber);
            Assert.True(controller.ModelState.ContainsKey("DriverNumber"));
        }

        [Fact]
        public void DeleteDriver_ExistingDriverId_DeletesDriver()
        {
            // Arrange
            var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);
            var driverId = context.Drivers.First().Id;

            // Act
            var result = controller.DeleteDriver(driverId);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal(nameof(controller.ListDrivers), redirectToActionResult.ActionName);
            var driver = context.Drivers.Find(driverId);
            Assert.Null(driver);
        }

        [Fact]
        public void DeleteDriver_NonExistingDriverId_ReturnsNotFound()
        {
            var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);
            var nonExistingDriverId = 999;

            var result = controller.DeleteDriver(nonExistingDriverId);

            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void DeleteDriver_RetiredDriver_ReturnsBadRequest()
        {
            var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);
            var retiredDriver = context.Drivers.FirstOrDefault(d => d.IsRetired);

            Assert.NotNull(retiredDriver);
            var retiredDriverId = retiredDriver.Id;

            var result = controller.DeleteDriver(retiredDriverId);

            Assert.IsType<BadRequestResult>(result);
        }
    }
}
