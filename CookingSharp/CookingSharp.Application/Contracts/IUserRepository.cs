using CookingSharp.Domain.Entities;
using System.Threading.Tasks;

namespace CookingSharp.Application.Contracts;

/// <summary>
/// Contrato para el repositorio de usuarios. Hereda las operaciones genéricas
/// y añade métodos específicos para la entidad User.
/// </summary>
public interface IUserRepository : IGenericRepository<User>
{
    /// <summary>
    /// Obtiene un usuario por su dirección de correo electrónico.
    /// </summary>
    /// <param name="email">El email a buscar.</param>
    /// <returns>El usuario encontrado, o null si no existe.</returns>
    Task<User?> GetByEmailAsync(string email);

    /// <summary>
    /// Verifica si ya existe un usuario con un determinado email.
    /// </summary>
    /// <param name="email">El email a verificar.</param>
    /// <param name="excludeId">Un ID de usuario opcional para excluir de la búsqueda (útil al actualizar).</param>
    /// <returns>True si el email ya está en uso, de lo contrario False.</returns>
    Task<bool> ExistsWithEmailAsync(string email, int? excludeId = null);
}