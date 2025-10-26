using CookingSharp.Clients;
using CookingSharp.WindowsForms.AppealsControl;
using CookingSharp.WindowsForms.CategoriesControl;
using CookingSharp.WindowsForms.Features.Apprentice;
using CookingSharp.WindowsForms.Features.Authentication;
using CookingSharp.WindowsForms.Features.Chef;
using CookingSharp.WindowsForms.Features.Dashboard;
using CookingSharp.WindowsForms.RecipesControl;
using CookingSharp.WindowsForms.UserControls;
using CookingSharp.WindowsForms.Users;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms
{
    /// <summary>
    /// Clase principal de la aplicación. Responsable de la configuración
    /// y del control del flujo principal (login, dashboards, logout).
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Proveedor de servicios de inyección de dependencias para toda la aplicación.
        /// </summary>
        public static IServiceProvider? ServiceProvider { get; private set; }

        /// <summary>
        /// Punto de entrada principal de la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

            while (true)
            {
                SessionManager.Logout();

                using (var loginForm = ServiceProvider.GetRequiredService<FrmLogin>())
                {
                    var loginResult = loginForm.ShowDialog();

                    if (loginResult == DialogResult.OK)
                    {
                        LaunchDashboardBasedOnRole();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Configura el contenedor de inyección de dependencias (DI) para la aplicación.
        /// </summary>
        private static void ConfigureServices(IServiceCollection services)
        {
            const string baseApiAddress = "https://localhost:7111";
            services.AddApiClients(baseApiAddress);

            services.AddTransient<FrmLogin>();
            services.AddTransient<FrmDashboard>();
            services.AddTransient<FrmChefDashboard>();
            services.AddTransient<FrmApprenticeDashboard>();
            services.AddTransient<frmCategoriesCreate>();
            services.AddTransient<frmCategoriesUpdate>();
            services.AddTransient<FrmUsersCreate>();
            services.AddTransient<FrmUsersUpdate>();
            services.AddTransient<frmAppeal>();
            services.AddTransient<FrmRecipe>();

            services.AddTransient<UC_AdminPanel>();
            services.AddTransient<UC_Categories>();
            services.AddTransient<UC_Users>();
            services.AddTransient<UC_Appeals>();
            services.AddTransient<UC_Recipes>();
            services.AddTransient<UC_RecipesChef>();
            services.AddTransient<UC_AppealsApprentice>();
            services.AddTransient<UC_RecipiesApprentice>();
        }

        /// <summary>
        /// Determina el rol del usuario autenticado y lanza el dashboard correspondiente.
        /// </summary>
        private static void LaunchDashboardBasedOnRole()
        {
            if (ServiceProvider is null) return;

            var userRole = SessionManager.GetUserRole();
            Form? mainForm = null;

            switch (userRole)
            {
                case "Admin":
                    mainForm = ServiceProvider.GetRequiredService<FrmDashboard>();
                    break;
                case "Chef":
                    mainForm = ServiceProvider.GetRequiredService<FrmChefDashboard>();
                    break;
                case "Apprentice":
                    mainForm = ServiceProvider.GetRequiredService<FrmApprenticeDashboard>();
                    break;
                default:
                    MessageBox.Show("Rol de usuario no reconocido. Volviendo a la pantalla de inicio.", "Error de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SessionManager.Logout();
                    return;
            }

            System.Windows.Forms.Application.Run(mainForm);
        }
    }
}