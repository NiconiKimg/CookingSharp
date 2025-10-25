/// <summary>
/// Formulario de inicio de sesión para la aplicación CookingSharp.
/// Se encarga de capturar las credenciales del usuario, autenticarlas contra la API
/// y gestionar el inicio de la sesión a través del SessionManager.
/// </summary>
using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Authentication
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

        /// <summary>
        /// Maneja el evento de clic del botón para cerrar el formulario.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Maneja el evento de clic del botón "Acceder".
        /// Realiza una llamada asíncrona a la API para validar las credenciales.
        /// </summary>
        private async void btnAcceder_Click(object sender, EventArgs e)
        {
            // Deshabilitar el botón para prevenir múltiples clics mientras se procesa la solicitud.
            btnAcceder.Enabled = false;
            btnAcceder.Text = "Accediendo...";

            try
            {
                var loginDto = new UserLoginDTO
                {
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text
                };

                // Llamar al cliente de la API para intentar el inicio de sesión.
                var loginResponse = await _authApiClient.LoginAsync(loginDto);

                if (loginResponse != null && !string.IsNullOrEmpty(loginResponse.Token))
                {
                    // ¡Éxito! Asignar el token al SessionManager.
                    // El setter del token se encargará de decodificarlo y almacenar los claims.
                    SessionManager.JwtToken = loginResponse.Token;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // La API respondió, pero las credenciales no son válidas.
                    MessageBox.Show("Credenciales inválidas. Por favor, inténtelo de nuevo.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Capturar cualquier otro error (ej. la API no está disponible).
                MessageBox.Show($"Ocurrió un error al intentar iniciar sesión:\n{ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Volver a habilitar el botón, sin importar el resultado.
                btnAcceder.Enabled = true;
                btnAcceder.Text = "Acceder";
            }
        }
    }
}