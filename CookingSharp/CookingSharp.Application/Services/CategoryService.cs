using AutoMapper;
using CookingSharp.Application.Common.Exceptions;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services;

/// <summary>
/// Implementación del servicio de gestión de categorías.
/// </summary>
public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    /// <summary>
    /// Crea una nueva categoría de forma asíncrona.
    /// </summary>
    /// <param name="categoryDto">DTO con los datos de la nueva categoría.</param>
    /// <returns>El DTO de la categoría recién creada.</returns>
    /// <exception cref="BadRequestException">Se lanza si el nombre de la categoría ya existe.</exception>
    public async Task<CategoryResponseDTO> CreateAsync(CategoryCreateUpdateDTO categoryDto)
    {
        if (await _unitOfWork.Categories.ExistsWithNameAsync(categoryDto.Name))
        {
            throw new BadRequestException($"Una categoría con el nombre '{categoryDto.Name}' ya existe.");
        }

        var category = new Category(categoryDto.Name, categoryDto.Description);

        await _unitOfWork.Categories.AddAsync(category);
        await _unitOfWork.CompleteAsync();

        return _mapper.Map<CategoryResponseDTO>(category);
    }

    /// <summary>
    /// Obtiene todas las categorías de forma asíncrona, opcionalmente filtradas por un término de búsqueda.
    /// </summary>
    /// <param name="searchTerm">El término opcional para buscar en los nombres de las categorías.</param>
    /// <returns>Una colección de DTOs de categoría.</returns>
    public async Task<IEnumerable<CategoryResponseDTO>> GetAllAsync(string? searchTerm = null)
    {
        var categories = await _unitOfWork.Categories.GetAllAsync(searchTerm);
        return _mapper.Map<IEnumerable<CategoryResponseDTO>>(categories);
    }

    /// <summary>
    /// Obtiene una categoría por su ID de forma asíncrona.
    /// </summary>
    /// <param name="id">El ID de la categoría a buscar.</param>
    /// <returns>El DTO de la categoría encontrada.</returns>
    /// <exception cref="NotFoundException">Se lanza si no se encuentra la categoría.</exception>
    public async Task<CategoryResponseDTO?> GetByIdAsync(int id)
    {
        var category = await _unitOfWork.Categories.GetByIdAsync(id) ?? throw new NotFoundException(nameof(Category), id);
        return _mapper.Map<CategoryResponseDTO>(category);
    }

    /// <summary>
    /// Actualiza una categoría existente de forma asíncrona.
    /// </summary>
    /// <param name="id">El ID de la categoría a actualizar.</param>
    /// <param name="categoryDto">El DTO con los nuevos datos de la categoría.</param>
    /// <exception cref="NotFoundException">Se lanza si no se encuentra la categoría.</exception>
    /// <exception cref="BadRequestException">Se lanza si el nuevo nombre ya está en uso.</exception>
    public async Task UpdateAsync(int id, CategoryCreateUpdateDTO categoryDto)
    {
        var category = await _unitOfWork.Categories.GetByIdAsync(id) ?? throw new NotFoundException(nameof(Category), id);

        if (await _unitOfWork.Categories.ExistsWithNameAsync(categoryDto.Name, id))
        {
            throw new BadRequestException($"Una categoría con el nombre '{categoryDto.Name}' ya existe.");
        }

        category.UpdateDetails(categoryDto.Name, categoryDto.Description);

        _unitOfWork.Categories.Update(category);
        await _unitOfWork.CompleteAsync();
    }

    /// <summary>
    /// Elimina una categoría por su ID de forma asíncrona.
    /// </summary>
    /// <param name="id">El ID de la categoría a eliminar.</param>
    /// <exception cref="NotFoundException">Se lanza si no se encuentra la categoría.</exception>
    public async Task DeleteAsync(int id)
    {
        var category = await _unitOfWork.Categories.GetByIdAsync(id) ?? throw new NotFoundException(nameof(Category), id);
        _unitOfWork.Categories.Delete(category);
        await _unitOfWork.CompleteAsync();
    }

    /// <summary>
    /// Obtiene el número total de categorías de forma asíncrona.
    /// </summary>
    /// <returns>El número total de categorías.</returns>
    public async Task<int> GetTotalCountAsync()
    {
        return await _unitOfWork.Categories.CountAsync();
    }
}