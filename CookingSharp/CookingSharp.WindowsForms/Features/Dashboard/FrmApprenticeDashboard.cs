using CookingSharp.WindowsForms.Features.Apprentice;
using Microsoft.Extensions.DependencyInjection;

namespace CookingSharp.WindowsForms.Features.Dashboard
{
    public partial class FrmApprenticeDashboard : Form
    {
        public FrmApprenticeDashboard()
        {
            InitializeComponent();
            this.Load += FrmDashboard_Load;
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            LoadRecipesView();
        }

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

        private void LoadRecipesView()
        {
            LoadControl<UC_RecipiesApprentice>();
        }
    }
}
