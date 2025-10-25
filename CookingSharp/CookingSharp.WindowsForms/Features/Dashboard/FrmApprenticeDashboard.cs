using CookingSharp.WindowsForms.Features.Apprentice;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Dashboard
{
    public partial class FrmApprenticeDashboard : Form
    {
        public FrmApprenticeDashboard()
        {
            InitializeComponent();
            this.Load += FrmApprenticeDashboard_Load;
        }

        private void FrmApprenticeDashboard_Load(object sender, EventArgs e)
        {
            // Cargar la vista de recetas por defecto al iniciar
            LoadRecipesView();

            // Personalizar el encabezado con la información del usuario
            lblUserEmail.Text = Clients.SessionManager.GetUserEmail();
            lblUserRole.Text = Clients.SessionManager.GetUserRole();
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

        private void LoadRecipesView()
        {
            LoadControl<UC_RecipiesApprentice>();
        }

        private void LoadAppealsView()
        {
            LoadControl<UC_AppealsApprentice>();
        }

        private void btnNavRecetas_Click(object sender, EventArgs e)
        {
            LoadRecipesView();
        }

        private void btnNavSolicitudes_Click(object sender, EventArgs e)
        {
            LoadAppealsView();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            // El logo también sirve para volver a la vista principal
            LoadRecipesView();
        }
    }
}