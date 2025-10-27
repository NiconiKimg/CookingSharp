using CookingSharp.Clients;
using CookingSharp.WindowsForms.Features.Apprentice;
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
        /// Maneja el clic en el botón de cerrar sesión. Cierra el formulario actual para volver al login.
        /// </summary>
        private void btnUserOptions_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Está seguro de que desea cerrar la sesión?", "Confirmar Cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Maneja el evento que se dispara cuando el usuario intenta cerrar el formulario (ej. con la 'X').
        /// Pide confirmación y, si es afirmativa, cierra toda la aplicación.
        /// </summary>
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var confirmResult = MessageBox.Show("¿Está seguro de que desea salir de la aplicación?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        #endregion

        #region Private Helper Methods

        /// <summary>
        /// Carga el User Control para explorar recetas.
        /// </summary>
        private void LoadRecipesView() => LoadControl<UC_RecipiesApprentice>();

        /// <summary>
        /// Carga el User Control para gestionar las solicitudes del aprendiz.
        /// </summary>
        private void LoadAppealsView() => LoadControl<UC_AppealsApprentice>();

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