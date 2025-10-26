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

        builder.HasOne(m => m.User)
            .WithMany(u => u.Menus)
            .HasForeignKey(m => m.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(m => m.Recipes)
            .WithMany(r => r.Menus)
            .UsingEntity(j => j.ToTable("MenuRecipes"));

        builder.HasMany(m => m.Ratings)
            .WithOne(r => r.Menu)
            .HasForeignKey(r => r.MenuId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}