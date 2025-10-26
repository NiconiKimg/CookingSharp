using CookingSharp.Clients;
using CookingSharp.WindowsForms.Features.Chef;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Dashboard
{
    public partial class FrmChefDashboard : Form
    {
        public FrmChefDashboard()
        {
            InitializeComponent();
            this.Load += FrmChefDashboard_Load;
            this.btnUserOptions.Cursor = Cursors.Hand;
        }

        private void FrmChefDashboard_Load(object sender, EventArgs e)
        {
            LoadRecipesView();

            lblUserEmail.Text = SessionManager.GetUserEmail();
            lblUserRole.Text = SessionManager.GetUserRole();
        }

        private void LoadRecipesView()
        {
            LoadControl<UC_RecipesChef>();
        }

        private void btnNavRecetas_Click(object sender, EventArgs e)
        {
            LoadRecipesView();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            LoadRecipesView();
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
    }
}