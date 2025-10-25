using System;

namespace CookingSharp.Domain.Entities;

/// <summary>
/// Representa un paso individual en la preparación de una receta.
/// </summary>
public class RecipeStep
{
    /// <summary>
    /// Identificador único del paso.
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Número de orden del paso dentro de la receta (1, 2, 3...).
    /// </summary>
    public int StepNumber { get; private set; }

    /// <summary>
    /// Descripción textual de la instrucción a seguir en este paso.
    /// </summary>
    public string Instruction { get; private set; }

    /// <summary>
    /// Clave foránea de la receta a la que pertenece este paso.
    /// </summary>
    public int RecipeId { get; private set; }

    public Recipe Recipe { get; private set; }

    private RecipeStep() { }

    /// <summary>
    /// Constructor para crear un nuevo paso de receta válido.
    /// </summary>
    /// <param name="stepNumber">El número de orden del paso.</param>
    /// <param name="instruction">La instrucción del paso.</param>
    /// <param name="recipeId">El ID de la receta asociada.</param>
    public RecipeStep(int stepNumber, string instruction, int recipeId)
    {
        if (stepNumber <= 0)
            throw new ArgumentException("El número de paso debe ser positivo.", nameof(stepNumber));
        if (string.IsNullOrWhiteSpace(instruction))
            throw new ArgumentException("La instrucción no puede ser nula o vacía.", nameof(instruction));

        StepNumber = stepNumber;
        Instruction = instruction;
        RecipeId = recipeId;
    }
}