using CookingSharp.Application.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Infrastructure.Persistence.Repositories
{
    /// <summary>
    /// Implementación genérica de las operaciones básicas de un repositorio usando Entity Framework Core.
    /// </summary>
    /// <typeparam name="T">El tipo de la entidad del dominio.</typeparam>
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly CookingSharpDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(CookingSharpDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        /// <inheritdoc />
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        /// <inheritdoc />
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        /// <inheritdoc />
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        /// <inheritdoc />
        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        /// <inheritdoc />
        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        /// <inheritdoc />
        public async Task<int> CountAsync()
        {
            return await _dbSet.CountAsync();
        }
    }
}