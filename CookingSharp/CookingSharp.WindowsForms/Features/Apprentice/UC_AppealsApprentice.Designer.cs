namespace CookingSharp.WindowsForms.Features.Apprentice
{
    partial class UC_AppealsApprentice
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
            dgvAppealApprentice = new DataGridView();
            btnCreateAppeal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAppealApprentice).BeginInit();
            SuspendLayout();
            // 
            // lblRecetas
            // 
            lblRecetas.AutoSize = true;
            lblRecetas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRecetas.Location = new Point(58, 66);
            lblRecetas.Name = "lblRecetas";
            lblRecetas.Size = new Size(138, 32);
            lblRecetas.TabIndex = 11;
            lblRecetas.Text = "Solicitudes";
            // 
            // dgvAppealApprentice
            // 
            dgvAppealApprentice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppealApprentice.Location = new Point(58, 153);
            dgvAppealApprentice.Name = "dgvAppealApprentice";
            dgvAppealApprentice.RowHeadersWidth = 62;
            dgvAppealApprentice.Size = new Size(667, 370);
            dgvAppealApprentice.TabIndex = 10;
            // 
            // btnCreateAppeal
            // 
            btnCreateAppeal.Location = new Point(618, 114);
            btnCreateAppeal.Name = "btnCreateAppeal";
            btnCreateAppeal.Size = new Size(107, 23);
            btnCreateAppeal.TabIndex = 12;
            btnCreateAppeal.Text = "Crear Solicitud";
            btnCreateAppeal.UseVisualStyleBackColor = true;
            // 
            // UC_AppealsApprentice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCreateAppeal);
            Controls.Add(lblRecetas);
            Controls.Add(dgvAppealApprentice);
            Name = "UC_AppealsApprentice";
            Size = new Size(782, 589);
            ((System.ComponentModel.ISupportInitialize)dgvAppealApprentice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecetas;
        private DataGridView dgvAppealApprentice;
        private Button btnCreateAppeal;
    }
}
