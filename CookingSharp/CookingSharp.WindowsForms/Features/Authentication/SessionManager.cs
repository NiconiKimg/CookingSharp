using System;
using System.Linq;
using System.Security.Claims;
using static CookingSharp.Domain.User;

namespace CookingSharp.WindowsForms
{
    public static class SessionManager
    {
        public static CurrentUser? CurrentUser { get; private set; }

        public static bool IsLoggedIn => CurrentUser != null;

        public static void StartSession(string jwtToken)
        {
            TokenManager.SetToken(jwtToken);

            var claims = JwtParser.ParseClaimsFromJwt(jwtToken);

            var userIdClaim = claims.FirstOrDefault(c =>
                c.Type == ClaimTypes.NameIdentifier || c.Type == "sub");

            var userEmailClaim = claims.FirstOrDefault(c =>
                c.Type == ClaimTypes.Email || c.Type == "email");

            var userRoleClaim = claims.FirstOrDefault(c =>
                c.Type == ClaimTypes.Role || c.Type == "role" ||
                c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role");

            if (userIdClaim is null || userEmailClaim is null || userRoleClaim is null)
            {
                throw new InvalidOperationException("El token JWT no contiene los claims esperados (ID, Email, Rol).");
            }

            if (!int.TryParse(userIdClaim.Value, out var userId))
            {
                throw new InvalidOperationException("El claim de ID de usuario no es un número válido.");
            }

            var userEmail = userEmailClaim.Value;

            if (!Enum.TryParse<RoleTypes>(userRoleClaim.Value, ignoreCase: true, out var userRole))
            {
                throw new InvalidOperationException($"El claim de rol '{userRoleClaim.Value}' no es válido.");
            }

            CurrentUser = new CurrentUser(userId, userEmail, userRole);
        }

        public static void EndSession()
        {
            TokenManager.ClearToken();
            CurrentUser = null;
        }
    }
}