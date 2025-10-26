using AutoMapper;
using CookingSharp.Application.Common.Exceptions;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Entities;
using CookingSharp.Domain.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services
{
    /// <summary>
    /// Implementación del servicio de gestión de solicitudes para ser Chef.
    /// </summary>
    public class AppealService : IAppealService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AppealService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        /// <summary>
        /// Crea una nueva solicitud para convertirse en Chef de forma asíncrona.
        /// </summary>
        /// <param name="appealDto">El DTO con la descripción de la solicitud.</param>
        /// <param name="applicantUserId">El ID del usuario que realiza la solicitud.</param>
        /// <returns>El DTO de la solicitud recién creada.</returns>
        /// <exception cref="NotFoundException">Se lanza si el usuario no existe.</exception>
        /// <exception cref="BadRequestException">Se lanza si el usuario no es un Aprendiz.</exception>
        public async Task<AppealResponseDTO> CreateAsync(AppealCreateDTO appealDto, int applicantUserId)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(applicantUserId) ?? throw new NotFoundException(nameof(User), applicantUserId);
            if (user.Role != UserRole.Apprentice)
            {
                throw new BadRequestException("Solo los aprendices pueden solicitar ser chefs.");
            }

            var appeal = new Appeal(appealDto.Description, applicantUserId);

            await _unitOfWork.Appeals.AddAsync(appeal);
            await _unitOfWork.CompleteAsync();

            var createdAppealWithUser = await _unitOfWork.Appeals.GetByIdAsync(appeal.Id);
            return _mapper.Map<AppealResponseDTO>(createdAppealWithUser);
        }

        /// <summary>
        /// Procesa una solicitud, cambiándola a Aprobada o Rechazada, de forma asíncrona.
        /// </summary>
        /// <param name="id">El ID de la solicitud a procesar.</param>
        /// <param name="appealUpdateDto">El DTO con el nuevo estado.</param>
        /// <exception cref="NotFoundException">Se lanza si la solicitud no existe.</exception>
        /// <exception cref="BadRequestException">Se lanza si la solicitud ya fue procesada o el estado es inválido.</exception>
        public async Task ProcessAppealAsync(int id, AppealUpdateDTO appealUpdateDto)
        {
            var appeal = await _unitOfWork.Appeals.GetByIdAsync(id) ?? throw new NotFoundException(nameof(Appeal), id);

            if (appeal.Status != AppealStatus.Pending)
            {
                throw new BadRequestException("Esta solicitud ya ha sido procesada.");
            }

            if (appealUpdateDto.Status.Equals("Approved", System.StringComparison.OrdinalIgnoreCase))
            {
                appeal.Approve();
                var user = await _unitOfWork.Users.GetByIdAsync(appeal.UserId);
                user?.PromoteToChef();
            }
            else if (appealUpdateDto.Status.Equals("Rejected", System.StringComparison.OrdinalIgnoreCase))
            {
                appeal.Reject();
            }
            else
            {
                throw new BadRequestException("El estado proporcionado no es válido. Use 'Approved' o 'Rejected'.");
            }

            _unitOfWork.Appeals.Update(appeal);
            await _unitOfWork.CompleteAsync();
        }

        /// <summary>
        /// Obtiene todas las solicitudes que están actualmente pendientes de revisión.
        /// </summary>
        /// <returns>Una colección de DTOs de las solicitudes pendientes.</returns>
        public async Task<IEnumerable<AppealResponseDTO>> GetAllPendingAsync()
        {
            var pendingAppeals = await _unitOfWork.Appeals.GetPendingWithUserDetailsAsync();
            return _mapper.Map<IEnumerable<AppealResponseDTO>>(pendingAppeals);
        }

        /// <summary>
        /// Obtiene todas las solicitudes realizadas por un usuario específico.
        /// </summary>
        /// <param name="userId">El ID del usuario.</param>
        /// <returns>Una colección de DTOs de las solicitudes del usuario.</returns>
        public async Task<IEnumerable<AppealResponseDTO>> GetAppealsByUserAsync(int userId)
        {
            var allAppeals = await _unitOfWork.Appeals.GetAllAsync();
            var userAppeals = allAppeals.Where(a => a.UserId == userId);
            return _mapper.Map<IEnumerable<AppealResponseDTO>>(userAppeals);
        }

        /// <summary>
        /// Obtiene una solicitud por su ID.
        /// </summary>
        /// <param name="id">El ID de la solicitud.</param>
        /// <returns>El DTO de la solicitud encontrada.</returns>
        /// <exception cref="NotFoundException">Se lanza si la solicitud no existe.</exception>
        public async Task<AppealResponseDTO?> GetByIdAsync(int id)
        {
            var appeal = await _unitOfWork.Appeals.GetByIdAsync(id) ?? throw new NotFoundException(nameof(Appeal), id);
            return _mapper.Map<AppealResponseDTO>(appeal);
        }
    }
}