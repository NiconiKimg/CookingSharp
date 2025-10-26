using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.RecipesControl
{
    public partial class UC_Recipes : UserControl
    {
        private readonly RecipeApiClient _apiClient;

        public UC_Recipes(RecipeApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
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
                dgvRecipes.DataSource = recipes?.ToList();
                UpdateButtonsState();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las recetas: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                FillWeight = 40,
                MinimumWidth = 200
            });

            dgvRecipes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AuthorNameColumn",
                DataPropertyName = "AuthorName",
                HeaderText = "Autor",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                MinimumWidth = 150
            });

            dgvRecipes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StatusColumn",
                DataPropertyName = "Status",
                HeaderText = "Estado",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                MinimumWidth = 120
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

        private async void btnBlockRecipe_Click(object sender, EventArgs e)
        {
            await ProcessRecipeStatusChange("Blocked");
        }

        private async void btnUnblockRecipe_Click(object sender, EventArgs e)
        {
            await ProcessRecipeStatusChange("Published");
        }

        private async Task ProcessRecipeStatusChange(string newStatus)
        {
            var selectedRecipe = GetSelectedRecipe();
            if (selectedRecipe is null) return;

            string action = newStatus == "Blocked" ? "bloquear" : "desbloquear";
            if (selectedRecipe.Status.Equals(newStatus, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show($"La receta ya se encuentra en estado '{newStatus}'.", "Acción no requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show($"¿Está seguro de que desea {action} esta receta?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var updateDto = new RecipeStatusUpdateDTO { Status = newStatus };
                    bool success = await _apiClient.UpdateStatusAsync(selectedRecipe.Id, updateDto);
                    if (success)
                    {
                        await LoadRecipes();
                    }
                    else
                    {
                        MessageBox.Show($"No se pudo {action} la receta.", "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al {action} la receta: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private RecipeResponseDTO? GetSelectedRecipe()
        {
            if (dgvRecipes.CurrentRow != null && dgvRecipes.CurrentRow.DataBoundItem is RecipeResponseDTO recipe)
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
            bool hasSelection = dgvRecipes.SelectedRows.Count > 0;
            btnBlockRecipe.Enabled = hasSelection;
            btnUnblockRecipe.Enabled = hasSelection;
        }
    }
}