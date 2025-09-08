namespace CookingSharp.Domain.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Category(int id, string name, string description)
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("El nombre de la categoría no puede ser nulo o vacío.", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("La descripción de la categoría no puede ser nula o vacía.", nameof(description));
            }

            Id = id;
            Name = name;
            Description = description;
        }

    }
}
