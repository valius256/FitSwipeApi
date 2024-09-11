using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.Shared.Model.Auth;
using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {

        private readonly IUserServices _userServices;
        public AuthenticationController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterRequestModel registerDtos)
        {
            var response = await _userServices.RegisterUser(registerDtos);
            return Ok(response);
        }

    }
}
