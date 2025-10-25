using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookingSharp.Clients;

public class MenuApiClient
{
    private readonly HttpClient _httpClient;
    private const string Endpoint = "api/menus";

    public MenuApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<MenuResponseDTO>?> GetMyMenusAsync()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<MenuResponseDTO>>($"{Endpoint}/my-menus");
    }

    public async Task<MenuResponseDTO?> GetByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<MenuResponseDTO>($"{Endpoint}/{id}");
    }

    public async Task<MenuResponseDTO?> CreateAsync(MenuCreateUpdateDTO dto)
    {
        var response = await _httpClient.PostAsJsonAsync(Endpoint, dto);
        return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<MenuResponseDTO>() : null;
    }

    public async Task<bool> UpdateAsync(int id, MenuCreateUpdateDTO dto)
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