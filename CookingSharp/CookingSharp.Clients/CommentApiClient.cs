using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookingSharp.Clients;

public class CommentApiClient
{
    private readonly HttpClient _httpClient;

    public CommentApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<CommentResponseDTO>?> GetCommentsForRecipeAsync(int recipeId)
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<CommentResponseDTO>>($"api/recipes/{recipeId}/comments");
    }

    public async Task<CommentResponseDTO?> AddCommentAsync(int recipeId, CommentCreateDTO dto)
    {
        var response = await _httpClient.PostAsJsonAsync($"api/recipes/{recipeId}/comments", dto);
        return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<CommentResponseDTO>() : null;
    }

    public async Task<bool> UpdateCommentAsync(int recipeId, int commentId, CommentUpdateDTO dto)
    {
        var response = await _httpClient.PutAsJsonAsync($"api/recipes/{recipeId}/comments/{commentId}", dto);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteCommentAsync(int recipeId, int commentId)
    {
        var response = await _httpClient.DeleteAsync($"api/recipes/{recipeId}/comments/{commentId}");
        return response.IsSuccessStatusCode;
    }
}