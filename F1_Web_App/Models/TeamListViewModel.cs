using F1_Web_App.Common;
using F1_Web_App.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
{
    public class TeamListViewModel
    {
        public int TeamId { get; set; }

        [Required]
        [StringLength(ValidationConstants.TeamNameMaxLength, MinimumLength = ValidationConstants.TeamNameMinLength)]
        public string TeamName { get; set; } = null!;

        [Required]
        [Url]
        public string TeamImageUrl { get; set; } = null!;

        [Required]
        public ICollection<DriverListViewModel> Drivers { get; set; } = new List<DriverListViewModel>();
    }
}

