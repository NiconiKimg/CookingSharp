using CookingSharp.API.Clients;
using CookingSharp.DTOs;

namespace CookingSharp.WindowsForms
{
    public partial class frmCategoriesUpdate : Form
    {
        private readonly CategoryApiClient _apiClient;
        private readonly CategoryDTO _categoryToUpdate;

        public frmCategoriesUpdate(CategoryApiClient apiClient, CategoryDTO categoryToUpdate)
        {
            InitializeComponent();
            _apiClient = apiClient;
            _categoryToUpdate = categoryToUpdate;

            this.Load += FrmCategoriesUpdate_Load;
        }

        private void FrmCategoriesUpdate_Load(object sender, EventArgs e)
        {
            this.Text = $"Modificar Categoría: {_categoryToUpdate.Name}";
            txtBoxId.Text = _categoryToUpdate.Id.ToString();
            txtBoxId.Enabled = false;
            txtBoxName.Text = _categoryToUpdate.Name;
            txtBoxDescription.Text = _categoryToUpdate.Description;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxName.Text))
            {
                MessageBox.Show("El nombre de la categoría es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _categoryToUpdate.Name = txtBoxName.Text.Trim();
            _categoryToUpdate.Description = txtBoxDescription.Text.Trim();

            try
            {
                bool success = await _apiClient.UpdateAsync(_categoryToUpdate);

                if (success)
                {
                    MessageBox.Show("Categoría actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la categoría (posiblemente fue eliminada).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar la categoría: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
    }
}