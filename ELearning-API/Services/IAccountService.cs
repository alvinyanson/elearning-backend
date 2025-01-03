﻿using ELearning_API.DTOs.Auth;
using ELearning_API.Models;
using ELearning_API.Models.Account;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ELearning_API.Services
{
    public interface IAccountService
    {
        Task<SignInResult> LoginAsync(LoginDTO request);

        Task<IdentityResult> RegisterAsync(RegisterDTO request);

        Task<ApplicationUser> FindByEmailAsync(string email);

        Task<ClaimsPrincipal> CreateUserPrincipalAsync(ApplicationUser identityUser);

        Task<string> GenerateEmailConfirmationTokenAsync(ApplicationUser user);

        Task<string> GeneratePasswordResetTokenAsync(ApplicationUser user);
    }
}
