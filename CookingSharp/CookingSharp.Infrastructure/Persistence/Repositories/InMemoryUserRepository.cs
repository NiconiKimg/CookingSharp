using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain;

namespace CookingSharp.Infrastructure.Persistence.Repositories
{
    /// <summary>
    /// Implementación en memoria del repositorio de usuarios, utilizada para desarrollo y pruebas.
    /// </summary>
    public class InMemoryUserRepository : IUserRepository
    {
        private static readonly List<User> _users = new List<User>
        {
            new User(1, "Emiliano", "Luhmann", "emyluhmann@gmail.com", "12345678"),
            new User(2, "Nicolas", "Pedemonte", "NicoPedi@gmail.com", "12345678"),
            new User(3, "Luca", "Trincavelli", "LucaTricavelli@gmail.com", "12345678")
        };

        private static int _nextId = _users.Any() ? _users.Max(u => u.Id) + 1 : 1;

        /// <inheritdoc />
        public Task<User?> GetByIdAsync(int id)
        {
            var user = _users.Find(u => u.Id == id);
            return Task.FromResult(user);
        }

        /// <inheritdoc />
        public Task<IEnumerable<User>> GetAllAsync()
        {
            return Task.FromResult(_users.AsEnumerable());
        }

        /// <inheritdoc />
        public Task<User> AddAsync(User user)
        {
            user.Id = _nextId++;
            _users.Add(user);
            return Task.FromResult(user);
        }

        /// <inheritdoc />
        public Task UpdateAsync(User user)
        {
            var existingUser = _users.Find(u => u.Id == user.Id);
            if (existingUser is not null)
            {
                // El repositorio, al simular la base de datos, actualiza todo el estado de la entidad
                // a través de sus métodos públicos.
                existingUser.UpdateProfile(user.Name, user.Surname, user.Email);
                existingUser.ChangePassword(user.Password);
            }
            return Task.CompletedTask;
        }

        /// <inheritdoc />
        public Task<bool> DeleteAsync(int id)
        {
            var userToDelete = _users.Find(u => u.Id == id);
            if (userToDelete is null)
            {
                return Task.FromResult(false);
            }
            _users.Remove(userToDelete);
            return Task.FromResult(true);
        }

        /// <inheritdoc />
        public Task<bool> ExistsWithEmailAsync(string mail, int? excludeId = null)
        {
            var query = _users.AsQueryable();
            if (excludeId.HasValue)
            {
                query = query.Where(u => u.Id != excludeId.Value);
            }
            bool exists = query.Any(u => u.Email.Equals(mail, StringComparison.OrdinalIgnoreCase));
            return Task.FromResult(exists);
        }
    }
}