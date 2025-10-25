using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Text.Json;
using Blazored.LocalStorage;

namespace CookingSharp.BlazorApp.Services
{
    public class AuthService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly HttpClient _httpClient;

        public AuthService(
            ILocalStorageService localStorage,
            AuthenticationStateProvider authStateProvider,
            HttpClient httpClient)
        {
            _localStorage = localStorage;
            _authStateProvider = authStateProvider;
            _httpClient = httpClient;
        }

        public async Task<LoginResult> Login(LoginModel model)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("/api/auth/login", model);

                if (!response.IsSuccessStatusCode)
                {
                    return new LoginResult
                    {
                        Success = false,
                        Message = "Email o contraseña incorrectos"
                    };
                }

                var result = await response.Content.ReadFromJsonAsync<LoginResponse>();

                if (result != null && !string.IsNullOrEmpty(result.Token))
                {
                    await _localStorage.SetItemAsync("authToken", result.Token);
                    await _localStorage.SetItemAsync("userType", result.UserType);
                    await _localStorage.SetItemAsync("userName", result.UserName);

                    ((CustomAuthStateProvider)_authStateProvider).NotifyUserAuthentication(result.Token);

                    _httpClient.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", result.Token);

                    return new LoginResult
                    {
                        Success = true,
                        Message = "Login exitoso"
                    };
                }

                return new LoginResult
                {
                    Success = false,
                    Message = "Error inesperado"
                };
            }
            catch (Exception ex)
            {
                return new LoginResult
                {
                    Success = false,
                    Message = $"Error: {ex.Message}"
                };
            }
        }

        public async Task<RegisterResult> Register(RegisterModel model)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("/api/auth/register", model);

                if (!response.IsSuccessStatusCode)
                {
                    return new RegisterResult
                    {
                        Success = false,
                        Message = "Error en el registro. El email podría estar en uso."
                    };
                }

                return new RegisterResult
                {
                    Success = true,
                    Message = "Registro exitoso"
                };
            }
            catch (Exception ex)
            {
                return new RegisterResult
                {
                    Success = false,
                    Message = $"Error: {ex.Message}"
                };
            }
        }

        public async Task Logout()
        {
            try
            {
                await _localStorage.RemoveItemAsync("authToken");
                await _localStorage.RemoveItemAsync("userType");
                await _localStorage.RemoveItemAsync("userName");

                ((CustomAuthStateProvider)_authStateProvider).NotifyUserLogout();

                _httpClient.DefaultRequestHeaders.Authorization = null;
            }
            catch
            {
                // Ignorar errores de prerender
            }
        }

        public async Task<string?> GetToken()
        {
            try
            {
                return await _localStorage.GetItemAsync<string>("authToken");
            }
            catch
            {
                return null;
            }
        }

        public async Task<string?> GetUserType()
        {
            try
            {
                return await _localStorage.GetItemAsync<string>("userType");
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> IsAuthenticated()
        {
            var token = await GetToken();
            return !string.IsNullOrEmpty(token);
        }
    }

    // ---------------- Custom Authentication State Provider ----------------

    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorage;
        private readonly HttpClient _httpClient;

        public CustomAuthStateProvider(
            ILocalStorageService localStorage,
            HttpClient httpClient)
        {
            _localStorage = localStorage;
            _httpClient = httpClient;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            if (_localStorage is null)
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));

            string token = null;
            try
            {
                token = await _localStorage.GetItemAsync<string>("authToken");
            }
            catch
            {
                // Ignorar errores de prerender
            }

            if (string.IsNullOrEmpty(token))
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));

            var claims = ParseClaimsFromJwt(token);
            var userType = await SafeGetItemAsync("userType");

            if (!string.IsNullOrEmpty(userType))
                claims.Add(new Claim(ClaimTypes.Role, userType));

            var identity = new ClaimsIdentity(claims, "jwt");
            var user = new ClaimsPrincipal(identity);

            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            return new AuthenticationState(user);
        }

        private async Task<string?> SafeGetItemAsync(string key)
        {
            try
            {
                return await _localStorage.GetItemAsync<string>(key);
            }
            catch
            {
                return null;
            }
        }

        public void NotifyUserAuthentication(string token)
        {
            var claims = ParseClaimsFromJwt(token);
            var identity = new ClaimsIdentity(claims, "jwt");
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public void NotifyUserLogout()
        {
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        private List<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            if (keyValuePairs != null)
            {
                keyValuePairs.TryGetValue(ClaimTypes.Role, out var roles);

                if (roles != null)
                {
                    var rolesString = roles.ToString();
                    if (!string.IsNullOrEmpty(rolesString))
                    {
                        if (rolesString.Trim().StartsWith("["))
                        {
                            var parsedRoles = JsonSerializer.Deserialize<string[]>(rolesString);
                            if (parsedRoles != null)
                                claims.AddRange(parsedRoles.Select(r => new Claim(ClaimTypes.Role, r)));
                        }
                        else
                        {
                            claims.Add(new Claim(ClaimTypes.Role, rolesString));
                        }
                    }
                    keyValuePairs.Remove(ClaimTypes.Role);
                }

                foreach (var kvp in keyValuePairs)
                    claims.Add(new Claim(kvp.Key, kvp.Value?.ToString() ?? string.Empty));
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

    // ---------------- Models ----------------

    public class LoginModel
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string UserType { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
        public bool AcceptTerms { get; set; }
    }

    public class LoginResponse
    {
        public string Token { get; set; } = string.Empty;
        public string UserType { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
    }

    public class LoginResult
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
    }

    public class RegisterResult
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
