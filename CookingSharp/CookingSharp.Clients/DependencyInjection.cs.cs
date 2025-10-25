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
        // Registra el AuthenticationHandler que añadirá el token JWT a las peticiones.
        services.AddTransient<AuthenticationHandler>();

        // Función auxiliar para configurar las propiedades base de cada HttpClient.
        Action<HttpClient> configureClient = client =>
        {
            client.BaseAddress = new Uri(baseAddress);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        };

        // Función auxiliar para configurar el manejador de mensajes.
        // Esto es necesario en desarrollo si usas un certificado SSL autofirmado.
        Func<HttpMessageHandler> configureHandler = () => new HttpClientHandler
        {
            // Esto permite el uso de certificados SSL no válidos.
            // Solo debe usarse en entornos de desarrollo.
            // En producción, la API debe tener un certificado SSL válido y esta línea debe ser eliminada.
            ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
        };

        // El AuthApiClient no necesita el AuthenticationHandler porque su propósito es obtener el token.
        services.AddHttpClient<AuthApiClient>(configureClient)
            .ConfigurePrimaryHttpMessageHandler(configureHandler);

        // El resto de los clientes se encadenan con el AuthenticationHandler para enviar el token.
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

        return services;
    }
}