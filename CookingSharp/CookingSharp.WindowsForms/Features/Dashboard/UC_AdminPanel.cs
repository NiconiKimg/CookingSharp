using CookingSharp.Clients;
using CookingSharp.WindowsForms.Users;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.UserControls
{
    public partial class UC_AdminPanel : UserControl
    {
        private readonly UserApiClient _userApiClient;
        private readonly RecipeApiClient _recipeApiClient;
        private readonly AppealApiClient _appealApiClient;
        private readonly CategoryApiClient _categoryApiClient;

        /// <summary>
        /// Constructor que recibe los clientes API necesarios a través de inyección de dependencias.
        /// </summary>
        public UC_AdminPanel(UserApiClient user, RecipeApiClient recipe, AppealApiClient appeal, CategoryApiClient category)
        {
            InitializeComponent();
            _userApiClient = user;
            _recipeApiClient = recipe;
            _appealApiClient = appeal;
            _categoryApiClient = category;

            this.Load += UC_AdminPanel_Load;
        }

        /// <summary>
        /// Se ejecuta cuando el control se carga por primera vez.
        /// </summary>
        private async void UC_AdminPanel_Load(object sender, EventArgs e)
        {
            await LoadKpiData();
        }

        /// <summary>
        /// Carga los datos de los indicadores clave de rendimiento (KPI) desde la API de forma asíncrona.
        /// </summary>
        private async Task LoadKpiData()
        {
            lblKpiUsersValue.Text = "...";
            lblKpiRecipesValue.Text = "...";
            lblKpiPendingValue.Text = "...";
            lblKpiCategoryValue.Text = "...";

            try
            {
                var userCountTask = _userApiClient.GetCountAsync();
                var recipeCountTask = _recipeApiClient.GetCountAsync();
                var pendingCountTask = _appealApiClient.GetPendingCountAsync();
                var categoryCountTask = _categoryApiClient.GetCountAsync();

                await Task.WhenAll(userCountTask, recipeCountTask, pendingCountTask, categoryCountTask);

                lblKpiUsersValue.Text = userCountTask.Result.ToString("N0");
                lblKpiRecipesValue.Text = recipeCountTask.Result.ToString("N0");
                lblKpiPendingValue.Text = pendingCountTask.Result.ToString("N0");
                lblKpiCategoryValue.Text = categoryCountTask.Result.ToString("N0");
            }
            catch (Exception ex)
            {
                lblKpiUsersValue.Text = "-";
                lblKpiRecipesValue.Text = "-";
                lblKpiPendingValue.Text = "-";
                lblKpiCategoryValue.Text = "-";
                Console.WriteLine($"Error al cargar los datos de los KPIs: {ex.Message}");
            }
        }

        /// <summary>
        /// Maneja el clic en el botón de atajo para crear un nuevo usuario.
        /// </summary>
        private async void btnNewUser_Click(object sender, EventArgs e)
        {
            using (var createUserForm = Program.ServiceProvider?.GetRequiredService<FrmUsersCreate>())
            {
                if (createUserForm?.ShowDialog() == DialogResult.OK)
                {
                    await LoadKpiData();
                }
            }
        }

        /// <summary>
        /// Maneja el clic en el botón de atajo para revisar las solicitudes pendientes.
        /// </summary>
        private void btnCheckPending_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is FrmDashboard dashboard)
            {
                dashboard.NavigateToAppeals();
            }
        }

        /// <summary>
        /// Maneja el clic en el botón de atajo para ver reportes.
        /// </summary>
        private void btnViewReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La funcionalidad de reportes aún no ha sido implementada.", "Próximamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}