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
            btnAcceder.Enabled = false;
            btnAcceder.Text = "Accediendo...";

            try
            {
                var loginDto = new UserLoginDTO
                {
                    Email = txtEmail.Text,
                    Password = txtPassword.Text
                };

                Console.WriteLine("previo");
                var response = await _authApiClient.LoginAsync(loginDto);
                
                if (response != null && !string.IsNullOrEmpty(response.Token))
                {
                    SessionManager.StartSession(response.Token);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Credenciales inválidas. Por favor, inténtelo de nuevo.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado:\n\n{ex.ToString()}", "Error Detallado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
            finally
            {
                btnAcceder.Enabled = true;
                btnAcceder.Text = "Acceder";
            }
        }
    }
}