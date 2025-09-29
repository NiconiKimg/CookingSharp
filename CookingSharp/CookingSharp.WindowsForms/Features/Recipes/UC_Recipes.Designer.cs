namespace CookingSharp.WindowsForms.RecipesControl
{
    partial class UC_Recipes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblRecipes = new Label();
            btnBlockRecipe = new Button();
            dgvRecipes = new DataGridView();
            btnUnblockRecipe = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).BeginInit();
            SuspendLayout();
            // 
            // lblRecipes
            // 
            lblRecipes.AutoSize = true;
            lblRecipes.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRecipes.Location = new Point(58, 45);
            lblRecipes.Name = "lblRecipes";
            lblRecipes.Size = new Size(229, 32);
            lblRecipes.TabIndex = 8;
            lblRecipes.Text = "Gestión de Recetas";
            // 
            // btnBlockRecipe
            // 
            btnBlockRecipe.Location = new Point(610, 520);
            btnBlockRecipe.Name = "btnBlockRecipe";
            btnBlockRecipe.Size = new Size(115, 23);
            btnBlockRecipe.TabIndex = 7;
            btnBlockRecipe.Text = "Bloquear Receta";
            btnBlockRecipe.UseVisualStyleBackColor = true;
            btnBlockRecipe.Click += btnBlockRecipe_Click;
            // 
            // dgvRecipes
            // 
            dgvRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipes.Location = new Point(58, 132);
            dgvRecipes.Name = "dgvRecipes";
            dgvRecipes.RowHeadersWidth = 62;
            dgvRecipes.Size = new Size(667, 370);
            dgvRecipes.TabIndex = 5;
            // 
            // btnUnblockRecipe
            // 
            btnUnblockRecipe.Location = new Point(455, 520);
            btnUnblockRecipe.Name = "btnUnblockRecipe";
            btnUnblockRecipe.Size = new Size(124, 23);
            btnUnblockRecipe.TabIndex = 9;
            btnUnblockRecipe.Text = "Desbloquear Receta";
            btnUnblockRecipe.UseVisualStyleBackColor = true;
            btnUnblockRecipe.Click += btnUnblockRecipe_Click;
            // 
            // UC_Recipes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUnblockRecipe);
            Controls.Add(lblRecipes);
            Controls.Add(btnBlockRecipe);
            Controls.Add(dgvRecipes);
            Name = "UC_Recipes";
            Size = new Size(782, 589);
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecipes;
        private Button btnBlockRecipe;
        private DataGridView dgvRecipes;
        private Button btnUnblockRecipe;
    }
}
