using MediatR;
using F1_Web_App.Data;
using F1_Web_App.Application.Drivers.Commands;

namespace F1_Web_App.Application.Drivers.Handlers;


public class DeleteDriverHandler : IRequestHandler<DeleteDriverCommand, bool>
{
    private readonly ApplicationDbContext _context;

    public DeleteDriverHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(DeleteDriverCommand request, CancellationToken cancellationToken)
    {
        var driver = await _context.Drivers.FindAsync(request.Id);
        if (driver == null) return false;

        _context.Drivers.Remove(driver);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
