using CookingSharp.DTOs;
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


        public async Task<UserDTO?> GetAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<UserDTO>($"api/users/{id}");
        }

        public async Task<IEnumerable<UserDTO>?> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<UserDTO>>("api/users");
        }

        public async Task<UserDTO?> AddAsync(UserDTO dto)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/users", dto);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<UserDTO>();
            }
            return null;
        }

        public async Task<bool> UpdateAsync(UserDTO dto)
        {
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"api/users/{dto.Id}", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"api/users/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}