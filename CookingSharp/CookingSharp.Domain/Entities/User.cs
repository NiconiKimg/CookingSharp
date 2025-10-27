using CookingSharp.Domain.Enums;
using System;
using System.Collections.Generic;

namespace CookingSharp.Domain.Entities;

/// <summary>
/// Representa a un usuario del sistema.
/// </summary>
public class User
{
    /// <summary>
    /// Identificador único del usuario.
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Nombre de pila del usuario.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Apellido del usuario.
    /// </summary>
    public string Surname { get; private set; }

    /// <summary>
    /// Correo electrónico del usuario, debe ser único.
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// Hash de la contraseña del usuario.
    /// </summary>
    public string Password { get; private set; }

    /// <summary>
    /// Rol del usuario en el sistema (Admin, Chef, Apprentice).
    /// </summary>
    public UserRole Role { get; private set; }

    /// <summary>
    /// Indica si la cuenta del usuario está activa.
    /// </summary>
    public bool IsActive { get; private set; }

    public ICollection<Recipe> Recipes { get; private set; } = new List<Recipe>();
    public ICollection<Menu> Menus { get; private set; } = new List<Menu>();
    public ICollection<Comment> Comments { get; private set; } = new List<Comment>();
    public ICollection<RecipeRating> RecipeRatings { get; private set; } = new List<RecipeRating>();
    public ICollection<MenuRating> MenuRatings { get; private set; } = new List<MenuRating>();
    public ICollection<Appeal> Appeals { get; private set; } = new List<Appeal>();

    private User() { }

    /// <summary>
    /// Constructor para crear una nueva instancia de Usuario válida.
    /// </summary>
    /// <param name="name">Nombre del usuario.</param>
    /// <param name="surname">Apellido del usuario.</param>
    /// <param name="email">Correo electrónico del usuario.</param>
    /// <param name="hashedPassword">Contraseña hasheada del usuario.</param>
    public User(string name, string surname, string email, string hashedPassword)
    {
        UpdateProfile(name, surname, email);
        ChangePassword(hashedPassword);
        Role = UserRole.Apprentice;
        IsActive = true;
    }

    /// <summary>
    /// Actualiza los datos del perfil de un usuario, aplicando validaciones.
    /// </summary>
    public void UpdateProfile(string name, string surname, string email)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(name));
        if (string.IsNullOrWhiteSpace(surname))
            throw new ArgumentException("El apellido no puede ser nulo o vacío.", nameof(surname));
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("El email no puede ser nulo o vacío.", nameof(email));

        Name = name;
        Surname = surname;
        Email = email;
    }

    /// <summary>
    /// Cambia la contraseña del usuario.
    /// </summary>
    /// <param name="newHashedPassword">Nueva contraseña hasheada.</param>
    public void ChangePassword(string newHashedPassword)
    {
        if (string.IsNullOrWhiteSpace(newHashedPassword))
            throw new ArgumentException("El hash de la contraseña no puede ser nulo o vacío.", nameof(newHashedPassword));

        Password = newHashedPassword;
    }

    /// <summary>
    /// Promueve el rol del usuario a Chef.
    /// </summary>
    public void PromoteToChef()
    {
        if (Role == UserRole.Apprentice)
        {
            Role = UserRole.Chef;
        }
    }

    /// <summary>
    /// Desactiva el usuario.
    /// </summary>
    public void Deactivate()
    {
        IsActive = false;
    }
}