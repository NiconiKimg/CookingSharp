using System;
using System.Threading.Tasks;

namespace CookingSharp.Application.Contracts;

/// <summary>
/// Define el patrón Unit of Work para agrupar transacciones de base de datos.
/// Expone todos los repositorios de la aplicación y un método para guardar los cambios.
/// </summary>
public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IRecipeRepository Recipes { get; }
    ICategoryRepository Categories { get; }
    ICommentRepository Comments { get; }
    IRatingRepository Ratings { get; }
    IMenuRepository Menus { get; }
    IAppealRepository Appeals { get; }

    /// <summary>
    /// Guarda todos los cambios realizados en el contexto de esta unidad de trabajo en la base de datos de forma asíncrona.
    /// </summary>
    /// <returns>El número de filas afectadas en la base de datos.</returns>
    Task<int> CompleteAsync();
}