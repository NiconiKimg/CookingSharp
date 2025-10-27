using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookingSharp.Clients;

/// <summary>
/// Cliente para interactuar con el endpoint de solicitudes de la API.
/// </summary>
public class AppealApiClient
{
    private readonly HttpClient _httpClient;
    private const string Endpoint = "api/appeals";

    public AppealApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <summary>
    /// Obtiene todas las solicitudes pendientes de revisión.
    /// </summary>
    public async Task<IEnumerable<AppealResponseDTO>?> GetAllPendingAsync()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<AppealResponseDTO>>($"{Endpoint}/pending");
    }

    /// <summary>
    /// Procesa una solicitud, aprobándola o rechazándola.
    /// </summary>
    public async Task<bool> ProcessAppealAsync(int appealId, AppealUpdateDTO dto)
    {
        var response = await _httpClient.PutAsJsonAsync($"{Endpoint}/{appealId}/process", dto);
        return response.IsSuccessStatusCode;
    }

    /// <summary>
    /// Obtiene todas las solicitudes hechas por el usuario autenticado.
    /// </summary>
    public async Task<IEnumerable<AppealResponseDTO>?> GetMyAppealsAsync()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<AppealResponseDTO>>($"{Endpoint}/my-appeals");
    }

    /// <summary>
    /// Crea una nueva solicitud para convertirse en Chef.
    /// </summary>
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