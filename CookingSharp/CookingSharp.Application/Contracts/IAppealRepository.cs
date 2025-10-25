using CookingSharp.Domain.Entities;

namespace CookingSharp.Application.Contracts;

/// <summary>
/// Contrato para el repositorio de solicitudes (Appeals).
/// </summary>
public interface IAppealRepository : IGenericRepository<Appeal>
{
}