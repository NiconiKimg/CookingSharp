using System.Collections.Generic;
using System.Threading.Tasks;
namespace CookingSharp.Application.Contracts;
/// <summary>
/// Define un contrato genérico para las operaciones comunes de un repositorio.
/// Esto nos permite reutilizar la lógica básica de acceso a datos para cualquier entidad.
/// </summary>
/// <typeparam name="T">El tipo de la entidad del dominio.</typeparam>
public interface IGenericRepository<T> where T : class
{
    /// <summary>
    /// Obtiene una entidad por su identificador único de forma asíncrona.
    /// </summary>
    /// <param name="id">El ID de la entidad a buscar.</param>
    /// <returns>La entidad encontrada, o null si no existe.</returns>
    Task<T?> GetByIdAsync(int id);
    /// <summary>
    /// Obtiene todas las entidades de un tipo de forma asíncrona.
    /// </summary>
    /// <returns>Una colección de todas las entidades.</returns>
    Task<IEnumerable<T>> GetAllAsync();

    /// <summary>
    /// Añade una nueva entidad al contexto de datos de forma asíncrona.
    /// </summary>
    /// <param name="entity">La entidad a añadir.</param>
    Task AddAsync(T entity);

    /// <summary>
    /// Marca una entidad existente como modificada en el contexto de datos.
    /// </summary>
    /// <param name="entity">La entidad a actualizar.</param>
    void Update(T entity);

    /// <summary>
    /// Marca una entidad existente como eliminada en el contexto de datos.
    /// </summary>
    /// <param name="entity">La entidad a eliminar.</param>
    void Delete(T entity);
}