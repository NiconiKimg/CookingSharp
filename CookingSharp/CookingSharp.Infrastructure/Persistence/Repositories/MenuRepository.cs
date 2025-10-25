using CookingSharp.Application.Contracts;
using CookingSharp.Domain.Entities;

namespace CookingSharp.Infrastructure.Persistence.Repositories;

/// <summary>
/// Implementación del repositorio para la entidad Menu.
/// </summary>
public class MenuRepository : GenericRepository<Menu>, IMenuRepository
{
    public MenuRepository(CookingSharpDbContext context) : base(context)
    {
    }
}