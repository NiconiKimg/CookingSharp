using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CookingSharp.Clients;

/// <summary>
/// Métodos de extensión para registrar los clientes de la API en el contenedor de inyección de dependencias.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Registra todos los ApiClients necesarios para comunicarse con la CookingSharp API.
    /// </summary>
    /// <param name="services">La colección de servicios.</param>
    /// <param name="baseAddress">La URL base de la API (ej. "https://localhost:7111").</param>
    /// <returns>La colección de servicios para encadenamiento.</returns>
    public static IServiceCollection AddApiClients(this IServiceCollection services, string baseAddress)
    {
        services.AddTransient<AuthenticationHandler>();

        Action<HttpClient> configureClient = client =>
        {
            client.BaseAddress = new Uri(baseAddress);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        };

        Func<HttpMessageHandler> configureHandler = () => new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
        };

        services.AddHttpClient<AuthApiClient>(configureClient)
            .ConfigurePrimaryHttpMessageHandler(configureHandler);

        services.AddHttpClient<CategoryApiClient>(configureClient)
            .AddHttpMessageHandler<AuthenticationHandler>()
            .ConfigurePrimaryHttpMessageHandler(configureHandler);

        services.AddHttpClient<UserApiClient>(configureClient)
            .AddHttpMessageHandler<AuthenticationHandler>()
            .ConfigurePrimaryHttpMessageHandler(configureHandler);

        services.AddHttpClient<RecipeApiClient>(configureClient)
            .AddHttpMessageHandler<AuthenticationHandler>()
            .ConfigurePrimaryHttpMessageHandler(configureHandler);

        services.AddHttpClient<AppealApiClient>(configureClient)
            .AddHttpMessageHandler<AuthenticationHandler>()
            .ConfigurePrimaryHttpMessageHandler(configureHandler);

        services.AddHttpClient<CommentApiClient>(configureClient)
            .AddHttpMessageHandler<AuthenticationHandler>()
            .ConfigurePrimaryHttpMessageHandler(configureHandler);

        services.AddHttpClient<RatingApiClient>(configureClient)
            .AddHttpMessageHandler<AuthenticationHandler>()
            .ConfigurePrimaryHttpMessageHandler(configureHandler);

        services.AddHttpClient<MenuApiClient>(configureClient)
            .AddHttpMessageHandler<AuthenticationHandler>()
            .ConfigurePrimaryHttpMessageHandler(configureHandler);

        services.AddHttpClient<ReportApiClient>(configureClient)
            .AddHttpMessageHandler<AuthenticationHandler>()
            .ConfigurePrimaryHttpMessageHandler(configureHandler);

        return services;
    }
}