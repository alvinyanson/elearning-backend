using ELearning_API.DTOs;
using ELearning_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ELearning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(
            IAccountService accountService)
        {
            _accountService = accountService;
        }


        [HttpGet]
        public async Task<IActionResult> TestConnection()
        {
            return Ok("Test connection");
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO request)
        {
            // Check if email exist in database
            IdentityUser existingUser = await _accountService.FindByEmailAsync(request.Email);

            if (existingUser != null)
            {
                return Ok(new { success = false, message = $"The email {request.Email} is already registered!" });
            }

            // Register user account
            var registerResult = await _accountService.RegisterAsync(request);

            if (!registerResult.Succeeded)
            {
                return BadRequest(new { success = false, message = registerResult.Errors.FirstOrDefault()?.Description });
            }

            return Ok(new { success = true, message = "User registered successfully!" });
        }
    }
}
