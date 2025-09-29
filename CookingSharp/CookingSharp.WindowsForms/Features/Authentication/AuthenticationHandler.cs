using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace CookingSharp.WindowsForms
{
    public class AuthenticationHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (!string.IsNullOrEmpty(TokenManager.CurrentToken))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", TokenManager.CurrentToken);
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}