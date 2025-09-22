using CookingSharp.Application.DTOs;
using CookingSharp.Domain;
using CookingSharp.Application.Services.Contracts;

namespace CookingSharp.Application.Services
{
    /// <summary>
    /// Proporciona la lógica de negocio para gestionar las categorías.
    /// </summary>
    public class AppealService
    {
        private readonly IAppealRepository _appealRepository;

        public AppealService(IAppealRepository appealRepository)
        {
            _appealRepository = appealRepository;
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
                Description = a.Description
            });
        }

        /// <summary>
        /// Añade una nueva categoría al sistema.
        /// </summary>
        /// <param name="dto">El DTO con la información de la nueva categoría.</param>
        /// <returns>El DTO de la categoría recién creada con su ID asignado.</returns>
        public async Task<AppealDTO> AddAsync(AppealDTO dto)
        {

            var appeal = new Appeal(0, dto.Description);

            var addedAppeal = await _appealRepository.AddAsync(appeal);

            dto.Id = addedAppeal.Id;

            return dto;
        }

        /// <summary>
        /// Actualiza una solicitud existente.
        /// </summary>
        /// <param name="dto">El DTO con los datos actualizados de la solicitud.</param>
        public async Task UpdateAsync(AppealDTO dto)
        {
            var existingAppeal = await _appealRepository.GetByIdAsync(dto.Id);

            if (existingAppeal is null)
            {
                throw new KeyNotFoundException($"Appeal with ID {dto.Id} not found.");
            }

            existingAppeal.UpdateStatus(dto.Status);

            await _appealRepository.UpdateAsync(existingAppeal);
        }
    }
}