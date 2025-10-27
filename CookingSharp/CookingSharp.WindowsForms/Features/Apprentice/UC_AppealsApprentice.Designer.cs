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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flpActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateAppeal = new System.Windows.Forms.Button();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.dgvAppealApprentice = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.headerLayout.SuspendLayout();
            this.flpActions.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppealApprentice)).BeginInit();
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
            this.pnlHeader.TabIndex = 4;
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
            this.headerLayout.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mis Solicitudes";
            // 
            // flpActions
            // 
            this.flpActions.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flpActions.AutoSize = true;
            this.flpActions.Controls.Add(this.btnCreateAppeal);
            this.flpActions.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpActions.Location = new System.Drawing.Point(579, 17);
            this.flpActions.Name = "flpActions";
            this.flpActions.Size = new System.Drawing.Size(160, 46);
            this.flpActions.TabIndex = 1;
            this.flpActions.WrapContents = false;
            // 
            // btnCreateAppeal
            // 
            this.btnCreateAppeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnCreateAppeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAppeal.FlatAppearance.BorderSize = 0;
            this.btnCreateAppeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAppeal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAppeal.ForeColor = System.Drawing.Color.White;
            this.btnCreateAppeal.Location = new System.Drawing.Point(10, 3);
            this.btnCreateAppeal.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnCreateAppeal.Name = "btnCreateAppeal";
            this.btnCreateAppeal.Size = new System.Drawing.Size(147, 40);
            this.btnCreateAppeal.TabIndex = 0;
            this.btnCreateAppeal.Text = "Nueva Solicitud";
            this.btnCreateAppeal.UseVisualStyleBackColor = false;
            this.btnCreateAppeal.Click += new System.EventHandler(this.btnCreateAppeal_Click);
            // 
            // pnlGridContainer
            // 
            this.pnlGridContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.pnlGridContainer.Controls.Add(this.dgvAppealApprentice);
            this.pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridContainer.Location = new System.Drawing.Point(20, 100);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlGridContainer.Size = new System.Drawing.Size(742, 469);
            this.pnlGridContainer.TabIndex = 5;
            // 
            // dgvAppealApprentice
            // 
            this.dgvAppealApprentice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppealApprentice.Location = new System.Drawing.Point(1, 1);
            this.dgvAppealApprentice.Name = "dgvAppealApprentice";
            this.dgvAppealApprentice.Size = new System.Drawing.Size(740, 467);
            this.dgvAppealApprentice.TabIndex = 0;
            // 
            // UC_AppealsApprentice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlGridContainer);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_AppealsApprentice";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(782, 589);
            this.pnlHeader.ResumeLayout(false);
            this.headerLayout.ResumeLayout(false);
            this.headerLayout.PerformLayout();
            this.flpActions.ResumeLayout(false);
            this.pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppealApprentice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private System.Windows.Forms.Button btnCreateAppeal;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dgvAppealApprentice;
    }
}