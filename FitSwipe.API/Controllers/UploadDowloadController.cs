using FitSwipe.BusinessLogic.Interfaces.UploadDowload;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.Shared.Dtos.UploadDowloads;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadDowloadController : BaseController<UploadDowloadController>
    {
        private readonly IFirebaseUploadDowloadServices _firebaseUploadServices;
        private readonly IUserServices _userServices;
        public UploadDowloadController(IFirebaseUploadDowloadServices firebaseUploadServices, IUserServices userServices, ILogger<UploadDowloadController> logger) : base(logger)
        {
            _firebaseUploadServices = firebaseUploadServices;
            _userServices = userServices;
        }

        [HttpPost("upload-video")]
        [Authorize]
        public async Task<IActionResult> UploadVideo(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("File is empty");
            var userFirebaseId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "user_id")?.Value;
            if (userFirebaseId == null)
                return BadRequest("Can't get user from HttpContext");
            using (var stream = file.OpenReadStream())
            {
                var fileUrl = await _firebaseUploadServices.UploadVideoAsync(userFirebaseId, file.FileName, stream);
                return Ok(new { fileUrl });
            }
        }


        [HttpPost("upload-image")]
        [Authorize]
        public async Task<IActionResult> Upload(string fileName, IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("File is empty");

            try
            {
                // Convert IFormFile to Stream
                using (var stream = file.OpenReadStream())
                {
                    // Call the service method with the MIME type
                    var fileUrl = await _firebaseUploadServices.UploadImageAsync(CurrentUserFirebaseId, fileName, stream, file.ContentType);
                    return Ok(new { fileUrl });
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log them and return a meaningful response)
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("upload-video-get-thumb")]
        [Authorize]
        public async Task<ActionResult<GetUploadVideoResultWithThumbDto>> UploadVideoAndGetThumbnail(IFormFile file)
        {
            return await _firebaseUploadServices.UploadVideoAndGetThumb(file,CurrentUserFirebaseId);
        }
    }
}
