using CookingSharp.Application.Contracts.Infrastructure;

namespace CookingSharp.Infrastructure.Auth;

/// <summary>
/// Implementación del servicio de hashing de contraseñas utilizando la librería BCrypt.Net.
/// </summary>
public class PasswordHasher : IPasswordHasher
{
    /// <summary>
    /// Crea un hash a partir de una contraseña en texto plano.
    /// </summary>
    /// <param name="password">La contraseña a hashear.</param>
    /// <returns>El hash de la contraseña, listo para ser almacenado.</returns>
    public string Hash(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    /// <summary>
    /// Verifica si una contraseña en texto plano coincide con un hash existente.
    /// </summary>
    /// <param name="hashedPassword">El hash almacenado en la base de datos.</param>
    /// <param name="providedPassword">La contraseña proporcionada por el usuario durante el login.</param>
    /// <returns>True si las contraseñas coinciden, de lo contrario False.</returns>
    public bool Verify(string hashedPassword, string providedPassword)
    {
        return BCrypt.Net.BCrypt.Verify(providedPassword, hashedPassword);
    }
}