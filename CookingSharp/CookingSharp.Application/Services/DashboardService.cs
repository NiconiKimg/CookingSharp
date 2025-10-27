using AutoMapper;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services;

public class DashboardService : IDashboardService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public DashboardService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<HomePageDTO> GetHomePageDataAsync()
    {
        // 1. Obtener las entidades del dominio usando los nuevos métodos del repositorio.
        var topRecipesEntities = await _unitOfWork.Recipes.GetTopRatedRecipesAsync(3);
        var topMenusEntities = await _unitOfWork.Menus.GetTopRatedMenusAsync(3);

        // 2. Usar AutoMapper para convertir las entidades a DTOs.
        var topRecipesDtos = _mapper.Map<List<RecipeSummaryDTO>>(topRecipesEntities);
        var topMenusDtos = _mapper.Map<List<MenuSummaryDTO>>(topMenusEntities);

        // 3. Devolver el DTO contenedor.
        return new HomePageDTO
        {
            TopRatedRecipes = topRecipesDtos,
            TopRatedMenus = topMenusDtos
        };
    }
}