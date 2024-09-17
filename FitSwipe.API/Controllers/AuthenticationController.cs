using FitSwipe.BusinessLogic.Interfaces.Auth;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.Shared.Dtos.Users;
using FitSwipe.Shared.Model.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : BaseController<AuthenticationController>
    {

        private readonly IUserServices _userServices;
        private readonly IFirebaseAuthServices _authServices;
        public AuthenticationController(IUserServices userServices, IFirebaseAuthServices authServices, ILogger<AuthenticationController> logger) : base(logger)
        {
            _userServices = userServices;
            _authServices = authServices;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterRequestModel registerRequestModel)
        {
            var response = await _userServices.RegisterUser(registerRequestModel);
            return Ok(response);
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] string email)
        {
            var response = await _authServices.ForgotPasswordAsync(email);
            return Ok(response);
        }

        [Authorize(Policy = "RequireTraineeRole")]
        [HttpGet("get-test")]
        public async Task<IActionResult> GetListUser()
        {
            var response = await _userServices.GetAllUserAsync();
            return Ok(response);
        }


        [HttpPost("login-firebase")]
        public async Task<AuthenResponseDto> LoginFireBase([FromBody] LoginRequest body)
        {
            var response = await _authServices.LoginWithFireBase(body);
            return response;
        }


        [Authorize]
        [HttpGet("who-am-i")]
        public async Task<GetProfileUserDto> GetProfile()
        {
            var response = await _userServices.GetProfileUser(CurrentUserFirebaseId);
            return response;
        }



    }
}
