using AutoMapper;
using CookingSharp.Application.Common.Exceptions;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.Contracts.Infrastructure;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Entities;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services;

/// <summary>
/// Implementación del servicio de autenticación y registro.
/// </summary>
public class AuthService : IAuthService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthService(IUnitOfWork unitOfWork, IMapper mapper, IPasswordHasher passwordHasher, IJwtTokenGenerator jwtTokenGenerator)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _passwordHasher = passwordHasher;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    /// <summary>
    /// Registra un nuevo usuario en el sistema de forma asíncrona.
    /// </summary>
    /// <param name="userCreateDto">El DTO con los datos para el registro.</param>
    /// <returns>El DTO del usuario recién creado.</returns>
    /// <exception cref="BadRequestException">Se lanza si el email ya está en uso.</exception>
    public async Task<UserResponseDTO> RegisterAsync(UserCreateDTO userCreateDto)
    {
        if (await _unitOfWork.Users.ExistsWithEmailAsync(userCreateDto.Email))
        {
            throw new BadRequestException($"El email '{userCreateDto.Email}' ya está en uso.");
        }

        var hashedPassword = _passwordHasher.Hash(userCreateDto.Password);

        var user = new User(
            userCreateDto.Name,
            userCreateDto.Surname,
            userCreateDto.Email,
            hashedPassword
        );

        await _unitOfWork.Users.AddAsync(user);
        await _unitOfWork.CompleteAsync();

        return _mapper.Map<UserResponseDTO>(user);
    }

    /// <summary>
    /// Autentica a un usuario y genera un token JWT de forma asíncrona.
    /// </summary>
    /// <param name="userLoginDto">El DTO con las credenciales de inicio de sesión.</param>
    /// <returns>Un DTO con el token JWT si la autenticación es exitosa.</returns>
    /// <exception cref="BadRequestException">Se lanza si las credenciales son incorrectas.</exception>
    public async Task<LoginResponseDTO> LoginAsync(UserLoginDTO userLoginDto)
    {
        var user = await _unitOfWork.Users.GetByEmailAsync(userLoginDto.Email);

        if (user is null || !_passwordHasher.Verify(user.Password, userLoginDto.Password))
        {
            throw new BadRequestException("Email o contraseña incorrectos.");
        }

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new LoginResponseDTO { Token = token };
    }
}