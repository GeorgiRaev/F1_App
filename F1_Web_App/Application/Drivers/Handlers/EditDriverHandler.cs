using MediatR;
using F1_Web_App.Data;
using F1_Web_App.Application.Drivers.Commands;

namespace F1_Web_App.Application.Drivers.Handlers;

public class EditDriverHandler : IRequestHandler<EditDriverCommand, bool>
{
    private readonly ApplicationDbContext _context;

    public EditDriverHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(EditDriverCommand request, CancellationToken cancellationToken)
    {
        var driver = await _context.Drivers.FindAsync(request.Id);
        if (driver == null) return false;

        driver.Name = request.Name;
        driver.DriverNumber = request.DriverNumber;
        driver.TeamId = request.TeamId;
        driver.ImageUrl = request.ImageUrl;

        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
