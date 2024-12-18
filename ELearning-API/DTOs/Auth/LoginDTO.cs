using System.ComponentModel.DataAnnotations;

namespace ELearning_API.DTOs.Auth
{
    public class LoginDTO
    {
        [Required]
        [RegularExpression(GlobalConstants.RegexPatterns.EmailPattern, ErrorMessage = "Invalid Email address")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
