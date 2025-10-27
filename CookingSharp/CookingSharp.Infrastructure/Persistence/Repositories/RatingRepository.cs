using CookingSharp.Application.Contracts;
using CookingSharp.Domain.Entities;

namespace CookingSharp.Infrastructure.Persistence.Repositories;

/// <summary>
/// Implementación del repositorio para la entidad Rating.
/// </summary>
public class RatingRepository : GenericRepository<RecipeRating>, IRatingRepository
{
    public RatingRepository(CookingSharpDbContext context) : base(context)
    {
    }
    // No se necesitan métodos adicionales por ahora, ya que las operaciones
    // específicas se pueden manejar en los servicios con LINQ.
}