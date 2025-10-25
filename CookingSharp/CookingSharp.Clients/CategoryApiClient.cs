using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookingSharp.Clients;

public class CategoryApiClient
{
    private readonly HttpClient _httpClient;
    private const string Endpoint = "api/categories";

    public CategoryApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<CategoryResponseDTO>?> GetAllAsync()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<CategoryResponseDTO>>(Endpoint);
    }

    public async Task<CategoryResponseDTO?> GetByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<CategoryResponseDTO>($"{Endpoint}/{id}");
    }

    public async Task<CategoryResponseDTO?> CreateAsync(CategoryCreateUpdateDTO dto)
    {
        var response = await _httpClient.PostAsJsonAsync(Endpoint, dto);
        return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<CategoryResponseDTO>() : null;
    }

    public async Task<bool> UpdateAsync(int id, CategoryCreateUpdateDTO dto)
    {
        var response = await _httpClient.PutAsJsonAsync($"{Endpoint}/{id}", dto);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var response = await _httpClient.DeleteAsync($"{Endpoint}/{id}");
        return response.IsSuccessStatusCode;
    }
}