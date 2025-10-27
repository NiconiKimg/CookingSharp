using CookingSharp.Application.Services;
using CookingSharp.Application.Services.Contracts;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CookingSharp.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Registro de AutoMapper
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        // Registro de FluentValidation
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        // Registro de los Servicios de Aplicación
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


        return services;
    }
}