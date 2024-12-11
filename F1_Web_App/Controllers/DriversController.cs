using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using F1_Web_App.Data;
using F1_Web_App.Models;
using Microsoft.AspNetCore.Authorization;
using F1_Web_App.Data.Models;

namespace F1_Web_App.Controllers
{
    public class DriversController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DriversController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Administrator, Moderator")]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await _context.Drivers
                .Where(p => p.Id == id)
                .Select(p => new DriverEditViewModel
                {
                    Id = p.Id,
                    DriverName = p.Name,
                    DriverNumber = p.DriverNumber,
                    TeamId = p.TeamId,
                    ImageUrl = p.ImageUrl,
                    Teams = _context.Teams
                        .Select(t => new TeamListViewModel
                        {
                            TeamId = t.Id,
                            TeamName = t.Name
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync();

            return View(model);

        }

        [Authorize(Roles = "Administrator, Moderator")]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, DriverEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Teams = _context.Teams
                    .Select(t => new TeamListViewModel
                    {
                        TeamId = t.Id,
                        TeamName = t.Name
                    })
                    .ToList();
                return View(model);
            }

            var driver = await _context.Drivers.FindAsync(id);

            if (driver == null)
            {
                return BadRequest();
            }

            driver.Name = model.DriverName;
            driver.DriverNumber = model.DriverNumber;
            driver.TeamId = model.TeamId;
            driver.ImageUrl = model.ImageUrl;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(StatusActiveOrAllDrivers));

        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public IActionResult CreateDriver()
        {
            var model = new DriverEditViewModel
            {
                Teams = _context.Teams
                    .Select(t => new TeamListViewModel
                    {
                        TeamId = t.Id,
                        TeamName = t.Name
                    })
                    .ToList()
            };

            return View("CreateDriver", model); 
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CreateDriver(DriverEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Teams = _context.Teams
                    .Select(t => new TeamListViewModel
                    {
                        TeamId = t.Id,
                        TeamName = t.Name
                    })
                    .ToList();

                return View(model);
            }

            var existingDriver = await _context.Drivers
                .FirstOrDefaultAsync(d => d.DriverNumber == model.DriverNumber);

            if (existingDriver != null)
            {
                ModelState.AddModelError("DriverNumber", "The driver number is already taken.");
                model.Teams = _context.Teams
                    .Select(t => new TeamListViewModel
                    {
                        TeamId = t.Id,
                        TeamName = t.Name
                    })
                    .ToList();

                return View(model);
            }

            var driver = new Driver
            {
                Name = model.DriverName,
                DriverNumber = model.DriverNumber,
                TeamId = model.TeamId,
                ImageUrl = model.ImageUrl
            };

            _context.Drivers.Add(driver);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(StatusActiveOrAllDrivers));
        }


        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public IActionResult ConfirmDeleteDriver(int id)
        {
            var driver = _context.Drivers
                .Select(d => new DriverListViewModel
                {
                    Id = d.Id,
                    DriverNumber = d.DriverNumber,
                    Name = d.Name,
                    TeamName = d.Team.Name,
                    ImageUrl = d.ImageUrl
                })
                .FirstOrDefault(d => d.Id == id);

            if (driver == null)
            {
                return NotFound();
            }

            return View(driver);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public IActionResult DeleteDriver(int id)
        {
            if (_context == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Database context is not available.");
            }

            try
            {
                var driver = _context.Drivers.Find(id);
                if (driver == null)
                {
                    return NotFound();
                }

                if (driver.IsRetired)
                {
                    return BadRequest();
                }

                _context.Drivers.Remove(driver);
                _context.SaveChanges();

                if (TempData != null)
                {
                    TempData["SuccessMessage"] = "Driver deleted successfully.";
                }

                return RedirectToAction(nameof(StatusActiveOrAllDrivers));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while deleting the driver.");
            }
        }


        [Authorize(Roles = "Administrator, Moderator")]
        [HttpPost]
        public async Task<IActionResult> ToggleDriverStatus(int id)
        {
            var driver = await _context.Drivers.FindAsync(id);
            if (driver == null)
            {
                return NotFound();
            }

            driver.IsRetired = !driver.IsRetired;
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = $"Driver status updated to {(driver.IsRetired ? "Retired" : "Active")}.";

            var driverListViewModels = await _context.Drivers
                .Select(d => new DriverListViewModel
            {
                Id = d.Id,
                DriverNumber = d.DriverNumber,
                Name = d.Name,
                TeamName = d.Team.Name,
                ImageUrl = d.ImageUrl,
                IsRetired = d.IsRetired
            }).ToListAsync();

            return View("StatusActiveOrAllDrivers", driverListViewModels);
        }


        [Authorize(Roles = "Administrator, Moderator")]
        public async Task<IActionResult> StatusActiveOrAllDrivers(bool showActiveOnly = false)
        {
            IQueryable<Driver> drivers = _context.Drivers;
            if (showActiveOnly)
            {
                drivers = drivers.Where(d => !d.IsRetired);
            }

            var driverListViewModels = await drivers.Select(d => new DriverListViewModel
            {
                Id = d.Id,
                DriverNumber = d.DriverNumber,
                Name = d.Name,
                TeamName = d.Team.Name,
                ImageUrl = d.ImageUrl,
                IsRetired = d.IsRetired
            }).ToListAsync();

            ViewBag.ShowActiveOnly = showActiveOnly;
            return View(driverListViewModels);
        }
    }
}
