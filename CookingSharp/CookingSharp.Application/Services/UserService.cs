using AutoMapper;
using CookingSharp.Application.Common.Exceptions;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services
{
    /// <summary>
    /// Implementación del servicio de gestión de usuarios.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        /// <summary>
        /// Obtiene todos los usuarios del sistema de forma asíncrona.
        /// </summary>
        public async Task<IEnumerable<UserResponseDTO>> GetAllAsync()
        {
            var users = await _unitOfWork.Users.GetAllAsync();
            return _mapper.Map<IEnumerable<UserResponseDTO>>(users);
        }

        /// <summary>
        /// Obtiene un usuario por su ID de forma asíncrona.
        /// </summary>
        public async Task<UserResponseDTO?> GetByIdAsync(int id)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(id) ?? throw new NotFoundException(nameof(User), id);
            return _mapper.Map<UserResponseDTO>(user);
        }

        /// <summary>
        /// Actualiza el perfil de un usuario existente de forma asíncrona.
        /// </summary>
        public async Task UpdateAsync(int id, UserUpdateDTO userUpdateDto)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(id) ?? throw new NotFoundException(nameof(User), id);

            if (await _unitOfWork.Users.ExistsWithEmailAsync(userUpdateDto.Email, id))
            {
                throw new BadRequestException($"El email '{userUpdateDto.Email}' ya está en uso por otro usuario.");
            }

            user.UpdateProfile(userUpdateDto.Name, userUpdateDto.Surname, userUpdateDto.Email);
            _unitOfWork.Users.Update(user);
            await _unitOfWork.CompleteAsync();
        }

        /// <summary>
        /// Elimina un usuario por su ID de forma asíncrona.
        /// </summary>
        public async Task DeleteAsync(int id)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(id) ?? throw new NotFoundException(nameof(User), id);
            _unitOfWork.Users.Delete(user);
            await _unitOfWork.CompleteAsync();
        }

        /// <summary>
        /// Obtiene el número total de usuarios del sistema de forma asíncrona.
        /// </summary>
        public async Task<int> GetTotalCountAsync()
        {
            return await _unitOfWork.Users.CountAsync();
        }
    }
}