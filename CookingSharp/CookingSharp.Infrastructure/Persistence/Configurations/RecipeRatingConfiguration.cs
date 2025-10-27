using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookingSharp.Infrastructure.Persistence.Configurations;

/// <summary>
/// Configuración de Entity Framework para la entidad RecipeRating.
/// </summary>
public class RecipeRatingConfiguration : IEntityTypeConfiguration<RecipeRating>
{
    public void Configure(EntityTypeBuilder<RecipeRating> builder)
    {
        builder.ToTable("RecipeRatings");

        builder.HasKey(r => r.Id);

        builder.Property(r => r.Stars).IsRequired();

        builder.HasIndex(r => new { r.UserId, r.RecipeId }).IsUnique();

        builder.HasOne(r => r.User)
            .WithMany(u => u.RecipeRatings)
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(r => r.Recipe)
            .WithMany(rec => rec.Ratings) 
            .HasForeignKey(r => r.RecipeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}