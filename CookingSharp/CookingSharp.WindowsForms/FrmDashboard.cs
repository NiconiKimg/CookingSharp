using CookingSharp.WindowsForms.CategoriesControl;
using CookingSharp.WindowsForms.UserControls;
using Microsoft.Extensions.DependencyInjection;

namespace CookingSharp.WindowsForms
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();

            // Suscribimos los eventos en el constructor.
            this.Load += FrmDashboard_Load;
            this.btnNavCategorias.Click += btnNavCategorias_Click;
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

        #endregion

        private void btnNavUsuarios_Click(object sender, EventArgs e)
        {
            LoadUsersControl();
        }
    }
}