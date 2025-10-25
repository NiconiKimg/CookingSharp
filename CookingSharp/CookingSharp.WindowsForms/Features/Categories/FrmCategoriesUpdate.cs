using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms
{
    public partial class frmCategoriesUpdate : Form
    {
        private readonly CategoryApiClient _apiClient;
        private readonly CategoryResponseDTO _categoryToUpdate;

        public frmCategoriesUpdate(CategoryApiClient apiClient, CategoryResponseDTO categoryToUpdate)
        {
            InitializeComponent();
            _apiClient = apiClient;
            _categoryToUpdate = categoryToUpdate;

            // Configuración de accesibilidad y UX
            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            // Cargar los datos al iniciar el formulario
            this.Load += FrmCategoriesUpdate_Load;
        }

        private void FrmCategoriesUpdate_Load(object sender, EventArgs e)
        {
            // Llenar los campos con los datos de la categoría a editar
            txtBoxName.Text = _categoryToUpdate.Name;
            txtBoxDescription.Text = _categoryToUpdate.Description;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Validar todos los controles antes de guardar
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Por favor, corrija los errores marcados.", "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var categoryUpdateDto = new CategoryCreateUpdateDTO
            {
                Name = txtBoxName.Text.Trim(),
                Description = txtBoxDescription.Text.Trim()
            };

            try
            {
                bool success = await _apiClient.UpdateAsync(_categoryToUpdate.Id, categoryUpdateDto);

                if (success)
                {
                    MessageBox.Show("Categoría actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la categoría. Es posible que el nombre ya esté en uso por otra categoría.", "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar la categoría: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            this.Close();
        }

        #region Validation Events

        private void txtBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBoxName, "El nombre de la categoría es obligatorio.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBoxName, "");
            }
        }

        private void txtBoxDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxDescription.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBoxDescription, "La descripción es obligatoria.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBoxDescription, "");
            }
        }

        #endregion
    }
}