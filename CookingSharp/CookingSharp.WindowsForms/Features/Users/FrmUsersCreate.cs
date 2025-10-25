using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Users
{
    public partial class FrmUsersCreate : Form
    {
        private readonly UserApiClient _apiClient;

        public FrmUsersCreate(UserApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Por favor, corrija los errores marcados.", "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newUserDto = new UserCreateDTO
            {
                Name = txtBoxName.Text.Trim(),
                Surname = txtBoxSurname.Text.Trim(),
                Email = txtBoxEmail.Text.Trim(),
                Password = txtBoxPassword.Text.Trim()
            };

            try
            {
                var createdUser = await _apiClient.CreateAsync(newUserDto);
                if (createdUser != null)
                {
                    MessageBox.Show("Usuario creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el usuario. Verifique que el email no esté ya en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al crear el usuario: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                errorProvider1.SetError(txtBoxName, "El nombre es obligatorio.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBoxName, "");
            }
        }

        private void txtBoxSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxSurname.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBoxSurname, "El apellido es obligatorio.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBoxSurname, "");
            }
        }

        private void txtBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBoxEmail, "El email es obligatorio.");
            }
            else if (!txtBoxEmail.Text.Contains("@") || !txtBoxEmail.Text.Contains("."))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBoxEmail, "Por favor, ingrese un email válido.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBoxEmail, "");
            }
        }

        private void txtBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBoxPassword, "La contraseña es obligatoria.");
            }
            else if (txtBoxPassword.Text.Length < 8)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBoxPassword, "La contraseña debe tener al menos 8 caracteres.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBoxPassword, "");
            }
        }

        #endregion
    }
}