using CookingSharp.Application.Services;
using CookingSharp.DTOs;
using CookingSharp.Domain.Model;

namespace CookingSharp.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.UseSwagger();
            app.UseSwaggerUI();

            app.MapGet("/categories", () =>
            {
                CategoryService categoryService = new CategoryService();

                var dtos = categoryService.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllCategories")
            .Produces<List<CategoryDTO>>(StatusCodes.Status200OK);
            //.WithOpenApi();

            app.Run();
        }
    }

}
