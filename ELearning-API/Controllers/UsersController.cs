using ELearning_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ELearning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            return Ok(_usersService.All());
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return Ok(_usersService.All());
        }
    }
}
