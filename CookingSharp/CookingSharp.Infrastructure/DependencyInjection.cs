using CookingSharp.Application.Contracts;
using CookingSharp.Application.Contracts.Infrastructure;
using CookingSharp.Infrastructure.Auth;
using CookingSharp.Infrastructure.Persistence;
using CookingSharp.Infrastructure.Persistence.Repositories;
using CookingSharp.Infrastructure.Reporting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CookingSharp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Configuración del DbContext
        services.AddDbContext<CookingSharpDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // Registro del Unit of Work y Repositorios
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        // Registro de Servicios de Infraestructura
        services.AddScoped<IPasswordHasher, PasswordHasher>();
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();

        services.AddScoped<IPdfReportGenerator, PdfReportGenerator>();

        return services;
    }
}