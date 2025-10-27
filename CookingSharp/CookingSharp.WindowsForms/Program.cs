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
    /// Clase principal de la aplicaci�n. Responsable de la configuraci�n, inyecci�n de dependencias,
    /// y del control del flujo principal de autenticaci�n y navegaci�n.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Proveedor de servicios de inyecci�n de dependencias para toda la aplicaci�n.
        /// </summary>
        public static IServiceProvider? ServiceProvider { get; private set; }

        /// <summary>
        /// Punto de entrada principal de la aplicaci�n.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

            // Bucle principal que gestiona el ciclo de vida de la sesi�n.
            while (true)
            {
                SessionManager.Logout(); // Asegura que cualquier sesi�n anterior est� cerrada.

                using (var loginForm = ServiceProvider.GetRequiredService<FrmLogin>())
                {
                    // Muestra el formulario de login como un di�logo modal.
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        // Si el login es exitoso, lanza el dashboard correspondiente.
                        // El c�digo se detendr� aqu� hasta que el dashboard se cierre.
                        LaunchDashboardBasedOnRole();
                    }
                    else
                    {
                        // Si el usuario cierra el login con la 'X' o cancela,
                        // se rompe el bucle y la aplicaci�n termina.
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Configura el contenedor de inyecci�n de dependencias (DI) para la aplicaci�n.
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
                    return;
            }

            System.Windows.Forms.Application.Run(mainForm);
        }
    }
}