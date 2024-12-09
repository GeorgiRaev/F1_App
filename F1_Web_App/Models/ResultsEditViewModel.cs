using F1_Web_App.Common;
using F1_Web_App.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
{
    public class ResultsEditViewModel
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "EventId must be a positive number.")]
        public int EventId { get; set; }

        public ICollection<ResultEditViewModel> Results { get; set; } = new List<ResultEditViewModel>();

        public ICollection<DriverListViewModel> DriverListViewModels { get; set; } = new List<DriverListViewModel>();
    }
}

