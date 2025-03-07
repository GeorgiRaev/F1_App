using MediatR;
using F1_Web_App.Data;
using F1_Web_App.Application.Drivers.Commands;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace F1_Web_App.Application.Drivers.Handlers
{
    public class ToggleDriverStatusHandler : IRequestHandler<ToggleDriverStatusCommand, bool>
    {
        private readonly ApplicationDbContext _context;

        public ToggleDriverStatusHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(ToggleDriverStatusCommand request, CancellationToken cancellationToken)
        {
            var driver = await _context.Drivers.FindAsync(request.Id);
            if (driver == null) return false;

            driver.IsRetired = !driver.IsRetired;
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
