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

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
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
    }
}
