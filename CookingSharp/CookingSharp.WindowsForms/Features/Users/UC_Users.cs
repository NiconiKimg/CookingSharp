using CookingSharp.Application.DTOs;
using CookingSharp.Infrastructure.Clients;
using CookingSharp.WindowsForms.Users;
using Microsoft.Extensions.DependencyInjection;

namespace CookingSharp.WindowsForms.UserControls
{
    public partial class UC_Users : UserControl
    {
        private readonly UserApiClient _apiClient;
        public UC_Users(UserApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            this.Load += UCUsers_Load;
        }

        private async void UCUsers_Load(object sender, EventArgs e)
        {
            await LoadUsers();
        }

        private async Task LoadUsers()
        {
            try
            {
                var users = await _apiClient.GetAllAsync();

                dgvUsers.DataSource = users?.ToList();

                ConfigureGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGridView()
        {
            if (dgvUsers.Columns.Count == 0) return;

            if (dgvUsers.Columns["Id"] != null)
                dgvUsers.Columns["Id"].Visible = false;

            if (dgvUsers.Columns["Name"] != null)
                dgvUsers.Columns["Name"].HeaderText = "Nombre";

            if (dgvUsers.Columns["Surname"] != null)
                dgvUsers.Columns["Surname"].HeaderText = "Apellido";

            if (dgvUsers.Columns["Email"] != null)
                dgvUsers.Columns["Email"].HeaderText = "Email";

            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.ReadOnly = true;
            dgvUsers.AllowUserToAddRows = false;

            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
        }

        private async void btnCreateUser_Click(object sender, EventArgs e)
        {

            using (var createForm = Program.ServiceProvider?.GetRequiredService<FrmUsersCreate>())
            {
                if (createForm == null) return;
                createForm.ShowDialog();
            }

            await LoadUsers();
        }

        private async void btnModifyUser_Click(object sender, EventArgs e)
        {
            var selectedUser = GetSelectedUser();
            if (selectedUser == null)
            {
                MessageBox.Show("Por favor, seleccione un usuario para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var apiClient = Program.ServiceProvider.GetRequiredService<UserApiClient>();

            using (var modifyForm = new FrmUsersUpdate(apiClient, selectedUser))
            {
                if (modifyForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadUsers();
                }
            }
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var selectedUser = GetSelectedUser();
            if (selectedUser == null)
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar el usuario '{selectedUser.Name}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    bool success = await _apiClient.DeleteAsync(selectedUser.Id);
                    if (success)
                    {
                        await LoadUsers();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no pudo ser eliminado (posiblemente ya fue borrado).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el usuario: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private UserResponseDTO? GetSelectedUser()
        {
            if (dgvUsers.CurrentRow != null && dgvUsers.CurrentRow.DataBoundItem is UserResponseDTO users)
            {
                return users;
            }
            return null;
        }
    }
}
