using MediatR;
using F1_Web_App.Models;
using F1_Web_App.Data.Models;

namespace F1_Web_App.Application.Drivers.Commands;

public class CreateDriverCommand : IRequest<Driver?>
{
    public string Name { get; set; }
    public int DriverNumber { get; set; }
    public int TeamId { get; set; }
    public string ImageUrl { get; set; }

    public CreateDriverCommand(string name, int driverNumber, int teamId, string imageUrl)
    {
        Name = name;
        DriverNumber = driverNumber;
        TeamId = teamId;
        ImageUrl = imageUrl;
    }
}
