using FitSwipe.BusinessLogic.Interfaces.Chats;
using FitSwipe.BusinessLogic.Library;
using FitSwipe.Shared.Dtos.Chat;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FitSwipe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RealtimeChatController : BaseController<RealtimeChatController>
    {
        private readonly ILogger<RealtimeChatController> _logger;
        private readonly IChatServices _chatServices;
        private readonly IHubContext<ChatHub> _chatHubContext;

        public RealtimeChatController(ILogger<RealtimeChatController> logger, IChatServices chatServices, IHubContext<ChatHub> chatHubContext) : base(logger)
        {
            _logger = logger;
            _chatServices = chatServices;
            _chatHubContext = chatHubContext;
        }

        [HttpPost("chat1-1")]
        [Authorize]
        public async Task<IActionResult> CreateSoloChat([FromQuery] string toUserFirebaseId)
        {
            var chatRoomId = await _chatServices.CreateSoloChatAsync(CurrentUserFirebaseId, toUserFirebaseId);

            //if (chatRoomId == null)
            //{
            //    return BadRequest("Failed to create chat room.");
            //}

            return Ok(new { ChatRoomId = chatRoomId });
        }


        [HttpPost("create-chat-room")]
        public async Task<IActionResult> CreateChatRoom([FromBody] CreateChatRoomRequest request)
        {
            var chatRoomId = await _chatServices.CreateChatRoomAsync(request.IsGroup, request.UserFirebaseIds, request.ChatRoomName);

            if (chatRoomId == null)
            {
                return BadRequest("Failed to create chat room.");
            }

            foreach (var userId in request.UserFirebaseIds)
            {
                await _chatHubContext.Clients.User(userId).SendAsync("JoinRoom", chatRoomId, request.IsGroup);
            }


            return Ok(new { ChatRoomId = chatRoomId });
        }



        [HttpPost("sendMessage")]
        [Authorize]
        public async Task<IActionResult> SendMessage([FromBody] ChatMessageRequest request)
        {
            if (string.IsNullOrEmpty(request.ChatRoomId) || string.IsNullOrEmpty(request.Message))
                return BadRequest("ChatRoomId and Message are required.");

            try
            {
                // Group(request.ChatRoomId)
                await _chatServices.SaveMessageAsync(request.ChatRoomId, request.Message, CurrentUserFirebaseId);
                await _chatHubContext.Clients.Group(request.ChatRoomId).SendAsync("ReceiveMessage", CurrentUserId, request.Message, request.IsGroup);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error sending message in chat room {ChatRoomId} by user {UserId}", request.ChatRoomId, CurrentUserFirebaseId);
                return StatusCode(500, "Internal server error while sending message.");
            }


            return Ok("Message sent successfully.");
        }

        [HttpGet("getAllChatRooms")]
        [Authorize]
        public async Task<IActionResult> GetAllChatRooms()
        {
            var chatRooms = await _chatServices.GetAllChatRoomByUserFirebaseIdAsync(CurrentUserFirebaseId);
            return Ok(chatRooms);
        }
        [HttpGet("chat-room-detail/{chatRoomId}")]
        [Authorize]
        public async Task<IActionResult> GetChatRoomDetailById([FromRoute] Guid chatRoomId)
        {
            var chatRooms = await _chatServices.GetChatRoomDetailByIdAsync(chatRoomId,CurrentUserFirebaseId);
            return Ok(chatRooms);
        }
        [HttpGet("messages")]
        [Authorize]
        public async Task<IActionResult> GetMessagesOfTheRoomWith([FromQuery] string guestId, [FromQuery] int limit = 10, [FromQuery] int skip = 0)
        {
            var chatRooms = await _chatServices.GetMessagesOfTheRoomWith(CurrentUserFirebaseId, guestId, limit, skip);
            return Ok(chatRooms);
        }
        [HttpPut("seen")]
        [Authorize]
        public async Task<IActionResult> SeenMessages([FromQuery] Guid chatRoomId)
        {
            await _chatServices.UpdateViewedUnseenMessages(chatRoomId,CurrentUserFirebaseId);
            return Ok();
        }
    }
}
