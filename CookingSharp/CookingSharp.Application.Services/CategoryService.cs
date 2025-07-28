using CookingSharp.DTOs;
using CookingSharp.Data;
using CookingSharp.Domain.Model;
using System.Runtime.CompilerServices;

namespace CookingSharp.Application.Services
{
    public class CategoryService
    {
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

        //public bool Delete(int id)

        public IEnumerable<CategoryDTO> GetAll()
        {
            return CategoryInMemory.Categories.Select(category => new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            }).ToList();
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
