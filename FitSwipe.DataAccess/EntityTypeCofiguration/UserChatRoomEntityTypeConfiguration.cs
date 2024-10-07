using FitSwipe.DataAccess.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace FitSwipe.DataAccess.EntityTypeCofiguration
{
    public class UserChatRoomEntityTypeConfiguration : IEntityTypeConfiguration<UserChatRoom>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UserChatRoom> builder)
        {
            builder.HasKey(ts => new { ts.UserFirebaseId, ts.ChatRoomId });


            // Relationships
            builder.HasOne(uc => uc.User)
                   .WithMany(u => u.UserChatRooms)
                   .HasForeignKey(uc => uc.UserFirebaseId);

            builder.HasOne(uc => uc.ChatRoom)
                   .WithMany(c => c.UserChatRooms)
                   .HasForeignKey(uc => uc.ChatRoomId);
        }
    }
}
