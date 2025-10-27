using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CookingSharp.Infrastructure.Persistence
{
    /// <summary>
    /// Factory para crear instancias del DbContext en tiempo de diseño, utilizado por las migraciones de Entity Framework.
    /// </summary>
    public class CookingSharpDbContextFactory : IDesignTimeDbContextFactory<CookingSharpDbContext>
    {
        /// <summary>
        /// Crea una instancia del DbContext para las herramientas de diseño de Entity Framework.
        /// </summary>
        /// <param name="args">Argumentos de línea de comandos.</param>
        /// <returns>Instancia configurada del DbContext.</returns>
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