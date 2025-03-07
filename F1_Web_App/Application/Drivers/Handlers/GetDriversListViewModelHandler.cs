using MediatR;
using F1_Web_App.Data;
using F1_Web_App.Application.Drivers.Queries;
using F1_Web_App.Models;
using Microsoft.EntityFrameworkCore;

namespace F1_Web_App.Application.Drivers.Handlers
{
    public class GetDriversListViewModelHandler : IRequestHandler<GetDriversListViewModelQuery, IEnumerable<DriverListViewModel>>
    {
        private readonly ApplicationDbContext _context;

        public GetDriversListViewModelHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DriverListViewModel>> Handle(GetDriversListViewModelQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Drivers.AsQueryable();

            if (request.ShowActiveOnly)
            {
                query = query.Where(d => !d.IsRetired);
            }

            return await query.Select(d => new DriverListViewModel
            {
                Id = d.Id,
                DriverNumber = d.DriverNumber,
                Name = d.Name,
                TeamName = d.Team.Name,
                ImageUrl = d.ImageUrl,
                IsRetired = d.IsRetired
            }).ToListAsync(cancellationToken);
        }
    }
}
