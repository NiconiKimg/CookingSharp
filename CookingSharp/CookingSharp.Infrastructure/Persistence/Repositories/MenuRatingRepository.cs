using CookingSharp.Application.Contracts;
using CookingSharp.Domain.Entities;
using CookingSharp.Infrastructure.Persistence;

namespace CookingSharp.Infrastructure.Persistence.Repositories
{
    public class MenuRatingRepository : GenericRepository<MenuRating>, IMenuRatingRepository
    {
        public MenuRatingRepository(CookingSharpDbContext context) : base(context)
        {
        }
    }
}