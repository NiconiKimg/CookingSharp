using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;
using WebApp.Services;

namespace WebApp.Auth
{
    /// <summary>
    /// Proveedor de estado de autenticación personalizado para la aplicación Blazor WebAssembly.
    /// </summary>
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly UserStateService _userStateService;
        private readonly ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());

        public CustomAuthStateProvider(HttpClient httpClient, ILocalStorageService localStorage, UserStateService userStateService)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
            _userStateService = userStateService;
        }

        /// <summary>
        /// Obtiene el estado de autenticación actual del usuario.
        /// </summary>
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await _localStorage.GetItemAsync<string>("authToken");

            if (string.IsNullOrWhiteSpace(token))
            {
                _userStateService.SetUser(_anonymous);
                return new AuthenticationState(_anonymous);
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);

            var claims = ParseClaimsFromJwt(token);

            var identity = new ClaimsIdentity(claims, "jwt", ClaimTypes.Name, ClaimTypes.Role);

            var user = new ClaimsPrincipal(identity);

            _userStateService.SetUser(user);

            return new AuthenticationState(user);
        }

        /// <summary>
        /// Marca al usuario como autenticado y almacena el token.
        /// </summary>
        public async Task MarkUserAsAuthenticated(string token)
        {
            var claims = ParseClaimsFromJwt(token);

            var identity = new ClaimsIdentity(claims, "jwt", ClaimTypes.Name, ClaimTypes.Role);

            var user = new ClaimsPrincipal(identity);

            await _localStorage.SetItemAsync("authToken", token);

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);

            _userStateService.SetUser(user);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        /// <summary>
        /// Marca al usuario como desconectado y elimina el token.
        /// </summary>
        public async Task MarkUserAsLoggedOut()
        {
            await _localStorage.RemoveItemAsync("authToken");
            _httpClient.DefaultRequestHeaders.Authorization = null;
            _userStateService.SetUser(_anonymous);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(_anonymous)));
        }

        /// <summary>
        /// Analiza y extrae los claims del token JWT.
        /// </summary>
        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(jsonBytes);

            if (keyValuePairs != null)
            {
                if (keyValuePairs.TryGetValue(ClaimTypes.Role, out var roleElement) ||
                    keyValuePairs.TryGetValue("role", out roleElement))
                {
                    if (roleElement.ValueKind == JsonValueKind.String)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, roleElement.GetString() ?? ""));
                    }
                    else if (roleElement.ValueKind == JsonValueKind.Array)
                    {
                        foreach (var role in roleElement.EnumerateArray())
                        {
                            claims.Add(new Claim(ClaimTypes.Role, role.GetString() ?? ""));
                        }
                    }
                }

                if (keyValuePairs.TryGetValue(ClaimTypes.NameIdentifier, out var subElement) ||
                    keyValuePairs.TryGetValue("sub", out subElement))
                {
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, subElement.GetString() ?? ""));
                }

                if (keyValuePairs.TryGetValue(ClaimTypes.Email, out var emailElement) ||
                    keyValuePairs.TryGetValue("email", out emailElement))
                {
                    claims.Add(new Claim(ClaimTypes.Email, emailElement.GetString() ?? ""));
                }

                if (keyValuePairs.TryGetValue(ClaimTypes.Name, out var nameElement) ||
                    keyValuePairs.TryGetValue("unique_name", out nameElement))
                {
                    claims.Add(new Claim(ClaimTypes.Name, nameElement.GetString() ?? ""));
                }

                if (keyValuePairs.TryGetValue(ClaimTypes.GivenName, out var givenNameElement) ||
                    keyValuePairs.TryGetValue("given_name", out givenNameElement))
                {
                    claims.Add(new Claim(ClaimTypes.GivenName, givenNameElement.GetString() ?? ""));
                }

                if (keyValuePairs.TryGetValue(ClaimTypes.Surname, out var surnameElement) ||
                    keyValuePairs.TryGetValue("family_name", out surnameElement))
                {
                    claims.Add(new Claim(ClaimTypes.Surname, surnameElement.GetString() ?? ""));
                }
            }
            return claims;
        }

        /// <summary>
        /// Convierte una cadena Base64 sin padding a un array de bytes.
        /// </summary>
        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }
    }
}