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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Categories));
            pnlHeader = new Panel();
            headerLayout = new TableLayoutPanel();
            lblTitle = new Label();
            flpActions = new FlowLayoutPanel();
            btnDeleteCategory = new Button();
            btnModifyCategory = new Button();
            btnCreateCategory = new Button();
            pnlGridContainer = new Panel();
            dgvCategories = new DataGridView();
            pnlSearch = new Panel();
            pnlSearchContainer = new Panel();
            txtSearch = new TextBox();
            picSearchIcon = new PictureBox();
            pnlHeader.SuspendLayout();
            headerLayout.SuspendLayout();
            flpActions.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            pnlSearch.SuspendLayout();
            pnlSearchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(headerLayout);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(20, 23);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(742, 91);
            pnlHeader.TabIndex = 0;
            // 
            // headerLayout
            // 
            headerLayout.ColumnCount = 2;
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            headerLayout.ColumnStyles.Add(new ColumnStyle());
            headerLayout.Controls.Add(lblTitle, 0, 0);
            headerLayout.Controls.Add(flpActions, 1, 0);
            headerLayout.Dock = DockStyle.Fill;
            headerLayout.Location = new Point(0, 0);
            headerLayout.Name = "headerLayout";
            headerLayout.RowCount = 1;
            headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            headerLayout.Size = new Size(742, 91);
            headerLayout.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(3, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(264, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gestión de Categorías";
            // 
            // flpActions
            // 
            flpActions.Anchor = AnchorStyles.Right;
            flpActions.AutoSize = true;
            flpActions.Controls.Add(btnDeleteCategory);
            flpActions.Controls.Add(btnModifyCategory);
            flpActions.Controls.Add(btnCreateCategory);
            flpActions.Location = new Point(344, 20);
            flpActions.Name = "flpActions";
            flpActions.Size = new Size(395, 51);
            flpActions.TabIndex = 1;
            flpActions.WrapContents = false;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.BackColor = Color.FromArgb(253, 237, 237);
            btnDeleteCategory.Cursor = Cursors.Hand;
            btnDeleteCategory.Enabled = false;
            btnDeleteCategory.FlatAppearance.BorderColor = Color.FromArgb(249, 195, 194);
            btnDeleteCategory.FlatAppearance.BorderSize = 2;
            btnDeleteCategory.FlatStyle = FlatStyle.Flat;
            btnDeleteCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDeleteCategory.ForeColor = Color.FromArgb(186, 24, 21);
            btnDeleteCategory.Location = new Point(3, 3);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(120, 45);
            btnDeleteCategory.TabIndex = 2;
            btnDeleteCategory.Text = "Eliminar";
            btnDeleteCategory.UseVisualStyleBackColor = false;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnModifyCategory
            // 
            btnModifyCategory.BackColor = Color.FromArgb(248, 249, 250);
            btnModifyCategory.Cursor = Cursors.Hand;
            btnModifyCategory.Enabled = false;
            btnModifyCategory.FlatAppearance.BorderColor = Color.FromArgb(222, 226, 230);
            btnModifyCategory.FlatAppearance.BorderSize = 2;
            btnModifyCategory.FlatStyle = FlatStyle.Flat;
            btnModifyCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnModifyCategory.ForeColor = Color.FromArgb(64, 64, 64);
            btnModifyCategory.Location = new Point(129, 3);
            btnModifyCategory.Name = "btnModifyCategory";
            btnModifyCategory.Size = new Size(120, 45);
            btnModifyCategory.TabIndex = 1;
            btnModifyCategory.Text = "Modificar";
            btnModifyCategory.UseVisualStyleBackColor = false;
            btnModifyCategory.Click += btnModifyCategory_Click;
            // 
            // btnCreateCategory
            // 
            btnCreateCategory.BackColor = Color.FromArgb(13, 110, 253);
            btnCreateCategory.Cursor = Cursors.Hand;
            btnCreateCategory.FlatAppearance.BorderSize = 0;
            btnCreateCategory.FlatStyle = FlatStyle.Flat;
            btnCreateCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateCategory.ForeColor = Color.White;
            btnCreateCategory.Location = new Point(262, 3);
            btnCreateCategory.Margin = new Padding(10, 3, 3, 3);
            btnCreateCategory.Name = "btnCreateCategory";
            btnCreateCategory.Size = new Size(130, 45);
            btnCreateCategory.TabIndex = 0;
            btnCreateCategory.Text = "Crear Nuevo";
            btnCreateCategory.UseVisualStyleBackColor = false;
            btnCreateCategory.Click += btnCreateCategory_Click;
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.BackColor = Color.WhiteSmoke;
            pnlGridContainer.Controls.Add(dgvCategories);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(20, 171);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(0, 11, 0, 0);
            pnlGridContainer.Size = new Size(742, 474);
            pnlGridContainer.TabIndex = 1;
            // 
            // dgvCategories
            // 
            dgvCategories.Dock = DockStyle.Fill;
            dgvCategories.Location = new Point(0, 11);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.Size = new Size(742, 463);
            dgvCategories.TabIndex = 0;
            dgvCategories.SelectionChanged += dgvCategories_SelectionChanged;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.White;
            pnlSearch.Controls.Add(pnlSearchContainer);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(20, 114);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Padding = new Padding(3, 11, 3, 0);
            pnlSearch.Size = new Size(742, 57);
            pnlSearch.TabIndex = 3;
            // 
            // pnlSearchContainer
            // 
            pnlSearchContainer.BackColor = Color.White;
            pnlSearchContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlSearchContainer.Controls.Add(txtSearch);
            pnlSearchContainer.Controls.Add(picSearchIcon);
            pnlSearchContainer.Location = new Point(6, 14);
            pnlSearchContainer.Name = "pnlSearchContainer";
            pnlSearchContainer.Size = new Size(320, 34);
            pnlSearchContainer.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(30, 0);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Buscar por nombre...";
            txtSearch.Size = new Size(288, 32);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // picSearchIcon
            // 
            picSearchIcon.BackColor = Color.White;
            picSearchIcon.Dock = DockStyle.Left;
            picSearchIcon.Image = (Image)resources.GetObject("picSearchIcon.Image");
            picSearchIcon.Location = new Point(0, 0);
            picSearchIcon.Name = "picSearchIcon";
            picSearchIcon.Padding = new Padding(5, 6, 5, 6);
            picSearchIcon.Size = new Size(30, 32);
            picSearchIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            picSearchIcon.TabIndex = 2;
            picSearchIcon.TabStop = false;
            // 
            // UC_Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlSearch);
            Controls.Add(pnlHeader);
            Name = "UC_Categories";
            Padding = new Padding(20, 23, 20, 23);
            Size = new Size(782, 668);
            pnlHeader.ResumeLayout(false);
            headerLayout.ResumeLayout(false);
            headerLayout.PerformLayout();
            flpActions.ResumeLayout(false);
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearchContainer.ResumeLayout(false);
            pnlSearchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchIcon).EndInit();
            ResumeLayout(false);

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
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlSearchContainer;
        private System.Windows.Forms.PictureBox picSearchIcon;
    }
}