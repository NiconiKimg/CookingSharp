using Azure;
using CookingSharp.Application.DTOs;
using CookingSharp.Infrastructure.Clients;
using CookingSharp.WindowsForms.AppealsControl;
using CookingSharp.WindowsForms.CategoriesControl;
using CookingSharp.WindowsForms.Features.Dashboard;
using CookingSharp.WindowsForms.RecipesControl;
using CookingSharp.WindowsForms.UserControls;
using CookingSharp.WindowsForms.Users;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;
using CookingSharp.WindowsForms.Features.Apprentice;
using CookingSharp.WindowsForms.Features.Chef;

namespace CookingSharp.WindowsForms
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

            using (var loginForm = ServiceProvider?.GetRequiredService<FrmLogin>())
            {
                DialogResult result = loginForm?.ShowDialog() ?? DialogResult.Cancel;
                if (result == DialogResult.OK)
                {
                    var userRole = SessionManager.CurrentUser?.Role;

                    Form? mainForm = null;

                    switch (userRole)
                    {
                        case Domain.User.RoleTypes.Admin:
                            mainForm = ServiceProvider?.GetRequiredService<FrmDashboard>();
                            break;

                        case Domain.User.RoleTypes.Chef:
                            mainForm = ServiceProvider?.GetRequiredService<FrmChefDashboard>();
                            break;

                        case Domain.User.RoleTypes.Apprentice:
                            mainForm = ServiceProvider?.GetRequiredService<FrmApprenticeDashboard>();
                            break;

                        default:
                            MessageBox.Show("Rol de usuario no reconocido. La aplicación se cerrará.", "Error de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            System.Windows.Forms.Application.Exit();
                            break;
                    }

                    if (mainForm != null)
                    {
                        System.Windows.Forms.Application.Run(mainForm);
                    }
                }
                else
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            
            services.AddTransient<AuthenticationHandler>();

            // Category
            services.AddHttpClient<CategoryApiClient>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7111/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            })
            .AddHttpMessageHandler<AuthenticationHandler>()
            .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            });

            // Appeals
            services.AddHttpClient<AppealApiClient>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7111/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            })
            .AddHttpMessageHandler<AuthenticationHandler>()
            .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            });

            // Recipes
            services.AddHttpClient<RecipeApiClient>(recipe =>
            {
                recipe.BaseAddress = new Uri("https://localhost:7111/api/");
                recipe.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            })
            .AddHttpMessageHandler<AuthenticationHandler>()
            .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            });

            // Users
            services.AddHttpClient<UserApiClient>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7111/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            })
            .AddHttpMessageHandler<AuthenticationHandler>()
            .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            });

            // Auth
            services.AddHttpClient<AuthApiClient>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7111/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            })
            .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            });

            services.AddTransient<FrmLogin>();

            services.AddTransient<FrmDashboard>();
            services.AddTransient<FrmChefDashboard>();
            services.AddTransient<FrmApprenticeDashboard>();

            services.AddTransient<frmCategoriesCreate>();
            services.AddTransient<FrmUsersCreate>();
            services.AddTransient<frmAppeal>();
            services.AddTransient<FrmRecipe>();
            services.AddTransient<UC_AdminPanel>();
            services.AddTransient<UC_RecipesChef>();
            services.AddTransient<UC_Appeals>();
            services.AddTransient<UC_Categories>();
            services.AddTransient<UC_Recipes>();
            services.AddTransient<UC_Users>();
            services.AddTransient<UC_AppealsApprentice>();
            services.AddTransient<UC_RecipiesApprentice>();
        }
    }
}