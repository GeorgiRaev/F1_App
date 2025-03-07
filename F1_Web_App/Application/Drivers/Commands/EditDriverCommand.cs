using MediatR;

public class EditDriverCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DriverNumber { get; set; }
    public int TeamId { get; set; }
    public string ImageUrl { get; set; }

    public EditDriverCommand() { }

    public EditDriverCommand(int id, string name, int driverNumber, int teamId, string imageUrl)
    {
        Id = id;
        Name = name;
        DriverNumber = driverNumber;
        TeamId = teamId;
        ImageUrl = imageUrl;
    }
}
