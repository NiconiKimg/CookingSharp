using CookingSharp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CookingSharp.Domain.Entities;

/// <summary>
/// Representa una receta de cocina, incluyendo sus detalles y pasos.
/// Protege su estado interno y gestiona su ciclo de vida.
/// </summary>
public class Recipe
{
    /// <summary>
    /// Identificador único de la receta.
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Título de la receta.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Breve descripción o sumario de la receta.
    /// </summary>
    public string Description { get; private set; }

    /// <summary>
    /// Estado del ciclo de vida de la receta (Borrador, Publicada, etc.).
    /// </summary>
    public RecipeStatus Status { get; private set; }

    /// <summary>
    /// Clave foránea del usuario que creó la receta.
    /// </summary>
    public int UserId { get; private set; }


    // Se usa un campo privado y una colección de solo lectura para proteger la lista de pasos.
    // La única forma de añadir o quitar pasos es a través de los métodos de la entidad
    private readonly List<RecipeStep> _steps = new();
    public IReadOnlyCollection<RecipeStep> Steps => _steps.AsReadOnly();

    public User User { get; private set; }
    public ICollection<Category> Categories { get; private set; } = new List<Category>();
    public ICollection<Comment> Comments { get; private set; } = new List<Comment>();
    public ICollection<Rating> Ratings { get; private set; } = new List<Rating>();
    public ICollection<Menu> Menus { get; private set; } = new List<Menu>();

    private Recipe() { }

    /// <summary>
    /// Constructor para crear una nueva receta válida.
    /// </summary>
    /// <param name="name">Título de la receta.</param>
    /// <param name="description">Descripción de la receta.</param>
    /// <param name="userId">ID del usuario creador.</param>
    public Recipe(string name, string description, int userId)
    {
        UpdateDetails(name, description);

        if (userId <= 0)
            throw new ArgumentException("El ID de usuario debe ser un valor positivo.", nameof(userId));

        UserId = userId;
        Status = RecipeStatus.Draft;
    }

    /// <summary>
    /// Actualiza los detalles textuales de la receta.
    /// </summary>
    public void UpdateDetails(string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("El nombre de la receta no puede ser nulo o vacío.", nameof(name));
        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("La descripción no puede ser nula o vacía.", nameof(description));

        Name = name;
        Description = description;
    }

    /// <summary>
    /// Añade un nuevo paso a la receta, calculando automáticamente el número de paso.
    /// </summary>
    /// <param name="instruction">El texto de la instrucción para el nuevo paso.</param>
    public void AddStep(string instruction)
    {
        var stepNumber = (_steps.Any() ? _steps.Max(s => s.StepNumber) : 0) + 1;
        _steps.Add(new RecipeStep(stepNumber, instruction, this.Id));
    }

    /// <summary>
    /// Elimina todos los pasos existentes de la receta. Útil para una actualización completa.
    /// </summary>
    public void ClearSteps()
    {
        _steps.Clear();
    }

    /// <summary>
    /// Cambia el estado de la receta a Publicada.
    /// </summary>
    public void Publish()
    {
        if (Status == RecipeStatus.Draft || Status == RecipeStatus.Archived)
            Status = RecipeStatus.Published;
    }

    /// <summary>
    /// Cambia el estado de la receta a Archivada.
    /// </summary>
    public void Archive()
    {
        if (Status == RecipeStatus.Published)
            Status = RecipeStatus.Archived;
    }

    /// <summary>
    /// Cambia el estado de la receta a Bloqueada (acción de administrador).
    /// </summary>
    public void Block() => Status = RecipeStatus.Blocked;

    /// <summary>
    /// Saca la receta del estado Bloqueada, devolviéndola a Borrador para su revisión.
    /// </summary>
    public void Unblock() => Status = RecipeStatus.Draft;
}