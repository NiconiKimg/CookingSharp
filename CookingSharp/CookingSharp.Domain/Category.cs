namespace CookingSharp.Domain
{
    /// <summary>
    /// Representa una categoría de recetas en el dominio del negocio.
    /// Esta entidad es responsable de mantener su propio estado consistente a través de validaciones internas.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Identificador único de la categoría.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la categoría.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Descripción detallada de lo que representa la categoría.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Constructor para crear una nueva instancia de Categoría.
        /// </summary>
        public Category(int id, string name, string description)
        {
            Id = id;
            UpdateDetails(name, description);
        }

        /// <summary>
        /// Actualiza los detalles de la categoría, aplicando las reglas de validación del dominio.
        /// Este es el único punto a través del cual se deben modificar las propiedades de la entidad.
        /// </summary>
        public void UpdateDetails(string newName, string newDescription)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("El nombre de la categoría no puede ser nulo o vacío.", nameof(newName));
            }

            if (string.IsNullOrWhiteSpace(newDescription))
            {
                throw new ArgumentException("La descripción de la categoría no puede ser nula o vacía.", nameof(newDescription));
            }

            Name = newName;
            Description = newDescription;
        }
    }
}