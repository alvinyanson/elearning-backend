using System.ComponentModel.DataAnnotations;

namespace ELearning_API.DTOs
{
    public class LoginDTO
    {
        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}
