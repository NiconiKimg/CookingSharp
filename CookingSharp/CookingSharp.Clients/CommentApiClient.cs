using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookingSharp.Clients;

/// <summary>
/// Cliente para interactuar con el endpoint de comentarios de la API.
/// </summary>
public class CommentApiClient
{
    private readonly HttpClient _httpClient;

    public CommentApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <summary>
    /// Obtiene todos los comentarios de una receta específica.
    /// </summary>
    public async Task<IEnumerable<CommentResponseDTO>?> GetCommentsForRecipeAsync(int recipeId)
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<CommentResponseDTO>>($"api/recipes/{recipeId}/comments");
    }

    /// <summary>
    /// Añade un nuevo comentario a una receta.
    /// </summary>
    public async Task<CommentResponseDTO?> AddCommentAsync(int recipeId, CommentCreateDTO dto)
    {
        var response = await _httpClient.PostAsJsonAsync($"api/recipes/{recipeId}/comments", dto);
        return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<CommentResponseDTO>() : null;
    }

    /// <summary>
    /// Actualiza un comentario existente.
    /// </summary>
    public async Task<bool> UpdateCommentAsync(int recipeId, int commentId, CommentUpdateDTO dto)
    {
        var response = await _httpClient.PutAsJsonAsync($"api/recipes/{recipeId}/comments/{commentId}", dto);
        return response.IsSuccessStatusCode;
    }

    /// <summary>
    /// Elimina un comentario.
    /// </summary>
    public async Task<bool> DeleteCommentAsync(int recipeId, int commentId)
    {
        var response = await _httpClient.DeleteAsync($"api/recipes/{recipeId}/comments/{commentId}");
        return response.IsSuccessStatusCode;
    }
}