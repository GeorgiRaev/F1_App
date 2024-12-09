using F1_Web_App.Common;
using F1_Web_App.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
{
    public class ResultEditViewModel
    {
        public int Id { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "DriverId must be a positive number.")]
        public int DriverId { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Points must be a non-negative number.")]
        public int Points { get; set; }
    }
}

