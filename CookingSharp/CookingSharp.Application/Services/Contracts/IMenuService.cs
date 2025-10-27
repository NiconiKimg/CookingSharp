using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services.Contracts;

/// <summary>
/// Define el contrato para el servicio de gestión de menús.
/// </summary>
public interface IMenuService
{
    /// <summary>
    /// Obtiene todos los menús creados por un usuario específico.
    /// </summary>
    /// <param name="userId">El ID del usuario (Chef).</param>
    Task<IEnumerable<MenuResponseDTO>> GetMenusByUserAsync(int userId);

    /// <summary>
    /// Obtiene una versión acotada de todos menús creados.
    /// </summary>
    Task<IEnumerable<MenuSummaryDTO>> GetAllSummariesAsync();

    /// <summary>
    /// Obtiene un menú por su ID.
    /// </summary>
    /// <param name="id">El ID del menu.</param>
    Task<MenuResponseDTO?> GetByIdAsync(int id);

    /// <summary>
    /// Crea un nuevo menú para un usuario.
    /// </summary>
    /// <param name="menuDto">El DTO con los datos del nuevo menú.</param>
    /// <param name="creatorUserId">El ID del usuario que crea el menú.</param>
    Task<MenuResponseDTO> CreateAsync(MenuCreateUpdateDTO menuDto, int creatorUserId);

    Task UpdateAsync(int id, MenuCreateUpdateDTO menuDto);
    Task DeleteAsync(int id);
}