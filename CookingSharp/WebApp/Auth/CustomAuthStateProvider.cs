using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;
using WebApp.Services;

namespace WebApp.Auth
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());

        public CustomAuthStateProvider(HttpClient httpClient, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await _localStorage.GetItemAsync<string>("authToken");

            if (string.IsNullOrWhiteSpace(token))
            {
                return new AuthenticationState(_anonymous);
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);

            var claims = ParseClaimsFromJwt(token);
            var identity = new ClaimsIdentity(claims, "jwt");
            var user = new ClaimsPrincipal(identity);

            return new AuthenticationState(user);
        }

        public async Task MarkUserAsAuthenticated(string token)
        {
            var claims = ParseClaimsFromJwt(token);
            var identity = new ClaimsIdentity(claims, "jwt");
            var user = new ClaimsPrincipal(identity);

            await _localStorage.SetItemAsync("authToken", token);

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public async Task MarkUserAsLoggedOut()
        {
            await _localStorage.RemoveItemAsync("authToken");

            _httpClient.DefaultRequestHeaders.Authorization = null;
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(_anonymous)));
        }

        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);

            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(jsonBytes);

            if (keyValuePairs != null)
            {
                if (keyValuePairs.TryGetValue("role", out var rolesElement)
                    || keyValuePairs.TryGetValue("roles", out rolesElement)
                    || keyValuePairs.TryGetValue("http://schemas.microsoft.com/ws/2008/06/identity/claims/role", out rolesElement))
                {
                    if (rolesElement.ValueKind == JsonValueKind.Array)
                    {
                        foreach (var role in rolesElement.EnumerateArray())
                        {
                            var roleValue = role.ValueKind == JsonValueKind.String ? role.GetString() : role.ToString();
                            if (!string.IsNullOrEmpty(roleValue))
                                claims.Add(new Claim(ClaimTypes.Role, roleValue));
                        }
                    }
                    else if (rolesElement.ValueKind == JsonValueKind.String)
                    {
                        var roleValue = rolesElement.GetString();
                        if (!string.IsNullOrEmpty(roleValue))
                            claims.Add(new Claim(ClaimTypes.Role, roleValue));
                    }
                }

                var claimMappings = new Dictionary<string, string>
                {
                    { "sub", ClaimTypes.NameIdentifier },
                    { "email", ClaimTypes.Email },
                    { "unique_name", ClaimTypes.Name }
                };

                foreach (var kvp in keyValuePairs)
                {
                    if (claimMappings.ContainsKey(kvp.Key))
                    {
                        string value = kvp.Value.ValueKind == JsonValueKind.String ? kvp.Value.GetString() : kvp.Value.ToString();
                        if (!string.IsNullOrEmpty(value))
                            claims.Add(new Claim(claimMappings[kvp.Key], value));
                    }
                }
            }
            return claims;
        }

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