using CookingSharp.Application.DTOs;
using System.Net;
using System.Net.Http.Json;

namespace CookingSharp.Infrastructure.Clients
{
    public class AppealApiClient
    {
        private readonly HttpClient _httpClient;

        public AppealApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private const string AppealsEndpoint = "appeals";


        public async Task<AppealDTO?> GetAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<AppealDTO>($"{AppealsEndpoint}/{id}");
        }

        public async Task<IEnumerable<AppealDTO>?> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<AppealDTO>>(AppealsEndpoint);
        }

        public async Task<AppealDTO?> AddAsync(AppealDTO dto)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(AppealsEndpoint, dto);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<AppealDTO>();
            }
            return null;
        }

        public async Task UpdateAsync(int id, UpdateAppealDTO dto)
        {
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"{AppealsEndpoint}/{id}", dto);

            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new Exception($"La solicitud con ID: {id} no fue encontrada. Probablemente fue eliminada.");
                }

                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error en la solicitud (Bad Request): {errorContent}");
                }

                throw new Exception($"Error al actualizar la solicitud. El servidor respondió con el código: {response.StatusCode}");
            }
        }
    }
}