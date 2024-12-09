using F1_Web_App.Common;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Data.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.DriverTeamNameMaxLength)]
        public string Name { get; set; } = null!;

        [Range(1, int.MaxValue, ErrorMessage = "CountryId must be a positive number.")]
        public int CountryId { get; set; }

        public Country Country { get; set; } = null!;

        [Required]
        [Url]
        public string ImageUrl { get; set; } = null!;

        public ICollection<Driver> Drivers { get; set; } = new List<Driver>();
    }
}
