using CookingSharp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookingSharp.Infrastructure.Persistence.Configurations
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.ToTable("Recipes");
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Description)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(r => r.Content)
                .IsRequired();

            builder.Property(r => r.Status);

            builder.HasOne(r => r.User)
               .WithMany(u => u.Recipes)
               .HasForeignKey(r => r.UserId)
               .IsRequired();

            builder.HasMany(r => r.Categories)
                   .WithMany(c => c.Recipes);
        }
    }
}