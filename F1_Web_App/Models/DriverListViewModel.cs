using F1_Web_App.Common;
using F1_Web_App.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
{
    public class DriverListViewModel
    {
        public int Id { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Driver number must be between 1 and 99.")]
        public int DriverNumber { get; set; }

        [Required]
        [StringLength(ValidationConstants.DriverNameMaxLength, MinimumLength = ValidationConstants.DriverNameMinLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(ValidationConstants.DriverTeamNameMaxLength, MinimumLength = ValidationConstants.DriverTeamNameMinLength)]
        public string TeamName { get; set; } = string.Empty;

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        public bool IsRetired { get; set; }
    }
}
