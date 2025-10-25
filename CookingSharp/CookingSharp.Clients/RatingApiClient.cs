using CookingSharp.Application.DTOs;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookingSharp.Clients;

public class RatingApiClient
{
    private readonly HttpClient _httpClient;

    public RatingApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<bool> RateRecipeAsync(int recipeId, RatingCreateUpdateDTO dto)
    {
        var response = await _httpClient.PostAsJsonAsync($"api/recipes/{recipeId}/ratings", dto);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> RemoveRatingAsync(int recipeId)
    {
        var response = await _httpClient.DeleteAsync($"api/recipes/{recipeId}/ratings");
        return response.IsSuccessStatusCode;
    }
}