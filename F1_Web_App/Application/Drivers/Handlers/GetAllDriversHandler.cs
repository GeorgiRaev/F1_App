using MediatR;
using F1_Web_App.Data;
using F1_Web_App.Models;
using Microsoft.EntityFrameworkCore;
using F1_Web_App.Data.Models;
using F1_Web_App.Application.Drivers.Queries;

namespace F1_Web_App.Application.Drivers.Handlers;

public class GetAllDriversHandler : IRequestHandler<GetAllDriversQuery, IEnumerable<Driver>>
{
    private readonly ApplicationDbContext _context;

    public GetAllDriversHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Driver>> Handle(GetAllDriversQuery request, CancellationToken cancellationToken)
    {
        return await _context.Drivers.ToListAsync(cancellationToken);
    }
}
