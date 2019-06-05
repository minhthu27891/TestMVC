using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        public bool ContactMe { get; set; }
    }
}