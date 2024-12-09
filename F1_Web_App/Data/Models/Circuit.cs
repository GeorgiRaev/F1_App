using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using F1_Web_App.Common;

namespace F1_Web_App.Data.Models
{
    public class Circuit
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.CircuitNameMaxLength)]
        public string Name { get; set; } = null!;

        [Range(1, int.MaxValue, ErrorMessage = "CountryId must be a positive number.")]
        public int CountryId { get; set; }

        public Country Country { get; set; } = null!;

        [Required]
        [Url]
        public string ImageUrl { get; set; } = null!;

        public bool IsLegacy { get; set; }
    }
}
