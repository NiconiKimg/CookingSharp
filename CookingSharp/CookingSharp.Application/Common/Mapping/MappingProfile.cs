using AutoMapper;
using CookingSharp.Application.DTOs;
using CookingSharp.Domain.Entities;

namespace CookingSharp.Application.Common.Mapping;

/// <summary>
/// Perfil de mapeo de AutoMapper que define las conversiones entre entidades de dominio y DTOs.
/// </summary>
public class MappingProfile : Profile
{
    /// <summary>
    /// Constructor que configura todos los mapeos del sistema.
    /// </summary>
    public MappingProfile()
    {
        CreateMap<User, UserResponseDTO>();

        CreateMap<Category, CategoryResponseDTO>();
        CreateMap<CategoryCreateUpdateDTO, Category>();
        CreateMap<Recipe, RecipeSummaryDTO>()
            .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => $"{src.User.Name} {src.User.Surname}"))
            .ForMember(dest => dest.AuthorId, opt => opt.MapFrom(src => src.User.Id))
            .ForMember(dest => dest.AverageRating, opt => opt.MapFrom(src => src.Ratings.Any() ? src.Ratings.Average(r => r.Stars) : 0.0))
            .ForMember(dest => dest.RatingsCount, opt => opt.MapFrom(src => src.Ratings.Count))
            .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.Categories));

        CreateMap<Recipe, RecipeResponseDTO>()
            .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => $"{src.User.Name} {src.User.Surname}"))
            .ForMember(dest => dest.AuthorId, opt => opt.MapFrom(src => src.User.Id))
            .ForMember(dest => dest.AverageRating, opt => opt.MapFrom(src => src.Ratings.Any() ? src.Ratings.Average(r => r.Stars) : 0.0))
            .ForMember(dest => dest.RatingsCount, opt => opt.MapFrom(src => src.Ratings.Count));

        CreateMap<RecipeStep, RecipeStepResponseDTO>();
        CreateMap<RecipeStepCreateDTO, RecipeStep>();

        // Comment Mappings
        CreateMap<Comment, CommentResponseDTO>()
            .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => $"{src.User.Name} {src.User.Surname}"))
            .ForMember(dest => dest.AuthorId, opt => opt.MapFrom(src => src.User.Id));

        CreateMap<Appeal, AppealResponseDTO>()
            .ForMember(dest => dest.ApplicantName, opt => opt.MapFrom(src => $"{src.User.Name} {src.User.Surname}"))
            .ForMember(dest => dest.ApplicantId, opt => opt.MapFrom(src => src.User.Id));

        CreateMap<Menu, MenuResponseDTO>()
            .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => $"{src.User.Name} {src.User.Surname}"))
            .ForMember(dest => dest.AverageRating, opt => opt.MapFrom(src => src.Ratings.Any() ? src.Ratings.Average(r => r.Stars) : 0.0))
            .ForMember(dest => dest.RatingsCount, opt => opt.MapFrom(src => src.Ratings.Count));

        CreateMap<Menu, MenuSummaryDTO>()
            .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => $"{src.User.Name} {src.User.Surname}"))
            .ForMember(dest => dest.RecipeCount, opt => opt.MapFrom(src => src.Recipes.Count))
            .ForMember(dest => dest.AverageRating, opt => opt.MapFrom(src =>
                src.Ratings.Any() ? src.Ratings.Average(r => r.Stars) : 0.0));

        CreateMap<Recipe, RecipeSummaryDTO>()
            .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.User.Name))
            .ForMember(dest => dest.AverageRating, opt => opt.MapFrom(src =>
                src.Ratings.Any() ? src.Ratings.Average(r => r.Stars) : 0.0));
    }
}