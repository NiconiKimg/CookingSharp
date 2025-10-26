using CookingSharp.Clients;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Apprentice
{
    public partial class UC_AppealsApprentice : UserControl
    {
        private readonly AppealApiClient _apiClient;

        public UC_AppealsApprentice(AppealApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            this.Load += UC_AppealsApprentice_Load;
        }

        private async void UC_AppealsApprentice_Load(object sender, EventArgs e)
        {
            ConfigureGridView();
            await LoadAppealsAsync();
        }

        private async Task LoadAppealsAsync()
        {
            try
            {
                var userAppeals = await _apiClient.GetMyAppealsAsync();
                dgvAppealApprentice.DataSource = userAppeals?.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tus solicitudes: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGridView()
        {
            dgvAppealApprentice.AutoGenerateColumns = false;
            dgvAppealApprentice.Columns.Clear();

            dgvAppealApprentice.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DescriptionColumn",
                DataPropertyName = "Description",
                HeaderText = "Descripción",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 80,
                MinimumWidth = 300
            });

            dgvAppealApprentice.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StatusColumn",
                DataPropertyName = "Status",
                HeaderText = "Estado",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                FillWeight = 20,
                MinimumWidth = 120
            });

            dgvAppealApprentice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppealApprentice.MultiSelect = false;
            dgvAppealApprentice.ReadOnly = true;
            dgvAppealApprentice.AllowUserToAddRows = false;
            dgvAppealApprentice.RowHeadersVisible = false;
            dgvAppealApprentice.BackgroundColor = Color.White;
            dgvAppealApprentice.BorderStyle = BorderStyle.None;

            dgvAppealApprentice.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvAppealApprentice.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAppealApprentice.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvAppealApprentice.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvAppealApprentice.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvAppealApprentice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAppealApprentice.EnableHeadersVisualStyles = false;
            dgvAppealApprentice.ColumnHeadersHeight = 40;

            dgvAppealApprentice.DefaultCellStyle.BackColor = Color.White;
            dgvAppealApprentice.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvAppealApprentice.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvAppealApprentice.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
            dgvAppealApprentice.DefaultCellStyle.SelectionForeColor = Color.FromArgb(21, 21, 21);
            dgvAppealApprentice.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvAppealApprentice.RowTemplate.Height = 38;
            dgvAppealApprentice.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private async void btnCreateAppeal_Click(object sender, EventArgs e)
        {
            using (var createForm = Program.ServiceProvider?.GetRequiredService<frmAppeal>())
            {
                if (createForm != null && createForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadAppealsAsync();
                }
            }
        }
    }
}