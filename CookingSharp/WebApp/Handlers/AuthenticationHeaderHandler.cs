using Microsoft.AspNetCore.Components;
using System.Net;
using System.Net.Http.Headers;
using WebApp.Auth;
using WebApp.Services;

namespace WebApp.Handlers
{
    public class AuthenticationHeaderHandler : DelegatingHandler
    {
        private readonly IServiceProvider _serviceProvider;

        public AuthenticationHeaderHandler(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var localStorage = scope.ServiceProvider.GetRequiredService<ILocalStorageService>();

                if (request.Headers.Authorization == null)
                {
                    var token = await localStorage.GetItemAsync<string>("authToken");
                    if (!string.IsNullOrWhiteSpace(token))
                    {
                        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    }
                }
            }

            var response = await base.SendAsync(request, cancellationToken);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var authStateProvider = scope.ServiceProvider.GetRequiredService<CustomAuthStateProvider>();
                    var navigationManager = scope.ServiceProvider.GetRequiredService<NavigationManager>();

                    await authStateProvider.MarkUserAsLoggedOut();
                    navigationManager.NavigateTo("/login");
                }
            }

            return response;
        }
    }
}