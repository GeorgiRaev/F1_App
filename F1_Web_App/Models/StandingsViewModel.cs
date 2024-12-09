using F1_Web_App.Common;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
{
    public class StandingsViewModel
    {
        [Required]
        [Range(1, 99, ErrorMessage = "Driver number must be between 1 and 99.")]
        public int DriverNumber { get; set; }

        [Required]
        [StringLength(ValidationConstants.DriverNameMaxLength, MinimumLength = ValidationConstants.DriverNameMinLength)]
        public string DriverName { get; set; } = null!;

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Total points must be a non-negative number.")]
        public int TotalPoints { get; set; }

        [Required]
        [StringLength(ValidationConstants.DriverTeamNameMaxLength, MinimumLength = ValidationConstants.DriverTeamNameMinLength)]
        public string TeamName { get; set; } = null!;

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Total team points must be a non-negative number.")]
        public int TotalTeamPoints { get; set; }
    }
}

