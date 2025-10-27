using AutoMapper;
using CookingSharp.Application.DTOs;
using CookingSharp.Domain.Entities;

namespace CookingSharp.Application.Common.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // User Mappings
        CreateMap<User, UserResponseDTO>();

        // Category Mappings
        CreateMap<Category, CategoryResponseDTO>();
        CreateMap<CategoryCreateUpdateDTO, Category>();

        // Recipe Mappings
        CreateMap<Recipe, RecipeSummaryDTO>()
            .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => $"{src.User.Name} {src.User.Surname}"))
            .ForMember(dest => dest.AuthorId, opt => opt.MapFrom(src => src.User.Id))
            .ForMember(dest => dest.AverageRating, opt => opt.MapFrom(src => src.Ratings.Any() ? src.Ratings.Average(r => r.Stars) : 0.0))
            .ForMember(dest => dest.RatingsCount, opt => opt.MapFrom(src => src.Ratings.Count));

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

        // Appeal Mappings
        CreateMap<Appeal, AppealResponseDTO>()
            .ForMember(dest => dest.ApplicantName, opt => opt.MapFrom(src => $"{src.User.Name} {src.User.Surname}"))
            .ForMember(dest => dest.ApplicantId, opt => opt.MapFrom(src => src.User.Id));

        // Menu Mappings
        CreateMap<Menu, MenuResponseDTO>();

        // Menu Summary Mapping
        CreateMap<Menu, MenuSummaryDTO>()
            .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.User.Name))
            .ForMember(dest => dest.RecipeCount, opt => opt.MapFrom(src => src.Recipes.Count))
            .ForMember(dest => dest.AverageRating, opt => opt.MapFrom(src =>
                src.Ratings.Any() ? src.Ratings.Average(r => r.Stars) : 0.0));

        // Recipe Summary Mapping
        CreateMap<Recipe, RecipeSummaryDTO>()
            .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.User.Name))
            .ForMember(dest => dest.AverageRating, opt => opt.MapFrom(src =>
                src.Ratings.Any() ? src.Ratings.Average(r => r.Stars) : 0.0));
    }
}