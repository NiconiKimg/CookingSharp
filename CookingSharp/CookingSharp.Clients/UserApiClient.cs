using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookingSharp.Clients;

public class UserApiClient
{
    private readonly HttpClient _httpClient;
    private const string Endpoint = "api/users";

    public UserApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<UserResponseDTO>?> GetAllAsync()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<UserResponseDTO>>(Endpoint);
    }

    public async Task<UserResponseDTO?> GetByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<UserResponseDTO>($"{Endpoint}/{id}");
    }

    public async Task<bool> UpdateAsync(int id, UserUpdateDTO dto)
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