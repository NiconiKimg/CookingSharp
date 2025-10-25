using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
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
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                MessageBox.Show("El nombre, email y contraseña son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SOLUCIÓN: Usar el DTO específico para la creación de usuarios.
            var newUserDto = new UserCreateDTO
            {
                Name = txtBoxName.Text.Trim(),
                Surname = txtBoxSurname.Text.Trim(),
                Email = txtBoxEmail.Text.Trim(),
                Password = txtBoxPassword.Text.Trim()
            };

            try
            {
                // SOLUCIÓN: Llamar al nuevo método CreateAsync.
                var createdUser = await _apiClient.CreateAsync(newUserDto);

                if (createdUser != null)
                {
                    MessageBox.Show("Usuario creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Este mensaje podría aparecer si, por ejemplo, el email ya existe.
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}