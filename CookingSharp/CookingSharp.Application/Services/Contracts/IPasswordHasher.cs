namespace CookingSharp.Application.Contracts.Infrastructure;

/// <summary>
/// Define el contrato para un servicio de hashing de contraseñas.
/// </summary>
public interface IPasswordHasher
{
    /// <summary>
    /// Crea un hash a partir de una contraseña en texto plano.
    /// </summary>
    /// <param name="password">La contraseña a hashear.</param>
    /// <returns>El hash de la contraseña.</returns>
    string Hash(string password);

    /// <summary>
    /// Verifica si una contraseña en texto plano coincide con un hash existente.
    /// </summary>
    /// <param name="hashedPassword">El hash almacenado.</param>
    /// <param name="providedPassword">La contraseña proporcionada por el usuario.</param>
    /// <returns>True si las contraseñas coinciden, de lo contrario False.</returns>
    bool Verify(string hashedPassword, string providedPassword);
}