using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookingSharp.Clients;

public class AppealApiClient
{
    private readonly HttpClient _httpClient;
    private const string Endpoint = "api/appeals";

    public AppealApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<AppealResponseDTO>?> GetAllPendingAsync()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<AppealResponseDTO>>($"{Endpoint}/pending");
    }

    public async Task<bool> ProcessAppealAsync(int appealId, AppealUpdateDTO dto)
    {
        var response = await _httpClient.PutAsJsonAsync($"{Endpoint}/{appealId}/process", dto);
        return response.IsSuccessStatusCode;
    }

    // Métodos para el usuario (aprendiz)
    public async Task<IEnumerable<AppealResponseDTO>?> GetMyAppealsAsync()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<AppealResponseDTO>>($"{Endpoint}/my-appeals");
    }

    public async Task<AppealResponseDTO?> CreateAppealAsync(AppealCreateDTO dto)
    {
        var response = await _httpClient.PostAsJsonAsync(Endpoint, dto);
        return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<AppealResponseDTO>() : null;
    }

    /// <summary>
    /// Obtiene el número de solicitudes pendientes de revisión.
    /// </summary>
    public async Task<int> GetPendingCountAsync()
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<int>($"{Endpoint}/pending/count");
        }
        catch
        {
            return 0;
        }
    }
}