using CookingSharp.Application.DTOs;
using CookingSharp.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Chef
{
    public partial class FrmRecipe : Form
    {
        private readonly RecipeApiClient _recipeApiClient;
        private readonly CategoryApiClient _categoryApiClient;
        private readonly RecipeResponseDTO? _recipeToEdit; // Será null si es modo creación

        public FrmRecipe(RecipeApiClient recipeApiClient, CategoryApiClient categoryApiClient, RecipeResponseDTO? recipeToEdit = null)
        {
            InitializeComponent();
            _recipeApiClient = recipeApiClient;
            _categoryApiClient = categoryApiClient;
            _recipeToEdit = recipeToEdit;

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.Load += FrmRecipe_Load;
        }

        private async void FrmRecipe_Load(object sender, EventArgs e)
        {
            try
            {
                var categories = await _categoryApiClient.GetAllAsync();
                if (categories != null)
                {
                    clbCategories.DataSource = categories.ToList();
                    clbCategories.DisplayMember = "Name";
                    clbCategories.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (_recipeToEdit != null)
            {
                // Modo Edición
                lblTitle.Text = "Editar Receta";
                txtName.Text = _recipeToEdit.Name;
                txtDescription.Text = _recipeToEdit.Description;

                foreach (var step in _recipeToEdit.Steps)
                {
                    listBoxSteps.Items.Add(step.Instruction);
                }

                for (int i = 0; i < clbCategories.Items.Count; i++)
                {
                    if (clbCategories.Items[i] is CategoryResponseDTO cat && _recipeToEdit.Categories.Any(c => c.Id == cat.Id))
                    {
                        clbCategories.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {
            string newStep = txtStepInput.Text.Trim();
            if (!string.IsNullOrEmpty(newStep))
            {
                listBoxSteps.Items.Add(newStep);
                txtStepInput.Clear();
                txtStepInput.Focus();
                errorProvider1.SetError(listBoxSteps, "");
            }
        }

        private void btnRemoveStep_Click(object sender, EventArgs e)
        {
            if (listBoxSteps.SelectedItem != null)
            {
                listBoxSteps.Items.Remove(listBoxSteps.SelectedItem);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Por favor, corrija los errores marcados.", "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_recipeToEdit == null)
            {
                await CreateRecipe();
            }
            else
            {
                await UpdateRecipe();
            }
        }

        private async Task CreateRecipe()
        {
            var recipeDto = new RecipeCreateDTO
            {
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                CategoryIds = clbCategories.CheckedItems.OfType<CategoryResponseDTO>().Select(c => c.Id).ToList(),
                Steps = listBoxSteps.Items.OfType<string>().Select(instruction => new RecipeStepCreateDTO { Instruction = instruction }).ToList()
            };

            try
            {
                var createdRecipe = await _recipeApiClient.CreateAsync(recipeDto);
                if (createdRecipe != null)
                {
                    MessageBox.Show("Receta creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al crear la receta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UpdateRecipe()
        {
            var recipeDto = new RecipeUpdateDTO
            {
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                CategoryIds = clbCategories.CheckedItems.OfType<CategoryResponseDTO>().Select(c => c.Id).ToList(),
                Steps = listBoxSteps.Items.OfType<string>().Select(instruction => new RecipeStepCreateDTO { Instruction = instruction }).ToList()
            };

            try
            {
                bool success = await _recipeApiClient.UpdateAsync(_recipeToEdit.Id, recipeDto);
                if (success)
                {
                    MessageBox.Show("Receta actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar la receta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            this.Close();
        }

        #region Validation Events
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtName, "El nombre de la receta es obligatorio.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, "");
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "La descripción es obligatoria.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDescription, "");
            }
        }

        private void clbCategories_Validating(object sender, CancelEventArgs e)
        {
            if (clbCategories.CheckedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(clbCategories, "Debe seleccionar al menos una categoría.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(clbCategories, "");
            }
        }

        private void listBoxSteps_Validating(object sender, CancelEventArgs e)
        {
            if (listBoxSteps.Items.Count == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(listBoxSteps, "Debe añadir al menos un paso a la receta.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(listBoxSteps, "");
            }
        }
        #endregion
    }
}