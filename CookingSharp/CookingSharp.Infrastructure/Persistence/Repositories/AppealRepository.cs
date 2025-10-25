using CookingSharp.Application.Contracts;
using CookingSharp.Domain.Entities;

namespace CookingSharp.Infrastructure.Persistence.Repositories;

/// <summary>
/// Implementación del repositorio para la entidad Appeal.
/// </summary>
public class AppealRepository : GenericRepository<Appeal>, IAppealRepository
{
    public AppealRepository(CookingSharpDbContext context) : base(context)
    {
    }
}