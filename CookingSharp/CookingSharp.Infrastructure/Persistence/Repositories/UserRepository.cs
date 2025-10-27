using CookingSharp.Application.Contracts;
using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSharp.Infrastructure.Persistence.Repositories;

/// <summary>
/// Implementación del repositorio para la entidad User.
/// </summary>
public class UserRepository : GenericRepository<User>, IUserRepository
{
    /// <summary>
    /// Constructor del repositorio de usuarios.
    /// </summary>
    /// <param name="context">El contexto de la base de datos.</param>
    public UserRepository(CookingSharpDbContext context) : base(context)
    {
    }

    /// <summary>
    /// Obtiene todos los usuarios activos, opcionalmente filtrados por un término de búsqueda en nombre, apellido o email.
    /// </summary>
    /// <param name="searchTerm">Término de búsqueda.</param>
    /// <returns>Una colección de usuarios activos.</returns>
    public new async Task<IEnumerable<User>> GetAllAsync(string? searchTerm = null)
    {
        var query = _dbSet.Where(u => u.IsActive);

        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            var term = searchTerm.ToUpper();
            query = query.Where(u =>
                u.Name.ToUpper().Contains(term) ||
                u.Surname.ToUpper().Contains(term) ||
                u.Email.ToUpper().Contains(term)
            );
        }

        return await query.ToListAsync();
    }

    /// <summary>
    /// Obtiene un usuario activo por su ID.
    /// </summary>
    /// <param name="id">El ID del usuario a buscar.</param>
    /// <returns>La entidad del usuario si se encuentra y está activo; de lo contrario, null.</returns>
    public override async Task<User?> GetByIdAsync(int id)
    {
        return await _dbSet.FirstOrDefaultAsync(u => u.Id == id && u.IsActive);
    }

    /// <summary>
    /// Verifica si un usuario con un email específico ya existe.
    /// </summary>
    /// <param name="email">Email a verificar.</param>
    /// <param name="excludeId">ID de usuario a excluir de la búsqueda.</param>
    /// <returns>Verdadero si existe, falso en caso contrario.</returns>
    public async Task<bool> ExistsWithEmailAsync(string email, int? excludeId = null)
    {
        var query = _dbSet.AsQueryable();
        if (excludeId.HasValue)
        {
            query = query.Where(u => u.Id != excludeId.Value);
        }
        return await query.AnyAsync(u => u.Email.ToUpper() == email.ToUpper());
    }

    /// <summary>
    /// Obtiene un usuario activo por su dirección de email.
    /// </summary>
    /// <param name="email">El email a buscar.</param>
    /// <returns>El usuario encontrado si está activo, o null si no existe o está inactivo.</returns>
    public async Task<User?> GetByEmailAsync(string email)
    {
        return await _dbSet.FirstOrDefaultAsync(u => u.Email.ToUpper() == email.ToUpper() && u.IsActive);
    }
}