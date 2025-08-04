using System.Windows.Forms;
using CookingSharp.API.Clients;
using CookingSharp.DTOs;

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
            if (string.IsNullOrWhiteSpace(txtBoxName.Text))
            {
                MessageBox.Show("El nombre del usuario es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newUserDto = new UserDTO
            {
                Name = txtBoxName.Text.Trim(),
                Surname = txtBoxSurname.Text.Trim(),
                Email = txtBoxEmail.Text.Trim(),
                Password = txtBoxPassword.Text.Trim()
            };

            try
            {
                var createdUser = await _apiClient.AddAsync(newUserDto);

                if (createdUser != null)
                {
                    MessageBox.Show("Usario creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el usuario. La API no devolvió el objeto creado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
