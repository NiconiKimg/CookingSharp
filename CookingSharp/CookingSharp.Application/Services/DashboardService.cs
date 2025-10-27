using AutoMapper;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services;

/// <summary>
/// Implementación del servicio para gestionar datos del dashboard.
/// </summary>
public class DashboardService : IDashboardService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public DashboardService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    /// <summary>
    /// Obtiene los datos para la página principal, incluyendo recetas y menús mejor valorados.
    /// </summary>
    /// <returns>DTO con los datos de la página principal.</returns>
    public async Task<HomePageDTO> GetHomePageDataAsync()
    {
        var topRecipesEntities = await _unitOfWork.Recipes.GetTopRatedRecipesAsync(3);
        var topMenusEntities = await _unitOfWork.Menus.GetTopRatedMenusAsync(3);

        var topRecipesDtos = _mapper.Map<List<RecipeSummaryDTO>>(topRecipesEntities);
        var topMenusDtos = _mapper.Map<List<MenuSummaryDTO>>(topMenusEntities);

        return new HomePageDTO
        {
            TopRatedRecipes = topRecipesDtos,
            TopRatedMenus = topMenusDtos
        };
    }
}