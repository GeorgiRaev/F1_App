using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using F1_Web_App.Data;
using F1_Web_App.Data.Models;
using F1_Web_App.Models;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using X.PagedList.Extensions;

namespace F1_Web_App.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);

            var events = _context.Events.OrderBy(e => e.EventDate).ToPagedList(pageNumber, pageSize);

            return View(events);
        }

        public async Task<IActionResult> List(int? year, int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);

            var eventsQuery = _context.Events.AsQueryable();

            if (year.HasValue)
            {
                eventsQuery = eventsQuery.Where(e => e.EventDate.Year == year.Value);
            }

            var model = eventsQuery
                .OrderBy(e => e.EventDate)
                .Select(p => new EventViewModel
                {
                    Id = p.Id,
                    CircuitName = p.Circuit.Name,
                    Country = p.Circuit.Country.Name,
                    EventDate = p.EventDate,
                    ImageUrl = p.Circuit.ImageUrl
                })
                .ToPagedList(pageNumber, pageSize);

            var years = await _context.Events
                .Select(e => e.EventDate.Year)
                .Distinct()
                .OrderBy(y => y)
                .ToListAsync();

            ViewBag.Years = years;
            ViewBag.SelectedYear = year;

            return View(model);
        }
    }
}
