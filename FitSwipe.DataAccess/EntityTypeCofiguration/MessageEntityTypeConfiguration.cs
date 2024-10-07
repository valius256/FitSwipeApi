using FitSwipe.DataAccess.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitSwipe.DataAccess.EntityTypeCofiguration
{
    public class MessageEntityTypeConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            // Primary Key
            builder.HasKey(m => m.Id);

            // Properties
            builder.Property(m => m.Content)
                   .IsRequired()
                   .HasMaxLength(1000); // You can adjust the length as per your requirement.

            builder.Property(m => m.SentAt)
                   .IsRequired();

            // Relationships
            builder.HasOne(m => m.User)
                   .WithMany(u => u.Messages) // Assuming the User entity will have a collection of Messages
                   .HasForeignKey(m => m.UserFirebaseId)
                   .OnDelete(DeleteBehavior.Cascade); // If a user is deleted, their messages are also deleted.

            builder.HasOne(m => m.ChatRoom)
                   .WithMany(c => c.Messages) // Assuming the ChatRoom entity will have a collection of Messages
                   .HasForeignKey(m => m.ChatRoomId)
                   .OnDelete(DeleteBehavior.Cascade); // If a chat room is deleted, its messages are also deleted.
        }
    }
}
