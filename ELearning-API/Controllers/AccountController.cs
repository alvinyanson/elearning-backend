using Azure.Core;
using ELearning_API.DTOs.Auth;
using ELearning_API.Models;
using ELearning_API.Models.Account;
using ELearning_API.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;


namespace ELearning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IJWTService _jwtService;
        private readonly IAccountService _accountService;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly AppSettings _appSettings;


        public AccountController(
            IJWTService jwtService,
            IAccountService accountService,
            SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager,
            IOptions<AppSettings> appSettings,
            IEmailSender emailSender)
        {
            _jwtService = jwtService;
            _accountService = accountService;
            _signInManager = signInManager;
            _userManager = userManager;
            _emailSender = emailSender;
            _appSettings = appSettings.Value;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO request)
        {
            var signInResult = await _accountService.LoginAsync(request);

            if (!signInResult.Succeeded)
            {
                return Unauthorized(new { success = false, message = "Invalid email address or password!" });
            }

            ApplicationUser user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                return BadRequest(new { success = false, message = $"User with email {request.Email} was null!" });
            }

            try
            {
                ApplicationUser identityUser = await _accountService.FindByEmailAsync(user.Email);

                ClaimsPrincipal principal = await _accountService.CreateUserPrincipalAsync(identityUser);

                AuthResponse authResponse = await _jwtService.GenerateTokens(identityUser, principal.Claims);

                await _userManager.SetAuthenticationTokenAsync(user, _appSettings.AuthSettings.RefreshTokenProvider, _appSettings.AuthSettings.RefreshTokenPurpose, authResponse.RefreshToken.TokenString);

                return Ok(new { success = true, message = "User logged in successfully!", result = authResponse });

            }
            catch
            {
                return StatusCode(500, new { success = false, message = $"Something went wrong!" });
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDTO request)
        {
            // Check if email exist
            ApplicationUser existingUser = await _accountService.FindByEmailAsync(request.Email);
            if (existingUser != null)
            {
                return Ok(new { success = false, message = $"The email {request.Email} is already registered!" });
            }

            // Register account
            IdentityResult registerResult = await _accountService.RegisterAsync(request);
            if (!registerResult.Succeeded)
            {
                return BadRequest(new { success = false, message = registerResult.Errors.FirstOrDefault()?.Description });
            }


            // Generate email token confirmation
            ApplicationUser user = await _accountService.FindByEmailAsync(request.Email);
            string emailConfirmationToken = await _accountService.GenerateEmailConfirmationTokenAsync(user);

            var callbackUrl = Url.Action(
                action: "ConfirmEmail",
                controller: "Account",
                values: new { area = "Identity", userId = user.Id, code = emailConfirmationToken },
                protocol: Request.Scheme
                );

            await _emailSender.SendEmailAsync(request.Email, "Confirm your email",
           $"Thanks for signing up to eLearning! Please activate your account by clicking the link below: <br/> <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>Activate account</a>.");

            // Success response message
            string successResponseMessage = request.Role switch
            {
                "Instructor" => GlobalConstants.SuccessResponseMessage.RegisterInstructor,

                "Student" => GlobalConstants.SuccessResponseMessage.RegisterStudent,

                _ => GlobalConstants.SuccessResponseMessage.RegisterAdmin
            };

            return Ok(new { success = true, message = successResponseMessage, token = emailConfirmationToken });
        }

        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            var user = await _userManager.FindByIdAsync(userId);

            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await _userManager.ConfirmEmailAsync(user, code);

            if(!result.Succeeded)
            {
                return BadRequest("Error confirming your email.");
            }

            return Ok("Thank you for confirming your email.");
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken(string refreshToken)
        {
            string email = User.FindFirst(ClaimTypes.Email)?.Value;

            ApplicationUser user = await _userManager.FindByEmailAsync(email);

            var isValid = await _userManager.VerifyUserTokenAsync(user, _appSettings.AuthSettings.RefreshTokenProvider, _appSettings.AuthSettings.RefreshTokenPurpose, refreshToken);

            if (!isValid)
            {
                return BadRequest("Invalid refresh token!");
            }

            ClaimsPrincipal principal = await _accountService.CreateUserPrincipalAsync(user);

            return Ok(await _jwtService.GenerateTokens(user, principal.Claims));
        }

        [HttpPost("resend-email-confirmation")]
        public async Task<IActionResult> ResendEmailConfirmation(string email)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(email);

            if(user == null)
            {
                return BadRequest($"The user with email {email} does not exist!");
            }

            string emailConfirmationToken = await _accountService.GenerateEmailConfirmationTokenAsync(user);

            var callbackUrl = Url.Action(
                action: "ConfirmEmail",
                controller: "Account",
                values: new { area = "Identity", userId = user.Id, code = emailConfirmationToken },
                protocol: Request.Scheme
            );

            await _emailSender.SendEmailAsync(user.Email, "Confirm your email",
           $"Thanks for signing up to eLearning! Please activate your account by clicking the link below: <br/> <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>Activate account</a>.");

            return Ok("Email sent successfully!");
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok("Logged out successfully!");
        }
    }
}
