using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Data.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "CircuitId must be a positive number.")]
        public int CircuitId { get; set; }

        public Circuit Circuit { get; set; } = null!;

        [Required]
        public DateTime EventDate { get; set; }

        public ICollection<Result> Results { get; set; } = new List<Result>();
    }
}
