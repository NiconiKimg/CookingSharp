namespace CookingSharp.Application.DTOs;

/// <summary>
/// DTO para el proceso de inicio de sesión.
/// </summary>
public class UserLoginDTO
{
    public string Email { get; set; }
    public string Password { get; set; }
}

/// <summary>
/// DTO para la respuesta del login, conteniendo el token JWT.
/// </summary>
public class LoginResponseDTO
{
    public string Token { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public int UserId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public class LoginRequestDTO
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

public class RegisterRequestDTO
{
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}