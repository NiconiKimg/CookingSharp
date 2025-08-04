using CookingSharp.API.Clients;
using CookingSharp.DTOs;
using Microsoft.Extensions.DependencyInjection;

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
            await LoadCategories();
        }

        private async Task LoadCategories()
        {
            try
            {
                var categories = await _apiClient.GetAllAsync();

                dgvCategories.DataSource = categories?.ToList();

                ConfigureGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGridView()
        {
            if (dgvCategories.Columns.Count == 0) return;

            if (dgvCategories.Columns["Id"] != null)
                dgvCategories.Columns["Id"].Visible = false;

            if (dgvCategories.Columns["Name"] != null)
                dgvCategories.Columns["Name"].HeaderText = "Nombre";

            if (dgvCategories.Columns["Description"] != null)
                dgvCategories.Columns["Description"].HeaderText = "Descripción";

            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.MultiSelect = false;
            dgvCategories.ReadOnly = true;
            dgvCategories.AllowUserToAddRows = false;

            dgvCategories.EnableHeadersVisualStyles = false;
            dgvCategories.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvCategories.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
        }

        private async void btnCreateCategory_Click(object sender, EventArgs e)
        {

            using (var createForm = Program.ServiceProvider?.GetRequiredService<frmCategoriesCreate>())
            {
                if (createForm == null) return;
                createForm.ShowDialog();
            }

            await LoadCategories();
        }

        private async void btnModifyCategory_Click(object sender, EventArgs e)
        {
            var selectedCategory = GetSelectedCategory();
            if (selectedCategory == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
            if (selectedCategory == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
                        MessageBox.Show("La categoría no pudo ser eliminada (posiblemente ya fue borrada).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la categoría: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private CategoryDTO? GetSelectedCategory()
        {
            if (dgvCategories.CurrentRow != null && dgvCategories.CurrentRow.DataBoundItem is CategoryDTO category)
            {
                return category;
            }
            return null;
        }
    }
}