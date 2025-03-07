using MediatR;
using F1_Web_App.Models;
using System.Collections.Generic;

namespace F1_Web_App.Application.Teams.Queries;

public class GetAllTeamsQuery : IRequest<List<TeamListViewModel>>
{
}
