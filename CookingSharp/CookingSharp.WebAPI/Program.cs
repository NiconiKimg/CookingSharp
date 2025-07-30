using CookingSharp.Application.Services;
using CookingSharp.DTOs;

namespace CookingSharp.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //builder.Services.AddOpenApi(); -> CHECK
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.UseSwagger();
            app.UseSwaggerUI();

            #region Categories
            //GetAll of categories
            app.MapGet("/categories", () =>
            {
                CategoryService categoryService = new CategoryService();

                var dtos = categoryService.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllCategories")
            .Produces<List<CategoryDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            //Get category by id
            app.MapGet("/categories/{id:int}", (int id) =>
            {
                CategoryService categoryService = new CategoryService();
                try
                {
                    var dto = categoryService.Get(id);
                    return Results.Ok(dto);
                }
                catch (KeyNotFoundException)
                {
                    return Results.NotFound();
                }
            })
            .WithName("GetCategories")
            .Produces<CategoryDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            //Add category
            app.MapPost("/categories", (CategoryDTO dto) =>
            {
                CategoryService categoryService = new CategoryService();
                try
                {
                    var addedDto = categoryService.Add(dto);
                    return Results.Created($"/categories/{addedDto.Id}", addedDto);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(ex.Message);
                }
            })
            .WithName("AddCategory")
            .Produces<CategoryDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();


            //Update category
            app.MapPut("/categories", (CategoryDTO dto) =>
            {
                CategoryService categoryService = new CategoryService();
                try
                {
                    if (categoryService.Update(dto))
                    {
                        return Results.Ok(dto);
                    }
                    else
                    {
                        return Results.NotFound();
                    }
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message});
                }
            })
            .WithName("UpdateCategory")
            .Produces<CategoryDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();


            //Delete category
            app.MapDelete("/categories/{id:int}", (int id) =>
            {
                CategoryService categoryService = new CategoryService();
                try
                {
                    if (categoryService.Delete(id))
                    {
                        return Results.NoContent();
                    }
                    else
                    {
                        return Results.NotFound();
                    }
                }
                catch (KeyNotFoundException)
                {
                    return Results.NotFound();
                }
            })
            .WithName("DeleteCategory")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            #endregion
            
            app.Run();
        }
    }

}
