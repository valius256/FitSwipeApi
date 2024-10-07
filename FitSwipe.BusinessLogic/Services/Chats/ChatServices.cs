using FitSwipe.BusinessLogic.Interfaces.Chats;
using FitSwipe.BusinessLogic.Library;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Chat;
using FitSwipe.Shared.Dtos.Users;
using Mapster;
using Microsoft.AspNetCore.SignalR;

namespace FitSwipe.BusinessLogic.Services.Chats
{
    public class ChatServices : IChatServices
    {
        private readonly IChatRoomRepository _chatRoomRepository;
        private readonly IMessageRepository _messageRepository;
        private readonly IUserChatRoomRepository _userChatRoomRepository;
        private readonly IHubContext<ChatHub> _chatHubContext;

        public ChatServices(
                IChatRoomRepository chatRoomRepository,
                IMessageRepository messageRepository,
                IUserChatRoomRepository userChatRoomRepository,
                IHubContext<ChatHub> chatHubContext)
        {
            _chatRoomRepository = chatRoomRepository;
            _messageRepository = messageRepository;
            _userChatRoomRepository = userChatRoomRepository;
            _chatHubContext = chatHubContext;
        }

        public async Task<Guid?> CreateChatRoomAsync(bool isGroup, List<string> userFirebaseIds, string roomName)
        {
            // Check if this is a private chat
            if (!isGroup && userFirebaseIds.Count == 2)
            {
                var existingRoom = await _chatRoomRepository.GetPrivateChatRoomAsync(userFirebaseIds[0], userFirebaseIds[1]);
                if (existingRoom != null)
                {
                    return existingRoom.Id;
                }
            }

            var chatRoom = new ChatRoom
            {
                IsGroup = isGroup,
                RoomName = roomName,
            };

            await _chatRoomRepository.AddAsync(chatRoom);

            foreach (var userFirebaseId in userFirebaseIds)
            {
                var userChatRoom = new UserChatRoom
                {
                    ChatRoomId = chatRoom.Id,
                    UserFirebaseId = userFirebaseId,
                    JoinedAt = DateTime.UtcNow
                };
                await _userChatRoomRepository.AddAsync(userChatRoom);
            }

            return chatRoom.Id;
        }



        public async Task<Guid> CreateSoloChatAsync(string userFirebaseId1, string userFirebaseId2)
        {
            var chatRoom = new ChatRoom
            {
                IsGroup = false,
                RoomName = $"ChatRoomSolo {userFirebaseId1} to {userFirebaseId2}",
            };

            await _chatRoomRepository.AddAsync(chatRoom);

            var currUserChatRoom = new List<string> { userFirebaseId1, userFirebaseId2 };
            foreach (var userFirebaseId in currUserChatRoom)
            {
                var userChatRoom = new UserChatRoom
                {
                    ChatRoomId = chatRoom.Id,
                    UserFirebaseId = userFirebaseId
                };
                await _userChatRoomRepository.AddAsync(userChatRoom);
            }

            return chatRoom.Id;

        }

        public async Task<List<ChatRoomRecordDtos>> GetAllChatRoomByUserFirebaseIdAsync(string userFirebaseId)
        {
            var currentUserChatRooms = await _userChatRoomRepository.GetUserChatRoomsByUserFirebaseId(userFirebaseId);

            var result = currentUserChatRooms.Select(l => new ChatRoomRecordDtos
            {
                ChatRoomId = l.ChatRoomId,
                RoomName = l.ChatRoom.RoomName,
                UserFirebaseId = l.UserFirebaseId,
                User = l.User.Adapt<GetUserDto>()
            }).ToList();
            return result;
        }

        public async Task<List<MessageRecordDtos>> GetAllGroupChatMessageFromGroupChatIdAsync(Guid chatRoomId)
        {
            var messages = await _messageRepository.GetAllChatMessageWithChatRoomIdAsync(chatRoomId);
            var mapppedResult = messages.Adapt<List<MessageRecordDtos>>();
            return mapppedResult;
        }

        // Save a message in a chat room
        public async Task SaveMessageAsync(string chatRoomId, string message, string userFirebaseId)
        {
            var newMessage = new Message
            {
                ChatRoomId = new Guid(chatRoomId),
                Content = message,
                UserFirebaseId = userFirebaseId,
                SentAt = DateTime.UtcNow
            };

            await _messageRepository.AddAsync(newMessage);
        }
    }
}
