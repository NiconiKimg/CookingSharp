using CookingSharp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookingSharp.Infrastructure.Persistence.Configurations
{
    public class AppealConfiguration : IEntityTypeConfiguration<Appeal>
    {
        public void Configure(EntityTypeBuilder<Appeal> builder)
        {
            builder.ToTable("Appeals");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Description)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(a => a.Status)
                .IsRequired();

            builder.HasOne(a => a.User)
                   .WithMany(u => u.Appeals)
                   .HasForeignKey(a => a.UserId)
                   .IsRequired();
        }
    }
}