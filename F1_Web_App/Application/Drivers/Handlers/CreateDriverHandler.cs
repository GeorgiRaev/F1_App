using MediatR;
using F1_Web_App.Data;
using F1_Web_App.Application.Drivers.Commands;
using F1_Web_App.Models;
using Microsoft.EntityFrameworkCore;
using F1_Web_App.Data.Models;

namespace F1_Web_App.Application.Drivers.Handlers
{
    public class CreateDriverHandler : IRequestHandler<CreateDriverCommand, Driver?>
    {
        private readonly ApplicationDbContext _context;

        public CreateDriverHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Driver?> Handle(CreateDriverCommand request, CancellationToken cancellationToken)
        {
            var existingDriver = await _context.Drivers
                .FirstOrDefaultAsync(d => d.DriverNumber == request.DriverNumber, cancellationToken);
            if (existingDriver != null) return null;

            var driver = new Driver
            {
                Name = request.Name,
                DriverNumber = request.DriverNumber,
                TeamId = request.TeamId,
                ImageUrl = request.ImageUrl
            };

            _context.Drivers.Add(driver);
            await _context.SaveChangesAsync(cancellationToken);
            return driver;
        }
    }
}
