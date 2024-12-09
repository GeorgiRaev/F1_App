using F1_Web_App.Data;
using F1_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace F1_Web_App.Controllers
{
    public class TeamsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeamsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> List()
        {
            var model = await _context.Teams
               .Include(t => t.Drivers)
               .Select(t => new TeamListViewModel
               {
                   TeamName = t.Name,
                   TeamImageUrl = t.ImageUrl,
                   Drivers = t.Drivers.Select(d => new DriverListViewModel
                   {
                       Id = d.Id,
                       DriverNumber = d.DriverNumber,
                       Name = d.Name,
                       TeamName = t.Name,
                       ImageUrl = d.ImageUrl
                   }).ToList()
               })
               .ToListAsync();

            return View(model);
        }
    }
}
