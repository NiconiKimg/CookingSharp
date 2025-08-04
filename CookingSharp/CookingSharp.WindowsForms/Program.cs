using CookingSharp.API.Clients;
//using CookingSharp.WindowsForms;
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

            var mainForm = ServiceProvider.GetRequiredService<FrmLogin>();
            Application.Run(mainForm);
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