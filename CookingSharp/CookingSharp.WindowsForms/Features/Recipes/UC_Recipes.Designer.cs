namespace CookingSharp.WindowsForms.RecipesControl
{
    partial class UC_Recipes
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
            pnlHeader = new Panel();
            btnBlockRecipe = new Button();
            btnUnblockRecipe = new Button();
            lblTitle = new Label();
            pnlGridContainer = new Panel();
            splitContainer1 = new SplitContainer();
            dgvRecipes = new DataGridView();
            pnlDetails = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblDetailName = new Label();
            lblDetailDescription = new Label();
            label1 = new Label();
            lstDetailCategories = new ListBox();
            label2 = new Label();
            lstDetailSteps = new ListBox();
            pnlSearch = new Panel();
            cmbCategoryFilter = new ComboBox();
            pnlSearchContainer = new Panel();
            txtSearch = new TextBox();
            picSearchIcon = new PictureBox();
            pnlHeader.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).BeginInit();
            pnlDetails.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlSearch.SuspendLayout();
            pnlSearchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(btnBlockRecipe);
            pnlHeader.Controls.Add(btnUnblockRecipe);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(20, 23);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(742, 91);
            pnlHeader.TabIndex = 2;
            // 
            // btnBlockRecipe
            // 
            btnBlockRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBlockRecipe.BackColor = Color.White;
            btnBlockRecipe.Cursor = Cursors.Hand;
            btnBlockRecipe.FlatAppearance.BorderColor = Color.FromArgb(220, 53, 69);
            btnBlockRecipe.FlatAppearance.BorderSize = 2;
            btnBlockRecipe.FlatStyle = FlatStyle.Flat;
            btnBlockRecipe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBlockRecipe.ForeColor = Color.FromArgb(220, 53, 69);
            btnBlockRecipe.Location = new Point(619, 24);
            btnBlockRecipe.Name = "btnBlockRecipe";
            btnBlockRecipe.Size = new Size(120, 45);
            btnBlockRecipe.TabIndex = 2;
            btnBlockRecipe.Text = "Bloquear";
            btnBlockRecipe.UseVisualStyleBackColor = false;
            btnBlockRecipe.Click += btnBlockRecipe_Click;
            // 
            // btnUnblockRecipe
            // 
            btnUnblockRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUnblockRecipe.BackColor = Color.White;
            btnUnblockRecipe.Cursor = Cursors.Hand;
            btnUnblockRecipe.FlatAppearance.BorderColor = Color.FromArgb(25, 135, 84);
            btnUnblockRecipe.FlatAppearance.BorderSize = 2;
            btnUnblockRecipe.FlatStyle = FlatStyle.Flat;
            btnUnblockRecipe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUnblockRecipe.ForeColor = Color.FromArgb(25, 135, 84);
            btnUnblockRecipe.Location = new Point(493, 24);
            btnUnblockRecipe.Name = "btnUnblockRecipe";
            btnUnblockRecipe.Size = new Size(120, 45);
            btnUnblockRecipe.TabIndex = 3;
            btnUnblockRecipe.Text = "Desbloquear";
            btnUnblockRecipe.UseVisualStyleBackColor = false;
            btnUnblockRecipe.Click += btnUnblockRecipe_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(3, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(229, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gestión de Recetas";
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.BackColor = Color.WhiteSmoke;
            pnlGridContainer.Controls.Add(splitContainer1);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(20, 171);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(0, 11, 0, 0);
            pnlGridContainer.Size = new Size(742, 474);
            pnlGridContainer.TabIndex = 3;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 11);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvRecipes);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlDetails);
            splitContainer1.Size = new Size(742, 463);
            splitContainer1.SplitterDistance = 350;
            splitContainer1.TabIndex = 1;
            // 
            // dgvRecipes
            // 
            dgvRecipes.Dock = DockStyle.Fill;
            dgvRecipes.Location = new Point(0, 0);
            dgvRecipes.Name = "dgvRecipes";
            dgvRecipes.Size = new Size(350, 463);
            dgvRecipes.TabIndex = 0;
            dgvRecipes.SelectionChanged += dgvRecipes_SelectionChanged;
            // 
            // pnlDetails
            // 
            pnlDetails.BackColor = Color.White;
            pnlDetails.Controls.Add(tableLayoutPanel1);
            pnlDetails.Dock = DockStyle.Fill;
            pnlDetails.Location = new Point(0, 0);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Padding = new Padding(15, 17, 15, 17);
            pnlDetails.Size = new Size(388, 463);
            pnlDetails.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblDetailName, 0, 0);
            tableLayoutPanel1.Controls.Add(lblDetailDescription, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(lstDetailCategories, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 4);
            tableLayoutPanel1.Controls.Add(lstDetailSteps, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(15, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(358, 429);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDetailName
            // 
            lblDetailName.AutoSize = true;
            lblDetailName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailName.Location = new Point(3, 0);
            lblDetailName.Name = "lblDetailName";
            lblDetailName.Padding = new Padding(0, 0, 0, 11);
            lblDetailName.Size = new Size(203, 36);
            lblDetailName.TabIndex = 0;
            lblDetailName.Text = "Seleccione una receta";
            // 
            // lblDetailDescription
            // 
            lblDetailDescription.AutoEllipsis = true;
            lblDetailDescription.AutoSize = true;
            lblDetailDescription.Dock = DockStyle.Fill;
            lblDetailDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetailDescription.ForeColor = Color.FromArgb(64, 64, 64);
            lblDetailDescription.Location = new Point(3, 36);
            lblDetailDescription.MaximumSize = new Size(350, 0);
            lblDetailDescription.Name = "lblDetailDescription";
            lblDetailDescription.Padding = new Padding(0, 0, 0, 17);
            lblDetailDescription.Size = new Size(350, 34);
            lblDetailDescription.TabIndex = 1;
            lblDetailDescription.Text = "Los detalles de la receta seleccionada se mostrarán aquí.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 70);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 11, 0, 6);
            label1.Size = new Size(73, 34);
            label1.TabIndex = 2;
            label1.Text = "Categorías";
            // 
            // lstDetailCategories
            // 
            lstDetailCategories.BorderStyle = BorderStyle.None;
            lstDetailCategories.Dock = DockStyle.Fill;
            lstDetailCategories.Font = new Font("Segoe UI", 9.75F);
            lstDetailCategories.FormattingEnabled = true;
            lstDetailCategories.ItemHeight = 17;
            lstDetailCategories.Location = new Point(3, 107);
            lstDetailCategories.Name = "lstDetailCategories";
            lstDetailCategories.Size = new Size(352, 85);
            lstDetailCategories.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 195);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 11, 0, 6);
            label2.Size = new Size(43, 34);
            label2.TabIndex = 4;
            label2.Text = "Pasos";
            // 
            // lstDetailSteps
            // 
            lstDetailSteps.BorderStyle = BorderStyle.None;
            lstDetailSteps.Dock = DockStyle.Fill;
            lstDetailSteps.Font = new Font("Segoe UI", 9.75F);
            lstDetailSteps.FormattingEnabled = true;
            lstDetailSteps.ItemHeight = 17;
            lstDetailSteps.Location = new Point(3, 232);
            lstDetailSteps.Name = "lstDetailSteps";
            lstDetailSteps.Size = new Size(352, 194);
            lstDetailSteps.TabIndex = 5;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.White;
            pnlSearch.Controls.Add(cmbCategoryFilter);
            pnlSearch.Controls.Add(pnlSearchContainer);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(20, 114);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Padding = new Padding(3, 11, 3, 0);
            pnlSearch.Size = new Size(742, 57);
            pnlSearch.TabIndex = 4;
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoryFilter.Font = new Font("Segoe UI", 9.75F);
            cmbCategoryFilter.FormattingEnabled = true;
            cmbCategoryFilter.Location = new Point(332, 16);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(200, 25);
            cmbCategoryFilter.TabIndex = 4;
            cmbCategoryFilter.SelectedIndexChanged += cmbCategoryFilter_SelectedIndexChanged;
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
            pnlSearchContainer.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(30, 0);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Buscar por nombre, autor...";
            txtSearch.Size = new Size(288, 32);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // picSearchIcon
            // 
            picSearchIcon.BackColor = Color.White;
            picSearchIcon.Dock = DockStyle.Left;
            picSearchIcon.Image = Properties.Resources.searchIcon;
            picSearchIcon.Location = new Point(0, 0);
            picSearchIcon.Name = "picSearchIcon";
            picSearchIcon.Padding = new Padding(5, 6, 5, 6);
            picSearchIcon.Size = new Size(30, 32);
            picSearchIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            picSearchIcon.TabIndex = 2;
            picSearchIcon.TabStop = false;
            // 
            // UC_Recipes
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlSearch);
            Controls.Add(pnlHeader);
            Name = "UC_Recipes";
            Padding = new Padding(20, 23, 20, 23);
            Size = new Size(782, 668);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).EndInit();
            pnlDetails.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearchContainer.ResumeLayout(false);
            pnlSearchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchIcon).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDetailName;
        private System.Windows.Forms.Label lblDetailDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDetailCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDetailSteps;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.Panel pnlSearchContainer;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picSearchIcon;
        private System.Windows.Forms.Button btnBlockRecipe;
        private System.Windows.Forms.Button btnUnblockRecipe;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
    }
}