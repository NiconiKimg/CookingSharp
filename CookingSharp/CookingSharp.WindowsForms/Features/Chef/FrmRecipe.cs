using CookingSharp.Application.DTOs;
using CookingSharp.Infrastructure.Clients;


namespace CookingSharp.WindowsForms.Features.Chef
{
    public partial class FrmRecipe : Form
    {
        private readonly RecipeApiClient _recipeApiClient;

        // El constructor necesita el RecipeApiClient para comunicarse con la API.
        public FrmRecipe(RecipeApiClient recipeApiClient)
        {
            InitializeComponent();
            _recipeApiClient = recipeApiClient;
        }

        private async void btnCreateRecipe_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("La descripción es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSteps.Text))
            {
                MessageBox.Show("Los pasos de la receta son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Crear el DTO. No se necesita UserId ni CategoryIds.
            //    El backend se encargará de asignar el UserId desde el token.
            var newRecipeDto = new CreateRecipeDTO
            {
                Description = txtDescription.Text.Trim(),
                Content = txtSteps.Text.Trim(),
                CategoryIds = new List<int>() // Se envía una lista vacía, como se solicitó.
            };

            // 3. Llamar a la API y manejar la respuesta
            try
            {
                var createdRecipe = await _recipeApiClient.AddAsync(newRecipeDto);

                if (createdRecipe != null)
                {
                    MessageBox.Show("Receta creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Indica que la operación fue exitosa
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo crear la receta. La API no devolvió una respuesta válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al crear la receta: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}