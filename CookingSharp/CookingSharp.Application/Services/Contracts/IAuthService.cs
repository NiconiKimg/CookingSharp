using CookingSharp.Application.DTOs;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services.Contracts;

/// <summary>
/// Define el contrato para el servicio de autenticación y registro.
/// </summary>
public interface IAuthService
{
    /// <summary>
    /// Registra un nuevo usuario en el sistema.
    /// </summary>
    /// <param name="userCreateDto">El DTO con los datos para el registro.</param>
    /// <returns>El DTO del usuario recién creado.</returns>
    Task<UserResponseDTO> RegisterAsync(UserCreateDTO userCreateDto);

    /// <summary>
    /// Autentica a un usuario y genera un token JWT.
    /// </summary>
    /// <param name="userLoginDto">El DTO con las credenciales de inicio de sesión.</param>
    /// <returns>Un DTO con el token JWT si la autenticación es exitosa.</returns>
    Task<LoginResponseDTO> LoginAsync(UserLoginDTO userLoginDto);
}