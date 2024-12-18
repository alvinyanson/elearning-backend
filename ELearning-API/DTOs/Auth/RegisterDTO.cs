using System.ComponentModel.DataAnnotations;

namespace ELearning_API.DTOs.Auth
{
    public class RegisterDTO
    {
        [Required]
        [RegularExpression(GlobalConstants.RegexPatterns.EmailPattern, ErrorMessage = "Invalid Email address")]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
