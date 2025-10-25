using CookingSharp.Application.DTOs;
using CookingSharp.Clients;

namespace CookingSharp.WindowsForms.AppealsControl
{
    public partial class UC_Appeals : UserControl
    {
        private readonly AppealApiClient _apiClient;

        public UC_Appeals(AppealApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            this.Load += UCAppeals_Load;
        }

        private async void UCAppeals_Load(object sender, EventArgs e)
        {
            await LoadAppeals();
        }

        private async Task LoadAppeals()
        {
            try
            {
                var appeals = await _apiClient.GetAllAsync();

                dgvAppeals.DataSource = appeals?.ToList();

                ConfigureGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las solicitudes: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGridView()
        {
            if (dgvAppeals.Columns.Count == 0) return;

            if (dgvAppeals.Columns["Id"] != null)
                dgvAppeals.Columns["Id"].Visible = false;

            if (dgvAppeals.Columns["Description"] != null)
                dgvAppeals.Columns["Description"].HeaderText = "Descripción";

            if (dgvAppeals.Columns["Status"] != null)
                dgvAppeals.Columns["Status"].HeaderText = "Estado";

            if (dgvAppeals.Columns["UserName"] != null)
                dgvAppeals.Columns["UserName"].HeaderText = "Usuario";

            dgvAppeals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppeals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppeals.MultiSelect = false;
            dgvAppeals.ReadOnly = true;
            dgvAppeals.AllowUserToAddRows = false;

            dgvAppeals.EnableHeadersVisualStyles = false;
            dgvAppeals.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvAppeals.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
        }

        private async void btnApproveAppeal_Click(object sender, EventArgs e)
        {
            await ProcessAppeal("Approved");
        }

        private async void btnRejectAppeal_Click(object sender, EventArgs e)
        {
            await ProcessAppeal("Rejected");
        }

        private async Task ProcessAppeal(string newStatus)
        {
            var selectedAppeal = GetSelectedAppeal();
            if (selectedAppeal == null)
            {
                MessageBox.Show("Por favor, seleccione una solicitud para procesar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (selectedAppeal.Status != "Pending")
            {
                MessageBox.Show("Esta solicitud ya ha sido procesada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string action = newStatus == "Approved" ? "aprobar" : "rechazar";
            var confirmResult = MessageBox.Show($"¿Está seguro de que desea {action} esta solicitud?", $"Confirmar {action}", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var appealToUpdate = new UpdateAppealDTO { Status = newStatus };
                    await _apiClient.UpdateAsync(selectedAppeal.Id, appealToUpdate);
                    await LoadAppeals();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al {action} la solicitud: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private AppealDTO? GetSelectedAppeal()
        {
            if (dgvAppeals.CurrentRow != null && dgvAppeals.CurrentRow.DataBoundItem is AppealDTO appeal)
            {
                return appeal;
            }
            return null;
        }

    }
}