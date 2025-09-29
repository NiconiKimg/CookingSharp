using CookingSharp.Application.DTOs;
using CookingSharp.Infrastructure.Clients;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

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
            await LoadRecipes();
        }

        private async Task LoadRecipes()
        {
            try
            {
                var recipes = await _apiClient.GetAllAsync();
                dgvRecipes.DataSource = recipes?.ToList();
                ConfigureGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las recetas: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGridView()
        {
            if (dgvRecipes.Columns.Count == 0) return;

            if (dgvRecipes.Columns["Id"] != null)
                dgvRecipes.Columns["Id"].Visible = false;

            if (dgvRecipes.Columns["Content"] != null)
                dgvRecipes.Columns["Content"].Visible = false;

            if (dgvRecipes.Columns["Categories"] != null)
                dgvRecipes.Columns["Categories"].Visible = false;

            if (dgvRecipes.Columns["Description"] != null)
                dgvRecipes.Columns["Description"].HeaderText = "Descripción";

            if (dgvRecipes.Columns["AuthorName"] != null)
                dgvRecipes.Columns["AuthorName"].HeaderText = "Autor";

            if (dgvRecipes.Columns["Status"] != null)
                dgvRecipes.Columns["Status"].HeaderText = "Estado";

            dgvRecipes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecipes.MultiSelect = false;
            dgvRecipes.ReadOnly = true;
            dgvRecipes.AllowUserToAddRows = false;

            dgvRecipes.EnableHeadersVisualStyles = false;
            dgvRecipes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvRecipes.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
        }

        #region Botones de Estado (Block/Unblock)

        private async void btnBlockRecipe_Click(object sender, EventArgs e)
        {
            await ProcessRecipeStatusChange("Blocked");
        }

        private async void btnUnblockRecipe_Click(object sender, EventArgs e)
        {
            await ProcessRecipeStatusChange("Draft");
        }

        private async Task ProcessRecipeStatusChange(string newStatus)
        {
            var selectedRecipe = GetSelectedRecipe();
            if (selectedRecipe == null)
            {
                MessageBox.Show("Por favor, seleccione una receta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (selectedRecipe.Status.Equals(newStatus, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show($"La receta ya se encuentra en estado '{newStatus}'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string action = newStatus == "Blocked" ? "bloquear" : "desbloquear";
            var confirmResult = MessageBox.Show($"¿Está seguro de que desea {action} esta receta?", $"Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {

                    var updateDto = new UpdateRecipeDTO { Status = newStatus };

                    bool success = await _apiClient.UpdateAsync(selectedRecipe.Id, updateDto);
                    if (success)
                    {
                        await LoadRecipes();
                    }
                    else
                    {
                        MessageBox.Show($"No se pudo {action} la receta. Es posible que los datos enviados no sean válidos.", "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al {action} la receta: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        private ResponseRecipeDTO? GetSelectedRecipe()
        {
            if (dgvRecipes.CurrentRow != null && dgvRecipes.CurrentRow.DataBoundItem is ResponseRecipeDTO recipe)
            {
                return recipe;
            }
            return null;
        }
    }
}