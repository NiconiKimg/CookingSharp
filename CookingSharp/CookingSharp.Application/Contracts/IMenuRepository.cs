using CookingSharp.Domain.Entities;

namespace CookingSharp.Application.Contracts;

/// <summary>
/// Contrato para el repositorio de menús.
/// </summary>
public interface IMenuRepository : IGenericRepository<Menu>
{
    Task<IEnumerable<Menu>> GetTopRatedMenusAsync(int count);

}