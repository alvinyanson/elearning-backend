using Microsoft.AspNetCore.Identity;

namespace ELearning_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
