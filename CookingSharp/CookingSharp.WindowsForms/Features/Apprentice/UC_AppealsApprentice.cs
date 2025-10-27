using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Apprentice
{
    /// <summary>
    /// User Control para que el Aprendiz vea y gestione sus solicitudes para convertirse en Chef.
    /// </summary>
    public partial class UC_AppealsApprentice : UserControl
    {
        private readonly AppealApiClient _apiClient;
        private List<AppealResponseDTO> _myAppeals;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UC_AppealsApprentice"/>.
        /// </summary>
        /// <param name="apiClient">El cliente para interactuar con la API de solicitudes.</param>
        public UC_AppealsApprentice(AppealApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            _myAppeals = new List<AppealResponseDTO>();
            this.Load += UC_AppealsApprentice_Load;
        }

        #region Event Handlers

        /// <summary>
        /// Maneja el evento de carga inicial del User Control.
        /// </summary>
        private async void UC_AppealsApprentice_Load(object sender, EventArgs e)
        {
            ConfigureGridView();
            await LoadAppealsAsync();
        }

        /// <summary>
        /// Maneja el evento Click del botón "Nueva Solicitud".
        /// Abre el formulario para crear una nueva solicitud y recarga la lista si la operación es exitosa.
        /// </summary>
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

        #endregion

        #region Private Methods

        /// <summary>
        /// Carga las solicitudes del usuario actual desde la API y refresca la vista.
        /// </summary>
        private async Task LoadAppealsAsync()
        {
            try
            {
                var userAppeals = await _apiClient.GetMyAppealsAsync();
                _myAppeals = userAppeals?.ToList() ?? new List<AppealResponseDTO>();
                dgvAppealApprentice.DataSource = _myAppeals;

                UpdateButtonState();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tus solicitudes: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Configura la apariencia visual y las columnas del DataGridView.
        /// </summary>
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

        /// <summary>
        /// Actualiza el estado del botón "Nueva Solicitud" basándose en si existe una solicitud pendiente.
        /// </summary>
        private void UpdateButtonState()
        {
            bool hasPendingAppeal = _myAppeals.Any(a => a.Status.Equals("Pending", StringComparison.OrdinalIgnoreCase));
            btnCreateAppeal.Enabled = !hasPendingAppeal;

            if (hasPendingAppeal)
            {
                btnCreateAppeal.Text = "Solicitud Pendiente";
                btnCreateAppeal.BackColor = Color.Gray; // Color indicativo de estado deshabilitado
            }
            else
            {
                btnCreateAppeal.Text = "Nueva Solicitud";
                btnCreateAppeal.BackColor = Color.FromArgb(13, 110, 253); // Color original de acción
            }
        }
        #endregion
    }
}