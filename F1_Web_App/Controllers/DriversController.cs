using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MediatR;
using F1_Web_App.Application.Drivers.Commands;
using F1_Web_App.Application.Drivers.Queries;
using System.Threading.Tasks;
using F1_Web_App.Application.Teams.Queries;
using F1_Web_App.Models;

namespace F1_Web_App.Controllers
{
    [Authorize]
    public class DriversController : Controller
    {
        private readonly IMediator _mediator;

        public DriversController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var driver = await _mediator.Send(new GetDriverByIdQuery(id));
            if (driver == null) return NotFound();

            var teams = await _mediator.Send(new GetAllTeamsQuery());

            var viewModel = new DriverEditViewModel
            {
                Id = driver.Id,
                DriverName = driver.Name,
                DriverNumber = driver.DriverNumber,
                TeamId = driver.TeamId,
                ImageUrl = driver.ImageUrl,
                Teams = teams
            };

            return View(viewModel); 
        }


        [Authorize(Roles = "Administrator, Moderator")]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, DriverEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Teams = await _mediator.Send(new GetAllTeamsQuery());
                return View(model);
            }

            var command = new EditDriverCommand(model.Id, model.DriverName, model.DriverNumber, model.TeamId, model.ImageUrl);

            var result = await _mediator.Send(command);
            if (!result) return BadRequest();

            return RedirectToAction("StatusActiveOrAllDrivers");
        }


        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> CreateDriver()
        {
            var teams = await _mediator.Send(new GetAllTeamsQuery());
            return View(new CreateDriverCommand("", 0, 0, "", teams));
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CreateDriver(CreateDriverCommand command)
        {
            if (!ModelState.IsValid || await _mediator.Send(command) == null)
            {
                ModelState.AddModelError("DriverNumber", "The driver number is already taken.");
                command.Teams = await _mediator.Send(new GetAllTeamsQuery());
                return View(command);
            }
            return RedirectToAction("StatusActiveOrAllDrivers");

        }

        [HttpGet]
        public async Task<IActionResult> ConfirmDeleteDriver(int id)
        {
            var driver = await _mediator.Send(new GetDriverByIdQuery(id));

            if (driver == null) return NotFound();

            var viewModel = new DriverListViewModel
            {
                Id = driver.Id,
                Name = driver.Name,
                DriverNumber = driver.DriverNumber,
                TeamName = driver.Team?.Name ?? "Unknown Team",
                ImageUrl = driver.ImageUrl,
                IsRetired = driver.IsRetired
            };

            return View(viewModel);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> DeleteDriver(int id)
        {
            var result = await _mediator.Send(new DeleteDriverCommand(id));

            if (!result)
            {
                return NotFound();
            }

            return RedirectToAction("StatusActiveOrAllDrivers");
        }

        [Authorize(Roles = "Administrator, Moderator")]
        [HttpPost]
        public async Task<IActionResult> ToggleDriverStatus(int id)
        {
            var result = await _mediator.Send(new ToggleDriverStatusCommand(id));

            if (!result)
            {
                TempData["ErrorMessage"] = "Driver not found or could not change status.";
                return RedirectToAction("StatusActiveOrAllDrivers");
            }

            TempData["SuccessMessage"] = "Driver status updated successfully.";
            return RedirectToAction("StatusActiveOrAllDrivers");

        }

        [Authorize(Roles = "Administrator, Moderator")]
        public async Task<IActionResult> StatusActiveOrAllDrivers(bool showActiveOnly = false)
        {
            var drivers = await _mediator.Send(new GetDriversListViewModelQuery(showActiveOnly));
            return View(drivers);
        }
    }
}
