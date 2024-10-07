using FitSwipe.DataAccess.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitSwipe.DataAccess.EntityTypeCofiguration
{
    public class ChatRoomEntityTypeConfiguration : IEntityTypeConfiguration<ChatRoom>
    {
        public void Configure(EntityTypeBuilder<ChatRoom> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(c => c.RoomName)
             .IsRequired()
             .HasMaxLength(100);
            // relationship
            builder.HasMany(c => c.UserChatRooms)
             .WithOne(uc => uc.ChatRoom)
             .HasForeignKey(uc => uc.ChatRoomId);
        }
    }
}
