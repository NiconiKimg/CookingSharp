using System.Net.Http;
using System.Threading.Tasks;

namespace CookingSharp.Clients
{
    /// <summary>
    /// Cliente para interactuar con el endpoint de reportes de la API.
    /// </summary>
    public class ReportApiClient
    {
        private readonly HttpClient _httpClient;
        private const string Endpoint = "api/reports";

        public ReportApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Obtiene el reporte de popularidad de recetas como un array de bytes.
        /// </summary>
        /// <returns>El archivo PDF como byte[], o null si ocurre un error o no hay contenido.</returns>
        public async Task<byte[]?> GetPopularityReportAsync()
        {
            var response = await _httpClient.GetAsync($"{Endpoint}/popularity/recipes");
            return await HandleResponse(response);
        }

        /// <summary>
        /// Obtiene el reporte de contribución de chefs como un array de bytes.
        /// </summary>
        /// <returns>El archivo PDF como byte[], o null si ocurre un error o no hay contenido.</returns>
        public async Task<byte[]?> GetChefContributionReportAsync()
        {
            var response = await _httpClient.GetAsync($"{Endpoint}/contribution/chefs");
            return await HandleResponse(response);
        }

        private async Task<byte[]?> HandleResponse(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return null; // No hay datos
                }
                return await response.Content.ReadAsByteArrayAsync();
            }
            return null; // Error
        }
    }
}