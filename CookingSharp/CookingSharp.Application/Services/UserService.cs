using AutoMapper;
using CookingSharp.Application.Common.Exceptions;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services;

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
    /// <returns>Una colección de DTOs de respuesta de usuario.</returns>
    public async Task<IEnumerable<UserResponseDTO>> GetAllAsync()
    {
        var users = await _unitOfWork.Users.GetAllAsync();
        return _mapper.Map<IEnumerable<UserResponseDTO>>(users);
    }

    /// <summary>
    /// Obtiene un usuario por su ID de forma asíncrona.
    /// </summary>
    /// <param name="id">El ID del usuario a buscar.</param>
    /// <returns>El DTO del usuario encontrado.</returns>
    /// <exception cref="NotFoundException">Se lanza si no se encuentra ningún usuario con el ID especificado.</exception>
    public async Task<UserResponseDTO?> GetByIdAsync(int id)
    {
        var user = await _unitOfWork.Users.GetByIdAsync(id) ?? throw new NotFoundException(nameof(User), id);
        return _mapper.Map<UserResponseDTO>(user);
    }

    /// <summary>
    /// Actualiza el perfil de un usuario existente de forma asíncrona.
    /// </summary>
    /// <param name="id">El ID del usuario a actualizar.</param>
    /// <param name="userUpdateDto">El DTO con los nuevos datos del perfil.</param>
    /// <exception cref="NotFoundException">Se lanza si no se encuentra el usuario.</exception>
    /// <exception cref="BadRequestException">Se lanza si el nuevo email ya está en uso.</exception>
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
    /// <param name="id">El ID del usuario a eliminar.</param>
    /// <exception cref="NotFoundException">Se lanza si no se encuentra el usuario.</exception>
    public async Task DeleteAsync(int id)
    {
        var user = await _unitOfWork.Users.GetByIdAsync(id) ?? throw new NotFoundException(nameof(User), id);

        _unitOfWork.Users.Delete(user);
        await _unitOfWork.CompleteAsync();
    }
}