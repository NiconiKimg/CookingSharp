using CookingSharp.Clients;
using CookingSharp.WindowsForms.Features.Chef;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Dashboard
{
    /// <summary>
    /// Formulario principal del panel del Chef.
    /// Permite la navegación entre la gestión de sus propias recetas y la exploración de recetas públicas.
    /// </summary>
    public partial class FrmChefDashboard : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmChefDashboard"/>.
        /// </summary>
        public FrmChefDashboard()
        {
            InitializeComponent();
            this.Load += FrmChefDashboard_Load;
            this.btnUserOptions.Cursor = Cursors.Hand;
            this.FormClosing += Dashboard_FormClosing; // Suscripción al evento de cierre.
        }

        #region Event Handlers

        /// <summary>
        /// Maneja el evento de carga del formulario. Carga la vista de "Mis Recetas" por defecto.
        /// </summary>
        private void FrmChefDashboard_Load(object sender, EventArgs e)
        {
            LoadMyRecipesView();
            lblUserEmail.Text = SessionManager.GetUserEmail();
            lblUserRole.Text = SessionManager.GetUserRole();
        }

        /// <summary>
        /// Navega a la vista de gestión de las recetas del propio Chef.
        /// </summary>
        private void btnNavMisRecetas_Click(object sender, EventArgs e) => LoadMyRecipesView();

        /// <summary>
        /// Navega a la vista de exploración de recetas públicas.
        /// </summary>
        private void btnNavExplorar_Click(object sender, EventArgs e) => LoadExploreView();

        /// <summary>
        /// Maneja el clic en el logo para volver a la vista principal ("Mis Recetas").
        /// </summary>
        private void picLogo_Click(object sender, EventArgs e) => LoadMyRecipesView();

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
        /// Carga el User Control para gestionar las recetas propias del Chef.
        /// </summary>
        private void LoadMyRecipesView() => LoadControl<UC_Chef_MyRecipes>();

        /// <summary>
        /// Carga el User Control para explorar las recetas de otros Chefs.
        /// </summary>
        private void LoadExploreView() => LoadControl<UC_Chef_ExploreRecipes>();

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