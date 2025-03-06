using MediatR;
using F1_Web_App.Models;
using System.Collections.Generic;
using F1_Web_App.Data.Models;

public class GetAllDriversQuery : IRequest<IEnumerable<Driver>> { }
