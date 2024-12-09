using F1_Web_App.Common;
using F1_Web_App.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
{
    public class DriverEditViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(ValidationConstants.DriverNameMaxLength, MinimumLength = ValidationConstants.DriverNameMinLength)]
        public string DriverName { get; set; } = null!;

        [Required]
        [Range(1, 99, ErrorMessage = "Driver number must be between 1 and 99.")]
        public int DriverNumber { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "TeamId must be a positive number.")]
        public int TeamId { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        public ICollection<TeamListViewModel> Teams { get; set; } = new List<TeamListViewModel>();

        public ICollection<DriverListViewModel> Drivers { get; set; } = new List<DriverListViewModel>();
    }
}

