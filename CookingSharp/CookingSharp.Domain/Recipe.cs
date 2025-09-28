namespace CookingSharp.Domain
{
    public enum RecipeStatus
    {
        Draft,      // Borrador
        Published,  // Publicada
        Archived,   // Archivada
        Blocked     //Bloqueada
    }

    public class Recipe
    {
        public int Id { get; set; }
        public RecipeStatus Status { get; private set; }
        public string Description { get; private set; }
        public string Content { get; private set; }
        public int UserId { get; private set; }
        public virtual User User { get; private set; }
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        public Recipe(string description, string content, int userId)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("La descripción no puede ser nula o vacía.", nameof(description));
            }
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("El contenido de la receta no puede ser nulo o vacío.", nameof(content));
            }

            Description = description;
            Content = content;
            UserId = userId;
            Status = RecipeStatus.Draft;
        }

        public void Update(string newDescription, string newContent)
        {
            if (string.IsNullOrWhiteSpace(newDescription))
            {
                throw new ArgumentException("La descripción no puede ser nula o vacía.", nameof(newDescription));
            }
            if (string.IsNullOrWhiteSpace(newContent))
            {
                throw new ArgumentException("El contenido de la receta no puede ser nulo o vacío.", nameof(newContent));
            }
            Description = newDescription;
            Content = newContent;
        }

        public void Publish()
        {
            Status = RecipeStatus.Published;
        }

        public void Archive()
        {
            Status = RecipeStatus.Archived;
        }

        public void Block()
        {
            Status = RecipeStatus.Blocked;
        }

        // Constructor privado para EF Core
        private Recipe() { }
    }
}