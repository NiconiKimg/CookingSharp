using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace CookingSharp.Clients;

/// <summary>
/// Delegating handler que intercepta cada petición HTTP saliente y añade
/// el token JWT de autenticación si está disponible.
/// </summary>
public class AuthenticationHandler : DelegatingHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        // SessionManager es una clase estática simple para almacenar el token después del login.
        if (!string.IsNullOrEmpty(SessionManager.JwtToken))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.JwtToken);
        }

        return base.SendAsync(request, cancellationToken);
    }
}

/// <summary>
/// Clase estática simple para gestionar el estado de la sesión del cliente.
/// </summary>
public static class SessionManager
{
    public static string? JwtToken { get; set; }
}