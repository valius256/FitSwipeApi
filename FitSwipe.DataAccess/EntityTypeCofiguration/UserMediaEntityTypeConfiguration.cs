
using FitSwipe.DataAccess.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitSwipe.DataAccess.EntityTypeCofiguration
{
    public class UserMediaEntityTypeConfiguration : IEntityTypeConfiguration<UserMedia>
    {
        public void Configure(EntityTypeBuilder<UserMedia> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasOne(x => x.User)
                .WithMany(x => x.UserMedias)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
