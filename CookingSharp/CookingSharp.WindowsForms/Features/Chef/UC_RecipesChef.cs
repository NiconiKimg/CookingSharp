using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Chef
{
    public partial class UC_RecipesChef : UserControl
    {
        private readonly RecipeApiClient _apiClient;
        private readonly CategoryApiClient _categoryApiClient;

        public UC_RecipesChef(RecipeApiClient apiClient, CategoryApiClient categoryApiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            _categoryApiClient = categoryApiClient;
            this.Load += UCRecipes_Load;
        }

        private async void UCRecipes_Load(object sender, EventArgs e)
        {
            ConfigureGridView();
            await LoadRecipes();
            DisplayRecipeDetails(null);
        }

        private async Task LoadRecipes()
        {
            try
            {
                var recipes = await _apiClient.GetAllAsync();
                dgvRecipesChef.DataSource = recipes?.ToList();
                UpdateButtonsState();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las recetas: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGridView()
        {
            dgvRecipesChef.AutoGenerateColumns = false;
            dgvRecipesChef.Columns.Clear();

            dgvRecipesChef.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NameColumn",
                DataPropertyName = "Name",
                HeaderText = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 60,
                MinimumWidth = 200
            });

            dgvRecipesChef.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StatusColumn",
                DataPropertyName = "Status",
                HeaderText = "Estado",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                FillWeight = 40,
                MinimumWidth = 120
            });

            dgvRecipesChef.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecipesChef.MultiSelect = false;
            dgvRecipesChef.ReadOnly = true;
            dgvRecipesChef.AllowUserToAddRows = false;
            dgvRecipesChef.RowHeadersVisible = false;
            dgvRecipesChef.BackgroundColor = Color.White;
            dgvRecipesChef.BorderStyle = BorderStyle.None;

            dgvRecipesChef.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvRecipesChef.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRecipesChef.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvRecipesChef.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvRecipesChef.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvRecipesChef.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRecipesChef.EnableHeadersVisualStyles = false;
            dgvRecipesChef.ColumnHeadersHeight = 40;

            dgvRecipesChef.DefaultCellStyle.BackColor = Color.White;
            dgvRecipesChef.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvRecipesChef.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvRecipesChef.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
            dgvRecipesChef.DefaultCellStyle.SelectionForeColor = Color.FromArgb(21, 21, 21);
            dgvRecipesChef.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvRecipesChef.RowTemplate.Height = 38;
            dgvRecipesChef.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void DisplayRecipeDetails(RecipeResponseDTO? recipe)
        {
            if (recipe == null)
            {
                lblDetailName.Text = "Seleccione una receta";
                lblDetailDescription.Text = "Los detalles de la receta seleccionada se mostrarán aquí.";
                lstDetailCategories.DataSource = null;
                lstDetailSteps.DataSource = null;
            }
            else
            {
                lblDetailName.Text = recipe.Name;
                lblDetailDescription.Text = recipe.Description;
                lstDetailCategories.DataSource = recipe.Categories.Select(c => c.Name).ToList();
                lstDetailSteps.DataSource = recipe.Steps.OrderBy(s => s.StepNumber).Select(s => $"{s.StepNumber}. {s.Instruction}").ToList();
            }
        }

        private async void btnCreateRecipe_Click(object sender, EventArgs e)
        {
            using (var createForm = new FrmRecipe(_apiClient, _categoryApiClient))
            {
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadRecipes();
                }
            }
        }

        private async void btnModifyRecipe_Click(object sender, EventArgs e)
        {
            var selectedRecipe = GetSelectedRecipe();
            if (selectedRecipe == null) return;

            using (var editForm = new FrmRecipe(_apiClient, _categoryApiClient, selectedRecipe))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadRecipes();
                }
            }
        }

        private async void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            var selectedRecipe = GetSelectedRecipe();
            if (selectedRecipe == null) return;

            var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar la receta '{selectedRecipe.Name}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    bool success = await _apiClient.DeleteAsync(selectedRecipe.Id);
                    if (success)
                    {
                        await LoadRecipes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la receta: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private RecipeResponseDTO? GetSelectedRecipe()
        {
            if (dgvRecipesChef.CurrentRow != null && dgvRecipesChef.CurrentRow.DataBoundItem is RecipeResponseDTO recipe)
            {
                return recipe;
            }
            return null;
        }

        private void dgvRecipes_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRecipe = GetSelectedRecipe();
            DisplayRecipeDetails(selectedRecipe);
            UpdateButtonsState();
        }

        private void UpdateButtonsState()
        {
            bool hasSelection = dgvRecipesChef.SelectedRows.Count > 0;
            btnModifyRecipe.Enabled = hasSelection;
            btnDeleteRecipe.Enabled = hasSelection;
        }
    }
}