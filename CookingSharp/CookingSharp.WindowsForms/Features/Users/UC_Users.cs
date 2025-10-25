using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using CookingSharp.WindowsForms.Users;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ConfigureGridView();
            await LoadUsers();
        }

        private async Task LoadUsers()
        {
            try
            {
                var users = await _apiClient.GetAllAsync();
                dgvUsers.DataSource = users?.ToList();
                UpdateButtonsState();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGridView()
        {
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.Columns.Clear();

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NameColumn",
                DataPropertyName = "Name",
                HeaderText = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 30,
                MinimumWidth = 120
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SurnameColumn",
                DataPropertyName = "Surname",
                HeaderText = "Apellido",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 30,
                MinimumWidth = 120
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EmailColumn",
                DataPropertyName = "Email",
                HeaderText = "Email",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 40,
                MinimumWidth = 200
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RoleColumn",
                DataPropertyName = "Role",
                HeaderText = "Rol",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                MinimumWidth = 100
            });

            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.ReadOnly = true;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;

            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUsers.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.ColumnHeadersHeight = 40;

            dgvUsers.DefaultCellStyle.BackColor = Color.White;
            dgvUsers.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvUsers.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
            dgvUsers.DefaultCellStyle.SelectionForeColor = Color.FromArgb(21, 21, 21);
            dgvUsers.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvUsers.RowTemplate.Height = 38;
            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private async void btnCreateUser_Click(object sender, EventArgs e)
        {
            using (var createForm = Program.ServiceProvider?.GetRequiredService<FrmUsersCreate>())
            {
                if (createForm != null && createForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadUsers();
                }
            }
        }

        private async void btnModifyUser_Click(object sender, EventArgs e)
        {
            var selectedUser = GetSelectedUser();
            if (selectedUser == null) return;

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
            if (selectedUser == null) return;

            var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar al usuario '{selectedUser.Name} {selectedUser.Surname}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                        MessageBox.Show("El usuario no pudo ser eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvUsers.CurrentRow != null && dgvUsers.CurrentRow.DataBoundItem is UserResponseDTO user)
            {
                return user;
            }
            return null;
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonsState();
        }

        private void UpdateButtonsState()
        {
            bool hasSelection = dgvUsers.SelectedRows.Count > 0;
            btnModifyUser.Enabled = hasSelection;
            btnDeleteUser.Enabled = hasSelection;
        }
    }
}