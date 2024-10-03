using FitSwipe.BusinessLogic.Interfaces.Tags;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.UploadDowloads;
using FitSwipe.Shared.Dtos.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : BaseController<UserController>
    {
        private readonly IUserServices _userServices;
        private readonly IUserTagService _userTagService;

        public UserController(IUserServices userServices, IUserTagService userTagService, ILogger<UserController> logger) : base(logger)
        {
            _userServices = userServices;
            _userTagService = userTagService;
        }

        //[HttpGet]
        //public async Task<PagedResult<GetUserDto>> GetUsers([FromQuery] PagingModel<QueryUserDto> queryUserDto)
        //{
        //    return await _userServices.GetUserPagedAsync(queryUserDto);
        //}

        [HttpGet]
        public async Task<PagedResult<GetUserWithTagDto>> GetUserPagedWithTags([FromQuery] PagingModel<QueryUserDto> queryUserDto)
        {
            return await _userServices.GetUserPagedWithTagsAsync(queryUserDto);
        }
        [Authorize]
        [HttpGet("match-ordered")]
        public async Task<PagedResult<GetUserWithTagDto>> GetMatchedUsersWithTagsPaged([FromQuery] int page = 1, [FromQuery] int limit = 10)
        {
            return await _userTagService.GetRecommendedPTListByTags(CurrentUserFirebaseId, page, limit);
        }
        [Authorize]
        [HttpPatch("update-degree")]
        public async Task<IActionResult> UpdatePTDegree([FromBody] UpdateImageUrlDto updateImageUrlDto)
        {
            await _userServices.UpdatePTDegreeAsync(CurrentUserFirebaseId, updateImageUrlDto);
            return Ok();
        }
        [Authorize]
        [HttpPatch("set-up")]
        public async Task<IActionResult> SetupProfile([FromBody] SetupProfileDto setupProfileDto)
        {
            await _userServices.SetupProfileAsync(CurrentUserFirebaseId, setupProfileDto);
            return Ok();
        }
    }
}
