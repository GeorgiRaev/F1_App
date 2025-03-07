using MediatR;
using F1_Web_App.Models;
using System.Collections.Generic;

namespace F1_Web_App.Application.Drivers.Queries;

public class GetDriversListViewModelQuery : IRequest<IEnumerable<DriverListViewModel>>
{
    public bool ShowActiveOnly { get; set; }

    public GetDriversListViewModelQuery(bool showActiveOnly)
    {
        ShowActiveOnly = showActiveOnly;
    }
}
