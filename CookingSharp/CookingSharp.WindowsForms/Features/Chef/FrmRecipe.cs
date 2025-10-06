using CookingSharp.Application.DTOs;
using CookingSharp.Infrastructure.Clients;
using Microsoft.IdentityModel.Tokens;


namespace CookingSharp.WindowsForms.Features.Chef
{
    public partial class FrmRecipe : Form
    {
        private readonly RecipeApiClient _recipeApiClient;
        private readonly CategoryApiClient _categoryApiClient;

        // El constructor necesita el RecipeApiClient para comunicarse con la API.
        public FrmRecipe(RecipeApiClient recipeApiClient, CategoryApiClient categoryApiClient)
        {
            InitializeComponent();
            _recipeApiClient = recipeApiClient;
            _categoryApiClient = categoryApiClient;
            this.Load += FrmRecipe_Load;
        }

        private async void FrmRecipe_Load(object sender, EventArgs e)
        {
            try
            {
                var categorias = await _categoryApiClient.GetAllAsync();

                if (categorias.IsNullOrEmpty())
                {
                    MessageBox.Show("No se pudieron cargar las categorías.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    foreach (var categoria in categorias)
                    {
                        checkedListBox1.Items.Add(categoria);
                    }
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las categorías: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<int> selectedCategoryIds = new List<int>();

            foreach (var item in checkedListBox1.CheckedItems)
            {
                var category = item as CategoryDTO;
                if (category != null)
                {
                    selectedCategoryIds.Add(category.Id);
                }
            }

            // 2. Crear el DTO. No se necesita UserId ni CategoryIds.
            //    El backend se encargará de asignar el UserId desde el token.
            var newRecipeDto = new CreateRecipeDTO
            {
                Description = txtDescription.Text.Trim(),
                Content = txtSteps.Text.Trim(),
                CategoryIds = selectedCategoryIds // Se envía la lista de IDs seleccionados.
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