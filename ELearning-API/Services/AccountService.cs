using ELearning_API.DTOs;
using Mapster;
using Microsoft.AspNetCore.Identity;

namespace ELearning_API.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountService(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IdentityUser> FindByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
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
