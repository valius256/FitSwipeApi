using FitSwipe.BusinessLogic.Interfaces.Chats;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.BusinessLogic.Library;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Chat;
using FitSwipe.Shared.Dtos.Users;
using FitSwipe.Shared.Exceptions;
using Mapster;
using Microsoft.AspNetCore.SignalR;
using SixLabors.ImageSharp.ColorSpaces;
using System.Data.Entity;

namespace FitSwipe.BusinessLogic.Services.Chats
{
    public class ChatServices : IChatServices
    {
        private readonly IChatRoomRepository _chatRoomRepository;
        private readonly IMessageRepository _messageRepository;
        private readonly IUserChatRoomRepository _userChatRoomRepository;
        private readonly IUserServices _userService;
        private readonly IHubContext<ChatHub> _chatHubContext;

        public ChatServices(
                IChatRoomRepository chatRoomRepository,
                IMessageRepository messageRepository,
                IUserChatRoomRepository userChatRoomRepository,
                IUserServices userServices,
                IHubContext<ChatHub> chatHubContext)
        {
            _chatRoomRepository = chatRoomRepository;
            _messageRepository = messageRepository;
            _userChatRoomRepository = userChatRoomRepository;
            _userService = userServices;
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
            
            var existedChatRoom = await _chatRoomRepository.GetPrivateChatRoomAsync(userFirebaseId1,userFirebaseId2);

            if (existedChatRoom != null)
            {
                throw new BadRequestException("You have created a chat room with this user " + userFirebaseId2);
            }

            var guest = await _userService.GetUserByIdRequiredAsync(userFirebaseId2);
            var chatRoom = new ChatRoom
            {
                IsGroup = false,
                RoomName = $"{guest.UserName}",
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
        public async Task<ChatRoomRecordDtos> GetChatRoomDetailByIdAsync(Guid chatRoomId, string userFirebaseId)
        {
            var chatRoom = await _chatRoomRepository.GetByIdAsync(chatRoomId);
            if (chatRoom == null)
            {
                throw new BadRequestException("Chatroom doesnot exists");
            }
            var result =  new ChatRoomRecordDtos
            {
                ChatRoomId = chatRoom.Id,
                RoomName = chatRoom.RoomName,
                UserFirebaseId = userFirebaseId,
                CreatedDate = chatRoom.CreatedDate,
                UpdatedDate = chatRoom.UpdatedDate,
            };

            var usersInRoom = await _userChatRoomRepository.GetUserChatRoomsWithUserByChatRoomId(chatRoom.Id);
            result.Users = usersInRoom.OrderByDescending(u => u.UserFirebaseId != userFirebaseId).Select(uc => new GetSimpleUserChatRoomDto
            {
                UserFirebaseId = uc.User.FireBaseId,
                AvatarUrl = uc.User.AvatarUrl,
                DateOfBirth = uc.User.DateOfBirth,
                Gender = uc.User.Gender,
                Job = uc.User.Job,
                Role = uc.User.Role,
                SubscriptionLevel = uc.User.SubscriptionLevel,
                SubscriptionPaymentStatus = uc.User.SubscriptionPaymentStatus,
                UnseenMessaged = uc.UnseenMessaged,
                UserName = uc.User.UserName
            }).ToList();
            
            return result;
        }
        public async Task<List<ChatRoomRecordDtos>> GetAllChatRoomByUserFirebaseIdAsync(string userFirebaseId)
        {
            var currentUserChatRooms = await _userChatRoomRepository.GetUserChatRoomsByUserFirebaseId(userFirebaseId);
            
            var result = currentUserChatRooms.Select(l => new ChatRoomRecordDtos
            {
                ChatRoomId = l.ChatRoomId,
                RoomName = l.ChatRoom.RoomName,
                UserFirebaseId = l.UserFirebaseId,
                CreatedDate = l.ChatRoom.CreatedDate,
                UpdatedDate = l.ChatRoom.UpdatedDate,
            }).ToList();

            foreach (var chatRoom in result)
            {
                var usersInRoom = await _userChatRoomRepository.GetUserChatRoomsWithUserByChatRoomId(chatRoom.ChatRoomId);
                chatRoom.Users = usersInRoom.OrderByDescending(u => u.UserFirebaseId != userFirebaseId).Select(uc => new GetSimpleUserChatRoomDto
                {
                    UserFirebaseId = uc.User.FireBaseId,
                    AvatarUrl = uc.User.AvatarUrl,
                    DateOfBirth = uc.User.DateOfBirth,
                    Gender = uc.User.Gender,
                    Job = uc.User.Job,
                    Role = uc.User.Role,
                    SubscriptionLevel = uc.User.SubscriptionLevel,
                    SubscriptionPaymentStatus = uc.User.SubscriptionPaymentStatus,
                    UnseenMessaged = uc.UnseenMessaged,
                    UserName = uc.User.UserName
                }).ToList();
            }

            return result;
        }
        public async Task<PagedResult<MessageRecordDtos>> GetMessagesOfTheRoomWith(string yourId,string guestId, int limit, int skip)
        {
            var chatRoom = await _chatRoomRepository.GetPrivateChatRoomAsync(yourId, guestId); 
            if (chatRoom == null)
            {
                throw new DataNotFoundException("Room with this user is not exist yet!");
            }
            return await GetAllGroupChatMessageFromGroupChatIdAsync(chatRoom.Id, limit, skip);
        }
        public async Task<PagedResult<MessageRecordDtos>> GetAllGroupChatMessageFromGroupChatIdAsync(Guid chatRoomId, int limit, int skip)
        {
            var messages = await _messageRepository.GetAllChatMessageWithChatRoomIdAsync(chatRoomId, limit, skip);
            var mapppedResult = messages.Adapt<PagedResult<MessageRecordDtos>>();
            return mapppedResult;
        }

        // Save a message in a chat room
        public async Task SaveMessageAsync(string chatRoomId, string message, string userFirebaseId)
        {
            var chatRoom = await _chatRoomRepository.GetByIdAsync(new Guid(chatRoomId));

            if (chatRoom == null)
            {
                throw new DataNotFoundException("Chat room is not found");
            }

            var newMessage = new Message
            {
                ChatRoomId = chatRoom.Id,
                Content = message,
                UserFirebaseId = userFirebaseId,
                SentAt = DateTime.UtcNow
            };

            await _messageRepository.AddAsync(newMessage);
            await UpdateAddUnseenMessages(chatRoom.Id, userFirebaseId);

            chatRoom.UpdatedDate = DateTime.UtcNow.AddHours(7);
            await _chatRoomRepository.UpdateAsync(chatRoom);
        }

        public async Task UpdateAddUnseenMessages(Guid chatRoomId, string senderId)
        {
            var chatRoom = await _chatRoomRepository.GetByIdAsync(chatRoomId);

            if (chatRoom == null)
            {
                throw new DataNotFoundException("Chat room is not found");
            }
            var userChatRooms = await _userChatRoomRepository.FindWithNoTrackingAsync(ucr => ucr.ChatRoomId == chatRoomId);
            foreach (var userChatRoom in userChatRooms)
            {
                if (userChatRoom.UserFirebaseId == senderId) continue;
                userChatRoom.UpdatedDate = DateTime.UtcNow.AddHours(7);
                userChatRoom.UnseenMessaged += 1;
            }
            await _userChatRoomRepository.UpdateRangeAsync(userChatRooms);

        }
        public async Task UpdateViewedUnseenMessages(Guid chatRoomId, string userId)
        {
            var userChatRoom = await _userChatRoomRepository.FindOneWithNoTrackingAsync(ucr => ucr.ChatRoomId == chatRoomId && ucr.UserFirebaseId == userId)
                ?? throw new DataNotFoundException("userChatRoom is not found");
            userChatRoom.UpdatedDate = DateTime.UtcNow.AddHours(7);
            userChatRoom.UnseenMessaged = 0;
            await _userChatRoomRepository.UpdateAsync(userChatRoom);

        }
    }
}
