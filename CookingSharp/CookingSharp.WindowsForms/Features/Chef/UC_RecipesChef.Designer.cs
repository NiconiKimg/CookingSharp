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
            dgvRecipesApprentice = new DataGridView();
            btnCreateRecipe = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecipesApprentice).BeginInit();
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
            // dgvRecipesApprentice
            // 
            dgvRecipesApprentice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipesApprentice.Location = new Point(58, 153);
            dgvRecipesApprentice.Name = "dgvRecipesApprentice";
            dgvRecipesApprentice.RowHeadersWidth = 62;
            dgvRecipesApprentice.Size = new Size(667, 370);
            dgvRecipesApprentice.TabIndex = 10;
            // 
            // btnCreateRecipe
            // 
            btnCreateRecipe.Location = new Point(618, 113);
            btnCreateRecipe.Name = "btnCreateRecipe";
            btnCreateRecipe.Size = new Size(107, 23);
            btnCreateRecipe.TabIndex = 13;
            btnCreateRecipe.Text = "Crear Receta";
            btnCreateRecipe.UseVisualStyleBackColor = true;
            // 
            // UC_RecipesChef
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCreateRecipe);
            Controls.Add(lblRecetas);
            Controls.Add(dgvRecipesApprentice);
            Name = "UC_RecipesChef";
            Size = new Size(782, 589);
            ((System.ComponentModel.ISupportInitialize)dgvRecipesApprentice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecetas;
        private DataGridView dgvRecipesApprentice;
        private Button btnCreateRecipe;
    }
}
