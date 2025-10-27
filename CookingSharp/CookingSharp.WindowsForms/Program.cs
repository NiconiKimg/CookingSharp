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
using CookingSharp.WindowsForms.Features.Reports;
using System;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms
{
    /// <summary>
    /// Clase principal de la aplicación. Responsable de la configuración, inyección de dependencias,
    /// y del control del flujo principal de autenticación y navegación.
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

            // Bucle principal que gestiona el ciclo de vida de la sesión.
            while (true)
            {
                SessionManager.Logout(); // Asegura que cualquier sesión anterior esté cerrada.

                using (var loginForm = ServiceProvider.GetRequiredService<FrmLogin>())
                {
                    // Muestra el formulario de login como un diálogo modal.
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        // Si el login es exitoso, lanza el dashboard correspondiente.
                        // El código se detendrá aquí hasta que el dashboard se cierre.
                        LaunchDashboardBasedOnRole();
                    }
                    else
                    {
                        // Si el usuario cierra el login con la 'X' o cancela,
                        // se rompe el bucle y la aplicación termina.
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

            // Formularios
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

            // User Controls
            services.AddTransient<UC_AdminPanel>();
            services.AddTransient<UC_Categories>();
            services.AddTransient<UC_Users>();
            services.AddTransient<UC_Appeals>();
            services.AddTransient<UC_Recipes>();
            services.AddTransient<UC_Chef_MyRecipes>();
            services.AddTransient<UC_Chef_ExploreRecipes>();
            services.AddTransient<UC_AppealsApprentice>();
            services.AddTransient<UC_RecipiesApprentice>();
            services.AddTransient<UC_Reports>();
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
                    return; // Vuelve al bucle principal que mostrará el login.
            }

            // Inicia el bucle de mensajes para el formulario del dashboard.
            // El código en Main() esperará aquí hasta que este formulario se cierre.
            System.Windows.Forms.Application.Run(mainForm);
        }
    }
}