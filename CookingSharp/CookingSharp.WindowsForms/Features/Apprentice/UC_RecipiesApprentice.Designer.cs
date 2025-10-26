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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvRecipesApprentice = new System.Windows.Forms.DataGridView();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDetailName = new System.Windows.Forms.Label();
            this.lblDetailDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDetailCategories = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDetailSteps = new System.Windows.Forms.ListBox();
            this.pnlHeader.SuspendLayout();
            this.headerLayout.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipesApprentice)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.pnlHeader.TabIndex = 3;
            // 
            // headerLayout
            // 
            this.headerLayout.ColumnCount = 1;
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.Controls.Add(this.lblTitle, 0, 0);
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
            this.lblTitle.Size = new System.Drawing.Size(242, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Recetas Disponibles";
            // 
            // pnlGridContainer
            // 
            this.pnlGridContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.pnlGridContainer.Controls.Add(this.splitContainer1);
            this.pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridContainer.Location = new System.Drawing.Point(20, 100);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlGridContainer.Size = new System.Drawing.Size(742, 469);
            this.pnlGridContainer.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(1, 1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvRecipesApprentice);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlDetails);
            this.splitContainer1.Size = new System.Drawing.Size(740, 467);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvRecipesApprentice
            // 
            this.dgvRecipesApprentice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipesApprentice.Location = new System.Drawing.Point(0, 0);
            this.dgvRecipesApprentice.Name = "dgvRecipesApprentice";
            this.dgvRecipesApprentice.Size = new System.Drawing.Size(350, 467);
            this.dgvRecipesApprentice.TabIndex = 0;
            this.dgvRecipesApprentice.SelectionChanged += new System.EventHandler(this.dgvRecipesApprentice_SelectionChanged);
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Controls.Add(this.tableLayoutPanel1);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDetails.Size = new System.Drawing.Size(386, 467);
            this.pnlDetails.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblDetailName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDetailDescription, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lstDetailCategories, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lstDetailSteps, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 437);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDetailName
            // 
            this.lblDetailName.AutoSize = true;
            this.lblDetailName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailName.Location = new System.Drawing.Point(3, 0);
            this.lblDetailName.Name = "lblDetailName";
            this.lblDetailName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblDetailName.Size = new System.Drawing.Size(211, 35);
            this.lblDetailName.TabIndex = 0;
            this.lblDetailName.Text = "Seleccione una receta";
            // 
            // lblDetailDescription
            // 
            this.lblDetailDescription.AutoEllipsis = true;
            this.lblDetailDescription.AutoSize = true;
            this.lblDetailDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetailDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDetailDescription.Location = new System.Drawing.Point(3, 35);
            this.lblDetailDescription.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblDetailDescription.Name = "lblDetailDescription";
            this.lblDetailDescription.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.lblDetailDescription.Size = new System.Drawing.Size(350, 49);
            this.lblDetailDescription.TabIndex = 1;
            this.lblDetailDescription.Text = "Los detalles de la receta seleccionada se mostrarán aquí.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categorías";
            // 
            // lstDetailCategories
            // 
            this.lstDetailCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDetailCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDetailCategories.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lstDetailCategories.FormattingEnabled = true;
            this.lstDetailCategories.ItemHeight = 17;
            this.lstDetailCategories.Location = new System.Drawing.Point(3, 119);
            this.lstDetailCategories.Name = "lstDetailCategories";
            this.lstDetailCategories.Size = new System.Drawing.Size(350, 74);
            this.lstDetailCategories.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 196);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.label2.Size = new System.Drawing.Size(43, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pasos";
            // 
            // lstDetailSteps
            // 
            this.lstDetailSteps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDetailSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDetailSteps.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lstDetailSteps.FormattingEnabled = true;
            this.lstDetailSteps.ItemHeight = 17;
            this.lstDetailSteps.Location = new System.Drawing.Point(3, 231);
            this.lstDetailSteps.Name = "lstDetailSteps";
            this.lstDetailSteps.Size = new System.Drawing.Size(350, 203);
            this.lstDetailSteps.TabIndex = 5;
            // 
            // UC_RecipiesApprentice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlGridContainer);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_RecipiesApprentice";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(782, 589);
            this.pnlHeader.ResumeLayout(false);
            this.headerLayout.ResumeLayout(false);
            this.headerLayout.PerformLayout();
            this.pnlGridContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipesApprentice)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvRecipesApprentice;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDetailName;
        private System.Windows.Forms.Label lblDetailDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDetailCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDetailSteps;
    }
}