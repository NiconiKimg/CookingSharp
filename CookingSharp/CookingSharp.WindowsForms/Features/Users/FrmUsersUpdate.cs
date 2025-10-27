using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Users
{
    public partial class FrmUsersUpdate : Form
    {
        private readonly UserApiClient _apiClient;
        private readonly UserResponseDTO _userToUpdate;

        public FrmUsersUpdate(UserApiClient apiClient, UserResponseDTO userToUpdate)
        {
            InitializeComponent();
            _apiClient = apiClient;
            _userToUpdate = userToUpdate;

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            this.Load += FrmUsersUpdate_Load;
        }

        private void FrmUsersUpdate_Load(object sender, EventArgs e)
        {
            txtBoxName.Text = _userToUpdate.Name;
            txtBoxSurname.Text = _userToUpdate.Surname;
            txtBoxEmail.Text = _userToUpdate.Email;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Por favor, corrija los errores marcados.", "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userUpdateDto = new UserUpdateDTO
            {
                Name = txtBoxName.Text.Trim(),
                Surname = txtBoxSurname.Text.Trim(),
                Email = txtBoxEmail.Text.Trim()
            };

            try
            {
                bool success = await _apiClient.UpdateAsync(_userToUpdate.Id, userUpdateDto);
                if (success)
                {
                    MessageBox.Show("Usuario actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el usuario. Verifique que el email no esté en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #endregion
    }
}