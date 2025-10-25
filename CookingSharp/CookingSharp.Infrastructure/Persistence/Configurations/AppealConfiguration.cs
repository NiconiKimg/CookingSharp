using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookingSharp.Infrastructure.Persistence.Configurations;

public class AppealConfiguration : IEntityTypeConfiguration<Appeal>
{
    public void Configure(EntityTypeBuilder<Appeal> builder)
    {
        builder.ToTable("Appeals");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Description)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(a => a.Status).IsRequired();

        // Relación Uno-a-Muchos: Un Usuario tiene muchas Solicitudes
        builder.HasOne(a => a.User)
            .WithMany(u => u.Appeals)
            .HasForeignKey(a => a.UserId)
            .OnDelete(DeleteBehavior.Cascade); // Si se borra el usuario, se borran sus solicitudes
    }
}