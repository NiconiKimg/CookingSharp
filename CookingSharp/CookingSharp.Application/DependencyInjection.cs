using CookingSharp.Application.Services;
using CookingSharp.Application.Services.Contracts;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CookingSharp.Application;

/// <summary>
/// Clase de extensión para registrar los servicios de la capa de aplicación.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Registra todos los servicios de la capa de aplicación en el contenedor de inyección de dependencias.
    /// </summary>
    /// <param name="services">Colección de servicios.</param>
    /// <returns>La colección de servicios para permitir encadenamiento.</returns>
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IRecipeService, RecipeService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<ICommentService, CommentService>();
        services.AddScoped<IRatingService, RatingService>();
        services.AddScoped<IMenuService, MenuService>();
        services.AddScoped<IAppealService, AppealService>();
        services.AddScoped<IDashboardService, DashboardService>();
        services.AddScoped<IMenuRatingService, MenuRatingService>();
        services.AddScoped<IReportService, ReportService>();


        return services;
    }
}