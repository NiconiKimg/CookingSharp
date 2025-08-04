using CookingSharp.API.Clients;
using CookingSharp.DTOs;

namespace CookingSharp.WindowsForms
{
    public partial class frmCategoriesCreate : Form
    {
        private readonly CategoryApiClient _apiClient;

        public frmCategoriesCreate(CategoryApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxName.Text))
            {
                MessageBox.Show("El nombre de la categoría es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newCategoryDto = new CategoryDTO
            {
                Name = txtBoxName.Text.Trim(),
                Description = txtBoxDescription.Text.Trim()
            };

            try
            {
                var createdCategory = await _apiClient.AddAsync(newCategoryDto);

                if (createdCategory != null)
                {
                    MessageBox.Show("Categoría creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo crear la categoría. La API no devolvió el objeto creado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error al crear la categoría: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}