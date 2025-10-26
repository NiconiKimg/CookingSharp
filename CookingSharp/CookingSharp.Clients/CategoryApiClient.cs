using CookingSharp.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookingSharp.Clients;

/// <summary>
/// Cliente para interactuar con el endpoint de categorías de la API.
/// </summary>
public class CategoryApiClient
{
    private readonly HttpClient _httpClient;
    private const string Endpoint = "api/categories";

    /// <summary>
    /// Constructor del cliente de API de categorías.
    /// </summary>
    /// <param name="httpClient">Instancia de HttpClient para realizar las peticiones.</param>
    public CategoryApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <summary>
    /// Obtiene todas las categorías, opcionalmente filtradas por un término de búsqueda.
    /// </summary>
    /// <param name="searchTerm">El término a buscar en los nombres de las categorías.</param>
    /// <returns>Una colección de DTOs de categorías.</returns>
    public async Task<IEnumerable<CategoryResponseDTO>?> GetAllAsync(string? searchTerm = null)
    {
        string requestUri = Endpoint;
        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            requestUri += $"?search={Uri.EscapeDataString(searchTerm)}";
        }
        return await _httpClient.GetFromJsonAsync<IEnumerable<CategoryResponseDTO>>(requestUri);
    }

    /// <summary>
    /// Obtiene una categoría por su ID.
    /// </summary>
    /// <param name="id">El ID de la categoría.</param>
    /// <returns>El DTO de la categoría encontrada.</returns>
    public async Task<CategoryResponseDTO?> GetByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<CategoryResponseDTO>($"{Endpoint}/{id}");
    }

    /// <summary>
    /// Crea una nueva categoría.
    /// </summary>
    /// <param name="dto">DTO con los datos de la nueva categoría.</param>
    /// <returns>El DTO de la categoría creada.</returns>
    public async Task<CategoryResponseDTO?> CreateAsync(CategoryCreateUpdateDTO dto)
    {
        var response = await _httpClient.PostAsJsonAsync(Endpoint, dto);
        return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<CategoryResponseDTO>() : null;
    }

    /// <summary>
    /// Actualiza una categoría existente.
    /// </summary>
    /// <param name="id">ID de la categoría a actualizar.</param>
    /// <param name="dto">DTO con los nuevos datos.</param>
    /// <returns>Verdadero si la actualización fue exitosa.</returns>
    public async Task<bool> UpdateAsync(int id, CategoryCreateUpdateDTO dto)
    {
        var response = await _httpClient.PutAsJsonAsync($"{Endpoint}/{id}", dto);
        return response.IsSuccessStatusCode;
    }

    /// <summary>
    /// Elimina una categoría.
    /// </summary>
    /// <param name="id">ID de la categoría a eliminar.</param>
    /// <returns>Verdadero si la eliminación fue exitosa.</returns>
    public async Task<bool> DeleteAsync(int id)
    {
        var response = await _httpClient.DeleteAsync($"{Endpoint}/{id}");
        return response.IsSuccessStatusCode;
    }

    /// <summary>
    /// Obtiene el conteo total de categorías.
    /// </summary>
    /// <returns>El número total de categorías.</returns>
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