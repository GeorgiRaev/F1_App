using F1_Web_App.Common;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
{
    public class ResultListViewModel
    {
        [Required]
        [StringLength(ValidationConstants.CircuitNameMaxLength, MinimumLength = ValidationConstants.CircuitNameMinLength)]
        public string CircuitName { get; set; } = null!;

        [Required]
        public DateTime EventDate { get; set; }

        [Required]
        public ICollection<ResultViewModel> Results { get; set; } = new List<ResultViewModel>();
    }
}

