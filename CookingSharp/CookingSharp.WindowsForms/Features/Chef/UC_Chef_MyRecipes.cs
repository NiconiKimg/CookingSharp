using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Chef
{
    /// <summary>
    /// User Control para que el Chef gestione sus propias recetas.
    /// Permite crear, editar, eliminar y cambiar el estado de sus recetas.
    /// </summary>
    public partial class UC_Chef_MyRecipes : UserControl
    {
        private readonly RecipeApiClient _recipeApiClient;
        private readonly CategoryApiClient _categoryApiClient;

        public UC_Chef_MyRecipes(RecipeApiClient recipeApiClient, CategoryApiClient categoryApiClient)
        {
            InitializeComponent();
            _recipeApiClient = recipeApiClient;
            _categoryApiClient = categoryApiClient;
            this.Load += UC_Chef_MyRecipes_Load;
        }

        #region Event Handlers

        private async void UC_Chef_MyRecipes_Load(object sender, EventArgs e)
        {
            ConfigureGridView();
            await LoadMyRecipes();
            DisplayRecipeDetails(null);
        }

        private async void btnCreateRecipe_Click(object sender, EventArgs e)
        {
            using (var createForm = new FrmRecipe(_recipeApiClient, _categoryApiClient))
            {
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadMyRecipes();
                }
            }
        }

        private async void btnModifyRecipe_Click(object sender, EventArgs e)
        {
            var selectedRecipe = GetSelectedRecipe();
            if (selectedRecipe == null) return;

            if (selectedRecipe.Status != "Draft")
            {
                MessageBox.Show("Solo se pueden modificar recetas que están en estado 'Borrador'.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var editForm = new FrmRecipe(_recipeApiClient, _categoryApiClient, selectedRecipe))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadMyRecipes();
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
                    if (await _recipeApiClient.DeleteAsync(selectedRecipe.Id))
                    {
                        await LoadMyRecipes();
                        DisplayRecipeDetails(null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la receta: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvRecipesChef_SelectionChanged(object sender, EventArgs e)
        {
            DisplayRecipeDetails(GetSelectedRecipe());
            UpdateButtonsState();
        }

        private async void btnPublish_Click(object sender, EventArgs e) => await ProcessRecipeStatusChange("Published");

        private async void btnArchive_Click(object sender, EventArgs e) => await ProcessRecipeStatusChange("Archived");

        private async void btnToDraft_Click(object sender, EventArgs e) => await ProcessRecipeStatusChange("Draft");

        #endregion

        #region Private Methods

        private async Task LoadMyRecipes()
        {
            try
            {
                var myRecipes = await _recipeApiClient.GetMyFullRecipesAsync();
                dgvRecipesChef.DataSource = myRecipes?.ToList();
                UpdateButtonsState();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tus recetas: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ProcessRecipeStatusChange(string newStatus)
        {
            var selectedRecipe = GetSelectedRecipe();
            if (selectedRecipe is null) return;

            if (MessageBox.Show($"¿Está seguro de que desea cambiar el estado de esta receta a '{newStatus}'?", "Confirmar Cambio de Estado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var updateDto = new RecipeStatusUpdateDTO { Status = newStatus };
                    if (await _recipeApiClient.UpdateStatusAsync(selectedRecipe.Id, updateDto))
                    {
                        await LoadMyRecipes();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cambiar el estado de la receta.", "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cambiar el estado: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConfigureGridView()
        {
            dgvRecipesChef.AutoGenerateColumns = false;
            dgvRecipesChef.Columns.Clear();

            dgvRecipesChef.Columns.Add(new DataGridViewTextBoxColumn { Name = "NameColumn", DataPropertyName = "Name", HeaderText = "Nombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 60, MinimumWidth = 200 });
            dgvRecipesChef.Columns.Add(new DataGridViewTextBoxColumn { Name = "StatusColumn", DataPropertyName = "Status", HeaderText = "Estado", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, FillWeight = 40, MinimumWidth = 120 });

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

        private RecipeResponseDTO? GetSelectedRecipe()
        {
            return dgvRecipesChef.CurrentRow?.DataBoundItem as RecipeResponseDTO;
        }

        private void UpdateButtonsState()
        {
            var selectedRecipe = GetSelectedRecipe();
            bool hasSelection = selectedRecipe != null;

            btnModifyRecipe.Enabled = hasSelection;
            btnDeleteRecipe.Enabled = hasSelection;

            btnPublish.Visible = hasSelection && selectedRecipe.Status == "Draft";
            btnArchive.Visible = hasSelection && selectedRecipe.Status == "Published";
            btnToDraft.Visible = hasSelection && selectedRecipe.Status == "Archived";
        }

        #endregion
    }
}