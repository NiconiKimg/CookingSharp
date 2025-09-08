using CookingSharp.Infrastructure.Clients;
using CookingSharp.WindowsForms.CategoriesControl;
using CookingSharp.WindowsForms.UserControls;
using CookingSharp.WindowsForms.Users;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;

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
                    var mainForm = ServiceProvider?.GetRequiredService<FrmDashboard>();
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

            services.AddHttpClient<CategoryApiClient>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7111/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            })
            .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            });

            services.AddHttpClient<UserApiClient>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7111/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            })
            .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            });
            services.AddTransient<FrmLogin>();
            services.AddTransient<FrmDashboard>();

            services.AddTransient<frmCategoriesCreate>();
            services.AddTransient<FrmUsersCreate>();

            services.AddTransient<UC_Categories>();
            services.AddTransient<UC_AdminPanel>();
            services.AddTransient<UC_Users>();
        }
    }
}