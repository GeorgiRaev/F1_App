using F1_Web_App.Controllers;
using F1_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;

namespace F1_Web_App_Tests
{
    public class DriversControllerTests
    {
        [Fact]
        public void ListDrivers_ReturnsAllDrivers()
        {
            using var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);
            var result = controller.ListDrivers();


            var okResult = result.Result as ViewResult;
            Assert.NotNull(result);
            var model = okResult.Model as List<DriverListViewModel>;

            Assert.Equal(model.Count, context.Drivers.Count());

        }



        [Fact]
        public void StatusActiveOrAllDrivers_WhenShowActiveOnlyIsTrue_ReturnOnlyActive()
        {
            using var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);
            var result = controller.StatusActiveOrAllDrivers(true);


            var okResult = result.Result as ViewResult;
            Assert.NotNull(result);
            var model = okResult.Model as List<DriverListViewModel>;

            Assert.Equal(model.Count, context.Drivers.Where(x => !x.IsRetired).Count());

            Assert.True(model.All(x => x.IsRetired == false));

        }

        [Fact]
        public void StatusActiveOrAllDrivers_WhenShowActiveOnlyIsFalse_ReturnAll()
        {
            using var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new DriversController(context);
            var result = controller.StatusActiveOrAllDrivers(false);


            var okResult = result.Result as ViewResult;
            Assert.NotNull(result);
            var model = okResult.Model as List<DriverListViewModel>;

            Assert.Equal(model.Count, context.Drivers.Count());

        }


    }
}