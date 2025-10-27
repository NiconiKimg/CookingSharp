using CookingSharp.Clients;
using CookingSharp.WindowsForms.AppealsControl;
using CookingSharp.WindowsForms.CategoriesControl;
using CookingSharp.WindowsForms.RecipesControl;
using CookingSharp.WindowsForms.UserControls;
using CookingSharp.WindowsForms.Users;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms
{
    /// <summary>
    /// Formulario principal del panel de administración.
    /// Actúa como contenedor para los diferentes módulos de gestión (Usuarios, Recetas, etc.).
    /// </summary>
    public partial class FrmDashboard : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmDashboard"/>.
        /// </summary>
        public FrmDashboard()
        {
            InitializeComponent();
            this.Load += FrmDashboard_Load;
            this.btnUserOptions.Cursor = Cursors.Hand;
            this.FormClosing += Dashboard_FormClosing; // Suscripción al evento de cierre.
        }

        #region Event Handlers

        /// <summary>
        /// Maneja el evento de carga del formulario. Carga el panel de administración por defecto.
        /// </summary>
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            LoadAdminPanelControl();
            lblUserEmail.Text = SessionManager.GetUserEmail();
            lblUserRole.Text = SessionManager.GetUserRole();
        }

        /// <summary>
        /// Maneja el clic en el logo para volver al panel de administración principal.
        /// </summary>
        private void picLogo_Click(object sender, EventArgs e) => LoadAdminPanelControl();

        /// <summary>
        /// Navega a la vista de gestión de categorías.
        /// </summary>
        private void btnNavCategorias_Click(object sender, EventArgs e) => LoadCategoriesControl();

        /// <summary>
        /// Navega a la vista de gestión de usuarios.
        /// </summary>
        private void btnNavUsuarios_Click(object sender, EventArgs e) => LoadUsersControl();

        /// <summary>
        /// Navega a la vista de gestión de solicitudes.
        /// </summary>
        private void btnNavSolicitudes_Click(object sender, EventArgs e) => LoadAppealsControl();

        /// <summary>
        /// Navega a la vista de gestión de recetas.
        /// </summary>
        private void btnNavRecetas_Click(object sender, EventArgs e) => LoadRecipesControl();

        /// <summary>
        /// Maneja el clic en el botón de cerrar sesión. Cierra el formulario actual para volver al login.
        /// </summary>
        private void btnUserOptions_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Está seguro de que desea cerrar la sesión?", "Confirmar Cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Cierra solo este formulario, permitiendo que Program.cs muestre el login.
                this.Close();
            }
        }

        /// <summary>
        /// Maneja el evento que se dispara cuando el usuario intenta cerrar el formulario (ej. con la 'X').
        /// Pide confirmación y, si es afirmativa, cierra toda la aplicación.
        /// </summary>
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Solo actuar si el cierre fue iniciado por una acción del usuario.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var confirmResult = MessageBox.Show("¿Está seguro de que desea salir de la aplicación?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Forzar la terminación de todo el proceso de la aplicación.
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    // Cancelar el evento de cierre si el usuario selecciona "No".
                    e.Cancel = true;
                }
            }
        }

        #endregion

        /// <summary>
        /// Permite que los User Controls hijos (como el panel de admin) soliciten la navegación a la sección de Solicitudes.
        /// </summary>
        public void NavigateToAppeals() => LoadAppealsControl();

        #region Private Helper Methods

        /// <summary>
        /// Carga dinámicamente un UserControl en el panel de contenido principal, reemplazando el contenido anterior.
        /// </summary>
        /// <typeparam name="T">El tipo de UserControl a cargar.</typeparam>
        private void LoadControl<T>() where T : UserControl
        {
            var control = Program.ServiceProvider?.GetRequiredService<T>();
            if (control == null)
            {
                MessageBox.Show($"No se pudo cargar el módulo de tipo {typeof(T).Name}.", "Error de Configuración");
                return;
            }

            pnlMainContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(control);
        }

        private void LoadAdminPanelControl() => LoadControl<UC_AdminPanel>();
        private void LoadCategoriesControl() => LoadControl<UC_Categories>();
        private void LoadUsersControl() => LoadControl<UC_Users>();
        private void LoadAppealsControl() => LoadControl<UC_Appeals>();
        private void LoadRecipesControl() => LoadControl<UC_Recipes>();

        #endregion
    }
}