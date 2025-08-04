using CookingSharp.API.Clients;
using CookingSharp.DTOs;


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

            _userToUpdate.Name = txtBoxName.Text.Trim();
            _userToUpdate.Surname = txtBoxSurname.Text.Trim();

            try
            {
                bool success = await _apiClient.UpdateAsync(_userToUpdate);

                if (success)
                {
                    MessageBox.Show("Usuario actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el usuario (posiblemente fue eliminado).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar el usuario: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
    }
}
