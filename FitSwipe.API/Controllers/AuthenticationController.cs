using FirebaseAdmin.Auth;
using FitSwipe.BusinessLogic.Interfaces.Auth;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.Shared.Model.Auth;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FitSwipe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {

        private readonly IUserServices _userServices;
        private readonly IFirebaseAuthServices _authServices;
        public AuthenticationController(IUserServices userServices, IFirebaseAuthServices authServices)
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

        [HttpGet("get-test")]
        public async Task<IActionResult> GetListUser()
        {
            var response = await _userServices.GetAllUserAsync();
            return Ok(response);
        }


        [HttpPost("verify-token")]
        public async Task<IActionResult> VerifyToken([FromBody] TokenVerificationRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.Token))
            {
                return BadRequest("Invalid request: Token is required.");
            }

            var token = request.Token;

            // Verify the token using Firebase Admin SDK
            FirebaseToken decodedToken;
            try
            {
                decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(token);
            }
            catch (Exception)
            {
                return Unauthorized("Invalid Firebase token.");
            }

            // Get the user's Firebase UID from the token
            var uid = decodedToken.Uid;

            var userEntity = await _userServices.GetUserByIdRequired(uid);

            // Add role claim to the identity
            var claimsIdentity = new ClaimsIdentity(new[]
            {
                new Claim("uid", uid),
                new Claim(ClaimTypes.Role, userEntity.Role.ToString()) // Add the role claim
            });

            // Attach the identity to the current user
            var userPrincipal = new ClaimsPrincipal(claimsIdentity);
            HttpContext.User = userPrincipal;

            return Ok(new { Role = userEntity.Role.ToString() });
        }


    }
}
