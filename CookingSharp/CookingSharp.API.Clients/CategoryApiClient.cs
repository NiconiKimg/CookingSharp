using CookingSharp.DTOs;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace CookingSharp.API.Clients
{
    public class CategoryApiClient
    {
        private readonly HttpClient _httpClient;

        public CategoryApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<CategoryDTO?> GetAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<CategoryDTO>($"api/categories/{id}");
        }

        public async Task<IEnumerable<CategoryDTO>?> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<CategoryDTO>>("api/categories");
        }

        public async Task<CategoryDTO?> AddAsync(CategoryDTO dto)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/categories", dto);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CategoryDTO>();
            }
            return null;
        }

        public async Task<bool> UpdateAsync(CategoryDTO dto)
        {
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"api/categories/{dto.Id}", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"api/categories/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}




/*namespace CookingSharp.API.Clients
{
    public class CategoryApiClient
    {

        private static HttpClient httpClient = new HttpClient();

        static CategoryApiClient()
        {
            httpClient.BaseAddress = new Uri("http://localhost:5183/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<CategoryDTO> GetAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"categories/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<CategoryDTO>(); //check
                }
                else
                {
                    throw new HttpRequestException($"Error fetching category with ID {id}: {response.ReasonPhrase}");
                };
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"An error occurred while fetching the category: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"The request to fetch the category with ID {id} timed out: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<CategoryDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("categories");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<CategoryDTO>>();
                }
                else
                {
                    throw new HttpRequestException($"Error fetching categories: {response.ReasonPhrase}");
                };
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"An error occurred while fetching the categories: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"The request to fetch categories timed out: {ex.Message}", ex);
            }
        }

        public static async Task<CategoryDTO> AddAsync(CategoryDTO dto) // CHECK -> should be Task<CategoryDTO> or only Task
        {
            try
            {
                HttpResponseMessage response = await httpClient.PostAsJsonAsync("categories", dto);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<CategoryDTO>();
                }
                else
                {
                    throw new HttpRequestException($"Error adding category: {response.ReasonPhrase}");
                }
                ;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"An error occurred while adding the category: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"The request to add the category timed out: {ex.Message}", ex);
            }
        }

        public static async Task<bool> UpdateAsync(CategoryDTO dto) // CHECK -> should be Task<bool> or only Task
        {
            try
            {
                HttpResponseMessage response = await httpClient.PutAsJsonAsync($"categories/{dto.Id}", dto);
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"An error occurred while updating the category: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"The request to update the category timed out: {ex.Message}", ex);
            }
        }

        public static async Task<bool> DeleteAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await httpClient.DeleteAsync($"categories/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"An error occurred while deleting the category: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"The request to delete the category timed out: {ex.Message}", ex);
            }
        }

    }
}
*/