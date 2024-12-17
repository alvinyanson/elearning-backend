using ELearning_API.DTOs.Auth;

namespace ELearning_API.Models.Account
{
    public class AuthResponse
    {
        public string AccessToken { get; set; } = string.Empty;
        public RefreshTokenDTO RefreshToken { get; set; }
    }
}
