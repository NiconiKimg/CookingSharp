using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain;

namespace CookingSharp.Infrastructure.Persistence.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static readonly List<User> _users = new List<User>
        {
            new User(1, "Emiliano", "Luhmann", "emyluhmann@gmail.com", "123"),
            new User(2, "Nicolas", "Pedemonte", "NicoPedi@gmail.com", "123"),
            new User(3, "Luca", "Trincavelli", "LucaTricavelli@gmail.com", "123")
        };

        private static int _nextId = _users.Any() ? _users.Max(c => c.Id) + 1 : 1;

        public Task<User?> GetByIdAsync(int id)
        { 
            var user = _users.Find(u => u.Id == id); // Check if FirstOrDefault is useful here
            return Task.FromResult(user);
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            return Task.FromResult(_users.AsEnumerable());
        }

        public Task<User> AddAsync(User user)
        {
            user.Id = _nextId++;
            _users.Add(user);
            return Task.FromResult(user);
        }

        public Task UpdateAsync(User user)
        {
            var existingUser = _users.Find(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                existingUser.Surname = user.Surname;
                existingUser.Password = user.Password;
            }
            return Task.CompletedTask;
        }

        public Task<bool> DeleteAsync(int id)
        {
            var userToDelete = _users.Find(c => c.Id == id);
            if (userToDelete == null)
            {
                return Task.FromResult(false);
            }
            _users.Remove(userToDelete);
            return Task.FromResult(true);
        }

        public Task<bool> ExistsWithEmailAsync(string mail, int? excludeId = null)
        {
            var query = _users.AsQueryable();
            if (excludeId.HasValue)
            {
                query = query.Where(c => c.Id != excludeId.Value);
            }
            bool exists = query.Any(c => c.Email.Equals(mail, StringComparison.OrdinalIgnoreCase));
            return Task.FromResult(exists);
        }
    }
}
