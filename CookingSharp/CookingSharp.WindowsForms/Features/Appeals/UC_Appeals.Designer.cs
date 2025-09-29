namespace CookingSharp.WindowsForms.AppealsControl
{
    partial class UC_Appeals
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
            lblAppeals = new Label();
            btnApproveAppeal = new Button();
            btnRejectAppeal = new Button();
            dgvAppeals = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAppeals).BeginInit();
            SuspendLayout();
            // 
            // lblAppeals
            // 
            lblAppeals.AutoSize = true;
            lblAppeals.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAppeals.Location = new Point(58, 45);
            lblAppeals.Name = "lblAppeals";
            lblAppeals.Size = new Size(267, 32);
            lblAppeals.TabIndex = 9;
            lblAppeals.Text = "Gestión de Solicitudes";
            // 
            // btnApproveAppeal
            // 
            btnApproveAppeal.Location = new Point(469, 520);
            btnApproveAppeal.Name = "btnApproveAppeal";
            btnApproveAppeal.Size = new Size(124, 23);
            btnApproveAppeal.TabIndex = 8;
            btnApproveAppeal.Text = "Aprobar Solicitud";
            btnApproveAppeal.UseVisualStyleBackColor = true;
            btnApproveAppeal.Click += btnApproveAppeal_Click;
            // 
            // btnRejectAppeal
            // 
            btnRejectAppeal.Location = new Point(610, 520);
            btnRejectAppeal.Name = "btnRejectAppeal";
            btnRejectAppeal.Size = new Size(115, 23);
            btnRejectAppeal.TabIndex = 7;
            btnRejectAppeal.Text = "Rechazar Solicitud";
            btnRejectAppeal.UseVisualStyleBackColor = true;
            btnRejectAppeal.Click += btnRejectAppeal_Click;
            // 
            // dgvAppeals
            // 
            dgvAppeals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppeals.Location = new Point(58, 132);
            dgvAppeals.Name = "dgvAppeals";
            dgvAppeals.RowHeadersWidth = 62;
            dgvAppeals.Size = new Size(667, 370);
            dgvAppeals.TabIndex = 5;
            // 
            // UC_Appeals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAppeals);
            Controls.Add(btnApproveAppeal);
            Controls.Add(btnRejectAppeal);
            Controls.Add(dgvAppeals);
            Name = "UC_Appeals";
            Size = new Size(782, 589);
            ((System.ComponentModel.ISupportInitialize)dgvAppeals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAppeals;
        private Label lblAppeals;
        private Button btnApproveAppeal;
        private Button btnRejectAppeal;
    }
}
