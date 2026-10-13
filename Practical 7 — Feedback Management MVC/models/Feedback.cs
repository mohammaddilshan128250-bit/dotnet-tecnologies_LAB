
using System.ComponentModel.DataAnnotations;

namespace Practical_07_Feedback_Management_MVC.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select a rating.")]
        [Range(1, 5, ErrorMessage = "Please select a rating from 1 to 5.")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Please enter your feedback.")]
        [StringLength(500, ErrorMessage = "Feedback cannot exceed 500 characters.")]
        public string Comments { get; set; }
    }
}
