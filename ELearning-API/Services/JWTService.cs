
using ELearning_API.DTOs.Auth;
using ELearning_API.Models;
using ELearning_API.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Web;

namespace ELearning_API.Services
{
    public class JWTService : IJWTService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppSettings _appSettings;

        public JWTService(
            IConfiguration configuration, 
            UserManager<ApplicationUser> userManager,
            IOptions<AppSettings> appSettings
            )
        {
            _userManager = userManager;
            _appSettings = appSettings.Value;
        }

        public async Task<AuthResponse> GenerateTokens(ApplicationUser user, IEnumerable<Claim> claims)
        {
            string jwtKey = _appSettings.AuthSettings.SecretKey;

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
               issuer: _appSettings.AuthSettings.Issuer,
               audience: _appSettings.AuthSettings.Audience,
               claims: claims,
               expires: DateTime.UtcNow.AddMinutes(_appSettings.AuthSettings.AccessTokenExpiration),
               signingCredentials: credentials
               );

            string accessToken = new JwtSecurityTokenHandler().WriteToken(token);
            var refreshTokenstring = await _userManager.GenerateUserTokenAsync(user, _appSettings.AuthSettings.RefreshTokenProvider, _appSettings.AuthSettings.RefreshTokenPurpose);

            var refreshTokenDTO = new RefreshTokenDTO
            {
                UserName = user.Email,
                TokenString = HttpUtility.UrlEncode(refreshTokenstring),
                ExpireAt = DateTime.UtcNow.AddMinutes(_appSettings.AuthSettings.RefreshTokenExpiration)
            };


            return new AuthResponse
            {
                AccessToken = accessToken,
                RefreshToken = refreshTokenDTO
            };
        }
    }
}
