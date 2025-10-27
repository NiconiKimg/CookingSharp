using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Authentication
{
    /// <summary>
    /// Formulario para la autenticación de usuarios. Permite el inicio de sesión manual
    /// y la visualización de la contraseña.
    /// </summary>
    public partial class FrmLogin : Form
    {
        private readonly AuthApiClient _authApiClient;
        private int _loginAttempts = 0;
        private const int MAX_ATTEMPTS = 3;
        private bool _isPasswordVisible = false;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmLogin"/>.
        /// </summary>
        /// <param name="authApiClient">El cliente para interactuar con la API de autenticación.</param>
        public FrmLogin(AuthApiClient authApiClient)
        {
            InitializeComponent();
            _authApiClient = authApiClient;
            this.AcceptButton = btnAcceder; // Permite iniciar sesión con la tecla Enter.
            UpdatePasswordVisibility();     // Establece el estado visual inicial del campo de contraseña.
        }

        /// <summary>
        /// Maneja el evento Click del botón de cierre ('X'). Cierra el formulario con un resultado de Cancelar,
        /// lo que terminará el bucle principal de la aplicación.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Maneja el evento Click del botón "Acceder" para autenticar al usuario.
        /// </summary>
        private async void btnAcceder_Click(object sender, EventArgs e)
        {
            btnAcceder.Enabled = false;
            btnAcceder.Text = "Accediendo...";

            try
            {
                var loginDto = new UserLoginDTO
                {
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text
                };

                var response = await _authApiClient.LoginAsync(loginDto);

                if (response != null && !string.IsNullOrEmpty(response.Token))
                {
                    SessionManager.JwtToken = response.Token;
                    this.DialogResult = DialogResult.OK; // Indica un login exitoso.
                    this.Close();
                }
                else
                {
                    HandleFailedLogin();
                }
            }
            catch (Exception)
            {
                HandleFailedLogin();
            }
            finally
            {
                if (!this.IsDisposed)
                {
                    btnAcceder.Enabled = true;
                    btnAcceder.Text = "Acceder";
                }
            }
        }

        /// <summary>
        /// Gestiona la lógica para un intento de login fallido, mostrando un mensaje
        /// al usuario y cerrando la aplicación si se supera el número máximo de intentos.
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
                System.Windows.Forms.Application.Exit(); // Cierra la aplicación directamente.
            }
        }

        /// <summary>
        /// Maneja el evento Click del icono para alternar la visibilidad de la contraseña.
        /// </summary>
        private void picTogglePassword_Click(object sender, EventArgs e)
        {
            _isPasswordVisible = !_isPasswordVisible;
            UpdatePasswordVisibility();
        }

        /// <summary>
        /// Maneja el evento CheckedChanged del checkbox para alternar la visibilidad de la contraseña.
        /// </summary>
        private void chkVerPassword_CheckedChanged(object sender, EventArgs e)
        {
            _isPasswordVisible = chkVerPassword.Checked;
            UpdatePasswordVisibility();
        }

        /// <summary>
        /// Actualiza la visualización de la contraseña (oculta/visible) y sincroniza los controles correspondientes.
        /// </summary>
        private void UpdatePasswordVisibility()
        {
            if (_isPasswordVisible)
            {
                txtPassword.PasswordChar = '\0'; // Carácter nulo para hacer visible el texto.
                picTogglePassword.Image = Properties.Resources.eye_open;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                picTogglePassword.Image = Properties.Resources.eye_closed;
            }

            // Sincroniza el estado del CheckBox con la variable de control.
            chkVerPassword.Checked = _isPasswordVisible;
        }
    }
}