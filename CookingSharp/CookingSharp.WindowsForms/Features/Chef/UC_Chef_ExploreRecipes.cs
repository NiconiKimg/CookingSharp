using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Chef
{
    /// <summary>
    /// User Control que permite a los chefs explorar todas las recetas públicas del sistema.
    /// Proporciona funcionalidades de búsqueda y filtrado de solo lectura.
    /// </summary>
    public partial class UC_Chef_ExploreRecipes : UserControl
    {
        private readonly RecipeApiClient _recipeApiClient;
        private readonly CategoryApiClient _categoryApiClient;
        private readonly System.Windows.Forms.Timer _searchTimer;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UC_Chef_ExploreRecipes"/>.
        /// </summary>
        /// <param name="recipeApiClient">El cliente para interactuar con la API de recetas.</param>
        /// <param name="categoryApiClient">El cliente para interactuar con la API de categorías.</param>
        public UC_Chef_ExploreRecipes(RecipeApiClient recipeApiClient, CategoryApiClient categoryApiClient)
        {
            InitializeComponent();
            _recipeApiClient = recipeApiClient;
            _categoryApiClient = categoryApiClient;
            this.Load += UC_Chef_ExploreRecipes_Load;

            _searchTimer = new System.Windows.Forms.Timer();
            _searchTimer.Interval = 500; // 500ms de espera para el debouncing
            _searchTimer.Tick += SearchTimer_Tick;
        }

        #region Event Handlers

        private async void UC_Chef_ExploreRecipes_Load(object sender, EventArgs e)
        {
            ConfigureGridView();
            await PopulateCategoryFilter();
            await LoadPublicRecipes();
            DisplayRecipeDetails(null);
        }

        private void dgvRecipes_SelectionChanged(object sender, EventArgs e)
        {
            DisplayRecipeDetails(GetSelectedRecipe());
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

        /// <summary>
        /// Carga las recetas públicas desde la API, aplicando filtros opcionales.
        /// </summary>
        /// <param name="searchTerm">Término de búsqueda opcional.</param>
        /// <param name="categoryId">ID de categoría opcional.</param>
        private async Task LoadPublicRecipes(string? searchTerm = null, int? categoryId = null)
        {
            try
            {
                var recipes = await _recipeApiClient.GetAllAsync(searchTerm, categoryId);
                // Filtramos en el cliente para mostrar solo las publicadas (el rol de Chef no debe ver las bloqueadas)
                dgvRecipes.DataSource = recipes?.Where(r => r.Status == "Published").ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las recetas: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga y configura el ComboBox de filtro por categorías.
        /// </summary>
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

        /// <summary>
        /// Configura la apariencia y las columnas del DataGridView.
        /// </summary>
        private void ConfigureGridView()
        {
            dgvRecipes.AutoGenerateColumns = false;
            dgvRecipes.Columns.Clear();

            dgvRecipes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NameColumn",
                DataPropertyName = "Name",
                HeaderText = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 50,
                MinimumWidth = 200
            });

            dgvRecipes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AuthorNameColumn",
                DataPropertyName = "AuthorName",
                HeaderText = "Autor",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                FillWeight = 50,
                MinimumWidth = 150
            });

            dgvRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecipes.MultiSelect = false;
            dgvRecipes.ReadOnly = true;
            dgvRecipes.AllowUserToAddRows = false;
            dgvRecipes.RowHeadersVisible = false;
            dgvRecipes.BackgroundColor = Color.White;
            dgvRecipes.BorderStyle = BorderStyle.None;

            dgvRecipes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvRecipes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRecipes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvRecipes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvRecipes.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvRecipes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRecipes.EnableHeadersVisualStyles = false;
            dgvRecipes.ColumnHeadersHeight = 40;

            dgvRecipes.DefaultCellStyle.BackColor = Color.White;
            dgvRecipes.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvRecipes.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvRecipes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
            dgvRecipes.DefaultCellStyle.SelectionForeColor = Color.FromArgb(21, 21, 21);
            dgvRecipes.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvRecipes.RowTemplate.Height = 38;
            dgvRecipes.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        /// <summary>
        /// Muestra los detalles de la receta seleccionada en el panel lateral.
        /// </summary>
        /// <param name="recipe">La receta a mostrar.</param>
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

        /// <summary>
        /// Obtiene la receta seleccionada en el DataGridView.
        /// </summary>
        /// <returns>El DTO de la receta seleccionada.</returns>
        private RecipeResponseDTO? GetSelectedRecipe()
        {
            return dgvRecipes.CurrentRow?.DataBoundItem as RecipeResponseDTO;
        }

        #endregion
    }
}