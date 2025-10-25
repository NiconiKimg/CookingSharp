using CookingSharp.Application.DTOs;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookingSharp.Infrastructure.Clients
{
    public class AuthApiClient
    {
        private readonly HttpClient _httpClient;

        public AuthApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserResponseDTO?> RegisterAsync(UserDTO userDto)
        {
            var response = await _httpClient.PostAsJsonAsync("auth/register", userDto);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<UserResponseDTO>();
            }
            return null;
        }

        public async Task<LoginResponseDTO?> LoginAsync(UserLoginDTO loginDto)
        {
            var response = await _httpClient.PostAsJsonAsync("auth/login", loginDto);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<LoginResponseDTO>();
            }

            return null;
        }
    }
}