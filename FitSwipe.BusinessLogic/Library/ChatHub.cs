using FitSwipe.BusinessLogic.Interfaces.Chats;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace FitSwipe.BusinessLogic.Library
{
    public class ChatHub : Hub
    {
        private readonly ILogger<ChatHub> _logger;
        private readonly IChatServices _chatServices;

        public ChatHub(ILogger<ChatHub> logger, IChatServices chatServices)
        {
            _logger = logger;
            _chatServices = chatServices;
        }

        // send message to all
        public async Task SendMessageToAll(string userFirebaseId, string message)
        {
            // Broadcast the message to all clients in the room
            await Clients.All.SendAsync("ReceiveMessage", userFirebaseId, message);
        }


        // Send a message to a chat room
        public async Task SendMessage(string chatRoomId, string userFirebaseId, string message)
        {
            _logger.LogInformation($"Message from {userFirebaseId} to room {chatRoomId}: {message}");
            // Broadcast the message to all clients in the room
            await _chatServices.SaveMessageAsync(chatRoomId, message, userFirebaseId);
            await Clients.Group(chatRoomId).SendAsync("ReceiveMessage", userFirebaseId, message, DateTime.UtcNow.AddHours(7), chatRoomId);
        }

        // Called when a client joins a room (private or group)
        public async Task JoinRoom(string chatRoomId, bool isGroup, string userFirebaseId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, chatRoomId);
            await Clients.Group(chatRoomId).SendAsync("UserJoined", Context.ConnectionId, isGroup);
            //var isAddOrNot = _chatServices.CreateChatRoomAsync(isGroup, userFirebaseId, chatRoomId); 
            //var result = await _chatServices.GetAllGroupChatMessageFromGroupChatIdAsync(Guid.Parse(chatRoomId));

            _logger.LogInformation($"User {Context.ConnectionId} joined chat room {chatRoomId}");
        }

        // Called when a client leaves a room
        public async Task LeaveRoom(string chatRoomId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, chatRoomId);
            await Clients.Group(chatRoomId).SendAsync("UserLeft", Context.ConnectionId);


            _logger.LogInformation($"User: {Context.ConnectionId} has left the chat room");
        }
    }
}
