using F1_Web_App.Controllers;
using F1_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using F1_Web_App.Application.Drivers.Queries;
using F1_Web_App.Application.Drivers.Commands;
using F1_Web_App.Data.Models;
using F1_Web_App.Application.Teams.Queries;

namespace F1_Web_App_Tests
{
    public class DriversControllerTests
    {
        private readonly Mock<IMediator> _mediatorMock;
        private readonly DriversController _controller;

        public DriversControllerTests()
        {
            _mediatorMock = new Mock<IMediator>();
            _controller = new DriversController(_mediatorMock.Object);
        }

        [Fact]
        public async Task StatusActiveOrAllDrivers_WhenShowActiveOnlyIsTrue_ReturnsOnlyActive()
        {
            var drivers = new List<DriverListViewModel>
            {
                new DriverListViewModel { Id = 1, Name = "Lewis Hamilton", IsRetired = false },
                new DriverListViewModel { Id = 2, Name = "Sebastian Vettel", IsRetired = true }
            };

            _mediatorMock
                .Setup(m => m.Send(It.IsAny<GetDriversListViewModelQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(drivers.FindAll(d => !d.IsRetired));

            var result = await _controller.StatusActiveOrAllDrivers(true);

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<List<DriverListViewModel>>(viewResult.Model);
            Assert.All(model, d => Assert.False(d.IsRetired));
        }

        [Fact]
        public async Task EditGet_ReturnsDriver()
        {
            var driver = new Driver
            {
                Id = 1,
                Name = "Max Verstappen",
                DriverNumber = 33,
                TeamId = 1,
                ImageUrl = "img.jpg"
            };

            var teams = new List<TeamListViewModel> { new TeamListViewModel { TeamId = 1, TeamName = "Red Bull" } };

            _mediatorMock.Setup(m => m.Send(It.IsAny<GetDriverByIdQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(driver);

            _mediatorMock.Setup(m => m.Send(It.IsAny<GetAllTeamsQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(teams);

            var result = await _controller.Edit(1);

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<DriverEditViewModel>(viewResult.Model);
            Assert.Equal(driver.Id, model.Id);
        }

        [Fact]
        public async Task EditPost_ValidModel_UpdatesDriver()
        {
            var model = new DriverEditViewModel
            {
                Id = 1,
                DriverName = "Updated Name",
                DriverNumber = 44,
                TeamId = 2,
                ImageUrl = "new_img.jpg",
                Teams = new List<TeamListViewModel> { new TeamListViewModel { TeamId = 2, TeamName = "Mercedes" } }
            };

            _mediatorMock.Setup(m => m.Send(It.IsAny<EditDriverCommand>(), It.IsAny<CancellationToken>())).ReturnsAsync(true);

            var result = await _controller.Edit(1, model);

            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("StatusActiveOrAllDrivers", redirectToActionResult.ActionName);
        }

        [Fact]
        public async Task CreateDriver_Post_ValidModel_CreatesDriver()
        {
            var teams = new List<TeamListViewModel>
            {
                new TeamListViewModel { TeamId = 3, TeamName = "McLaren" }
            };

            var command = new CreateDriverCommand("Lando Norris", 4, 3, "img.jpg", teams);
            _mediatorMock.Setup(m => m.Send(It.IsAny<CreateDriverCommand>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new Driver { Id = 1 });

            var result = await _controller.CreateDriver(command);

            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("StatusActiveOrAllDrivers", redirectToActionResult.ActionName);
        }

        [Fact]
        public async Task DeleteDriver_ValidId_DeletesDriver()
        {
            _mediatorMock.Setup(m => m.Send(It.IsAny<DeleteDriverCommand>(), It.IsAny<CancellationToken>())).ReturnsAsync(true);

            var result = await _controller.DeleteDriver(1);

            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("StatusActiveOrAllDrivers", redirectToActionResult.ActionName);
        }

        [Fact]
        public async Task ToggleDriverStatus_ValidId_TogglesStatus()
        {
            _mediatorMock.Setup(m => m.Send(It.IsAny<ToggleDriverStatusCommand>(), It.IsAny<CancellationToken>())).ReturnsAsync(true);

            var result = await _controller.ToggleDriverStatus(1);

            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("StatusActiveOrAllDrivers", redirectToActionResult.ActionName);
        }
    }
}
