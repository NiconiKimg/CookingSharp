using CookingSharp.Application.DTOs;
using System.Net.Http.Json;
using System.Web;
using System.Text.Json;

namespace CookingSharp.Clients;

/// <summary>
/// Cliente para interactuar con el endpoint de recetas de la API.
/// </summary>
public class RecipeApiClient
{
    private readonly HttpClient _httpClient;
    private const string Endpoint = "api/recipes";

    /// <summary>
    /// Constructor del cliente de API de recetas.
    /// </summary>
    /// <param name="httpClient">Instancia de HttpClient.</param>
    public RecipeApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <summary>
    /// Obtiene todas las recetas, opcionalmente filtradas.
    /// </summary>
    /// <param name="searchTerm">Término de búsqueda opcional.</param>
    /// <param name="categoryId">ID de categoría opcional.</param>
    /// <returns>Una colección de DTOs de recetas.</returns>
    public async Task<IEnumerable<RecipeResponseDTO>?> GetAllAsync(string? searchTerm = null, int? categoryId = null)
    {
        var query = HttpUtility.ParseQueryString(string.Empty);
        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            query["search"] = searchTerm;
        }
        if (categoryId.HasValue && categoryId > 0)
        {
            query["categoryId"] = categoryId.ToString();
        }

        string requestUri = Endpoint;
        if (query.Count > 0)
        {
            requestUri += $"?{query}";
        }

        return await _httpClient.GetFromJsonAsync<IEnumerable<RecipeResponseDTO>>(requestUri);
    }

    /// <summary>
    /// Obtiene una receta por su ID.
    /// </summary>
    /// <param name="id">El ID de la receta.</param>
    /// <returns>El DTO de la receta.</returns>
    public async Task<RecipeResponseDTO?> GetByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<RecipeResponseDTO>($"{Endpoint}/{id}");
    }

    /// <summary>
    /// Crea una nueva receta.
    /// </summary>
    /// <param name="dto">DTO con los datos de la receta.</param>
    /// <returns>El DTO de la receta creada.</returns>
    public async Task<RecipeResponseDTO?> CreateAsync(RecipeCreateDTO dto)
    {
        var response = await _httpClient.PostAsJsonAsync(Endpoint, dto);
        return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<RecipeResponseDTO>() : null;
    }

    /// <summary>
    /// Actualiza una receta existente.
    /// </summary>
    /// <param name="id">ID de la receta a actualizar.</param>
    /// <param name="dto">DTO con los nuevos datos.</param>
    /// <returns>Verdadero si la actualización fue exitosa.</returns>
    /// <summary>
    /// Actualiza una receta existente.
    /// </summary>
    /// <param name="id">ID de la receta a actualizar.</param>
    /// <param name="dto">DTO con los nuevos datos.</param>
    /// <returns>Lanza una excepción si la actualización falla.</returns>
    public async Task UpdateAsync(int id, RecipeUpdateDTO dto)
    {
        using var content = new MultipartFormDataContent();

        content.Add(new StringContent(dto.Name), "Name");
        content.Add(new StringContent(dto.Description), "Description");

        foreach (var categoryId in dto.CategoryIds)
        {
            content.Add(new StringContent(categoryId.ToString()), "CategoryIds");
        }

        for (int i = 0; i < dto.Steps.Count; i++)
        {
            content.Add(new StringContent(dto.Steps.ElementAt(i).Instruction), $"Steps[{i}].Instruction");
        }

        var response = await _httpClient.PutAsync($"{Endpoint}/{id}", content);

        if (!response.IsSuccessStatusCode)
        {
            var errorResponse = await response.Content.ReadAsStringAsync();
            string errorMessage = "La API devolvió un error inesperado.";

            try
            {
                var jsonError = JsonDocument.Parse(errorResponse);
                if (jsonError.RootElement.TryGetProperty("error", out var errorProp))
                {
                    errorMessage = errorProp.GetString() ?? errorMessage;
                }
            }
            catch
            {
                if (!string.IsNullOrWhiteSpace(errorResponse))
                {
                    errorMessage = errorResponse;
                }
            }

            throw new Exception(errorMessage);
        }
    }

    /// <summary>
    /// Actualiza el estado de una receta.
    /// </summary>
    /// <param name="id">ID de la receta a actualizar.</param>
    /// <param name="dto">DTO con el nuevo estado.</param>
    /// <returns>Verdadero si la actualización fue exitosa.</returns>
    public async Task<bool> UpdateStatusAsync(int id, RecipeStatusUpdateDTO dto)
    {
        var response = await _httpClient.PatchAsJsonAsync($"{Endpoint}/{id}/status", dto);
        return response.IsSuccessStatusCode;
    }

    /// <summary>
    /// Elimina una receta.
    /// </summary>
    /// <param name="id">ID de la receta a eliminar.</param>
    /// <returns>Verdadero si la eliminación fue exitosa.</returns>
    public async Task<bool> DeleteAsync(int id)
    {
        var response = await _httpClient.DeleteAsync($"{Endpoint}/{id}");
        return response.IsSuccessStatusCode;
    }

    /// <summary>
    /// Obtiene el número total de recetas.
    /// </summary>
    /// <returns>El número total de recetas.</returns>
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

    /// <summary>
    /// Obtiene las recetas completas (con pasos) del usuario autenticado.
    /// </summary>
    /// <returns>Una colección de DTOs de recetas completos.</returns>
    public async Task<IEnumerable<RecipeResponseDTO>?> GetMyFullRecipesAsync()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<RecipeResponseDTO>>($"{Endpoint}/my-full-recipes");
    }

    /// <summary>
    /// Obtiene un resumen de las recetas públicas, opcionalmente filtradas.
    /// </summary>
    /// <param name="searchTerm">Término de búsqueda opcional.</param>
    /// <param name="categoryId">ID de categoría opcional.</param>
    /// <returns>Una colección de DTOs de resumen de receta.</returns>
    public async Task<IEnumerable<RecipeSummaryDTO>?> GetAllSummariesAsync(string? searchTerm = null, int? categoryId = null)
    {
        var query = HttpUtility.ParseQueryString(string.Empty);
        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            query["search"] = searchTerm;
        }
        if (categoryId.HasValue && categoryId > 0)
        {
            query["categoryId"] = categoryId.ToString();
        }

        string requestUri = $"{Endpoint}/summaries";
        if (query.Count > 0)
        {
            requestUri += $"?{query}";
        }

        return await _httpClient.GetFromJsonAsync<IEnumerable<RecipeSummaryDTO>>(requestUri);
    }
}