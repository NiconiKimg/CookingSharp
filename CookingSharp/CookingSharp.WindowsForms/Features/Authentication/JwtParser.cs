using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace CookingSharp.WindowsForms
{
    public static class JwtParser
    {
        /// <summary>
        /// Lee un token JWT y extrae todos sus claims.
        /// </summary>
        /// <param name="jwtToken">El token en formato de cadena.</param>
        /// <returns>Una colección de claims encontrados en el token.</returns>
        public static IEnumerable<Claim> ParseClaimsFromJwt(string jwtToken)
        {
            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(jwtToken);
            return token.Claims;
        }

        /// <summary>
        /// Extrae un claim específico de un token JWT.
        /// </summary>
        /// <param name="jwtToken">El token en formato de cadena.</param>
        /// <param name="claimType">El tipo de claim a buscar (ej. "sub" o "role").</param>
        /// <returns>El valor del claim si se encuentra; de lo contrario, null.</returns>
        public static string? GetClaimValue(string jwtToken, string claimType)
        {
            var claims = ParseClaimsFromJwt(jwtToken);
            return claims.FirstOrDefault(c => c.Type == claimType)?.Value;
        }
    }
}