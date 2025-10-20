namespace CookingSharp.WindowsForms.Features.Chef
{
    partial class UC_RecipesChef
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
            lblRecetas = new Label();
            dgvRecipesChef = new DataGridView();
            btnCreateRecipe = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecipesChef).BeginInit();
            SuspendLayout();
            // 
            // lblRecetas
            // 
            lblRecetas.AutoSize = true;
            lblRecetas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRecetas.Location = new Point(58, 66);
            lblRecetas.Name = "lblRecetas";
            lblRecetas.Size = new Size(100, 32);
            lblRecetas.TabIndex = 11;
            lblRecetas.Text = "Recetas";
            // 
            // dgvRecipesChef
            // 
            dgvRecipesChef.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipesChef.Location = new Point(58, 153);
            dgvRecipesChef.Name = "dgvRecipesChef";
            dgvRecipesChef.RowHeadersWidth = 62;
            dgvRecipesChef.Size = new Size(667, 370);
            dgvRecipesChef.TabIndex = 10;
            // 
            // btnCreateRecipe
            // 
            btnCreateRecipe.Location = new Point(618, 113);
            btnCreateRecipe.Name = "btnCreateRecipe";
            btnCreateRecipe.Size = new Size(107, 23);
            btnCreateRecipe.TabIndex = 13;
            btnCreateRecipe.Text = "Crear Receta";
            btnCreateRecipe.UseVisualStyleBackColor = true;
            btnCreateRecipe.Click += btnCreateRecipe_Click;
            // 
            // UC_RecipesChef
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCreateRecipe);
            Controls.Add(lblRecetas);
            Controls.Add(dgvRecipesChef);
            Name = "UC_RecipesChef";
            Size = new Size(782, 589);
            ((System.ComponentModel.ISupportInitialize)dgvRecipesChef).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecetas;
        private DataGridView dgvRecipesChef;
        private Button btnCreateRecipe;
    }
}
