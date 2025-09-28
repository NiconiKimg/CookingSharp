using CookingSharp.Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CookingSharp.Infrastructure.Persistence
{
    public class CookingSharpDbContext : DbContext
    {
        public CookingSharpDbContext(DbContextOptions<CookingSharpDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Appeal> Appeals { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}