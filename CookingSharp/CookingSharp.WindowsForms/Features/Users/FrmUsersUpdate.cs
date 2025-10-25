using CookingSharp.Application.DTOs;
using CookingSharp.Clients;


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

            this.Load += FrmUsersUpdate_Load;
        }

        private void FrmUsersUpdate_Load(object sender, EventArgs e)
        {
            this.Text = $"Modificar Usuario: {_userToUpdate.Name}";
            txtBoxName.Text = _userToUpdate.Name;
            txtBoxSurname.Text = _userToUpdate.Surname;
            txtBoxEmail.Text = _userToUpdate.Email;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxName.Text))
            {
                MessageBox.Show("El nombre del usuario es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
    }
}
