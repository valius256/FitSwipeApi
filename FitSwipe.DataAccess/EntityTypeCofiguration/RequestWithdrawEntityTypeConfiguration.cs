

using FitSwipe.DataAccess.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitSwipe.DataAccess.EntityTypeCofiguration
{
    public class RequestWithdrawEntityTypeConfiguration : IEntityTypeConfiguration<RequestWithdraw>
    {
        public void Configure(EntityTypeBuilder<RequestWithdraw> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();

            builder.HasOne(r => r.User)
                .WithMany(u => u.RequestWithdrawsCreated)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
