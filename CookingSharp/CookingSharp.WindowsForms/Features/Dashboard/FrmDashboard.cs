using CookingSharp.WindowsForms.AppealsControl;
using CookingSharp.WindowsForms.CategoriesControl;
using CookingSharp.WindowsForms.RecipesControl;
using CookingSharp.WindowsForms.UserControls;
using Microsoft.Extensions.DependencyInjection;

namespace CookingSharp.WindowsForms
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            this.Load += FrmDashboard_Load;
            this.btnNavCategorias.Click += btnNavCategorias_Click;
            this.btnNavSolicitudes.Click += btnNavSolicitudes_Click;
            this.btnNavRecetas.Click += btnNavRecetas_Click;
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

        #region Métodos de Ayuda para Cargar Controles

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

        private void LoadAdminPanelControl()
        {
            LoadControl<UC_AdminPanel>();
        }

        private void LoadCategoriesControl()
        {
            LoadControl<UC_Categories>();
        }

        private void LoadUsersControl()
        {
            LoadControl<UC_Users>();
        }

        private void LoadAppealsControl()
        {
            LoadControl<UC_Appeals>();
        }

        private void LoadRecipesControl()
        {
            LoadControl<UC_Recipes>();
        }

        #endregion

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
    }
}