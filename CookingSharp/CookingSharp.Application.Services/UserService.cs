using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Model;
using CookingSharp.DTOs;

namespace CookingSharp.Application.Services
{
    public class UserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public async Task<UserResponseDTO?> GetAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                return null;
            }
            return new UserResponseDTO
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
            };
        }

        public async Task<IEnumerable<UserResponseDTO>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return users.Select(u => new UserResponseDTO
            {
                Id = u.Id,
                Name = u.Name,
                Surname = u.Surname,
                Email = u.Email
            });
        }

        public async Task<UserResponseDTO> AddAsync(UserDTO dto)
        {
            if (await _userRepository.ExistsWithEmailAsync(dto.Email))
            {
                throw new ArgumentException("User with the same email already exists.");
            }

            var user = new User(0, dto.Name, dto.Surname, dto.Email, dto.Password);

            var addedUser = await _userRepository.AddAsync(user);

            var responseDto = new UserResponseDTO
            {
                Id = addedUser.Id,
                Name = addedUser.Name,
                Surname = addedUser.Surname,
                Email = addedUser.Email
            };
            return responseDto;
        }

        public async Task UpdateAsync(UserResponseDTO dto)
        {
            var existingUser = await _userRepository.GetByIdAsync(dto.Id);
            if (existingUser == null)
            {
                throw new KeyNotFoundException($"User with ID {dto.Id} not found.");
            }
            if (await _userRepository.ExistsWithEmailAsync(dto.Email, dto.Id))
            {
                throw new ArgumentException("User with the same email already exists.");
            }
            existingUser.Name = dto.Name;
            existingUser.Surname = dto.Surname;
            existingUser.Email = dto.Email;
            await _userRepository.UpdateAsync(existingUser);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _userRepository.DeleteAsync(id);
        }
    }
}
