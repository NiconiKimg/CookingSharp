using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookingSharp.Infrastructure.Persistence.Configurations;

public class RecipeStepConfiguration : IEntityTypeConfiguration<RecipeStep>
{
    public void Configure(EntityTypeBuilder<RecipeStep> builder)
    {
        builder.ToTable("RecipeSteps");

        builder.HasKey(s => s.Id);

        builder.Property(s => s.StepNumber).IsRequired();

        builder.Property(s => s.Instruction)
            .IsRequired()
            .HasMaxLength(1000);
    }
}