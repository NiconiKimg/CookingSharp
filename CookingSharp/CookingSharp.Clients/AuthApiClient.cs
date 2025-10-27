using CookingSharp.Application.DTOs;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookingSharp.Clients;

/// <summary>
/// Cliente para interactuar con los endpoints de autenticación de la API.
/// </summary>
public class AuthApiClient
{
    private readonly HttpClient _httpClient;

    public AuthApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <summary>
    /// Inicia sesión con las credenciales proporcionadas.
    /// </summary>
    /// <param name="loginDto">DTO con las credenciales de inicio de sesión.</param>
    /// <returns>El DTO de respuesta con el token JWT, o null si falla.</returns>
    public async Task<LoginResponseDTO?> LoginAsync(UserLoginDTO loginDto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/auth/login", loginDto);

        if (response.IsSuccessStatusCode)
        {
            var loginResponse = await response.Content.ReadFromJsonAsync<LoginResponseDTO>();
            SessionManager.JwtToken = loginResponse?.Token;
            return loginResponse;
        }

        return null;
    }
}