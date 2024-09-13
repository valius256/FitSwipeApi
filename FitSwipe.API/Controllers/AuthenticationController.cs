﻿using System.Security.Claims;
using FirebaseAdmin.Auth;
using FitSwipe.BusinessLogic.Interfaces.Auth;
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
        

        [HttpGet("verify-token")]
        public async Task<IActionResult> VerifyToken()
        {
            // Extract Firebase token from the request
            var authHeader = Request.Headers["Authorization"].ToString();
            var token = authHeader.Replace("Bearer ", "");
            
            // Verify the token using Firebase Admin SDK
            FirebaseToken decodedToken;
            try
            {
                decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(token);
            }
            catch (Exception ex)
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
