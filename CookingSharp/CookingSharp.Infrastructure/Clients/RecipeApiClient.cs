using CookingSharp.Application.DTOs;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CookingSharp.Infrastructure.Clients
{
    public class RecipeApiClient
    {
        private readonly HttpClient _httpClient;
        private const string RecipesEndpoint = "recipes";

        public RecipeApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ResponseRecipeDTO>?> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<ResponseRecipeDTO>>(RecipesEndpoint);
        }

        public async Task<ResponseRecipeDTO?> GetAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<ResponseRecipeDTO>($"{RecipesEndpoint}/{id}");
        }

        public async Task<ResponseRecipeDTO?> AddAsync(CreateRecipeDTO dto)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(RecipesEndpoint, dto);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ResponseRecipeDTO>();
            }
            return null;
        }

        public async Task<bool> UpdateAsync(int id, UpdateRecipeDTO dto)
        {
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"{RecipesEndpoint}/{id}", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"{RecipesEndpoint}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}