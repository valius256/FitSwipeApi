

using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Chat
{
    public class GetSimpleUserChatRoomDto
    {
        public string UserFirebaseId { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string? AvatarUrl { get; set; } = string.Empty;
        public Role Role { get; set; }
        public string? Job { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? SubscriptionLevel { get; set; }
        public PaymentStatus? SubscriptionPaymentStatus { get; set; }
        public int UnseenMessaged { get; set; } = 0;
    }
}
