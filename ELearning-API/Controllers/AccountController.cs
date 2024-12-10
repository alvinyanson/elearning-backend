using ELearning_API.DTOs;
using ELearning_API.Models;
using ELearning_API.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace ELearning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IJWTService _jwtService;
        private readonly IAccountService _accountService;

        public AccountController(
            IJWTService jwtService,
            IAccountService accountService)
        {
            _jwtService = jwtService;
            _accountService = accountService;
        }


        [HttpGet]
        public async Task<IActionResult> TestConnection()
        {
            return Ok("Test connection");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO request)
        {
            var signInResult = await _accountService.LoginAsync(request);

            if (!signInResult.Succeeded)
            {
                return Unauthorized(new { success = false, message = "Invalid email address or password!" });
            }

            try
            {
                // Generate JWT token
                string jwt = await GenerateJWT(request.Email);

                // Success logged in
                return Ok(new { success = true, message = "User logged in successfully!", result = jwt });

            }
            catch
            {
                return StatusCode(500, new { success = false, message = $"Something went wrong!" });
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDTO request)
        {
            // Check if email exist in database
            ApplicationUser existingUser = await _accountService.FindByEmailAsync(request.Email);

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

        private async Task<string> GenerateJWT(string email)
        {
            ApplicationUser identityUser = await _accountService.FindByEmailAsync(email);

            var principal = await _accountService.CreateUserPrincipalAsync(identityUser);

            return _jwtService.GenerateJwtToken(principal.Claims);
        }
    }
}
