using CookingSharp.Application.Contracts;
using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSharp.Infrastructure.Persistence.Repositories;

public class CommentRepository : GenericRepository<Comment>, ICommentRepository
{
    public CommentRepository(CookingSharpDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Comment>> GetByRecipeIdWithUserAsync(int recipeId)
    {
        return await _dbSet
            .Include(c => c.User)
            .Where(c => c.RecipeId == recipeId)
            .ToListAsync();
    }
}