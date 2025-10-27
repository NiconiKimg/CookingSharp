using CookingSharp.Domain.Entities;

namespace CookingSharp.Application.Contracts.Infrastructure;

/// <summary>
/// Define el contrato para un servicio de generación de tokens JWT.
/// </summary>
public interface IJwtTokenGenerator
{
    /// <summary>
    /// Genera un token JWT para un usuario específico.
    /// </summary>
    /// <param name="user">La entidad del usuario para quien se generará el token.</param>
    /// <returns>El token JWT como una cadena de texto.</returns>
    string GenerateToken(User user);
}