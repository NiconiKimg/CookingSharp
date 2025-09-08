using CookingSharp.DTOs;
using CookingSharp.Domain.Model;
using CookingSharp.Application.Services.Contracts;

namespace CookingSharp.Application.Services
{
    public class CategoryService
    {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        public async Task<CategoryDTO?> GetAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
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

        public async Task UpdateAsync(CategoryDTO dto)
        {
            var existingCategory = await _categoryRepository.GetByIdAsync(dto.Id);
            if (existingCategory == null)
            {
                throw new KeyNotFoundException($"Category with ID {dto.Id} not found.");
            }
            if (await _categoryRepository.ExistsWithNameAsync(dto.Name, dto.Id))
            {
                throw new ArgumentException("Category with the same name already exists.");
            }
            existingCategory.Name = dto.Name;
            existingCategory.Description = dto.Description;
            await _categoryRepository.UpdateAsync(existingCategory);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _categoryRepository.DeleteAsync(id);
        }
    }
}
