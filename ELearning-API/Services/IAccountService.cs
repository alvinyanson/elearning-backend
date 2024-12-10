using ELearning_API.DTOs;
using Microsoft.AspNetCore.Identity;

namespace ELearning_API.Services
{
    public interface IAccountService
    {
        Task<IdentityResult> RegisterAsync(RegisterDTO register);

        Task<IdentityUser> FindByEmailAsync(string email);
    }
}
