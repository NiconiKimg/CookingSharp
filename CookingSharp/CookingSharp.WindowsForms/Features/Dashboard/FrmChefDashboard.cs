using CookingSharp.WindowsForms.Features.Chef;
using Microsoft.Extensions.DependencyInjection;

namespace CookingSharp.WindowsForms.Features.Dashboard
{
    public partial class FrmChefDashboard : Form
    {
        public FrmChefDashboard()
        {
            InitializeComponent();
            this.Load += FrmChefDashboard_Load;
        }

        private void FrmChefDashboard_Load(object sender, EventArgs e)
        {
            // Cargar la vista principal por defecto al iniciar
            LoadRecipesView();

            // Personalizar el header con la información del usuario logueado
            lblUserEmail.Text = Clients.SessionManager.GetUserEmail();
            lblUserRole.Text = Clients.SessionManager.GetUserRole();
        }

        /// <summary>
        /// Método genérico para cargar un UserControl en el panel principal.
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

        /// <summary>
        /// Carga el UserControl que muestra las recetas del Chef.
        /// </summary>
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
            // El logo también puede servir para volver al inicio
            LoadRecipesView();
        }
    }
}