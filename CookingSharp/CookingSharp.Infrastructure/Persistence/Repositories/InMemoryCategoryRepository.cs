using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain;

namespace CookingSharp.Infrastructure.Persistence.Repositories
{
    /// <summary>
    /// Implementación en memoria del repositorio de categorías, utilizada para desarrollo y pruebas.
    /// </summary>
    public class InMemoryCategoryRepository : ICategoryRepository
    {
        private static readonly List<Category> _categories = new List<Category>
        {
            new Category(1, "Postres", "Platos generalmente dulces que se sirven después de una comida"),
            new Category(2, "Plato principal", "Plato principal de la comida"),
            new Category(3, "Aperitivos", "Pequeños platos que se sirven antes de el plato principal")
        };

        private static int _nextId = _categories.Any() ? _categories.Max(c => c.Id) + 1 : 1;

        /// <inheritdoc />
        public Task<Category?> GetByIdAsync(int id)
        {
            var category = _categories.Find(c => c.Id == id);
            return Task.FromResult(category);
        }

        /// <inheritdoc />
        public Task<IEnumerable<Category>> GetAllAsync()
        {
            return Task.FromResult(_categories.AsEnumerable());
        }

        /// <inheritdoc />
        public Task<Category> AddAsync(Category category)
        {
            category.Id = _nextId++;
            _categories.Add(category);
            return Task.FromResult(category);
        }

        /// <inheritdoc />
        public Task UpdateAsync(Category category)
        {
            var existingCategory = _categories.Find(c => c.Id == category.Id);

            if (existingCategory is not null)
            {
                // El repositorio respeta la regla del dominio: le pide a la entidad que se actualice a sí misma.
                existingCategory.UpdateDetails(category.Name, category.Description);
            }

            return Task.CompletedTask;
        }

        /// <inheritdoc />
        public Task<bool> DeleteAsync(int id)
        {
            var categoryToDelete = _categories.Find(c => c.Id == id);
            if (categoryToDelete is null)
            {
                return Task.FromResult(false);
            }

            _categories.Remove(categoryToDelete);
            return Task.FromResult(true);
        }

        /// <inheritdoc />
        public Task<bool> ExistsWithNameAsync(string name, int? excludeId = null)
        {
            var query = _categories.AsQueryable();
            if (excludeId.HasValue)
            {
                query = query.Where(c => c.Id != excludeId.Value);
            }
            bool exists = query.Any(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            return Task.FromResult(exists);
        }
    }
}