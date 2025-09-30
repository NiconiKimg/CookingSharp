using CookingSharp.Application.DTOs;
using CookingSharp.Infrastructure.Clients;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Chef
{
    public partial class UC_RecipesChef : UserControl
    {
        private readonly RecipeApiClient _apiClient;

        public UC_RecipesChef(RecipeApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            this.Load += UCRecipes_Load;
        }

        private async void UCRecipes_Load(object sender, EventArgs e)
        {
            await LoadRecipes();
        }

        private async Task LoadRecipes()
        {
            try
            {
                var recipes = await _apiClient.GetAllAsync();
                dgvRecipesChef.DataSource = recipes?.ToList();
                ConfigureGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las recetas: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGridView()
        {
            if (dgvRecipesChef.Columns.Count == 0) return;

            if (dgvRecipesChef.Columns["Id"] != null)
                dgvRecipesChef.Columns["Id"].Visible = false;

            if (dgvRecipesChef.Columns["Content"] != null)
                dgvRecipesChef.Columns["Content"].Visible = false;

            if (dgvRecipesChef.Columns["Categories"] != null)
                dgvRecipesChef.Columns["Categories"].Visible = false;

            if (dgvRecipesChef.Columns["Description"] != null)
                dgvRecipesChef.Columns["Description"].HeaderText = "Descripción";

            if (dgvRecipesChef.Columns["AuthorName"] != null)
                dgvRecipesChef.Columns["AuthorName"].HeaderText = "Autor";

            if (dgvRecipesChef.Columns["Status"] != null)
                dgvRecipesChef.Columns["Status"].HeaderText = "Estado";

            dgvRecipesChef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecipesChef.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecipesChef.MultiSelect = false;
            dgvRecipesChef.ReadOnly = true;
            dgvRecipesChef.AllowUserToAddRows = false;

            dgvRecipesChef.EnableHeadersVisualStyles = false;
            dgvRecipesChef.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvRecipesChef.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
        }

        private async void btnCreateRecipe_Click(object sender, EventArgs e)
        {

            using (var createForm = Program.ServiceProvider?.GetRequiredService<FrmRecipe>())
            {
                if (createForm == null) return;
                createForm.ShowDialog();
            }

            await LoadRecipes();
        }
    }
}
