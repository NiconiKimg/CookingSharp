using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services.Contracts
{
    /// <summary>
    /// Define el contrato para el servicio de gestión de usuarios.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Obtiene todos los usuarios del sistema.
        /// </summary>
        Task<IEnumerable<UserResponseDTO>> GetAllAsync();

        /// <summary>
        /// Obtiene todos los usuarios del sistema, opcionalmente filtrados.
        /// </summary>
        /// <param name="searchTerm">Término de búsqueda opcional.</param>
        Task<IEnumerable<UserResponseDTO>> GetAllAsync(string? searchTerm = null);

        /// <summary>
        /// Obtiene un usuario por su ID.
        /// </summary>
        Task<UserResponseDTO?> GetByIdAsync(int id);

        /// <summary>
        /// Actualiza el perfil de un usuario existente.
        /// </summary>
        Task UpdateAsync(int id, UserUpdateDTO userUpdateDto);

        /// <summary>
        /// Elimina un usuario por su ID.
        /// </summary>
        Task DeleteAsync(int id);

        /// <summary>
        /// Obtiene el número total de usuarios registrados.
        /// </summary>
        /// <returns>El conteo total de usuarios.</returns>
        Task<int> GetTotalCountAsync();
    }
}