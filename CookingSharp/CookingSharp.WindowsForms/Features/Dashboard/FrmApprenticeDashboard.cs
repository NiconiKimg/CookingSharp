using CookingSharp.Clients;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Dashboard
{
    /// <summary>
    /// Formulario principal del panel del Aprendiz.
    /// Permite la navegación entre la vista de recetas públicas y la gestión de sus solicitudes.
    /// </summary>
    public partial class FrmApprenticeDashboard : Form
    {
        /// <summary>
        /// Flag para diferenciar entre un cierre de sesión (volver al login) y un cierre completo de la aplicación.
        /// </summary>
        private bool _isLoggingOut = false;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmApprenticeDashboard"/>.
        /// </summary>
        public FrmApprenticeDashboard()
        {
            InitializeComponent();
            this.Load += FrmApprenticeDashboard_Load;
            this.btnUserOptions.Cursor = Cursors.Hand;
            this.FormClosing += Dashboard_FormClosing; // Suscripción al evento de cierre.
        }

        #region Event Handlers

        /// <summary>
        /// Maneja el evento de carga del formulario. Carga la vista de recetas por defecto.
        /// </summary>
        private void FrmApprenticeDashboard_Load(object sender, EventArgs e)
        {
            LoadRecipesView();
            lblUserEmail.Text = SessionManager.GetUserEmail();
            lblUserRole.Text = SessionManager.GetUserRole();
        }

        /// <summary>
        /// Navega a la vista de exploración de recetas públicas.
        /// </summary>
        private void btnNavRecetas_Click(object sender, EventArgs e) => LoadRecipesView();

        /// <summary>
        /// Navega a la vista de gestión de las solicitudes del propio aprendiz.
        /// </summary>
        private void btnNavSolicitudes_Click(object sender, EventArgs e) => LoadAppealsView();

        /// <summary>
        /// Maneja el clic en el logo para volver a la vista principal (recetas).
        /// </summary>
        private void picLogo_Click(object sender, EventArgs e) => LoadRecipesView();

        /// <summary>
        /// Maneja el clic en el botón de cerrar sesión. Activa el flag de logout y cierra el formulario para volver al login.
        /// </summary>
        private void btnUserOptions_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Está seguro de que desea cerrar la sesión?", "Confirmar Cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Activamos el flag para indicar que es un cierre de sesión intencionado.
                _isLoggingOut = true;
                this.Close(); // Esto disparará el evento FormClosing.
            }
        }

        /// <summary>
        /// Maneja el evento que se dispara cuando el formulario está a punto de cerrarse.
        /// </summary>
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si el flag _isLoggingOut es true, significa que venimos del botón de logout.
            // En este caso, simplemente permitimos que el formulario se cierre para volver al login.
            if (_isLoggingOut)
            {
                return; // No hacemos nada más, el formulario se cerrará y el bucle de Program.cs continuará.
            }

            // Si el cierre fue por otra razón (como hacer clic en la 'X'), mostramos la confirmación para salir de la app.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var confirmResult = MessageBox.Show("¿Está seguro de que desea salir de la aplicación?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Cierra toda la aplicación.
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    // Cancela el evento de cierre si el usuario selecciona "No".
                    e.Cancel = true;
                }
            }
        }

        #endregion

        #region Private Helper Methods

        /// <summary>
        /// Carga el User Control para explorar recetas.
        /// </summary>
        private void LoadRecipesView() => LoadControl<Apprentice.UC_RecipiesApprentice>();

        /// <summary>
        /// Carga el User Control para gestionar las solicitudes del aprendiz.
        /// </summary>
        private void LoadAppealsView() => LoadControl<Apprentice.UC_AppealsApprentice>();

        /// <summary>
        /// Carga dinámicamente un UserControl en el panel de contenido principal.
        /// </summary>
        /// <typeparam name="T">El tipo de UserControl a cargar.</typeparam>
        private void LoadControl<T>() where T : UserControl
        {
            var control = Program.ServiceProvider?.GetRequiredService<T>();
            if (control == null)
            {
                MessageBox.Show($"No se pudo cargar el módulo de tipo {typeof(T).Name}.", "Error de Configuración", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pnlMainContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(control);
        }

        #endregion
    }
}