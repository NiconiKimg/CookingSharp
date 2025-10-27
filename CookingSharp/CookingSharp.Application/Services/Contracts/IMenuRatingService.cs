using CookingSharp.Application.DTOs;

namespace CookingSharp.Application.Services.Contracts
{
    public interface IMenuRatingService
    {
        Task RateMenuAsync(int menuId, RatingCreateUpdateDTO ratingDto, int userId);
    }
}