using F1_Web_App.Common;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace F1_Web_App.Data.Models
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Driver number must be between 1 and 99.")]
        public int DriverNumber { get; set; }

        [Required]
        [MaxLength(ValidationConstants.DriverNameMaxLength)]
        public string Name { get; set; } = null!;


        [Range(1, int.MaxValue, ErrorMessage = "TeamId must be a positive number.")]
        public int TeamId { get; set; }

        [Required]
        public Team Team { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public bool IsRetired { get; set; }

        public ICollection<Result> Results { get; set; } = new List<Result>();
    }
}
