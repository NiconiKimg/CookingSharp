namespace CookingSharp.Application.DTOs;

/// <summary>
/// DTO para devolver la información pública de un usuario.
/// </summary>
public class UserResponseDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
}

/// <summary>
/// DTO para crear un nuevo usuario. Incluye la contraseña.
/// </summary>
public class UserCreateDTO
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

/// <summary>
/// DTO para actualizar el perfil de un usuario.
/// </summary>
public class UserUpdateDTO
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
}