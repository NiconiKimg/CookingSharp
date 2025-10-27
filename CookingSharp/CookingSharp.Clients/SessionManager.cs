using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CookingSharp.Clients
{
    public static class SessionManager
    {
        private static string? _jwtToken;
        private static List<Claim> _claims = new();

        /// <summary>
        /// Obtiene o establece el token JWT. Al establecer un nuevo token,
        /// se decodifica automáticamente para extraer y almacenar los claims del usuario.
        /// </summary>
        public static string? JwtToken
        {
            get => _jwtToken;
            set
            {
                _jwtToken = value;
                _claims.Clear();

                if (!string.IsNullOrEmpty(_jwtToken))
                {
                    var handler = new JwtSecurityTokenHandler();
                    var token = handler.ReadJwtToken(_jwtToken);
                    _claims.AddRange(token.Claims);
                }
            }
        }

        /// <summary>
        /// Indica si el usuario está actualmente autenticado (es decir, si existe un token).
        /// </summary>
        public static bool IsUserAuthenticated => !string.IsNullOrEmpty(JwtToken);

        /// <summary>
        /// Obtiene el rol del usuario autenticado desde los claims del token.
        /// </summary>
        /// <returns>El rol como string (ej. "Admin", "Chef") o null si no se encuentra.</returns>
        public static string? GetUserRole() =>
            _claims.FirstOrDefault(c => c.Type == ClaimTypes.Role || c.Type == "role")?.Value;

        /// <summary>
        /// Obtiene el ID del usuario autenticado desde los claims del token.
        /// </summary>
        /// <returns>El ID del usuario como string o null si no se encuentra.</returns>
        public static string? GetUserId() =>
            _claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier || c.Type == "sub")?.Value;

        /// <summary>
        /// Obtiene el email del usuario autenticado desde los claims del token.
        /// </summary>
        /// <returns>El email del usuario o null si no se encuentra.</returns>
        public static string? GetUserEmail() =>
            _claims.FirstOrDefault(c => c.Type == ClaimTypes.Email || c.Type == "email")?.Value;

        /// <summary>
        /// Cierra la sesión del usuario, limpiando el token y los claims almacenados.
        /// </summary>
        public static void Logout()
        {
            JwtToken = null;
        }
    }
}