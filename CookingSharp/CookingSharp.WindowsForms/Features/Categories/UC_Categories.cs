using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.CategoriesControl
{
    /// <summary>
    /// User Control para gestionar las categorías. Permite visualizar, crear, modificar, eliminar y filtrar categorías.
    /// </summary>
    public partial class UC_Categories : UserControl
    {
        private readonly CategoryApiClient _apiClient;
        private readonly System.Windows.Forms.Timer _searchTimer;

        /// <summary>
        /// Constructor del User Control de Categorías.
        /// </summary>
        /// <param name="apiClient">Cliente para interactuar con la API de categorías.</param>
        public UC_Categories(CategoryApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            this.Load += UCCategories_Load;

            // Inicializar el temporizador para debouncing de la búsqueda
            _searchTimer = new System.Windows.Forms.Timer();
            _searchTimer.Interval = 500; // Espera 500ms después de que el usuario deja de escribir
            _searchTimer.Tick += SearchTimer_Tick;
        }

        #region Event Handlers

        /// <summary>
        /// Manejador del evento de carga del control. Configura el DataGridView y carga las categorías iniciales.
        /// </summary>
        private async void UCCategories_Load(object sender, EventArgs e)
        {
            ConfigureGridView();
            await LoadCategories();
        }

        /// <summary>
        /// Manejador del evento Click del botón para crear una nueva categoría.
        /// </summary>
        private async void btnCreateCategory_Click(object sender, EventArgs e)
        {
            using (var createForm = Program.ServiceProvider?.GetRequiredService<frmCategoriesCreate>())
            {
                if (createForm != null && createForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadCategories(txtSearch.Text);
                }
            }
        }

        /// <summary>
        /// Manejador del evento Click del botón para modificar la categoría seleccionada.
        /// </summary>
        private async void btnModifyCategory_Click(object sender, EventArgs e)
        {
            var selectedCategory = GetSelectedCategory();
            if (selectedCategory == null) return;

            var apiClient = Program.ServiceProvider.GetRequiredService<CategoryApiClient>();

            using (var modifyForm = new frmCategoriesUpdate(apiClient, selectedCategory))
            {
                if (modifyForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadCategories(txtSearch.Text);
                }
            }
        }

        /// <summary>
        /// Manejador del evento Click del botón para eliminar la categoría seleccionada.
        /// </summary>
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
                        await LoadCategories(txtSearch.Text);
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

        /// <summary>
        /// Manejador del evento de cambio de selección en el DataGridView.
        /// </summary>
        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonsState();
        }

        /// <summary>
        /// Reinicia el temporizador de búsqueda cada vez que el usuario escribe en el cuadro de texto.
        /// </summary>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        /// <summary>
        /// Se ejecuta cuando el temporizador de búsqueda finaliza, iniciando la llamada a la API.
        /// </summary>
        private async void SearchTimer_Tick(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            await LoadCategories(txtSearch.Text);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Carga las categorías desde la API, aplicando un filtro de búsqueda si se proporciona, y las muestra en el DataGridView.
        /// </summary>
        /// <param name="searchTerm">El término de búsqueda opcional para filtrar las categorías.</param>
        private async Task LoadCategories(string? searchTerm = null)
        {
            try
            {
                var categories = await _apiClient.GetAllAsync(searchTerm);
                dgvCategories.DataSource = categories?.ToList();
                UpdateButtonsState();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Configura la apariencia y las columnas del DataGridView de categorías.
        /// </summary>
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

        /// <summary>
        /// Obtiene la categoría actualmente seleccionada en el DataGridView.
        /// </summary>
        /// <returns>La categoría seleccionada o null si no hay ninguna.</returns>
        private CategoryResponseDTO? GetSelectedCategory()
        {
            if (dgvCategories.CurrentRow != null && dgvCategories.CurrentRow.DataBoundItem is CategoryResponseDTO category)
            {
                return category;
            }
            return null;
        }

        /// <summary>
        /// Actualiza el estado (activado/desactivado) de los botones de modificar y eliminar.
        /// </summary>
        private void UpdateButtonsState()
        {
            bool hasSelection = dgvCategories.SelectedRows.Count > 0;
            btnModifyCategory.Enabled = hasSelection;
            btnDeleteCategory.Enabled = hasSelection;
        }

        #endregion
    }
}