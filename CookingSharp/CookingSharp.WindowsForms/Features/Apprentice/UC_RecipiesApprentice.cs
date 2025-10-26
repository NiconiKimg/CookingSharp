using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
using System.Drawing;
using System.Linq;
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
            ConfigureGridView();
            await LoadRecipes();
            DisplayRecipeDetails(null);
        }

        private async Task LoadRecipes()
        {
            try
            {
                var recipes = await _apiClient.GetAllAsync();
                dgvRecipesApprentice.DataSource = recipes?.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las recetas: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGridView()
        {
            dgvRecipesApprentice.AutoGenerateColumns = false;
            dgvRecipesApprentice.Columns.Clear();

            dgvRecipesApprentice.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NameColumn",
                DataPropertyName = "Name",
                HeaderText = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 50,
                MinimumWidth = 180
            });

            dgvRecipesApprentice.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AuthorNameColumn",
                DataPropertyName = "AuthorName",
                HeaderText = "Autor",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                FillWeight = 50,
                MinimumWidth = 150
            });

            dgvRecipesApprentice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecipesApprentice.MultiSelect = false;
            dgvRecipesApprentice.ReadOnly = true;
            dgvRecipesApprentice.AllowUserToAddRows = false;
            dgvRecipesApprentice.RowHeadersVisible = false;
            dgvRecipesApprentice.BackgroundColor = Color.White;
            dgvRecipesApprentice.BorderStyle = BorderStyle.None;

            dgvRecipesApprentice.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvRecipesApprentice.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRecipesApprentice.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvRecipesApprentice.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvRecipesApprentice.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvRecipesApprentice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRecipesApprentice.EnableHeadersVisualStyles = false;
            dgvRecipesApprentice.ColumnHeadersHeight = 40;

            dgvRecipesApprentice.DefaultCellStyle.BackColor = Color.White;
            dgvRecipesApprentice.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvRecipesApprentice.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvRecipesApprentice.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
            dgvRecipesApprentice.DefaultCellStyle.SelectionForeColor = Color.FromArgb(21, 21, 21);
            dgvRecipesApprentice.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvRecipesApprentice.RowTemplate.Height = 38;
            dgvRecipesApprentice.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
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

        private RecipeResponseDTO? GetSelectedRecipe()
        {
            if (dgvRecipesApprentice.CurrentRow != null && dgvRecipesApprentice.CurrentRow.DataBoundItem is RecipeResponseDTO recipe)
            {
                return recipe;
            }
            return null;
        }

        private void dgvRecipesApprentice_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRecipe = GetSelectedRecipe();
            DisplayRecipeDetails(selectedRecipe);
        }
    }
}