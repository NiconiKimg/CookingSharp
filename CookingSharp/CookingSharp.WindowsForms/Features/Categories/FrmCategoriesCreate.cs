using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms
{
    public partial class frmCategoriesCreate : Form
    {
        private readonly CategoryApiClient _apiClient;

        public frmCategoriesCreate(CategoryApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;

            // Configuración de accesibilidad y UX
            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;

            // Habilita la validación automática en los controles
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Dispara la validación de todos los controles hijos antes de continuar.
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Por favor, corrija los errores marcados.", "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newCategoryDto = new CategoryCreateUpdateDTO
            {
                Name = txtBoxName.Text.Trim(),
                Description = txtBoxDescription.Text.Trim()
            };

            try
            {
                var createdCategory = await _apiClient.CreateAsync(newCategoryDto);

                if (createdCategory != null)
                {
                    MessageBox.Show("Categoría creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo crear la categoría. La API no devolvió una respuesta válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al crear la categoría: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Desactiva la validación para permitir cerrar el formulario sin errores.
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
                e.Cancel = true; // Evita que el usuario salga del control
                errorProvider1.SetError(txtBoxName, "El nombre de la categoría es obligatorio.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBoxName, ""); // Limpia el mensaje de error
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