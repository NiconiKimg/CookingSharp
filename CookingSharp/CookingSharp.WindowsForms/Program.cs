/// <summary>
/// Archivo principal de la aplicación Windows Forms.
/// Responsable de configurar la inyección de dependencias,
/// gestionar el flujo de autenticación y lanzar el panel de control correspondiente al rol del usuario.
/// </summary>
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

            // Iniciar el flujo de la aplicación con el formulario de Login
            using (var loginForm = ServiceProvider.GetRequiredService<FrmLogin>())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Si el login es exitoso, determinar qué panel mostrar basado en el rol del usuario
                    LaunchDashboardBasedOnRole();
                }
                else
                {
                    // Si el login se cancela o falla, cerrar la aplicación
                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        /// <summary>
        /// Configura el contenedor de inyección de dependencias.
        /// </summary>
        private static void ConfigureServices(IServiceCollection services)
        {
            // URL base de la API. En un proyecto real, esto debería leerse desde un archivo de configuración.
            const string baseApiAddress = "https://localhost:7111";

            // Usar el método de extensión del proyecto Clients para registrar todos los ApiClients
            // de forma centralizada y correcta. Esto incluye el AuthenticationHandler.
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
        /// Lanza el panel de control (Dashboard) apropiado según el rol del usuario autenticado.
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
                    MessageBox.Show("Rol de usuario no reconocido. La aplicación se cerrará.", "Error de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Windows.Forms.Application.Exit();
                    return;
            }

            System.Windows.Forms.Application.Run(mainForm);
        }
    }
}