using F1_Web_App.Common;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Data.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.CountryNameMaxLength)]
        public string Name { get; set; } = null!;
    }
}
