using CookingSharp.Clients;
using CookingSharp.WindowsForms.AppealsControl;
using CookingSharp.WindowsForms.CategoriesControl;
using CookingSharp.WindowsForms.RecipesControl;
using CookingSharp.WindowsForms.UserControls;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            this.Load += FrmDashboard_Load;
            this.btnUserOptions.Cursor = Cursors.Hand;
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            LoadAdminPanelControl();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            LoadAdminPanelControl();
        }

        private void btnNavCategorias_Click(object sender, EventArgs e)
        {
            LoadCategoriesControl();
        }

        private void btnNavUsuarios_Click(object sender, EventArgs e)
        {
            LoadUsersControl();
        }

        private void btnNavSolicitudes_Click(object sender, EventArgs e)
        {
            LoadAppealsControl();
        }

        private void btnNavRecetas_Click(object sender, EventArgs e)
        {
            LoadRecipesControl();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de opciones de usuario para iniciar el proceso de cierre de sesión.
        /// </summary>
        private void btnUserOptions_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Está seguro de que desea cerrar la sesión?", "Confirmar Cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                SessionManager.Logout();
                this.Close();
            }
        }

        #region Métodos de Ayuda para Cargar Controles

        /// <summary>
        /// Carga dinámicamente un UserControl en el panel de contenido principal.
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