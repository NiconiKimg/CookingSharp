using System.Data;


namespace CookingSharp.Domain
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<RecipeStep> Steps { get; set; } = new List<RecipeStep>();

        public Recipe(string name, string descripcion, List<RecipeStep> steps) { 
            UpdateDetails(name, descripcion);
            AsignSteps(steps);

        }
        private void UpdateDetails( string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("El nombre de la receta no puede ser nulo o vacío.", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("La descripción de la receta no puede ser nula o vacía.", nameof(description));
            }

            Name = name;
            Description = description;
        }

        public void AsignSteps(List<RecipeStep> steps)
        {
            if (steps == null) 
            {
                throw new ArgumentException("La receta no puede no tener pasos.");
            }

            foreach (RecipeStep step in steps)
            {
                AddStep(step);
            }
        }

        public void AddStep(RecipeStep stepAdded)
        {
            if (stepAdded == null)
            {
                throw new ArgumentNullException(nameof(stepAdded));
            }

            int actualOrder = stepAdded.Order;
            foreach(var step in Steps)
            {
                if(step.Order == actualOrder)
                {
                    throw new Exception("El orden ingresado es incorrecto.");
                }
            }

            Steps.Add(stepAdded);
        }
    }
}
