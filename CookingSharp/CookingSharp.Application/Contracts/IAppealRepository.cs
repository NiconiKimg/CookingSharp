using CookingSharp.Domain;

namespace CookingSharp.Application.Services.Contracts
{
    public interface IAppealRepository
    {
        Task<Appeal?> GetByIdAsync(int id);
        Task<IEnumerable<Appeal>> GetAllAsync();
        Task<Appeal> AddAsync(Appeal appeal);
        Task UpdateAsync(Appeal appeal);
        //Task<bool> DeleteAsync(int id);
        //Task<bool> ExistsWithNameAsync(string name, int? excludeId = null);
    }
}
