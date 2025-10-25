using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookingSharp.Infrastructure.Persistence.Configurations;

public class RatingConfiguration : IEntityTypeConfiguration<Rating>
{
    public void Configure(EntityTypeBuilder<Rating> builder)
    {
        builder.ToTable("Ratings");

        builder.HasKey(r => r.Id);

        builder.Property(r => r.Stars).IsRequired();

        // Regla de negocio: Un usuario solo puede valorar una receta una vez.
        // Se implementa con un índice único compuesto.
        builder.HasIndex(r => new { r.UserId, r.RecipeId }).IsUnique();

        // Relación Uno-a-Muchos: Un Usuario tiene muchas Valoraciones
        builder.HasOne(r => r.User)
            .WithMany(u => u.Ratings)
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Restrict); // No permitir borrar un usuario si tiene valoraciones

        // Relación Uno-a-Muchos: Una Receta tiene muchas Valoraciones
        builder.HasOne(r => r.Recipe)
            .WithMany(rec => rec.Ratings)
            .HasForeignKey(r => r.RecipeId)
            .OnDelete(DeleteBehavior.Cascade); // Si se borra la receta, se borran sus valoraciones
    }
}