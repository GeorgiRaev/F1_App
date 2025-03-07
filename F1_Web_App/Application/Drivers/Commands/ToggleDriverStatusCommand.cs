using MediatR;

namespace F1_Web_App.Application.Drivers.Commands
{
    public class ToggleDriverStatusCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public ToggleDriverStatusCommand(int id)
        {
            Id = id;
        }
    }
}
