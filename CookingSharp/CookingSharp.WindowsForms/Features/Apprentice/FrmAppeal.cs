using CookingSharp.Application.DTOs;
using CookingSharp.Clients;


namespace CookingSharp.WindowsForms.Features.Apprentice
{
    public partial class frmAppeal : Form
    {
        private readonly AppealApiClient _apiClient;
        public frmAppeal(AppealApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            // 1. Validar la entrada del usuario
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("La descripción de la solicitud es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Crear el Data Transfer Object (DTO)
            var newAppealDto = new AppealCreateDTO
            {
                Description = txtDescription.Text.Trim(),
            };

            // 3. Enviar la solicitud a la API
            try
            {
                var createdAppeal = await _apiClient.CreateAppealAsync(newAppealDto);

                if (createdAppeal != null)
                {
                    MessageBox.Show("Solicitud enviada con éxito. Un administrador la revisará pronto.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Indicar que la operación fue exitosa
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo enviar la solicitud. La API no devolvió una respuesta válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores de conexión o del servidor
                MessageBox.Show($"Ocurrió un error al enviar la solicitud: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
