using MediatR;
using F1_Web_App.Data;
using F1_Web_App.Application.Teams.Queries;
using F1_Web_App.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace F1_Web_App.Application.Teams.Handlers
{
    public class GetAllTeamsHandler : IRequestHandler<GetAllTeamsQuery, List<TeamListViewModel>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllTeamsHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TeamListViewModel>> Handle(GetAllTeamsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Teams
                .Select(t => new TeamListViewModel
                {
                    TeamId = t.Id,
                    TeamName = t.Name
                })
                .ToListAsync(cancellationToken);
        }
    }
}
