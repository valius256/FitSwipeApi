using FitSwipe.BusinessLogic.Interfaces.Tags;
using FitSwipe.Shared.Dtos.Tags;
using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TagController : ControllerBase
    {
        private readonly IUserTagService _userTagService;
        private readonly ITagService _tagService;

        public TagController(IUserTagService userTagService, ITagService tagService)
        {
            _userTagService = userTagService;
            _tagService = tagService;
        }
        [HttpGet]
        public async Task<List<GetTagDto>> GetTagsQueried([FromQuery] QueryTagDto queryTagDto)
        {
            return await _tagService.GetTagsQueried(queryTagDto);
        }
        [HttpGet("{userId}/get-tags")]
        public async Task<List<GetTagDto>> GetsTagByUserId([FromRoute] string userId)
        {
            return await _userTagService.GetsTagByUserId(userId);
        }
        [HttpGet("get-tags-in-common")]
        public async Task<List<GetTagDto>> GetTagsInCommon([FromQuery] GetCommonUserTagDto getCommonUserTagDto)
        {
            return await _userTagService.GetCommonTags(getCommonUserTagDto.FirstUserId, getCommonUserTagDto.SecondUserId);
        }
        [HttpPut("upsert-user-tags")]
        public async Task<IActionResult> UpsertUserTags([FromBody] UpsertUserTagDto upsertUserTagDto)
        {
            await _userTagService.UpsertUserTags(upsertUserTagDto.UserId,upsertUserTagDto);
            return Ok();
        }
    }
}
