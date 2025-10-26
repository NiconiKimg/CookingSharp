using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookingSharp.Clients;

public class RecipeApiClient
{
    private readonly HttpClient _httpClient;
    private const string Endpoint = "api/recipes";

    public RecipeApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<RecipeResponseDTO>?> GetAllAsync()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<RecipeResponseDTO>>(Endpoint);
    }

    public async Task<RecipeResponseDTO?> GetByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<RecipeResponseDTO>($"{Endpoint}/{id}");
    }

    public async Task<RecipeResponseDTO?> CreateAsync(RecipeCreateDTO dto)
    {
        var response = await _httpClient.PostAsJsonAsync(Endpoint, dto);
        return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<RecipeResponseDTO>() : null;
    }

    public async Task<bool> UpdateAsync(int id, RecipeUpdateDTO dto)
    {
        var response = await _httpClient.PutAsJsonAsync($"{Endpoint}/{id}", dto);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateStatusAsync(int id, RecipeStatusUpdateDTO dto)
    {
        var response = await _httpClient.PatchAsJsonAsync($"{Endpoint}/{id}/status", dto);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var response = await _httpClient.DeleteAsync($"{Endpoint}/{id}");
        return response.IsSuccessStatusCode;
    }

    /// <summary>
    /// Obtiene el número total de recetas.
    /// </summary>
    public async Task<int> GetCountAsync()
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<int>($"{Endpoint}/count");
        }
        catch
        {
            return 0;
        }
    }
}