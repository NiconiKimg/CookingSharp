using CookingSharp.Clients;
using CookingSharp.WindowsForms.Features.Chef; // Asegúrate de tener este using
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Dashboard
{
    /// <summary>
    /// Dashboard principal para el rol de Chef.
    /// </summary>
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
            // Cargar la vista de "Mis Recetas" por defecto al iniciar
            LoadMyRecipesView();

            lblUserEmail.Text = SessionManager.GetUserEmail();
            lblUserRole.Text = SessionManager.GetUserRole();
        }

        /// <summary>
        /// Carga el User Control para gestionar las recetas propias del Chef.
        /// </summary>
        private void LoadMyRecipesView()
        {
            LoadControl<UC_Chef_MyRecipes>();
        }

        /// <summary>
        /// Carga el User Control para explorar las recetas de otros Chefs.
        /// </summary>
        private void LoadExploreView()
        {
            LoadControl<UC_Chef_ExploreRecipes>();
        }

        /// <summary>
        /// Manejador del evento Click para el botón de navegación "Mis Recetas".
        /// </summary>
        private void btnNavMisRecetas_Click(object sender, EventArgs e)
        {
            LoadMyRecipesView();
        }

        /// <summary>
        /// Manejador del evento Click para el botón de navegación "Explorar".
        /// </summary>
        private void btnNavExplorar_Click(object sender, EventArgs e)
        {
            LoadExploreView();
        }

        /// <summary>
        /// Manejador del evento Click en el logo para volver a la vista principal.
        /// </summary>
        private void picLogo_Click(object sender, EventArgs e)
        {
            LoadMyRecipesView(); // Vuelve a "Mis Recetas" por defecto
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

        /// <summary>
        /// Carga dinámicamente un UserControl en el panel de contenido principal.
        /// </summary>
        /// <typeparam name="T">El tipo de UserControl a cargar.</typeparam>
        private void LoadControl<T>() where T : UserControl
        {
            // Primero, debemos registrar los nuevos UserControls en la inyección de dependencias.
            // Esto se hará en Program.cs

            var control = Program.ServiceProvider?.GetRequiredService<T>();

            if (control == null)
            {
                MessageBox.Show($"No se pudo cargar el módulo de tipo {typeof(T).Name}. Asegúrese de que esté registrado en Program.cs.", "Error de Configuración", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pnlMainContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(control);
        }
    }
}