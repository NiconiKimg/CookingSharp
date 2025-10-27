using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.RecipesControl
{
    /// <summary>
    /// User Control para la gestión de recetas por parte del Administrador.
    /// </summary>
    public partial class UC_Recipes : UserControl
    {
        private readonly RecipeApiClient _recipeApiClient;
        private readonly CategoryApiClient _categoryApiClient;
        private readonly System.Windows.Forms.Timer _searchTimer;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UC_Recipes"/>.
        /// </summary>
        public UC_Recipes(RecipeApiClient recipeApiClient, CategoryApiClient categoryApiClient)
        {
            InitializeComponent();
            _recipeApiClient = recipeApiClient;
            _categoryApiClient = categoryApiClient;
            this.Load += UCRecipes_Load;

            _searchTimer = new System.Windows.Forms.Timer();
            _searchTimer.Interval = 500;
            _searchTimer.Tick += SearchTimer_Tick;
        }

        #region Event Handlers

        private async void UCRecipes_Load(object sender, EventArgs e)
        {
            ConfigureGridView();
            await PopulateCategoryFilter();
            await LoadRecipes();
            DisplayRecipeDetails(null);
        }

        /// <summary>
        /// Maneja el clic en el botón para bloquear una receta. Cambia su estado a "Blocked".
        /// </summary>
        private async void btnBlockRecipe_Click(object sender, EventArgs e)
        {
            await ProcessRecipeStatusChange("Blocked", "bloquear");
        }

        /// <summary>
        /// Maneja el clic en el botón para desbloquear una receta. Cambia su estado a "Draft".
        /// </summary>
        private async void btnUnblockRecipe_Click(object sender, EventArgs e)
        {
            // CORRECCIÓN CLAVE: Al desbloquear, el estado vuelve a "Draft" (Borrador), no a "Published".
            await ProcessRecipeStatusChange("Draft", "desbloquear y devolver a borrador");
        }

        private void dgvRecipes_SelectionChanged(object sender, EventArgs e)
        {
            DisplayRecipeDetails(GetSelectedRecipe());
            UpdateButtonsState();
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
            await LoadRecipes(txtSearch.Text, categoryId);
        }

        #endregion

        #region Private Methods

        private async Task LoadRecipes(string? searchTerm = null, int? categoryId = null)
        {
            try
            {
                var recipes = await _recipeApiClient.GetAllAsync(searchTerm, categoryId);
                dgvRecipes.DataSource = recipes?.ToList();
                UpdateButtonsState();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las recetas: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Procesa el cambio de estado de una receta, mostrando un diálogo de confirmación.
        /// </summary>
        /// <param name="newStatus">El nuevo estado para la receta (ej: "Blocked", "Draft").</param>
        /// <param name="actionText">El texto que describe la acción para el mensaje de confirmación (ej: "bloquear").</param>
        private async Task ProcessRecipeStatusChange(string newStatus, string actionText)
        {
            var selectedRecipe = GetSelectedRecipe();
            if (selectedRecipe is null) return;

            if (MessageBox.Show($"¿Está seguro de que desea {actionText} la receta '{selectedRecipe.Name}'?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var updateDto = new RecipeStatusUpdateDTO { Status = newStatus };
                    if (await _recipeApiClient.UpdateStatusAsync(selectedRecipe.Id, updateDto))
                    {
                        int? categoryId = (cmbCategoryFilter.SelectedItem as CategoryResponseDTO)?.Id;
                        await LoadRecipes(txtSearch.Text, categoryId);
                        DisplayRecipeDetails(null); // Limpiar detalles ya que la receta puede desaparecer de la lista
                    }
                    else
                    {
                        MessageBox.Show($"No se pudo {actionText} la receta.", "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al {actionText} la receta: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            dgvRecipes.AutoGenerateColumns = false;
            dgvRecipes.Columns.Clear();
            dgvRecipes.Columns.Add(new DataGridViewTextBoxColumn { Name = "NameColumn", DataPropertyName = "Name", HeaderText = "Nombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 40, MinimumWidth = 200 });
            dgvRecipes.Columns.Add(new DataGridViewTextBoxColumn { Name = "AuthorNameColumn", DataPropertyName = "AuthorName", HeaderText = "Autor", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, MinimumWidth = 150 });
            dgvRecipes.Columns.Add(new DataGridViewTextBoxColumn { Name = "StatusColumn", DataPropertyName = "Status", HeaderText = "Estado", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, MinimumWidth = 120 });
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
            return dgvRecipes.CurrentRow?.DataBoundItem as RecipeResponseDTO;
        }

        /// <summary>
        /// Actualiza la visibilidad y el estado de los botones de acción según el estado de la receta seleccionada.
        /// </summary>
        private void UpdateButtonsState()
        {
            var selectedRecipe = GetSelectedRecipe();

            // Ocultar todos los botones de acción al inicio
            btnBlockRecipe.Visible = false;
            btnUnblockRecipe.Visible = false;

            if (selectedRecipe != null)
            {
                // Lógica de visibilidad condicional
                if (selectedRecipe.Status.Equals("Published", StringComparison.OrdinalIgnoreCase))
                {
                    btnBlockRecipe.Visible = true;
                }
                else if (selectedRecipe.Status.Equals("Blocked", StringComparison.OrdinalIgnoreCase))
                {
                    btnUnblockRecipe.Visible = true;
                }
            }
        }

        #endregion
    }
}