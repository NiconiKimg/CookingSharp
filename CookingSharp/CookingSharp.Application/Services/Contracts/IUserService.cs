using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services.Contracts;

/// <summary>
/// Define el contrato para el servicio de gestión de usuarios.
/// </summary>
public interface IUserService
{
    /// <summary>
    /// Obtiene todos los usuarios del sistema.
    /// </summary>
    /// <returns>Una colección de DTOs de respuesta de usuario.</returns>
    Task<IEnumerable<UserResponseDTO>> GetAllAsync();

    /// <summary>
    /// Obtiene un usuario por su ID.
    /// </summary>
    /// <param name="id">El ID del usuario a buscar.</param>
    /// <returns>El DTO del usuario encontrado, o null si no existe.</returns>
    Task<UserResponseDTO?> GetByIdAsync(int id);

    /// <summary>
    /// Actualiza el perfil de un usuario existente.
    /// </summary>
    /// <param name="id">El ID del usuario a actualizar.</param>
    /// <param name="userUpdateDto">El DTO con los nuevos datos del perfil.</param>
    Task UpdateAsync(int id, UserUpdateDTO userUpdateDto);

    /// <summary>
    /// Elimina un usuario por su ID.
    /// </summary>
    /// <param name="id">El ID del usuario a eliminar.</param>
    Task DeleteAsync(int id);
}