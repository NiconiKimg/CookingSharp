using CookingSharp.Domain.Entities;

namespace CookingSharp.Application.Contracts;

/// <summary>
/// Contrato para el repositorio de valoraciones.
/// </summary>
public interface IRatingRepository : IGenericRepository<Rating>
{
}