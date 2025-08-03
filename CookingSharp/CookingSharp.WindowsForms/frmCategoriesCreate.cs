using System.Net.Http.Json;
using CookingSharp.Domain.Model;

namespace CookingSharp.WindowsForms
{
    public partial class frmCategoriesCreate : Form
    {
        private readonly HttpClient _httpClient;
        public frmCategoriesCreate(HttpClient httpClient)
        {
            InitializeComponent();
            _httpClient = httpClient;
        }
    }
}
