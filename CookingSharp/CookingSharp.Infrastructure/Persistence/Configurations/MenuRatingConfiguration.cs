using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookingSharp.Infrastructure.Persistence.Configurations;

/// <summary>
/// Configuración de Entity Framework para la entidad MenuRating.
/// </summary>
public class MenuRatingConfiguration : IEntityTypeConfiguration<MenuRating>
{
    public void Configure(EntityTypeBuilder<MenuRating> builder)
    {
        builder.ToTable("MenuRatings");

        builder.HasKey(r => r.Id);

        builder.Property(r => r.Stars).IsRequired();

        builder.HasIndex(r => new { r.UserId, r.MenuId }).IsUnique();

        builder.HasOne(r => r.User)
            .WithMany(u => u.MenuRatings) 
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(r => r.Menu)
            .WithMany(m => m.Ratings)
            .HasForeignKey(r => r.MenuId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}