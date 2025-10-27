using CookingSharp.Application.Contracts;
using CookingSharp.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace CookingSharp.Infrastructure.Persistence.Repositories
{
    /// <summary>
    /// Implementación del patrón Unit of Work que gestiona el contexto de la base de datos
    /// y proporciona acceso a todos los repositorios.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CookingSharpDbContext _context;

        public IUserRepository Users { get; private set; }
        public IRecipeRepository Recipes { get; private set; }
        public ICategoryRepository Categories { get; private set; }
        public ICommentRepository Comments { get; private set; }
        public IRatingRepository Ratings { get; private set; }
        public IMenuRepository Menus { get; private set; }
        public IAppealRepository Appeals { get; private set; }
        public IMenuRatingRepository MenuRatings { get; private set; }
        public IRecipeAnalysisRepository RecipeAnalysis { get; private set; }
        public ICategoryPerformanceRepository CategoryPerformance { get; private set; }

        public UnitOfWork(CookingSharpDbContext context, IConfiguration configuration)
        {
            _context = context;

            Users = new UserRepository(_context);
            Recipes = new RecipeRepository(_context);
            Categories = new CategoryRepository(_context);
            Comments = new CommentRepository(_context);
            Ratings = new RatingRepository(_context);
            Menus = new MenuRepository(_context);
            Appeals = new AppealRepository(_context);
            MenuRatings = new MenuRatingRepository(_context);
            RecipeAnalysis = new RecipeAnalysisRepository(configuration);
            CategoryPerformance = new CategoryPerformanceRepository(configuration);
        }

        /// <summary>
        /// Guarda todos los cambios pendientes en la base de datos como una única transacción.
        /// </summary>
        /// <returns>El número de filas afectadas.</returns>
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Libera los recursos del contexto de la base de datos.
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}