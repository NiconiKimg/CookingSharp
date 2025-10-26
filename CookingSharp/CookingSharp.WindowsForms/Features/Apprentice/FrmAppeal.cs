using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Apprentice
{
    public partial class frmAppeal : Form
    {
        private readonly AppealApiClient _apiClient;

        public frmAppeal(AppealApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            this.AcceptButton = btnCreate;
            this.CancelButton = btnCancel;
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Por favor, corrija los errores marcados.", "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newAppealDto = new AppealCreateDTO
            {
                Description = txtDescription.Text.Trim(),
            };

            try
            {
                var createdAppeal = await _apiClient.CreateAppealAsync(newAppealDto);

                if (createdAppeal != null)
                {
                    MessageBox.Show("Solicitud enviada con éxito. Un administrador la revisará pronto.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo enviar la solicitud. La API no devolvió una respuesta válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al enviar la solicitud: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "La descripción es obligatoria. Explica por qué quieres ser chef.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDescription, "");
            }
        }
    }
}