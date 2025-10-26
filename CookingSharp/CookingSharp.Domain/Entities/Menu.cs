namespace CookingSharp.Domain.Entities;

/// <summary>
/// Representa un menú creado por un Chef, que agrupa una colección de recetas.
/// </summary>
public class Menu
{
    /// <summary>
    /// Identificador único del menú.
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Nombre del menú (ej. "Cena de Fin de Semana").
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Descripción del propósito o tema del menú.
    /// </summary>
    public string Description { get; private set; }

    /// <summary>
    /// Clave foránea del usuario (Chef) que creó el menú.
    /// </summary>
    public int UserId { get; private set; }

    public User User { get; private set; }
    public ICollection<Recipe> Recipes { get; private set; } = [];
    public ICollection<MenuRating> Ratings { get; private set; } = new List<MenuRating>();

    private Menu() { }

    /// <summary>
    /// Constructor para crear un nuevo menú válido.
    /// </summary>
    /// <param name="name">Nombre del menú.</param>
    /// <param name="description">Descripción del menú.</param>
    /// <param name="userId">ID del usuario creador.</param>
    public Menu(string name, string description, int userId)
    {
        UpdateDetails(name, description);

        if (userId <= 0)
            throw new ArgumentException("El ID de usuario debe ser un valor positivo.", nameof(userId));

        UserId = userId;
    }

    /// <summary>
    /// Actualiza los detalles del menú.
    /// </summary>
    public void UpdateDetails(string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("El nombre del menú no puede ser nulo o vacío.", nameof(name));
        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("La descripción del menú no puede ser nula o vacía.", nameof(description));

        Name = name;
        Description = description;
    }

    /// <summary>
    /// Añade una receta a la colección del menú.
    /// </summary>
    public void AddRecipe(Recipe recipe)
    {
        // TODO: añadir lógica para evitar duplicados si fuera un requisito.
        Recipes.Add(recipe);
    }

    /// <summary>
    /// Elimina una receta de la colección del menú.
    /// </summary>
    public void RemoveRecipe(Recipe recipe)
    {
        Recipes.Remove(recipe);
    }
}