using F1_Web_App.Controllers;
using F1_Web_App.Data;
using F1_Web_App.Data.Models;
using F1_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using Xunit;

namespace F1_Web_App_Tests
{
    public class EventsControllerTests
    {
        [Fact]
        public void Index_ReturnsViewResult_WithPagedList()
        {
            using var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new EventsController(context);
            int? page = 1;

            var result = controller.Index(page);

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IPagedList<Event>>(viewResult.Model);
            Assert.Equal(10, model.PageSize);
        }

        [Fact]
        public async Task List_ReturnsViewResult_WithEventViewModelList()
        {
            using var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new EventsController(context);
            int? year = null;
            int? page = 1;

            var result = await controller.List(year, page);

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IPagedList<EventViewModel>>(viewResult.Model);
            Assert.Equal(10, model.PageSize);
        }

        [Fact]
        public async Task List_FiltersEventsByYear()
        {
            using var context = ContextHelper.GetContext();
            context.SeedData();
            var controller = new EventsController(context);
            int? year = context.Events.First().EventDate.Year;
            int? page = 1;

            var result = await controller.List(year, page);

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IPagedList<EventViewModel>>(viewResult.Model);
            Assert.All(model, e => Assert.Equal(year, e.EventDate.Year));
        }
    }
}

