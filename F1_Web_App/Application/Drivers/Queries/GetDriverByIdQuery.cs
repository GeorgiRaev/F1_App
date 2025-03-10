﻿using MediatR;
using F1_Web_App.Models;
using F1_Web_App.Data.Models;

namespace F1_Web_App.Application.Drivers.Queries;

public class GetDriverByIdQuery : IRequest<Driver?>
{
    public int Id { get; set; }

    public GetDriverByIdQuery(int id)
    {
        Id = id;
    }
}
