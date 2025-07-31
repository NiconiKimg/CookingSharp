using CookingSharp.DTOs;
using System.Net.Http.Json;

namespace CookingSharp.API.Clients
{
    public class CategoryApiClient
    {
        private readonly HttpClient _httpClient;

        public CategoryApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<CategoryDTO?> GetAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<CategoryDTO>($"api/categories/{id}");
        }

        public async Task<IEnumerable<CategoryDTO>?> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<CategoryDTO>>("api/categories");
        }

        public async Task<CategoryDTO?> AddAsync(CategoryDTO dto)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/categories", dto);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CategoryDTO>();
            }
            return null;
        }

        public async Task<bool> UpdateAsync(CategoryDTO dto)
        {
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"api/categories/{dto.Id}", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"api/categories/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}