using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.Shared.Dtos.Medias;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{
    [ApiController]
    [Route("api/medias")]
    public class MediaController : BaseController<MediaController>
    {
        private readonly IUserMediaService _userMediaService;
        public MediaController(ILogger<MediaController> logger, IUserMediaService userMediaService) : base(logger)
        {
            _userMediaService = userMediaService;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<GetUserMediaDto>> CreateUserMedia([FromBody] CreateUserMediaDto createUserMediaDto)
        {
            return await _userMediaService.CreateUserMediaAsync(createUserMediaDto, CurrentUserFirebaseId);
        }
        [Authorize]
        [HttpPut]
        public async Task<ActionResult<GetUserMediaDto>> UpdateUserMedia([FromBody] UpdateUserMediaDto updateUserMediaDto)
        {
            return await _userMediaService.UpdateUserMediaAsync(updateUserMediaDto, CurrentUserFirebaseId);
        }
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserMedia([FromRoute] Guid id)
        {
            await _userMediaService.DeleteUserMediaAsync(id, CurrentUserFirebaseId);
            return Ok();
        }

    }
}
