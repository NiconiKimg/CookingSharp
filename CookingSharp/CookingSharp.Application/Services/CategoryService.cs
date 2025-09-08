using CookingSharp.Application.DTOs;
using CookingSharp.Domain;
using CookingSharp.Application.Services.Contracts;

namespace CookingSharp.Application.Services
{
    /// <summary>
    /// Proporciona la lógica de negocio para gestionar las categorías.
    /// </summary>
    public class CategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        /// <summary>
        /// Obtiene una categoría por su identificador único.
        /// </summary>
        /// <param name="id">El ID de la categoría a buscar.</param>
        /// <returns>Un DTO de la categoría si se encuentra; de lo contrario, null.</returns>
        public async Task<CategoryDTO?> GetAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);

            if (category is null)
            {
                return null;
            }

            return new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            };
        }

        /// <summary>
        /// Obtiene todas las categorías existentes.
        /// </summary>
        /// <returns>Una colección de DTOs de todas las categorías.</returns>
        public async Task<IEnumerable<CategoryDTO>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return categories.Select(c => new CategoryDTO
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description
            });
        }

        /// <summary>
        /// Añade una nueva categoría al sistema.
        /// </summary>
        /// <param name="dto">El DTO con la información de la nueva categoría.</param>
        /// <returns>El DTO de la categoría recién creada con su ID asignado.</returns>
        public async Task<CategoryDTO> AddAsync(CategoryDTO dto)
        {
            if (await _categoryRepository.ExistsWithNameAsync(dto.Name))
            {
                throw new ArgumentException("Category with the same name already exists.");
            }

            var category = new Category(0, dto.Name, dto.Description);

            var addedCategory = await _categoryRepository.AddAsync(category);

            dto.Id = addedCategory.Id;

            return dto;
        }

        /// <summary>
        /// Actualiza una categoría existente.
        /// </summary>
        /// <param name="dto">El DTO con los datos actualizados de la categoría.</param>
        public async Task UpdateAsync(CategoryDTO dto)
        {
            var existingCategory = await _categoryRepository.GetByIdAsync(dto.Id);

            if (existingCategory is null)
            {
                throw new KeyNotFoundException($"Category with ID {dto.Id} not found.");
            }
            if (await _categoryRepository.ExistsWithNameAsync(dto.Name, dto.Id))
            {
                throw new ArgumentException("Category with the same name already exists.");
            }

            existingCategory.UpdateDetails(dto.Name, dto.Description);

            await _categoryRepository.UpdateAsync(existingCategory);
        }

        /// <summary>lica
        /// Elimina una categoría por su identificador único.
        /// </summary>
        /// <param name="id">El ID de la categoría a eliminar.</param>
        /// <returns>Verdadero si la eliminación fue exitosa, falso en caso contrario.</returns>
        public async Task<bool> DeleteAsync(int id)
        {
            return await _categoryRepository.DeleteAsync(id);
        }
    }
}