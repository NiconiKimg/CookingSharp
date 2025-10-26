using System;

namespace CookingSharp.Domain.Entities;

public class MenuRating : RatingBase
{
    public int MenuId { get; private set; }
    public Menu Menu { get; private set; }

    private MenuRating() { }

    public MenuRating(int stars, int userId, int menuId)
    {
        SetStars(stars);

        if (userId <= 0) throw new ArgumentException("El ID de usuario debe ser un valor positivo.", nameof(userId));
        if (menuId <= 0) throw new ArgumentException("El ID de menú debe ser un valor positivo.", nameof(menuId));

        UserId = userId;
        MenuId = menuId;
    }
}