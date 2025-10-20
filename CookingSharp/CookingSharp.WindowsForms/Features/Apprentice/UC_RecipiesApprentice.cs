using CookingSharp.Infrastructure.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Apprentice
{
    public partial class UC_RecipiesApprentice : UserControl
    {
        private readonly RecipeApiClient _apiClient;
        public UC_RecipiesApprentice(RecipeApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            this.Load += UCApprentice_Load;
        }

        private async void UCApprentice_Load(object sender, EventArgs e)
        {
            await LoadRecipes();
        }

        private async Task LoadRecipes()
        {
            try
            {
                var categories = await _apiClient.GetAllAsync();

                dgvRecipesApprentice.DataSource = categories?.ToList();

                ConfigureGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGridView()
        {
            if (dgvRecipesApprentice.Columns.Count == 0) return;

            if (dgvRecipesApprentice.Columns["Id"] != null)
                dgvRecipesApprentice.Columns["Id"].Visible = false;

            if (dgvRecipesApprentice.Columns["Content"] != null)
                dgvRecipesApprentice.Columns["Content"].HeaderText = "Receta";

            if (dgvRecipesApprentice.Columns["Categories"] != null)
                dgvRecipesApprentice.Columns["Categories"].Visible = false;

            if (dgvRecipesApprentice.Columns["Description"] != null)
                dgvRecipesApprentice.Columns["Description"].HeaderText = "Descripción";

            if (dgvRecipesApprentice.Columns["AuthorName"] != null)
                dgvRecipesApprentice.Columns["AuthorName"].HeaderText = "Autor";

            if (dgvRecipesApprentice.Columns["Status"] != null)
                dgvRecipesApprentice.Columns["Status"].HeaderText = "Estado";

            dgvRecipesApprentice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecipesApprentice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecipesApprentice.MultiSelect = false;
            dgvRecipesApprentice.ReadOnly = true;
            dgvRecipesApprentice.AllowUserToAddRows = false;

            dgvRecipesApprentice.EnableHeadersVisualStyles = false;
            dgvRecipesApprentice.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvRecipesApprentice.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
        }
    }
}
