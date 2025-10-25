using CookingSharp.Application.Contracts;
using System;
using System.Threading.Tasks;

namespace CookingSharp.Infrastructure.Persistence.Repositories;

/// <summary>
/// Implementación del patrón Unit of Work que gestiona el contexto de la base de datos
/// y proporciona acceso a todos los repositorios.
/// </summary>
public class UnitOfWork : IUnitOfWork
{
    private readonly CookingSharpDbContext _context;

    // Propiedades para cada repositorio. Se inicializan en el constructor.
    public IUserRepository Users { get; private set; }
    public IRecipeRepository Recipes { get; private set; }
    public ICategoryRepository Categories { get; private set; }
    public ICommentRepository Comments { get; private set; }
    public IRatingRepository Ratings { get; private set; }
    public IMenuRepository Menus { get; private set; }
    public IAppealRepository Appeals { get; private set; }

    public UnitOfWork(CookingSharpDbContext context)
    {
        _context = context;

        // Inicialización de todos los repositorios, pasando el mismo contexto de base de datos.
        // Esto asegura que todos operen dentro de la misma transacción.
        Users = new UserRepository(_context);
        Recipes = new RecipeRepository(_context);
        Categories = new CategoryRepository(_context);
        Comments = new CommentRepository(_context);
        Ratings = new RatingRepository(_context);
        Menus = new MenuRepository(_context);
        Appeals = new AppealRepository(_context);
    }

    /// <summary>
    /// Guarda todos los cambios pendientes en la base de datos como una única transacción.
    /// </summary>
    /// <returns>El número de filas afectadas.</returns>
    public async Task<int> CompleteAsync()
    {
        return await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Libera los recursos del contexto de la base de datos.
    /// Este método es llamado automáticamente por el contenedor de inyección de dependencias
    /// al final del ciclo de vida de la petición.
    /// </summary>
    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }
}