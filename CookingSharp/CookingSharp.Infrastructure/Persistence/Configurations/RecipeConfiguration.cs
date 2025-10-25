using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookingSharp.Infrastructure.Persistence.Configurations;

public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
{
    public void Configure(EntityTypeBuilder<Recipe> builder)
    {
        builder.ToTable("Recipes");

        builder.HasKey(r => r.Id);

        builder.Property(r => r.Name)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(r => r.Description)
            .IsRequired()
            .HasMaxLength(500);

        // Relación Uno-a-Muchos: Un Usuario tiene muchas Recetas
        builder.HasOne(r => r.User)
            .WithMany(u => u.Recipes)
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Cascade); // Si se borra un usuario, se borran sus recetas

        // Relación Uno-a-Muchos: Una Receta tiene muchos Pasos
        builder.HasMany(r => r.Steps)
            .WithOne(s => s.Recipe)
            .HasForeignKey(s => s.RecipeId)
            .OnDelete(DeleteBehavior.Cascade); // Si se borra una receta, se borran sus pasos

        // Relación Muchos-a-Muchos: Una Receta puede tener muchas Categorías
        builder.HasMany(r => r.Categories)
            .WithMany(c => c.Recipes);
    }
}