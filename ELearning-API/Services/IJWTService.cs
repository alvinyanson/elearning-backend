using ELearning_API.Models;
using ELearning_API.Models.Account;
using System.Security.Claims;

namespace ELearning_API.Services
{
    public interface IJWTService
    {
        Task<AuthResponse> GenerateTokens(ApplicationUser user, IEnumerable<Claim> claims);
    }
}
