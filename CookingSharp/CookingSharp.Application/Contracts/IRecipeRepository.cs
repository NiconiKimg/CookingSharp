using CookingSharp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Contracts;

public interface IRecipeRepository : IGenericRepository<Recipe>
{
    /// <summary>
    /// Obtiene todas las recetas incluyendo sus datos relacionados (Autor, Pasos, Categorías).
    /// </summary>
    Task<IEnumerable<Recipe>> GetAllWithDetailsAsync();

    /// <summary>
    /// Obtiene una receta por su ID, incluyendo sus datos relacionados.
    /// </summary>
    Task<Recipe?> GetByIdWithDetailsAsync(int id);

    /// <summary>
    /// Obtiene una receta por el ID del autor, incluyendo sus datos relacionados.
    /// </summary>
    Task<IEnumerable<Recipe>> GetByUserIdWithDetailsAsync(int userId);
}