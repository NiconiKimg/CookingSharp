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
        CreateMap<Recipe, RecipeResponseDTO>()
            .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => $"{src.User.Name} {src.User.Surname}"))
            .ForMember(dest => dest.AuthorId, opt => opt.MapFrom(src => src.User.Id));

        CreateMap<RecipeStep, RecipeStepResponseDTO>();
        CreateMap<RecipeStepCreateDTO, RecipeStep>(); // Asumiendo que se mapea a una entidad temporal

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
    }
}