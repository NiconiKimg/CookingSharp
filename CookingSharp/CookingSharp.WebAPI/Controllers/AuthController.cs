using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CookingSharp.WebAPI.Controllers;

public class AuthController : BaseApiController
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    #region --- POST Endpoints ---

    /// <summary>
    /// Registra un nuevo usuario en el sistema.
    /// </summary>
    [HttpPost("register")]
    [ProducesResponseType(typeof(UserResponseDTO), 201)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Register(UserCreateDTO userCreateDto)
    {
        var userResponse = await _authService.RegisterAsync(userCreateDto);
        // Devuelve una respuesta 201 Created con la URL para obtener el nuevo usuario
        return CreatedAtAction(nameof(UsersController.GetById), "Users", new { id = userResponse.Id }, userResponse);
    }

    /// <summary>
    /// Autentica a un usuario y devuelve un token JWT.
    /// </summary>
    [HttpPost("login")]
    [ProducesResponseType(typeof(LoginResponseDTO), 200)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Login(UserLoginDTO userLoginDto)
    {
        var loginResponse = await _authService.LoginAsync(userLoginDto);
        return Ok(loginResponse);
    }

    #endregion
}