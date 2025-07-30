using CookingSharp.DTOs;
using CookingSharp.Data;
using CookingSharp.Domain.Model;
using System.Runtime.CompilerServices;

namespace CookingSharp.Application.Services
{
    public class CategoryService
    {
        public CategoryDTO Get(int id)
        {
            Category? category = CategoryInMemory.Categories.Find(c => c.Id == id);
            if (category == null)
            {
                throw new KeyNotFoundException($"Category with ID {id} not found.");
            }
            return new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            };
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
            return CategoryInMemory.Categories.Select(category => new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            }).ToList();
        }

        public CategoryDTO Add(CategoryDTO dto)
        {
            if(CategoryInMemory.Categories.Any(c => c.Name.Equals(dto.Name, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("Category with the same name already exists.");
            }

            var id = GetNextId();

            Category category = new Category(id, dto.Name, dto.Description);

            CategoryInMemory.Categories.Add(category);

            dto.Id = category.Id;

            return dto;
        }

        public bool Update(CategoryDTO dto)
        {
            Category? existingCategory = CategoryInMemory.Categories.Find(c => c.Id == dto.Id);

            if (existingCategory == null)
            {
                throw new KeyNotFoundException($"Category with ID {dto.Id} not found.");
            }

            if (CategoryInMemory.Categories.Any(c => c.Name.Equals(dto.Name, StringComparison.OrdinalIgnoreCase) && c.Id != dto.Id))
            {
                throw new ArgumentException("Category with the same name already exists.");
            }

            existingCategory.Name = dto.Name;
            existingCategory.Description = dto.Description;
            return true;
        }

        public bool Delete(int id)
        {
            Category? categoryToDelete = CategoryInMemory.Categories.Find(c => c.Id == id);

            if (categoryToDelete == null)
            {
                return false;
            }

            CategoryInMemory.Categories.Remove(categoryToDelete);
            return true;
        }

        private static int GetNextId()
        {
            if (CategoryInMemory.Categories.Count == 0)
            {
                return 1;
            }
            return CategoryInMemory.Categories.Max(c => c.Id) + 1;
        }
    }
}
