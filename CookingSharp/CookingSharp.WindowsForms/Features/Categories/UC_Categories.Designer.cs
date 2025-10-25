namespace CookingSharp.WindowsForms.CategoriesControl
{
    partial class UC_Categories
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flpActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.btnModifyCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.headerLayout.SuspendLayout();
            this.flpActions.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
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
            this.pnlHeader.TabIndex = 0;
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
            this.lblTitle.Size = new System.Drawing.Size(262, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Gestión de Categorías";
            // 
            // flpActions
            // 
            this.flpActions.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flpActions.AutoSize = true;
            this.flpActions.Controls.Add(this.btnDeleteCategory);
            this.flpActions.Controls.Add(this.btnModifyCategory);
            this.flpActions.Controls.Add(this.btnCreateCategory);
            this.flpActions.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpActions.Location = new System.Drawing.Point(324, 17);
            this.flpActions.Name = "flpActions";
            this.flpActions.Size = new System.Drawing.Size(415, 46);
            this.flpActions.TabIndex = 1;
            this.flpActions.WrapContents = false;
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnCreateCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateCategory.FlatAppearance.BorderSize = 0;
            this.btnCreateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCategory.ForeColor = System.Drawing.Color.White;
            this.btnCreateCategory.Location = new System.Drawing.Point(282, 3);
            this.btnCreateCategory.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(130, 40);
            this.btnCreateCategory.TabIndex = 0;
            this.btnCreateCategory.Text = "Crear Nuevo";
            this.btnCreateCategory.UseVisualStyleBackColor = false;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // btnModifyCategory
            // 
            this.btnModifyCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnModifyCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyCategory.Enabled = false;
            this.btnModifyCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnModifyCategory.FlatAppearance.BorderSize = 2;
            this.btnModifyCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModifyCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModifyCategory.Location = new System.Drawing.Point(146, 3);
            this.btnModifyCategory.Name = "btnModifyCategory";
            this.btnModifyCategory.Size = new System.Drawing.Size(120, 40);
            this.btnModifyCategory.TabIndex = 1;
            this.btnModifyCategory.Text = "Modificar";
            this.btnModifyCategory.UseVisualStyleBackColor = false;
            this.btnModifyCategory.Click += new System.EventHandler(this.btnModifyCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCategory.Enabled = false;
            this.btnDeleteCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(195)))), ((int)(((byte)(194)))));
            this.btnDeleteCategory.FlatAppearance.BorderSize = 2;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(21)))));
            this.btnDeleteCategory.Location = new System.Drawing.Point(3, 3);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(120, 40);
            this.btnDeleteCategory.TabIndex = 2;
            this.btnDeleteCategory.Text = "Eliminar";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // pnlGridContainer
            // 
            this.pnlGridContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlGridContainer.Controls.Add(this.dgvCategories);
            this.pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridContainer.Location = new System.Drawing.Point(20, 100);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlGridContainer.Size = new System.Drawing.Size(742, 469);
            this.pnlGridContainer.TabIndex = 1;
            // 
            // dgvCategories
            // 
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.Location = new System.Drawing.Point(0, 10);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(742, 459);
            this.dgvCategories.TabIndex = 0;
            this.dgvCategories.SelectionChanged += new System.EventHandler(this.dgvCategories_SelectionChanged);
            // 
            // UC_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlGridContainer);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_Categories";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(782, 589);
            this.pnlHeader.ResumeLayout(false);
            this.headerLayout.ResumeLayout(false);
            this.headerLayout.PerformLayout();
            this.flpActions.ResumeLayout(false);
            this.pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.Button btnModifyCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
    }
}