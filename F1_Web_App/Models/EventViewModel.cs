using F1_Web_App.Common;
using F1_Web_App.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(ValidationConstants.CircuitNameMaxLength, MinimumLength = ValidationConstants.CircuitNameMinLength)]
        public string CircuitName { get; set; } = null!;

        [Required]
        [StringLength(ValidationConstants.CountryNameMaxLength, MinimumLength = ValidationConstants.CountryNameMinLength)]
        public string Country { get; set; } = null!;

        [Required]
        public DateTime EventDate { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; } = null!;
    }
}
