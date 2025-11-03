using Xunit;
using Moq;
using FluentAssertions;
using CookingSharp.Application.Services;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Domain.Entities;
using CookingSharp.Application.Common.Exceptions;
using AutoMapper;

namespace CookingSharp.Application.Tests
{
    public class CategoryServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly CategoryService _sut;

        public CategoryServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _mapperMock = new Mock<IMapper>();
            _sut = new CategoryService(_unitOfWorkMock.Object, _mapperMock.Object);
        }

        [Fact]
        public async Task CreateAsync_ShouldCreateCategory_WhenNameIsUnique()
        {
            // Arrange
            var categoryDto = new CategoryCreateUpdateDTO { Name = "Postres", Description = "Recetas dulces" };

            _unitOfWorkMock.Setup(uow => uow.Categories.ExistsWithNameAsync(categoryDto.Name, null))
                           .ReturnsAsync(false);

            _mapperMock.Setup(m => m.Map<CategoryResponseDTO>(It.IsAny<Category>()))
                       .Returns(new CategoryResponseDTO { Id = 1, Name = categoryDto.Name, Description = categoryDto.Description });

            // Act
            var result = await _sut.CreateAsync(categoryDto);

            // Assert
            result.Should().NotBeNull();
            result.Name.Should().Be(categoryDto.Name);
            _unitOfWorkMock.Verify(uow => uow.Categories.AddAsync(It.IsAny<Category>()), Times.Once);
            _unitOfWorkMock.Verify(uow => uow.CompleteAsync(), Times.Once);
        }

        [Fact]
        public async Task CreateAsync_ShouldThrowBadRequestException_WhenNameAlreadyExists()
        {
            // Arrange
            var categoryDto = new CategoryCreateUpdateDTO { Name = "Postres", Description = "Recetas dulces" };

            _unitOfWorkMock.Setup(uow => uow.Categories.ExistsWithNameAsync(categoryDto.Name, null))
                           .ReturnsAsync(true);

            // Act
            var action = async () => await _sut.CreateAsync(categoryDto);

            // Assert
            await action.Should().ThrowAsync<BadRequestException>()
                  .WithMessage($"Una categoría con el nombre '{categoryDto.Name}' ya existe.");

            _unitOfWorkMock.Verify(uow => uow.Categories.AddAsync(It.IsAny<Category>()), Times.Never);
            _unitOfWorkMock.Verify(uow => uow.CompleteAsync(), Times.Never);
        }

        [Fact]
        public async Task DeleteAsync_ShouldDeleteCategory_WhenCategoryExists()
        {
            // Arrange
            var categoryId = 1;
            var categoryEntity = new Category("Carnes", "Platos principales con carne");

            _unitOfWorkMock.Setup(uow => uow.Categories.GetByIdAsync(categoryId))
                           .ReturnsAsync(categoryEntity);

            // Act
            await _sut.DeleteAsync(categoryId);

            // Assert
            _unitOfWorkMock.Verify(uow => uow.Categories.Delete(categoryEntity), Times.Once);
            _unitOfWorkMock.Verify(uow => uow.CompleteAsync(), Times.Once);
        }
    }
}