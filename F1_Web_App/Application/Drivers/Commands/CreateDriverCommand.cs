using MediatR;
using F1_Web_App.Models;
using F1_Web_App.Data.Models;
using System.Collections.Generic;

namespace F1_Web_App.Application.Drivers.Commands
{
    public class CreateDriverCommand : IRequest<Driver?>
    {
        public string Name { get; set; }
        public int DriverNumber { get; set; }
        public int TeamId { get; set; }
        public string ImageUrl { get; set; }
        public List<TeamListViewModel> Teams { get; set; }

        public CreateDriverCommand()
        {
            Teams = new List<TeamListViewModel>();
        }

        public CreateDriverCommand(string name, int driverNumber, int teamId, string imageUrl, List<TeamListViewModel> teams)
        {
            Name = name;
            DriverNumber = driverNumber;
            TeamId = teamId;
            ImageUrl = imageUrl;
            Teams = teams ?? new List<TeamListViewModel>();
        }
    }
}
