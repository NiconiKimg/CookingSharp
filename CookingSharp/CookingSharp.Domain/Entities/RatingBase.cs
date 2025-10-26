using CookingSharp.Domain.Entities;

public abstract class RatingBase
{
    public int Id { get; protected set; }
    public int Stars { get; protected set; }
    public int UserId { get; protected set; }
    public User User { get; protected set; }

    public void SetStars(int newStars)
    {
        if (newStars < 1 || newStars > 5)
            throw new ArgumentOutOfRangeException(nameof(newStars), "La valoración debe estar entre 1 y 5 estrellas.");
        Stars = newStars;
    }
}