using CookingSharp.Application.Common.Exceptions;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Entities;

namespace CookingSharp.Application.Services
{
    public class MenuRatingService : IMenuRatingService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MenuRatingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task RateMenuAsync(int menuId, RatingCreateUpdateDTO ratingDto, int userId)
        {
            _ = await _unitOfWork.Menus.GetByIdAsync(menuId) ?? throw new NotFoundException(nameof(Menu), menuId);
            _ = await _unitOfWork.Users.GetByIdAsync(userId) ?? throw new NotFoundException(nameof(User), userId);

            var existingRating = (await _unitOfWork.MenuRatings.GetAllAsync())
                .FirstOrDefault(r => r.MenuId == menuId && r.UserId == userId);

            if (existingRating is null)
            {
                var newRating = new MenuRating(ratingDto.Stars, userId, menuId);
                await _unitOfWork.MenuRatings.AddAsync(newRating);
            }
            else
            {
                existingRating.SetStars(ratingDto.Stars);
                _unitOfWork.MenuRatings.Update(existingRating);
            }

            await _unitOfWork.CompleteAsync();
        }
    }
}