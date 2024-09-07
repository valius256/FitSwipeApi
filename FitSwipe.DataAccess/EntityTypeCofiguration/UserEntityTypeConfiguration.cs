using FitSwipe.DataAccess.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitSwipe.DataAccess.EntityTypeCofiguration
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.FireBaseId);

            builder.HasMany(x => x.TrainingsInstructing)
                .WithOne(x => x.PT)
                .HasForeignKey(x => x.PTId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.ReportsReceived)
                .WithOne(x => x.Target)
                .HasForeignKey(x => x.TargetId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(ut => ut.UserTags)
                .WithOne(u => u.User)
                .HasForeignKey(ut => ut.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
