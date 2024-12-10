using ELearning_API.DTOs;
using Mapster;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ELearning_API.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountService(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<ClaimsPrincipal> CreateUserPrincipalAsync(IdentityUser identityUser)
        {
            return await _signInManager.CreateUserPrincipalAsync(identityUser);
        }

        public async Task<IdentityUser> FindByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<SignInResult> LoginAsync(LoginDTO request)
        {
            return await _signInManager.PasswordSignInAsync(
                request.Email,
                request.Password,
                isPersistent: false,
                lockoutOnFailure: false);
        }

        public async Task<IdentityResult> RegisterAsync(RegisterDTO request)
        {
            var identityUser = request.Adapt<IdentityUser>();

            var identityRole = new IdentityRole { Name = request.Role };

            IdentityResult registerResult = await _userManager.CreateAsync(identityUser, request.Password);

            if(registerResult.Succeeded)
            {
                IdentityResult roleResult =  await _roleManager.CreateAsync(new IdentityRole { Name = request.Role });

                if(roleResult.Succeeded)
                {
                    await _userManager.AddToRoleAsync(identityUser, request.Role);

                }
            }

            return registerResult;
        }
    }
}
