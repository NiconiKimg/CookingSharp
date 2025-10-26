using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Authentication
{
    public partial class FrmLogin : Form
    {
        private readonly AuthApiClient _authApiClient;
        private int _loginAttempts = 0;
        private const int MAX_ATTEMPTS = 3;

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

        private async void btnAcceder_Click(object sender, EventArgs e)
        {
            btnAcceder.Enabled = false;
            btnAcceder.Text = "Accediendo...";

            try
            {
                var loginDto = new UserLoginDTO
                {
                    Email = txtEmail.Text,
                    Password = txtPassword.Text
                };

                var response = await _authApiClient.LoginAsync(loginDto);

                if (response != null && !string.IsNullOrEmpty(response.Token))
                {
                    // Login exitoso
                    SessionManager.JwtToken = response.Token;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Login fallido por credenciales incorrectas
                    HandleFailedLogin();
                }
            }
            catch (Exception)
            {
                // Login fallido por error de conexión u otro problema
                HandleFailedLogin();
            }
            finally
            {
                // Asegurarse de que el formulario no ha sido cerrado antes de actualizar los controles.
                if (!this.IsDisposed)
                {
                    btnAcceder.Enabled = true;
                    btnAcceder.Text = "Acceder";
                }
            }
        }

        /// <summary>
        /// Gestiona la lógica para un intento de login fallido.
        /// Incrementa el contador, informa al usuario y cierra la aplicación si se supera el límite.
        /// </summary>
        private void HandleFailedLogin()
        {
            _loginAttempts++;
            int remainingAttempts = MAX_ATTEMPTS - _loginAttempts;

            if (remainingAttempts > 0)
            {
                MessageBox.Show($"Credenciales inválidas o error de conexión. Quedan {remainingAttempts} intento(s).", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
            }
            else
            {
                MessageBox.Show("Ha superado el número máximo de intentos. La aplicación se cerrará.", "Acceso Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel; // Esto finalizará el bucle en Program.cs
                this.Close();
            }
        }
    }
}