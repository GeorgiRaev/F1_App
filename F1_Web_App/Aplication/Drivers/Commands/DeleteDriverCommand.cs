using MediatR;

public class DeleteDriverCommand : IRequest<bool>
{
    public int Id { get; set; }

    public DeleteDriverCommand(int id)
    {
        Id = id;
    }
}
