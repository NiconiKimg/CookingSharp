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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flpActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRejectAppeal = new System.Windows.Forms.Button();
            this.btnApproveAppeal = new System.Windows.Forms.Button();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.dgvAppeals = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.headerLayout.SuspendLayout();
            this.flpActions.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppeals)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.headerLayout);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(742, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // headerLayout
            // 
            this.headerLayout.ColumnCount = 2;
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.headerLayout.Controls.Add(this.lblTitle, 0, 0);
            this.headerLayout.Controls.Add(this.flpActions, 1, 0);
            this.headerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLayout.Location = new System.Drawing.Point(0, 0);
            this.headerLayout.Name = "headerLayout";
            this.headerLayout.RowCount = 1;
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.Size = new System.Drawing.Size(742, 80);
            this.headerLayout.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(273, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Gestión de Solicitudes";
            // 
            // flpActions
            // 
            this.flpActions.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flpActions.AutoSize = true;
            this.flpActions.Controls.Add(this.btnRejectAppeal);
            this.flpActions.Controls.Add(this.btnApproveAppeal);
            this.flpActions.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpActions.Location = new System.Drawing.Point(475, 17);
            this.flpActions.Name = "flpActions";
            this.flpActions.Size = new System.Drawing.Size(264, 46);
            this.flpActions.TabIndex = 1;
            this.flpActions.WrapContents = false;
            // 
            // btnRejectAppeal
            // 
            this.btnRejectAppeal.BackColor = System.Drawing.Color.White;
            this.btnRejectAppeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRejectAppeal.Enabled = false;
            this.btnRejectAppeal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRejectAppeal.FlatAppearance.BorderSize = 2;
            this.btnRejectAppeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejectAppeal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRejectAppeal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRejectAppeal.Location = new System.Drawing.Point(3, 3);
            this.btnRejectAppeal.Name = "btnRejectAppeal";
            this.btnRejectAppeal.Size = new System.Drawing.Size(120, 40);
            this.btnRejectAppeal.TabIndex = 2;
            this.btnRejectAppeal.Text = "Rechazar";
            this.btnRejectAppeal.UseVisualStyleBackColor = false;
            this.btnRejectAppeal.Click += new System.EventHandler(this.btnRejectAppeal_Click);
            // 
            // btnApproveAppeal
            // 
            this.btnApproveAppeal.BackColor = System.Drawing.Color.White;
            this.btnApproveAppeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApproveAppeal.Enabled = false;
            this.btnApproveAppeal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnApproveAppeal.FlatAppearance.BorderSize = 2;
            this.btnApproveAppeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproveAppeal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnApproveAppeal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnApproveAppeal.Location = new System.Drawing.Point(129, 3);
            this.btnApproveAppeal.Name = "btnApproveAppeal";
            this.btnApproveAppeal.Size = new System.Drawing.Size(132, 40);
            this.btnApproveAppeal.TabIndex = 1;
            this.btnApproveAppeal.Text = "Aprobar";
            this.btnApproveAppeal.UseVisualStyleBackColor = false;
            this.btnApproveAppeal.Click += new System.EventHandler(this.btnApproveAppeal_Click);
            // 
            // pnlGridContainer
            // 
            this.pnlGridContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.pnlGridContainer.Controls.Add(this.dgvAppeals);
            this.pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridContainer.Location = new System.Drawing.Point(20, 100);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlGridContainer.Size = new System.Drawing.Size(742, 469);
            this.pnlGridContainer.TabIndex = 2;
            // 
            // dgvAppeals
            // 
            this.dgvAppeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppeals.Location = new System.Drawing.Point(1, 1);
            this.dgvAppeals.Name = "dgvAppeals";
            this.dgvAppeals.Size = new System.Drawing.Size(740, 467);
            this.dgvAppeals.TabIndex = 0;
            this.dgvAppeals.SelectionChanged += new System.EventHandler(this.dgvAppeals_SelectionChanged);
            // 
            // UC_Appeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlGridContainer);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_Appeals";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(782, 589);
            this.pnlHeader.ResumeLayout(false);
            this.headerLayout.ResumeLayout(false);
            this.headerLayout.PerformLayout();
            this.flpActions.ResumeLayout(false);
            this.pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppeals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private System.Windows.Forms.Button btnApproveAppeal;
        private System.Windows.Forms.Button btnRejectAppeal;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dgvAppeals;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
    }
}