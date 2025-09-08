using CookingSharp.Application.DTOs;
using CookingSharp.Domain;
using CookingSharp.Application.Services.Contracts;

namespace CookingSharp.Application.Services
{
    /// <summary>
    /// Proporciona la lógica de negocio para gestionar los usuarios.
    /// </summary>
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Obtiene un usuario por su identificador único.
        /// </summary>
        /// <param name="id">El ID del usuario a buscar.</param>
        /// <returns>Un DTO de respuesta del usuario si se encuentra; de lo contrario, null.</returns>
        public async Task<UserResponseDTO?> GetAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user is null)
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

        /// <summary>
        /// Obtiene todos los usuarios existentes.
        /// </summary>
        /// <returns>Una colección de DTOs de respuesta de todos los usuarios.</returns>
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

        /// <summary>
        /// Añade un nuevo usuario al sistema.
        /// </summary>
        /// <param name="dto">El DTO con la información del nuevo usuario.</param>
        /// <returns>El DTO de respuesta del usuario recién creado.</returns>
        public async Task<UserResponseDTO> AddAsync(UserDTO dto)
        {
            if (await _userRepository.ExistsWithEmailAsync(dto.Email))
            {
                throw new ArgumentException("User with the same email already exists.");
            }

            var user = new User(0, dto.Name, dto.Surname, dto.Email, dto.Password);

            var addedUser = await _userRepository.AddAsync(user);

            return new UserResponseDTO
            {
                Id = addedUser.Id,
                Name = addedUser.Name,
                Surname = addedUser.Surname,
                Email = addedUser.Email
            };
        }

        /// <summary>
        /// Actualiza la información del perfil de un usuario existente.
        /// </summary>
        /// <param name="dto">El DTO con los datos actualizados del perfil del usuario.</param>
        public async Task UpdateAsync(UserResponseDTO dto)
        {
            var existingUser = await _userRepository.GetByIdAsync(dto.Id);
            if (existingUser is null)
            {
                throw new KeyNotFoundException($"User with ID {dto.Id} not found.");
            }
            if (await _userRepository.ExistsWithEmailAsync(dto.Email, dto.Id))
            {
                throw new ArgumentException("User with the same email already exists.");
            }

            existingUser.UpdateProfile(dto.Name, dto.Surname, dto.Email);

            await _userRepository.UpdateAsync(existingUser);
        }

        /// <summary>
        /// Elimina un usuario por su identificador único.
        /// </summary>
        /// <param name="id">El ID del usuario a eliminar.</param>
        /// <returns>Verdadero si la eliminación fue exitosa, falso en caso contrario.</returns>
        public async Task<bool> DeleteAsync(int id)
        {
            return await _userRepository.DeleteAsync(id);
        }
    }
}