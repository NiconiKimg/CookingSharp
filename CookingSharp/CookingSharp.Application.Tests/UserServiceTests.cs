using Xunit;
using Moq;
using FluentAssertions;
using CookingSharp.Application.Services;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Domain.Entities;
using CookingSharp.Domain.Enums;
using CookingSharp.Application.Common.Exceptions;
using AutoMapper;

namespace CookingSharp.Application.Tests
{
    public class UserServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly UserService _sut;

        public UserServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _mapperMock = new Mock<IMapper>();
            _sut = new UserService(_unitOfWorkMock.Object, _mapperMock.Object);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnUser_WhenUserExists()
        {
            // Arrange
            var userId = 1;
            var user = new User("Nico", "Kimg", "nico@test.com", "hashedpassword");

            _unitOfWorkMock.Setup(uow => uow.Users.GetByIdAsync(userId)).ReturnsAsync(user);
            _mapperMock.Setup(m => m.Map<UserResponseDTO>(user))
                       .Returns(new UserResponseDTO { Id = userId, Name = user.Name });

            // Act
            var result = await _sut.GetByIdAsync(userId);

            // Assert
            result.Should().NotBeNull();
            result.Id.Should().Be(userId);
            result.Name.Should().Be(user.Name);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldThrowNotFoundException_WhenUserDoesNotExist()
        {
            // Arrange
            var userId = 99;
            _unitOfWorkMock.Setup(uow => uow.Users.GetByIdAsync(userId)).ReturnsAsync((User)null);

            // Act
            var action = async () => await _sut.GetByIdAsync(userId);

            // Assert
            await action.Should().ThrowAsync<NotFoundException>();
        }

        [Fact]
        public async Task DeleteAsync_ShouldDeactivateUser_WhenUserIsNotAdmin()
        {
            // Arrange
            var userId = 2;
            var userToDelete = new User("Chef", "Test", "chef@test.com", "hashedpassword");
            userToDelete.PromoteToChef();

            _unitOfWorkMock.Setup(uow => uow.Users.GetByIdAsync(userId)).ReturnsAsync(userToDelete);

            // Act
            await _sut.DeleteAsync(userId);

            // Assert
            userToDelete.IsActive.Should().BeFalse();
            _unitOfWorkMock.Verify(uow => uow.Users.Update(userToDelete), Times.Once);
            _unitOfWorkMock.Verify(uow => uow.CompleteAsync(), Times.Once);
        }

        [Fact]
        public async Task DeleteAsync_ShouldThrowBadRequestException_WhenAttemptingToDeleteAdmin()
        {
            // Arrange
            var adminId = 1;
            // No podemos instanciar un admin directamente, así que creamos un usuario y lo "forzamos"
            var adminUser = new User("Admin", "User", "admin@test.com", "hashedpassword");
            // Usamos reflexión para simular que este usuario es Admin, ya que el constructor no lo permite
            typeof(User).GetProperty(nameof(User.Role)).SetValue(adminUser, UserRole.Admin, null);

            _unitOfWorkMock.Setup(uow => uow.Users.GetByIdAsync(adminId)).ReturnsAsync(adminUser);

            // Act
            var action = async () => await _sut.DeleteAsync(adminId);

            // Assert
            await action.Should().ThrowAsync<BadRequestException>()
                  .WithMessage("No está permitido eliminar a otro administrador.");

            _unitOfWorkMock.Verify(uow => uow.Users.Update(It.IsAny<User>()), Times.Never);
            _unitOfWorkMock.Verify(uow => uow.CompleteAsync(), Times.Never);
        }
    }
}