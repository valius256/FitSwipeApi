using FitSwipe.BusinessLogic.Interfaces.Tags;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Tags;
using FitSwipe.Shared.Dtos.Users;
using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        private readonly IUserTagService _userTagService;

        public UserController(IUserServices userServices, IUserTagService userTagService)
        {
            _userServices = userServices;
            _userTagService = userTagService;
        }

        [HttpGet]
        public async Task<PagedResult<GetUserDto>> GetUsers([FromQuery] PagingModel<QueryUserDto> queryUserDto)
        {
            return await _userServices.GetUserPaged(queryUserDto);
        }

        [HttpGet("with-tags")]
        public async Task<PagedResult<GetUserWithTagDto>> GetUserPagedWithTags([FromQuery] PagingModel<QueryUserDto> queryUserDto)
        {
            return await _userServices.GetUserPagedWithTags(queryUserDto);
        }

        [HttpGet("match-ordered")]
        public async Task<PagedResult<GetUserWithTagDto>> GetMatchedUsersWithTagsPaged([FromQuery] string userId, [FromQuery] int page = 1, [FromQuery] int limit = 10)//Remove later the userId later
        {
            return await _userTagService.GetRecommendedPTListByTags(userId, page, limit);
        }
    }
}
