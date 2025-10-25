using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CookingSharp.WebAPI.Controllers;

public class CategoriesController : BaseApiController
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    #region --- GET Endpoints ---

    /// <summary>
    /// Obtiene una lista de todas las categorías (público).
    /// </summary>
    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var categories = await _categoryService.GetAllAsync();
        return Ok(categories);
    }

    /// <summary>
    /// Obtiene una categoría específica por su ID (público).
    /// </summary>
    [AllowAnonymous]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var category = await _categoryService.GetByIdAsync(id);
        return Ok(category);
    }

    #endregion

    #region --- POST, PUT, DELETE Endpoints (Admin Only) ---

    /// <summary>
    /// Crea una nueva categoría (solo para Admins).
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Create(CategoryCreateUpdateDTO categoryDto)
    {
        var createdCategory = await _categoryService.CreateAsync(categoryDto);
        return CreatedAtAction(nameof(GetById), new { id = createdCategory.Id }, createdCategory);
    }

    /// <summary>
    /// Actualiza una categoría existente (solo para Admins).
    /// </summary>
    [HttpPut("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Update(int id, CategoryCreateUpdateDTO categoryDto)
    {
        await _categoryService.UpdateAsync(id, categoryDto);
        return NoContent();
    }

    /// <summary>
    /// Elimina una categoría (solo para Admins).
    /// </summary>
    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Delete(int id)
    {
        await _categoryService.DeleteAsync(id);
        return NoContent();
    }

    #endregion
}