using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services.Contracts;

/// <summary>
/// Define el contrato para el servicio de gestión de categorías.
/// </summary>
public interface ICategoryService
{
    Task<IEnumerable<CategoryResponseDTO>> GetAllAsync();
    Task<CategoryResponseDTO?> GetByIdAsync(int id);
    Task<CategoryResponseDTO> CreateAsync(CategoryCreateUpdateDTO categoryCreateUpdateDto);
    Task UpdateAsync(int id, CategoryCreateUpdateDTO categoryCreateUpdateDto);
    Task DeleteAsync(int id);
}