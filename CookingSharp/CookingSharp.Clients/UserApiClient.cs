using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookingSharp.Clients
{
    public class UserApiClient
    {
        private readonly HttpClient _httpClient;
        private const string UserEndpoint = "api/users";
        private const string AuthEndpoint = "api/auth";

        public UserApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Crea un nuevo usuario llamando al endpoint de registro.
        /// Este método es utilizado por los administradores para crear nuevas cuentas.
        /// </summary>
        /// <param name="dto">El DTO con la información del nuevo usuario.</param>
        /// <returns>El DTO del usuario creado si la operación es exitosa; de lo contrario, null.</returns>
        public async Task<UserResponseDTO?> CreateAsync(UserCreateDTO dto)
        {
            var response = await _httpClient.PostAsJsonAsync($"{AuthEndpoint}/register", dto);
            return response.IsSuccessStatusCode
                ? await response.Content.ReadFromJsonAsync<UserResponseDTO>()
                : null;
        }

        public async Task<IEnumerable<UserResponseDTO>?> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<UserResponseDTO>>(UserEndpoint);
        }

        public async Task<UserResponseDTO?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<UserResponseDTO>($"{UserEndpoint}/{id}");
        }

        public async Task<bool> UpdateAsync(int id, UserUpdateDTO dto)
        {
            var response = await _httpClient.PutAsJsonAsync($"{UserEndpoint}/{id}", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{UserEndpoint}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}