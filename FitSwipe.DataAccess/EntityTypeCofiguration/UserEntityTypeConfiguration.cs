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

            builder.Property(u => u.Phone)
                .IsRequired()   // Phone number is required
                .HasMaxLength(10) // The length of a Vietnamese phone number is 10 digits
                .HasColumnType("varchar(10)"); // Store it as a varchar(10) in the database

            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.PricePerHour)
                .IsRequired(true)
                .ValueGeneratedOnAdd()
                .HasDefaultValue(0)
                .HasColumnType("decimal(10,2)");


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
