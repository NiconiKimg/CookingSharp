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
        /// </summary>
        public async Task<UserResponseDTO?> CreateAsync(UserCreateDTO dto)
        {
            var response = await _httpClient.PostAsJsonAsync($"{AuthEndpoint}/register", dto);
            return response.IsSuccessStatusCode
                ? await response.Content.ReadFromJsonAsync<UserResponseDTO>()
                : null;
        }

        /// <summary>
        /// Obtiene una lista de todos los usuarios.
        /// </summary>
        public async Task<IEnumerable<UserResponseDTO>?> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<UserResponseDTO>>(UserEndpoint);
        }

        /// <summary>
        /// Obtiene un usuario por su ID.
        /// </summary>
        public async Task<UserResponseDTO?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<UserResponseDTO>($"{UserEndpoint}/{id}");
        }

        /// <summary>
        /// Obtiene el número total de usuarios registrados.
        /// </summary>
        public async Task<int> GetCountAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<int>($"{UserEndpoint}/count");
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Actualiza el perfil de un usuario.
        /// </summary>
        public async Task<bool> UpdateAsync(int id, UserUpdateDTO dto)
        {
            var response = await _httpClient.PutAsJsonAsync($"{UserEndpoint}/{id}", dto);
            return response.IsSuccessStatusCode;
        }

        /// <summary>
        /// Elimina un usuario.
        /// </summary>
        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{UserEndpoint}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}