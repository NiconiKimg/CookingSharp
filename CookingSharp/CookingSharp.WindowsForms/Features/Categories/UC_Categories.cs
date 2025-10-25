using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.CategoriesControl
{
    public partial class UC_Categories : UserControl
    {
        private readonly CategoryApiClient _apiClient;

        public UC_Categories(CategoryApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            this.Load += UCCategories_Load;
        }

        private async void UCCategories_Load(object sender, EventArgs e)
        {
            ConfigureGridView();
            await LoadCategories();
        }

        private async Task LoadCategories()
        {
            try
            {
                var categories = await _apiClient.GetAllAsync();
                dgvCategories.DataSource = categories?.ToList();
                UpdateButtonsState();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGridView()
        {
            dgvCategories.AutoGenerateColumns = false;
            dgvCategories.Columns.Clear();

            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NameColumn",
                DataPropertyName = "Name",
                HeaderText = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 40,
                MinimumWidth = 150
            });

            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DescriptionColumn",
                DataPropertyName = "Description",
                HeaderText = "Descripción",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 60,
                MinimumWidth = 200
            });

            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.MultiSelect = false;
            dgvCategories.ReadOnly = true;
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.BackgroundColor = Color.White;
            dgvCategories.BorderStyle = BorderStyle.None;


            dgvCategories.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvCategories.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCategories.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvCategories.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCategories.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvCategories.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategories.EnableHeadersVisualStyles = false;
            dgvCategories.ColumnHeadersHeight = 40;

            dgvCategories.DefaultCellStyle.BackColor = Color.White;
            dgvCategories.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvCategories.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvCategories.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
            dgvCategories.DefaultCellStyle.SelectionForeColor = Color.FromArgb(21, 21, 21);
            dgvCategories.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvCategories.RowTemplate.Height = 38;
            dgvCategories.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

        }

        private async void btnCreateCategory_Click(object sender, EventArgs e)
        {
            using (var createForm = Program.ServiceProvider?.GetRequiredService<frmCategoriesCreate>())
            {
                if (createForm != null && createForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadCategories();
                }
            }
        }

        private async void btnModifyCategory_Click(object sender, EventArgs e)
        {
            var selectedCategory = GetSelectedCategory();
            if (selectedCategory == null) return;

            var apiClient = Program.ServiceProvider.GetRequiredService<CategoryApiClient>();

            using (var modifyForm = new frmCategoriesUpdate(apiClient, selectedCategory))
            {
                if (modifyForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadCategories();
                }
            }
        }

        private async void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            var selectedCategory = GetSelectedCategory();
            if (selectedCategory == null) return;

            var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar la categoría '{selectedCategory.Name}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    bool success = await _apiClient.DeleteAsync(selectedCategory.Id);
                    if (success)
                    {
                        await LoadCategories();
                    }
                    else
                    {
                        MessageBox.Show("La categoría no pudo ser eliminada (posiblemente ya fue borrada o tiene recetas asociadas).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la categoría: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private CategoryResponseDTO? GetSelectedCategory()
        {
            if (dgvCategories.CurrentRow != null && dgvCategories.CurrentRow.DataBoundItem is CategoryResponseDTO category)
            {
                return category;
            }
            return null;
        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonsState();
        }

        private void UpdateButtonsState()
        {
            bool hasSelection = dgvCategories.SelectedRows.Count > 0;
            btnModifyCategory.Enabled = hasSelection;
            btnDeleteCategory.Enabled = hasSelection;
        }
    }
}