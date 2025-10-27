using AutoMapper;
using CookingSharp.Application.Common.Exceptions;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Entities;


namespace CookingSharp.Application.Services;

/// <summary>
/// Implementación del servicio de gestión de menús.
/// </summary>
public class MenuService : IMenuService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public MenuService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    /// <summary>
    /// Crea un nuevo menú para un usuario.
    /// </summary>
    /// <param name="menuDto">El DTO con los datos del nuevo menú.</param>
    /// <param name="creatorUserId">El ID del usuario que crea el menú.</param>
    /// <returns>El DTO del menú recién creado.</returns>
    /// <exception cref="NotFoundException">Se lanza si el usuario o alguna receta no existen.</exception>
    public async Task<MenuResponseDTO> CreateAsync(MenuCreateUpdateDTO menuDto, int creatorUserId)
    {
        _ = await _unitOfWork.Users.GetByIdAsync(creatorUserId) ?? throw new NotFoundException(nameof(User), creatorUserId);

        var menu = new Menu(menuDto.Name, menuDto.Description, creatorUserId);

        foreach (var recipeId in menuDto.RecipeIds)
        {
            var recipe = await _unitOfWork.Recipes.GetByIdAsync(recipeId) ?? throw new BadRequestException($"La receta con ID '{recipeId}' no existe.");
            menu.AddRecipe(recipe);
        }

        await _unitOfWork.Menus.AddAsync(menu);
        await _unitOfWork.CompleteAsync();

        return _mapper.Map<MenuResponseDTO>(menu);
    }

    /// <summary>
    /// Obtiene todos los menús creados por un usuario específico.
    /// </summary>
    /// <param name="userId">El ID del usuario (Chef).</param>
    /// <returns>Una colección de DTOs de menú.</returns>
    public async Task<IEnumerable<MenuResponseDTO>> GetMenusByUserAsync(int userId)
    {
        var userMenus = await _unitOfWork.Menus.GetMenusByUserWithRecipesAsync(userId);
        return _mapper.Map<IEnumerable<MenuResponseDTO>>(userMenus);
    }

    public async Task<IEnumerable<MenuSummaryDTO>> GetAllSummariesAsync()
    {
        var menus = await _unitOfWork.Menus.GetAllWithDetailsAsync();
        return _mapper.Map<IEnumerable<MenuSummaryDTO>>(menus);
    }

    /// <summary>
    /// Obtiene un menú por su ID.
    /// </summary>
    /// <param name="id">El ID del menú.</param>
    /// <returns>El DTO del menú encontrado.</returns>
    /// <exception cref="NotFoundException">Se lanza si el menú no existe.</exception>
    public async Task<MenuResponseDTO?> GetByIdAsync(int id)
    {
        var menu = await _unitOfWork.Menus.GetByIdWithDetailsAsync(id)
               ?? throw new NotFoundException(nameof(Menu), id);

        return _mapper.Map<MenuResponseDTO>(menu);
    }

    public async Task<IEnumerable<MenuSummaryDTO>> GetAllSummariesAsync(string? nameFilter = null, string? authorFilter = null)
    {
        var menus = await _unitOfWork.Menus.GetAllWithDetailsAsync(nameFilter, authorFilter);
        return _mapper.Map<IEnumerable<MenuSummaryDTO>>(menus);
    }

    /// <summary>
    /// Actualiza un menú existente.
    /// </summary>
    /// <param name="id">El ID del menú a actualizar.</param>
    /// <param name="menuDto">El DTO con los nuevos datos del menú.</param>
    /// <exception cref="NotFoundException">Se lanza si el menú o alguna receta no existen.</exception>
    public async Task UpdateAsync(int id, MenuCreateUpdateDTO menuDto)
    {
        var menu = await _unitOfWork.Menus.GetByIdAsync(id) ?? throw new NotFoundException(nameof(Menu), id);

        menu.UpdateDetails(menuDto.Name, menuDto.Description);

        // Limpiar recetas existentes y añadir las nuevas
        menu.Recipes.Clear();
        foreach (var recipeId in menuDto.RecipeIds)
        {
            var recipe = await _unitOfWork.Recipes.GetByIdAsync(recipeId) ?? throw new BadRequestException($"La receta con ID '{recipeId}' no existe.");
            menu.AddRecipe(recipe);
        }

        _unitOfWork.Menus.Update(menu);
        await _unitOfWork.CompleteAsync();
    }

    /// <summary>
    /// Elimina un menú por su ID.
    /// </summary>
    /// <param name="id">El ID del menú a eliminar.</param>
    /// <exception cref="NotFoundException">Se lanza si el menú no existe.</exception>
    public async Task DeleteAsync(int id)
    {
        var menu = await _unitOfWork.Menus.GetByIdAsync(id) ?? throw new NotFoundException(nameof(Menu), id);
        _unitOfWork.Menus.Delete(menu);
        await _unitOfWork.CompleteAsync();
    }
}