using System.Security.Claims;

namespace ELearning_API.Services
{
    public interface IJWTService
    {
        string GenerateJwtToken(IEnumerable<Claim> claims);

        bool ValidateJwtToken(string token);
    }
}
