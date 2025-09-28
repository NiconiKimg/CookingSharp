namespace CookingSharp.Domain
{
    /// <summary>
    /// Representa una solicitud para ser cocinero en el dominio del negocio.
    /// Esta entidad es responsable de mantener su propio estado consistente a través de validaciones internas.
    /// </summary>
    public class Appeal
    {
        public enum StatusType { Pending, Aproved, Rejected }; 

        /// <summary>
        /// Identificador único de la solicitud.
        /// </summary>
        public int Id { get; set; }

        public StatusType Status { get; private set; }

        public string Description { get; private set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
        /// <summary>
        /// Constructor para crear una nueva instancia de Solicitud.
        /// </summary>
        public Appeal(int id, string description, int userId)
        {
            Id = id;
            Description = description;
            Status = StatusType.Pending;
            UserId = userId;
        }

        private Appeal() { } // For EF

        /// <summary>
        /// Actualiza los detalles de la solicitud, aplicando las reglas de validación del dominio.
        /// Este es el único punto a través del cual se deben modificar las propiedades de la entidad.
        /// </summary>
        public void UpdateStatus(string NewStatus)
        {

            if (NewStatus == StatusType.Aproved.ToString())
            {
                Status = StatusType.Aproved;          
            }
            if (NewStatus == StatusType.Rejected.ToString())
            {
                Status = StatusType.Rejected;
            }
            else
            {
                throw new Exception("Seleccione una acción válida");
            }

        }
    }
}