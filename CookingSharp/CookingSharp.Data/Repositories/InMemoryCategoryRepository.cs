using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Model;

namespace CookingSharp.Data.Repositories
{
    public class InMemoryCategoryRepository : ICategoryRepository
    {
        private static readonly List<Category> _categories = new List<Category>
        {
            new Category(1, "Postres", "Platos generalmente dulces que se sirven después de una comida"),
            new Category(2, "Plato principal", "Plato principal de la comida"),
            new Category(3, "Aperitivos", "Pequeños platos que se sirven antes de el plato principal")
        };

        private static int _nextId = _categories.Any() ? _categories.Max(c => c.Id) + 1 : 1;

        public Task<Category?> GetByIdAsync(int id)
        {
            var category = _categories.Find(c => c.Id == id); // Check if FirstOrDefault is useful here
            return Task.FromResult(category);
        }

        public Task<IEnumerable<Category>> GetAllAsync()
        {
            return Task.FromResult(_categories.AsEnumerable());
        }

        public Task<Category> AddAsync(Category category)
        {
            category.Id = _nextId++;
            _categories.Add(category);
            return Task.FromResult(category);
        }

        public Task UpdateAsync(Category category)
        {
            var existingCategory = _categories.Find(c => c.Id == category.Id);
            if (existingCategory != null)
            {
                existingCategory.Name = category.Name;
                existingCategory.Description = category.Description;
            }
            return Task.CompletedTask;
        }

        public Task<bool> DeleteAsync(int id)
        {
            var categoryToDelete = _categories.Find(c => c.Id == id);
            if (categoryToDelete == null)
            {
                return Task.FromResult(false);
            }
            _categories.Remove(categoryToDelete);
            return Task.FromResult(true);
        }

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
