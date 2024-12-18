using ELearning_API.DTOs.Auth;
using ELearning_API.Models;
using ELearning_API.Models.Account;
using Mapster;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ELearning_API.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IJWTService _jwtService;

        public AccountService(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<ApplicationUser> signInManager,
            IJWTService jwtService
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _jwtService = jwtService;
        }

        public async Task<ClaimsPrincipal> CreateUserPrincipalAsync(ApplicationUser identityUser)
        {
            return await _signInManager.CreateUserPrincipalAsync(identityUser);
        }

        public async Task<ApplicationUser> FindByEmailAsync(string email)
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
            ApplicationUser identityUser = request.Adapt<ApplicationUser>();

            var identityRole = new IdentityRole { Name = request.Role };

            IdentityResult registerResult = await _userManager.CreateAsync(identityUser, request.Password);

            if(registerResult.Succeeded)
            {
                IdentityResult roleResult =  await _roleManager.CreateAsync(new IdentityRole { Name = request.Role });

                if(roleResult.Succeeded)
                {
                }
                    await _userManager.AddToRoleAsync(identityUser, request.Role);
            }

            return registerResult;
        }

        public IEnumerable<ApplicationUser> All()
        {
            return _userManager.Users.ToList();
        }
    }
}
