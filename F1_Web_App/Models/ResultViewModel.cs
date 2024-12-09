using F1_Web_App.Common;
using F1_Web_App.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
{
    public class ResultViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(ValidationConstants.DriverNameMaxLength, MinimumLength = ValidationConstants.DriverNameMinLength)]
        public string DriverName { get; set; } = null!;

        [Required]
        [Range(1, 99, ErrorMessage = "Driver number must be between 1 and 99.")]
        public int DriverNumber { get; set; }

        [Required]
        [StringLength(ValidationConstants.DriverTeamNameMaxLength, MinimumLength = ValidationConstants.DriverTeamNameMinLength)]
        public string TeamName { get; set; } = null!;

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Points must be a non-negative number.")]
        public int Points { get; set; }
    }
}

