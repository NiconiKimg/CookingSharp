using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ConfigureGridView();
            await LoadAppeals();
        }

        private async Task LoadAppeals()
        {
            try
            {
                var appeals = await _apiClient.GetAllPendingAsync();
                dgvAppeals.DataSource = appeals?.ToList();
                UpdateButtonsState();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las solicitudes pendientes: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGridView()
        {
            dgvAppeals.AutoGenerateColumns = false;
            dgvAppeals.Columns.Clear();

            dgvAppeals.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ApplicantNameColumn",
                DataPropertyName = "ApplicantName",
                HeaderText = "Solicitante",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                MinimumWidth = 150
            });

            dgvAppeals.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DescriptionColumn",
                DataPropertyName = "Description",
                HeaderText = "Descripción",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 100,
                MinimumWidth = 250
            });

            dgvAppeals.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StatusColumn",
                DataPropertyName = "Status",
                HeaderText = "Estado",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                MinimumWidth = 100
            });

            dgvAppeals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppeals.MultiSelect = false;
            dgvAppeals.ReadOnly = true;
            dgvAppeals.AllowUserToAddRows = false;
            dgvAppeals.RowHeadersVisible = false;
            dgvAppeals.BackgroundColor = Color.White;
            dgvAppeals.BorderStyle = BorderStyle.None;

            dgvAppeals.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvAppeals.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAppeals.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvAppeals.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvAppeals.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvAppeals.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAppeals.EnableHeadersVisualStyles = false;
            dgvAppeals.ColumnHeadersHeight = 40;

            dgvAppeals.DefaultCellStyle.BackColor = Color.White;
            dgvAppeals.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvAppeals.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvAppeals.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
            dgvAppeals.DefaultCellStyle.SelectionForeColor = Color.FromArgb(21, 21, 21);
            dgvAppeals.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvAppeals.RowTemplate.Height = 38;
            dgvAppeals.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
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
            if (selectedAppeal is null) return;

            string action = newStatus == "Approved" ? "aprobar" : "rechazar";
            var confirmResult = MessageBox.Show($"¿Está seguro de que desea {action} esta solicitud?", $"Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var appealUpdateDto = new AppealUpdateDTO { Status = newStatus };
                    bool success = await _apiClient.ProcessAppealAsync(selectedAppeal.Id, appealUpdateDto);

                    // La API devuelve un bool que indica éxito, pero no devuelve contenido.
                    // Si la llamada no lanza una excepción, asumimos que fue exitosa.
                    await LoadAppeals();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar la solicitud: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private AppealResponseDTO? GetSelectedAppeal()
        {
            if (dgvAppeals.CurrentRow != null && dgvAppeals.CurrentRow.DataBoundItem is AppealResponseDTO appeal)
            {
                return appeal;
            }
            return null;
        }

        private void dgvAppeals_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonsState();
        }

        private void UpdateButtonsState()
        {
            bool hasSelection = dgvAppeals.SelectedRows.Count > 0;
            btnApproveAppeal.Enabled = hasSelection;
            btnRejectAppeal.Enabled = hasSelection;
        }
    }
}