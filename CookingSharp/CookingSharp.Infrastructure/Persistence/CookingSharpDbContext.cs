using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CookingSharp.Infrastructure.Persistence;

/// <summary>
/// Representa la sesión con la base de datos y proporciona acceso a las entidades del dominio.
/// </summary>
public class CookingSharpDbContext : DbContext
{
    public CookingSharpDbContext(DbContextOptions<CookingSharpDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<RecipeStep> RecipeSteps { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<RecipeRating> Ratings { get; set; }
    public DbSet<Menu> Menus { get; set; }
    public DbSet<Appeal> Appeals { get; set; }

    /// <summary>
    /// Configura el modelo de la base de datos aplicando las configuraciones de las entidades.
    /// </summary>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}