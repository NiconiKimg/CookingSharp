using System;
using System.Collections.Generic;

namespace CookingSharp.Domain.Entities;

/// <summary>
/// Representa una categoría para clasificar recetas (ej. "Postres", "Comida Italiana").
/// </summary>
public class Category
{
    /// <summary>
    /// Identificador único de la categoría.
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Nombre de la categoría.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Descripción detallada de la categoría.
    /// </summary>
    public string Description { get; private set; }

    public ICollection<Recipe> Recipes { get; private set; } = new List<Recipe>();

    private Category() { }

    /// <summary>
    /// Constructor para crear una nueva categoría válida.
    /// </summary>
    /// <param name="name">Nombre de la categoría.</param>
    /// <param name="description">Descripción de la categoría.</param>
    public Category(string name, string description)
    {
        UpdateDetails(name, description);
    }

    /// <summary>
    /// Actualiza los detalles de la categoría.
    /// </summary>
    public void UpdateDetails(string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("El nombre de la categoría no puede ser nulo o vacío.", nameof(name));
        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("La descripción no puede ser nula o vacía.", nameof(description));

        Name = name;
        Description = description;
    }
}