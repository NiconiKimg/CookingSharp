using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Apprentice
{
    /// <summary>
    /// User Control para que los Aprendices exploren las recetas públicas.
    /// </summary>
    public partial class UC_RecipiesApprentice : UserControl
    {
        private readonly RecipeApiClient _recipeApiClient;
        private readonly CategoryApiClient _categoryApiClient;
        private readonly System.Windows.Forms.Timer _searchTimer;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UC_RecipiesApprentice"/>.
        /// </summary>
        /// <param name="recipeApiClient">El cliente para la API de recetas.</param>
        /// <param name="categoryApiClient">El cliente para la API de categorías.</param>
        public UC_RecipiesApprentice(RecipeApiClient recipeApiClient, CategoryApiClient categoryApiClient)
        {
            InitializeComponent();
            _recipeApiClient = recipeApiClient;
            _categoryApiClient = categoryApiClient;
            this.Load += UCApprentice_Load;

            _searchTimer = new System.Windows.Forms.Timer();
            _searchTimer.Interval = 500;
            _searchTimer.Tick += SearchTimer_Tick;
        }

        #region Event Handlers

        private async void UCApprentice_Load(object sender, EventArgs e)
        {
            ConfigureGridView();
            await PopulateCategoryFilter();
            await LoadPublicRecipes();
            DisplayRecipeDetails(null);
        }

        private async void dgvRecipesApprentice_SelectionChanged(object sender, EventArgs e)
        {
            var selectedSummary = GetSelectedRecipeSummary();
            if (selectedSummary == null)
            {
                DisplayRecipeDetails(null);
                return;
            }

            try
            {
                // Hacemos una llamada para obtener los detalles completos, incluyendo los pasos
                var fullRecipe = await _recipeApiClient.GetByIdAsync(selectedSummary.Id);
                DisplayRecipeDetails(fullRecipe);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los detalles de la receta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisplayRecipeDetails(null);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        private async void SearchTimer_Tick(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            int? categoryId = (cmbCategoryFilter.SelectedItem as CategoryResponseDTO)?.Id;
            await LoadPublicRecipes(txtSearch.Text, categoryId);
        }

        #endregion

        #region Private Methods

        private async Task LoadPublicRecipes(string? searchTerm = null, int? categoryId = null)
        {
            try
            {
                var recipes = await _recipeApiClient.GetAllSummariesAsync(searchTerm, categoryId);
                dgvRecipesApprentice.DataSource = recipes?.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las recetas: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task PopulateCategoryFilter()
        {
            try
            {
                var categories = (await _categoryApiClient.GetAllAsync())?.ToList() ?? new List<CategoryResponseDTO>();
                categories.Insert(0, new CategoryResponseDTO { Id = 0, Name = "Todas las categorías" });
                cmbCategoryFilter.DataSource = categories;
                cmbCategoryFilter.DisplayMember = "Name";
                cmbCategoryFilter.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el filtro de categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private RecipeSummaryDTO? GetSelectedRecipeSummary()
        {
            return dgvRecipesApprentice.CurrentRow?.DataBoundItem as RecipeSummaryDTO;
        }
        #endregion
    }
}