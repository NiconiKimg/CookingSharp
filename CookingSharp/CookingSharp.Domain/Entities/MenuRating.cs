using System;

namespace CookingSharp.Domain.Entities;

/// <summary>
/// Representa la valoración que un usuario otorga a un menú.
/// </summary>
public class MenuRating : RatingBase
{
    /// <summary>
    /// Clave foránea del menú calificado.
    /// </summary>
    public int MenuId { get; private set; }

    public Menu Menu { get; private set; }

    private MenuRating() { }

    /// <summary>
    /// Constructor para crear una nueva valoración de menú válida.
    /// </summary>
    /// <param name="stars">Número de estrellas (1-5).</param>
    /// <param name="userId">ID del usuario que realiza la valoración.</param>
    /// <param name="menuId">ID del menú calificado.</param>
    public MenuRating(int stars, int userId, int menuId)
    {
        SetStars(stars);

        if (userId <= 0) throw new ArgumentException("El ID de usuario debe ser un valor positivo.", nameof(userId));
        if (menuId <= 0) throw new ArgumentException("El ID de menú debe ser un valor positivo.", nameof(menuId));

        UserId = userId;
        MenuId = menuId;
    }
}