using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace F1_Web_App.Data.Models
{
    public class Result
    {
        public int Id { get; set; }

        public int Points { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "DriverId must be a positive number.")]
        public int DriverId { get; set; }

        public Driver Driver { get; set; } = null!;

        [Range(1, int.MaxValue, ErrorMessage = "EventId must be a positive number.")]
        public int EventId { get; set; }

        public Event Event { get; set; } = null!;
    }
}
