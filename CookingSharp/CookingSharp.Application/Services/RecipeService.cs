using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain;


namespace CookingSharp.Application.Services
{
    /// <summary>
    /// Proporciona la lógica de negocio para gestionar las recetas.
    /// </summary>
    public class RecipeService
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly IUserRepository _userRepository;
        private readonly ICategoryRepository _categoryRepository;

        public RecipeService(IRecipeRepository recipeRepository, IUserRepository userRepository, ICategoryRepository categoryRepository)
        {
            _recipeRepository = recipeRepository;
            _userRepository = userRepository;
            _categoryRepository = categoryRepository;
        }

        /// <summary>
        /// Obtiene una receta por su identificador único.
        /// </summary>
        public async Task<ResponseRecipeDTO?> GetAsync(int id)
        {
            var recipe = await _recipeRepository.GetByIdAsync(id);
            if (recipe is null)
            {
                return null;
            }
            return MapToDto(recipe);
        }

        /// <summary>
        /// Obtiene todas las recetas existentes.
        /// </summary>
        public async Task<IEnumerable<ResponseRecipeDTO>> GetAllAsync()
        {
            var recipes = await _recipeRepository.GetAllAsync();
            return recipes.Select(MapToDto);
        }

        /// <summary>
        /// Añade una nueva receta al sistema.
        /// </summary>
        /// <returns>El DTO de respuesta de la receta recién creada.</returns>
        public async Task<ResponseRecipeDTO> AddAsync(CreateRecipeDTO dto)
        {
            var user = await _userRepository.GetByIdAsync(dto.UserId);
            if (user is null)
            {
                throw new KeyNotFoundException($"Usuario con ID {dto.UserId} no encontrado.");
            }

            var categories = await ValidateAndGetCategoriesAsync(dto.CategoryIds);

            var recipe = new Recipe(dto.Description, dto.Content, dto.UserId)
            {
                Categories = categories
            };

            var addedRecipe = await _recipeRepository.AddAsync(recipe);

            return MapToDto(addedRecipe);
        }

        /// <summary>
        /// Actualiza una receta existente. Permite actualizaciones parciales.
        /// </summary>
        public async Task UpdateAsync(int id, UpdateRecipeDTO dto)
        {
            var existingRecipe = await _recipeRepository.GetByIdAsync(id);
            if (existingRecipe is null)
            {
                throw new KeyNotFoundException($"Receta con ID {id} no encontrada.");
            }

            var newDescription = dto.Description ?? existingRecipe.Description;
            var newContent = dto.Content ?? existingRecipe.Content;
            existingRecipe.Update(newDescription, newContent);

            if (!string.IsNullOrEmpty(dto.Status))
            {
                if (dto.Status.Equals(nameof(RecipeStatus.Published), StringComparison.OrdinalIgnoreCase))
                {
                    existingRecipe.Publish();
                }
                else if (dto.Status.Equals(nameof(RecipeStatus.Archived), StringComparison.OrdinalIgnoreCase))
                {
                    existingRecipe.Archive();
                }
            }

            if (dto.Categories != null)
            {
                var categoryIds = dto.Categories.Select(c => c.Id).ToList();
                existingRecipe.Categories = await ValidateAndGetCategoriesAsync(categoryIds);
            }

            await _recipeRepository.UpdateAsync(existingRecipe);
        }

        /// <summary>
        /// Elimina una receta por su identificador único.
        /// </summary>
        public async Task<bool> DeleteAsync(int id)
        {
            return await _recipeRepository.DeleteAsync(id);
        }

        /// <summary>
        /// Mapea una entidad de dominio Recipe a su DTO de respuesta.
        /// </summary>
        private ResponseRecipeDTO MapToDto(Recipe recipe)
        {
            return new ResponseRecipeDTO
            {
                Id = recipe.Id,
                Description = recipe.Description,
                Content = recipe.Content,
                Status = recipe.Status.ToString(),
                AuthorName = recipe.User?.Name ?? "Desconocido",
                Categories = recipe.Categories?.Select(c => new CategoryDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description
                }).ToList() ?? new List<CategoryDTO>()
            };
        }

        /// <summary>
        /// Método helper para validar una lista de IDs de categoría y devolver las entidades.
        /// </summary>
        private async Task<List<Category>> ValidateAndGetCategoriesAsync(List<int> categoryIds)
        {
            var categories = new List<Category>();
            foreach (var categoryId in categoryIds.Distinct()) // Usamos Distinct para evitar duplicados
            {
                var category = await _categoryRepository.GetByIdAsync(categoryId);
                if (category is null)
                {
                    throw new KeyNotFoundException($"Categoría con ID {categoryId} no encontrada.");
                }
                categories.Add(category);
            }
            return categories;
        }
    }
}