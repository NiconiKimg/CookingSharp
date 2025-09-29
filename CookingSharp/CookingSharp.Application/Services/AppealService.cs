 using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain;
using System.Data;
using static CookingSharp.Domain.User;

namespace CookingSharp.Application.Services
{
    /// <summary>
    /// Proporciona la lógica de negocio para gestionar las categorías.
    /// </summary>
    public class AppealService
    {
        private readonly IAppealRepository _appealRepository;
        private readonly IUserRepository _userRepository;

        public AppealService(IAppealRepository appealRepository, IUserRepository userRepository)
        {
            _appealRepository = appealRepository;
            _userRepository = userRepository;
        }

        /// <summary>
        /// Obtiene una categoría por su identificador único.
        /// </summary>
        /// <param name="id">El ID de la categoría a buscar.</param>
        /// <returns>Un DTO de la categoría si se encuentra; de lo contrario, null.</returns>
        public async Task<AppealDTO?> GetAsync(int id)
        {
            var appeal = await _appealRepository.GetByIdAsync(id);

            if (appeal is null)
            {
                return null;
            }

            return new AppealDTO
            {
                Id = appeal.Id,
                Description = appeal.Description,
                Status = appeal.Status.ToString(),
                UserId = appeal.UserId,
                UserName = appeal.User?.Name
            };
        }

        /// <summary>
        /// Obtiene todas las solicitudes existentes.
        /// </summary>
        /// <returns>Una colección de DTOs de todas las solicitudes.</returns>
        public async Task<IEnumerable<AppealDTO>> GetAllAsync()
        {
            var appeals = await _appealRepository.GetAllAsync();
            return appeals.Select(a => new AppealDTO
            {
                Id = a.Id,
                Status = a.Status.ToString(),
                Description = a.Description,
                UserId = a.UserId,
                UserName = a.User?.Name
            });
        }

        /// <summary>
        /// Obtiene todas las solicitudes existentes para un id de usuario.
        /// </summary>
        /// <returns>Una colección de DTOs de todas las solicitudes para ese usuario.</returns>
        public async Task<IEnumerable<AppealDTO>> GetAllAsyncMy(int idUsuario)
        {

            var appeals = await _appealRepository.GetAllAsync();
            return appeals.Select(a => new AppealDTO
            {
                Id = a.Id,
                Status = a.Status.ToString(),
                Description = a.Description,
                UserId = a.UserId,
                UserName = a.User?.Name
            });
        }

        /// <summary>
        /// Añade una nueva categoría al sistema.
        /// </summary>
        /// <param name="dto">El DTO con la información de la nueva categoría.</param>
        /// <returns>El DTO de la categoría recién creada con su ID asignado.</returns>
        public async Task<AppealDTO> AddAsync(AppealDTO dto)
        {

            var userExists = await _userRepository.GetByIdAsync(dto.UserId);
            if (userExists == null)
            {
                throw new KeyNotFoundException($"User with ID {dto.UserId} not found.");
            }

            var appeal = new Appeal(0, dto.Description, dto.UserId);

            var addedAppeal = await _appealRepository.AddAsync(appeal);
            dto.Id = addedAppeal.Id;

            return dto;
        }

        /// <summary>
        /// Actualiza una solicitud existente.
        /// </summary>
        /// <param name="dto">El DTO con los datos actualizados de la solicitud.</param>
        public async Task UpdateAsync(int appealId, UpdateAppealDTO dto)
        {
            var existingAppeal = await _appealRepository.GetByIdAsync(appealId);
            if (existingAppeal is null)
            {
                throw new KeyNotFoundException($"Solicitud con ID {appealId} no encontrada.");
            }

            existingAppeal.UpdateStatus(dto.Status);

            if (string.Equals(dto.Status, nameof(RoleTypes.Chef), StringComparison.OrdinalIgnoreCase) ||
                string.Equals(dto.Status, "Approved", StringComparison.OrdinalIgnoreCase)) 
            {
                var user = await _userRepository.GetByIdAsync(existingAppeal.UserId);
                if (user is null)
                {
                    throw new KeyNotFoundException($"El usuario con ID {existingAppeal.UserId} asociado a esta solicitud no fue encontrado.");
                }

                user.PromoteToChef();

                await _userRepository.UpdateAsync(user);
            }

            await _appealRepository.UpdateAsync(existingAppeal);
        }
    }
}