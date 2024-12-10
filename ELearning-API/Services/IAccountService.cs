using ELearning_API.DTOs;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ELearning_API.Services
{
    public interface IAccountService
    {
        Task<SignInResult> LoginAsync(LoginDTO request);

        Task<IdentityResult> RegisterAsync(RegisterDTO request);

        Task<IdentityUser> FindByEmailAsync(string email);

        Task<ClaimsPrincipal> CreateUserPrincipalAsync(IdentityUser identityUser);
    }
}
