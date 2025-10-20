namespace CookingSharp.WindowsForms.Features.Apprentice
{
    partial class UC_RecipiesApprentice
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
            ((System.ComponentModel.ISupportInitialize)dgvRecipesApprentice).BeginInit();
            SuspendLayout();
            // 
            // lblRecetas
            // 
            lblRecetas.AutoSize = true;
            lblRecetas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRecetas.Location = new Point(58, 45);
            lblRecetas.Name = "lblRecetas";
            lblRecetas.Size = new Size(100, 32);
            lblRecetas.TabIndex = 9;
            lblRecetas.Text = "Recetas";
            // 
            // dgvRecipesApprentice
            // 
            dgvRecipesApprentice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipesApprentice.Location = new Point(58, 132);
            dgvRecipesApprentice.Name = "dgvRecipesApprentice";
            dgvRecipesApprentice.RowHeadersWidth = 62;
            dgvRecipesApprentice.Size = new Size(667, 370);
            dgvRecipesApprentice.TabIndex = 5;
            // 
            // UC_RecipiesApprentice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblRecetas);
            Controls.Add(dgvRecipesApprentice);
            Name = "UC_RecipiesApprentice";
            Size = new Size(782, 589);
            ((System.ComponentModel.ISupportInitialize)dgvRecipesApprentice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecetas;
        private DataGridView dgvRecipesApprentice;
    }
}
