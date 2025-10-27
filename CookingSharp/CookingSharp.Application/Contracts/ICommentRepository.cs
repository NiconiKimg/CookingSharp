using CookingSharp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Contracts;

public interface ICommentRepository : IGenericRepository<Comment>
{
    /// <summary>
    /// Obtiene todos los comentarios para una receta específica, incluyendo el autor de cada comentario.
    /// </summary>
    Task<IEnumerable<Comment>> GetByRecipeIdWithUserAsync(int recipeId);
}