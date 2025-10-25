using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookingSharp.Infrastructure.Persistence.Configurations;

public class MenuConfiguration : IEntityTypeConfiguration<Menu>
{
    public void Configure(EntityTypeBuilder<Menu> builder)
    {
        builder.ToTable("Menus");

        builder.HasKey(m => m.Id);

        builder.Property(m => m.Name)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(m => m.Description)
            .IsRequired()
            .HasMaxLength(500);

        // Relación Uno-a-Muchos: Un Usuario tiene muchos Menús
        builder.HasOne(m => m.User)
            .WithMany(u => u.Menus)
            .HasForeignKey(m => m.UserId)
            .OnDelete(DeleteBehavior.Cascade); // Si se borra el usuario, se borran sus menús

        // Relación Muchos-a-Muchos: Un Menú tiene muchas Recetas
        builder.HasMany(m => m.Recipes)
            .WithMany(r => r.Menus)
            .UsingEntity(j => j.ToTable("MenuRecipes")); // Tabla de unión explícita
    }
}