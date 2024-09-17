using FirebaseAdmin.Auth;
using FitSwipe.BusinessLogic.Interfaces.Auth;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.Shared.Dtos.Users;
using FitSwipe.Shared.Model.Auth;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
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


        [HttpPost("verify-token")]
        public async Task<IActionResult> VerifyToken([FromBody] TokenVerificationRequest request)
        {
            try
            {
                // Verify the Firebase ID token
                var decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(request.Token);
                var uid = decodedToken.Uid;

                var user = await _userServices.GetUserByIdRequired(uid);

                // Extract claims from the Firebase token
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, uid),

                    new Claim(ClaimTypes.Email, decodedToken.Claims["email"]?.ToString() ?? "")
                };

                // If you have custom claims or roles, add them here
                if (decodedToken.Claims.TryGetValue("role", out object role))
                {
                    claims.Add(new Claim(ClaimTypes.Role, user.Role.ToString()));
                }

                // Create identity and principal
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                // Sign in the user with the created principal
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return Ok(new { UserId = uid });
            }
            catch (FirebaseAuthException)
            {
                // Token verification failed
                return Unauthorized("Invalid token");
            }
        }




    }
}
