using System.Net.Http.Json;
using CookingSharp.DTOs;

namespace CookingSharp.API.Clients
{
    public class CategoryApiClient
    {
        private readonly HttpClient _httpClient;

        private const string CategoriesEndpoint = "categories";

        public CategoryApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        #region Métodos de la API


        public async Task<IEnumerable<CategoryDTO>?> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<CategoryDTO>>(CategoriesEndpoint);
        }

        public async Task<CategoryDTO?> GetAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<CategoryDTO>($"{CategoriesEndpoint}/{id}");
        }

        public async Task<CategoryDTO?> AddAsync(CategoryDTO dto)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(CategoriesEndpoint, dto);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CategoryDTO>();
            }

            return null;
        }

        public async Task<bool> UpdateAsync(CategoryDTO dto)
        {
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"{CategoriesEndpoint}/{dto.Id}", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"{CategoriesEndpoint}/{id}");
            return response.IsSuccessStatusCode;
        }

        #endregion
    }
}