using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookingSharp.Clients;

/// <summary>
/// Cliente para interactuar con el endpoint de menús de la API.
/// </summary>
public class MenuApiClient
{
    private readonly HttpClient _httpClient;
    private const string Endpoint = "api/menus";

    public MenuApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <summary>
    /// Obtiene todos los menús creados por el usuario autenticado.
    /// </summary>
    public async Task<IEnumerable<MenuResponseDTO>?> GetMyMenusAsync()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<MenuResponseDTO>>($"{Endpoint}/my-menus");
    }

    /// <summary>
    /// Obtiene un menú por su ID.
    /// </summary>
    public async Task<MenuResponseDTO?> GetByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<MenuResponseDTO>($"{Endpoint}/{id}");
    }

    /// <summary>
    /// Crea un nuevo menú.
    /// </summary>
    public async Task<MenuResponseDTO?> CreateAsync(MenuCreateUpdateDTO dto)
    {
        var response = await _httpClient.PostAsJsonAsync(Endpoint, dto);
        return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<MenuResponseDTO>() : null;
    }

    /// <summary>
    /// Actualiza un menú existente.
    /// </summary>
    public async Task<bool> UpdateAsync(int id, MenuCreateUpdateDTO dto)
    {
        var response = await _httpClient.PutAsJsonAsync($"{Endpoint}/{id}", dto);
        return response.IsSuccessStatusCode;
    }

    /// <summary>
    /// Elimina un menú.
    /// </summary>
    public async Task<bool> DeleteAsync(int id)
    {
        var response = await _httpClient.DeleteAsync($"{Endpoint}/{id}");
        return response.IsSuccessStatusCode;
    }
}