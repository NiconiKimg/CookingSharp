using CookingSharp.Application.DTOs;
using CookingSharp.Infrastructure.Clients;
using System;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms
{
    public partial class FrmLogin : Form
    {
        private readonly AuthApiClient _authApiClient;

        /// <summary>
        /// Constructor que recibe el cliente de la API de autenticación
        /// a través de la inyección de dependencias configurada en Program.cs.
        /// </summary>
        public FrmLogin(AuthApiClient authApiClient)
        {
            InitializeComponent();
            _authApiClient = authApiClient;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Maneja el evento de clic del botón Acceder.
        /// Se declara como 'async void' para poder realizar llamadas a la API sin congelar la interfaz de usuario.
        /// </summary>
        private async void btnAcceder_Click(object sender, EventArgs e)
        {
            // Deshabilitar el botón para evitar múltiples clics mientras se procesa la solicitud.
            btnAcceder.Enabled = false;
            btnAcceder.Text = "Accediendo...";

            try
            {
                // 1. Recoger las credenciales del formulario.
                var loginDto = new UserLoginDTO
                {
                    Email = txtEmail.Text,
                    Password = txtPassword.Text
                };

                // 2. Llamar a la API para intentar iniciar sesión.
                var response = await _authApiClient.LoginAsync(loginDto);

                // 3. Procesar la respuesta de la API.
                if (response != null && !string.IsNullOrEmpty(response.Token))
                {
                    // ÉXITO: Se recibió un token.
                    TokenManager.SetToken(response.Token);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // FALLO: La API devolvió una respuesta no exitosa (ej. 401 Unauthorized).
                    MessageBox.Show("Credenciales inválidas. Por favor, inténtelo de nuevo.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                // ERROR: No se pudo conectar con el servidor o hubo otro error de red.
                MessageBox.Show($"No se pudo conectar con el servidor. Verifique que la API esté en ejecución.\n\nError: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
            finally
            {
                // Asegurarse de que el botón se vuelva a habilitar, sin importar el resultado.
                btnAcceder.Enabled = true;
                btnAcceder.Text = "Acceder";
            }
        }
    }
}