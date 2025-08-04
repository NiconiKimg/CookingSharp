using CookingSharp.DTOs;
using System.Net;
using System.Net.Http.Json;

namespace CookingSharp.API.Clients
{
    public class UserApiClient
    {
        private readonly HttpClient _httpClient;

        public UserApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private const string UsersEndpoint = "users";


        public async Task<UserDTO?> GetAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<UserDTO>($"{UsersEndpoint}/{id}");
        }

        public async Task<IEnumerable<UserResponseDTO>?> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<UserResponseDTO>>(UsersEndpoint);
        }

        public async Task<UserDTO?> AddAsync(UserDTO dto)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(UsersEndpoint, dto);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<UserDTO>();
            }
            return null;
        }

        public async Task UpdateAsync(UserResponseDTO dto)
        {
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"{UsersEndpoint}/{dto.Id}", dto);

            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new Exception($"El usuario con ID {dto.Id} no fue encontrado. Probablemente fue eliminado por otro usuario.");
                }

                throw new Exception($"Error al actualizar el usuario. El servidor respondió con el código: {response.StatusCode}");
            }


        }
        public async Task<bool> DeleteAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"{UsersEndpoint}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}