using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookingSharp.Infrastructure.Persistence.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.ToTable("Comments");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Text)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(c => c.CreatedAt).IsRequired();

        // Relación Uno-a-Muchos: Un Usuario tiene muchos Comentarios
        builder.HasOne(c => c.User)
            .WithMany(u => u.Comments)
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.Restrict); // No permitir borrar un usuario si tiene comentarios

        // Relación Uno-a-Muchos: Una Receta tiene muchos Comentarios
        builder.HasOne(c => c.Recipe)
            .WithMany(r => r.Comments)
            .HasForeignKey(c => c.RecipeId)
            .OnDelete(DeleteBehavior.Cascade); // Si se borra la receta, se borran sus comentarios
    }
}