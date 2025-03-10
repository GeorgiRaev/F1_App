﻿using MediatR;
using F1_Web_App.Data;
using F1_Web_App.Models;
using F1_Web_App.Data.Models;
using F1_Web_App.Application.Drivers.Queries;
using Microsoft.EntityFrameworkCore;

namespace F1_Web_App.Application.Drivers.Handlers;
public class GetDriverByIdHandler : IRequestHandler<GetDriverByIdQuery, Driver?>
{
    private readonly ApplicationDbContext _context;

    public GetDriverByIdHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Driver?> Handle(GetDriverByIdQuery request, CancellationToken cancellationToken)
    {
        return await _context.Drivers
            .Include(d => d.Team) 
            .FirstOrDefaultAsync(d => d.Id == request.Id, cancellationToken);
    }
}
