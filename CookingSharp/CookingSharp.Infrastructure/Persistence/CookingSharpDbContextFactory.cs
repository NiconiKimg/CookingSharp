using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CookingSharp.Infrastructure.Persistence
{
    public class CookingSharpDbContextFactory : IDesignTimeDbContextFactory<CookingSharpDbContext>
    {
        public CookingSharpDbContext CreateDbContext(string[] args)
        {
            string basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "CookingSharp.WebAPI");

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<CookingSharpDbContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new CookingSharpDbContext(optionsBuilder.Options);
        }
    }
}