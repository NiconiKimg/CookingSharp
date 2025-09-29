using CookingSharp.Application.DTOs;
using CookingSharp.Infrastructure.Clients;
using System.Data;

namespace CookingSharp.WindowsForms.Features.Apprentice
{
    public partial class UC_AppealsApprentice : UserControl
    {
        private readonly AppealApiClient _apiClient;
        private readonly int _currentUserId; // ID del usuario logeado

        /// <summary>
        /// Constructor del UserControl.
        /// </summary>
        /// <param name="apiClient">El cliente para comunicarse con la API de Appeals.</param>
        /// <param name="currentUserId">El ID del usuario actualmente logeado.</param>
        public UC_AppealsApprentice(AppealApiClient apiClient, int currentUserId)
        {
            InitializeComponent();
            _apiClient = apiClient;
            _currentUserId = currentUserId; // Guardamos el ID del usuario
            this.Load += UC_AppealsApprentice_Load; // Suscribimos el evento Load
        }

        /// <summary>
        /// Manejador del evento Load del UserControl. Se ejecuta cuando el control se carga.
        /// </summary>
        private async void UC_AppealsApprentice_Load(object sender, EventArgs e)
        {
            await LoadAppealsAsync();
        }

        /// <summary>
        /// Carga las solicitudes (appeals) del usuario actual desde la API y las muestra en el DataGridView.
        /// </summary>
        private async Task LoadAppealsAsync()
        {
            try
            {

                var userAppeals = await _apiClient.GetAppealsByUserIdAsync();

                dgvAppealApprentice.DataSource = userAppeals?.ToList();

                ConfigureGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tus solicitudes: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Configura la apariencia y las columnas del DataGridView.
        /// </summary>
        private void ConfigureGridView()
        {
            if (dgvAppealApprentice.Columns.Count == 0) return;

            if (dgvAppealApprentice.Columns["Id"] != null)
                dgvAppealApprentice.Columns["Id"].Visible = false;

            if (dgvAppealApprentice.Columns["UserId"] != null)
                dgvAppealApprentice.Columns["UserId"].Visible = false;

            if (dgvAppealApprentice.Columns["Description"] != null)
                dgvAppealApprentice.Columns["Description"].HeaderText = "Descripción";

            if (dgvAppealApprentice.Columns["Status"] != null)
                dgvAppealApprentice.Columns["Status"].HeaderText = "Estado";

            dgvAppealApprentice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppealApprentice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppealApprentice.MultiSelect = false;
            dgvAppealApprentice.ReadOnly = true;
            dgvAppealApprentice.AllowUserToAddRows = false;

            dgvAppealApprentice.EnableHeadersVisualStyles = false;
            dgvAppealApprentice.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvAppealApprentice.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
        }
    }
}