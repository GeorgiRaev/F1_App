using MediatR;

namespace F1_Web_App.Application.Drivers.Commands;

public class DeleteDriverCommand : IRequest<bool>
{
    public int Id { get; set; }

    public DeleteDriverCommand(int id)
    {
        Id = id;
    }
}
