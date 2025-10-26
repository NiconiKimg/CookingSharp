using CookingSharp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CookingSharp.Domain.Entities;

/// <summary>
/// Representa a un usuario en el dominio del negocio.
/// Esta entidad protege sus invariantes (reglas) a través de setters privados y métodos de modificación.
/// </summary>
public class User
{
    /// <summary>
    /// Identificador único del usuario, generado por la base de datos.
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
    /// Hash de la contraseña del usuario. Nunca se debe almacenar la contraseña en texto plano.
    /// </summary>
    public string Password { get; private set; }

    /// <summary>
    /// Rol del usuario en el sistema (Admin, Chef, Apprentice).
    /// </summary>
    public UserRole Role { get; private set; }

    public ICollection<Recipe> Recipes { get; private set; } = new List<Recipe>();
    public ICollection<Menu> Menus { get; private set; } = new List<Menu>();
    public ICollection<Comment> Comments { get; private set; } = new List<Comment>();
    public ICollection<RecipeRating> RecipeRatings { get; private set; } = new List<RecipeRating>();
    public ICollection<MenuRating> MenuRatings { get; private set; } = new List<MenuRating>();
    public ICollection<Appeal> Appeals { get; private set; } = new List<Appeal>();

    /// <summary>
    /// Constructor privado sin parámetros requerido por EF Core para la materialización de entidades.
    /// </summary>
    private User() { }

    /// <summary>
    /// Constructor público para crear una nueva instancia de Usuario válida.
    /// </summary>
    /// <param name="name">Nombre del usuario.</param>
    /// <param name="surname">Apellido del usuario.</param>
    /// <param name="email">Correo electrónico del usuario.</param>
    /// <param name="hashedPassword">La contraseña ya hasheada.</param>
    public User(string name, string surname, string email, string hashedPassword)
    {
        UpdateProfile(name, surname, email);
        ChangePassword(hashedPassword);
        Role = UserRole.Apprentice; // Todos los usuarios nuevos comienzan como aprendices.
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
    /// Cambia la contraseña del usuario. Se espera que la nueva contraseña ya venga hasheada.
    /// </summary>
    public void ChangePassword(string newHashedPassword)
    {
        if (string.IsNullOrWhiteSpace(newHashedPassword))
            throw new ArgumentException("El hash de la contraseña no puede ser nulo o vacío.", nameof(newHashedPassword));

        Password = newHashedPassword;
    }

    /// <summary>
    /// Promueve el rol del usuario a Chef, únicamente si su rol actual es Aprendiz.
    /// </summary>
    public void PromoteToChef()
    {
        if (Role == UserRole.Apprentice)
        {
            Role = UserRole.Chef;
        }
    }
}