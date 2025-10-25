using CookingSharp.Application.DTOs;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookingSharp.Clients;

public class AuthApiClient
{
    private readonly HttpClient _httpClient;

    public AuthApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<LoginResponseDTO?> LoginAsync(UserLoginDTO loginDto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/auth/login", loginDto);

        if (response.IsSuccessStatusCode)
        {
            var loginResponse = await response.Content.ReadFromJsonAsync<LoginResponseDTO>();
            // Guardamos el token en nuestra clase estática para que el AuthenticationHandler lo use.
            SessionManager.JwtToken = loginResponse?.Token;
            return loginResponse;
        }

        // Si las credenciales son incorrectas, la API devolverá un 400 Bad Request.
        // Podríamos manejar el error aquí de forma más explícita...
        return null;
    }
}