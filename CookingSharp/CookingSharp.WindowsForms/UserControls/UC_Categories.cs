using System.Net.Http.Json;
using System.Threading.Tasks;
using CookingSharp.Domain.Model;

namespace CookingSharp.WindowsForms.CategoriesControl
{
    public partial class UC_Categories : UserControl
    {
        public UC_Categories()
        {
            InitializeComponent();
            this.Load += UCCategories_Load;
        }

        private readonly HttpClient _httpClient = new HttpClient(
            new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true // Bypass SSL validation for local development
            })
        {
            BaseAddress = new Uri("https://localhost:7111/api/")
        };

        private async void UCCategories_Load(object sender, EventArgs e)
        {
            await LoadCategories();
        }

        private async Task LoadCategories()
        {
            var categories = await _httpClient.GetFromJsonAsync<IEnumerable<Category>>("categories");
            dgvCategories.DataSource = categories.ToList();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var frmCreateCategory = new frmCategoriesCreate(_httpClient);
            frmCreateCategory.ShowDialog();
            await LoadCategories();
        }
    }
}
