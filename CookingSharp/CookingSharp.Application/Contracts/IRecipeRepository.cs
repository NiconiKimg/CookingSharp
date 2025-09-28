using CookingSharp.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services.Contracts
{
    public interface IRecipeRepository
    {
        Task<Recipe?> GetByIdAsync(int id);
        Task<IEnumerable<Recipe>> GetAllAsync();
        Task<Recipe> AddAsync(Recipe recipe);
        Task UpdateAsync(Recipe recipe);
        Task<bool> DeleteAsync(int id);
    }
}