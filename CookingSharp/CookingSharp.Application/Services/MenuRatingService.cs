using CookingSharp.Application.Common.Exceptions;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Entities;

namespace CookingSharp.Application.Services
{
    /// <summary>
    /// Implementación del servicio de valoración de menús.
    /// </summary>
    public class MenuRatingService : IMenuRatingService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MenuRatingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Añade o actualiza la valoración de un usuario para un menú específico.
        /// </summary>
        /// <param name="menuId">ID del menú a valorar.</param>
        /// <param name="ratingDto">DTO con la puntuación en estrellas.</param>
        /// <param name="userId">ID del usuario que realiza la valoración.</param>
        /// <exception cref="NotFoundException">Se lanza si el menú o el usuario no existen.</exception>
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