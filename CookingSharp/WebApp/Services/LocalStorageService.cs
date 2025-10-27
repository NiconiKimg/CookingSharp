using Microsoft.JSInterop;
using System.Text.Json;

namespace WebApp.Services
{
    /// <summary>
    /// Servicio para interactuar con el almacenamiento local del navegador.
    /// </summary>
    public class LocalStorageService : ILocalStorageService
    {
        private readonly IJSRuntime _jsRuntime;

        public LocalStorageService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        /// <summary>
        /// Obtiene un elemento del almacenamiento local.
        /// </summary>
        public async Task<T> GetItemAsync<T>(string key)
        {
            var json = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", key);
            if (string.IsNullOrEmpty(json))
                return default;

            return JsonSerializer.Deserialize<T>(json);
        }

        /// <summary>
        /// Establece un elemento en el almacenamiento local.
        /// </summary>
        public async Task SetItemAsync<T>(string key, T value)
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", key, JsonSerializer.Serialize(value));
        }

        /// <summary>
        /// Elimina un elemento del almacenamiento local.
        /// </summary>
        public async Task RemoveItemAsync(string key)
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", key);
        }
    }
}