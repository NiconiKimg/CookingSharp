using CookingSharp.Domain;

namespace CookingSharp.Application.Services.Contracts
{
    public interface ICategoryRepository
    {
        Task<Category?> GetByIdAsync(int id);
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> AddAsync(Category category);
        Task UpdateAsync(Category category);
        Task<bool> DeleteAsync(int id);
        Task<bool> ExistsWithNameAsync(string name, int? excludeId = null);
    }
}