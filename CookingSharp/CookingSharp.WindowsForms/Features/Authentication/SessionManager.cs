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

            // Usamos FirstOrDefault y comprobamos si es nulo para evitar excepciones.
            var userIdClaim = claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier || c.Type == "sub");
            var userEmailClaim = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email);
            var userRoleClaim = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role);

            if (userIdClaim is null || userEmailClaim is null || userRoleClaim is null)
            {
                // Si falta algún claim esencial, la sesión no es válida.
                throw new InvalidOperationException("El token JWT no contiene los claims esperados (ID, Email, Rol).");
            }

            var userId = int.Parse(userIdClaim.Value);
            var userEmail = userEmailClaim.Value;
            var userRole = Enum.Parse<RoleTypes>(userRoleClaim.Value);

            CurrentUser = new CurrentUser(userId, userEmail, userRole);
        }

        public static void EndSession()
        {
            TokenManager.ClearToken();
            CurrentUser = null;
        }
    }
}