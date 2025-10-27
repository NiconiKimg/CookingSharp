using CookingSharp.Application.Contracts;
using CookingSharp.Application.Contracts.Infrastructure;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Infrastructure.Auth;
using CookingSharp.Infrastructure.Persistence;
using CookingSharp.Infrastructure.Persistence.Repositories;
using CookingSharp.Infrastructure.Reporting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CookingSharp.Infrastructure;

/// <summary>
/// Clase de extensión para registrar los servicios de la capa de infraestructura.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Registra todos los servicios de infraestructura en el contenedor de inyección de dependencias.
    /// </summary>
    /// <param name="services">Colección de servicios.</param>
    /// <param name="configuration">Configuración de la aplicación.</param>
    /// <returns>La colección de servicios para permitir encadenamiento.</returns>
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CookingSharpDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                sqlServerOptions => sqlServerOptions.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IPasswordHasher, PasswordHasher>();
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
        services.Configure<CloudinarySettings>(configuration.GetSection("CloudinarySettings"));
        services.AddScoped<IPhotoService, PhotoService>();
        services.AddScoped<IPdfReportGenerator, PdfReportGenerator>();

        return services;
    }
}