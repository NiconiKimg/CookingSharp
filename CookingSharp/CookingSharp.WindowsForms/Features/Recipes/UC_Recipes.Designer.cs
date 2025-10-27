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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBlockRecipe = new System.Windows.Forms.Button();
            this.btnUnblockRecipe = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDetailName = new System.Windows.Forms.Label();
            this.lblDetailDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDetailCategories = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDetailSteps = new System.Windows.Forms.ListBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.pnlSearchContainer = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picSearchIcon = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlSearchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnBlockRecipe);
            this.pnlHeader.Controls.Add(this.btnUnblockRecipe);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(742, 80);
            this.pnlHeader.TabIndex = 2;
            // 
            // btnBlockRecipe
            // 
            this.btnBlockRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlockRecipe.BackColor = System.Drawing.Color.White;
            this.btnBlockRecipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlockRecipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnBlockRecipe.FlatAppearance.BorderSize = 2;
            this.btnBlockRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlockRecipe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBlockRecipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnBlockRecipe.Location = new System.Drawing.Point(619, 21);
            this.btnBlockRecipe.Name = "btnBlockRecipe";
            this.btnBlockRecipe.Size = new System.Drawing.Size(120, 40);
            this.btnBlockRecipe.TabIndex = 2;
            this.btnBlockRecipe.Text = "Bloquear";
            this.btnBlockRecipe.UseVisualStyleBackColor = false;
            this.btnBlockRecipe.Click += new System.EventHandler(this.btnBlockRecipe_Click);
            // 
            // btnUnblockRecipe
            // 
            this.btnUnblockRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnblockRecipe.BackColor = System.Drawing.Color.White;
            this.btnUnblockRecipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnblockRecipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnUnblockRecipe.FlatAppearance.BorderSize = 2;
            this.btnUnblockRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnblockRecipe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUnblockRecipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnUnblockRecipe.Location = new System.Drawing.Point(493, 21);
            this.btnUnblockRecipe.Name = "btnUnblockRecipe";
            this.btnUnblockRecipe.Size = new System.Drawing.Size(120, 40);
            this.btnUnblockRecipe.TabIndex = 3;
            this.btnUnblockRecipe.Text = "Desbloquear";
            this.btnUnblockRecipe.UseVisualStyleBackColor = false;
            this.btnUnblockRecipe.Click += new System.EventHandler(this.btnUnblockRecipe_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Gestión de Recetas";
            // 
            // pnlGridContainer
            // 
            this.pnlGridContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlGridContainer.Controls.Add(this.splitContainer1);
            this.pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridContainer.Location = new System.Drawing.Point(20, 150);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlGridContainer.Size = new System.Drawing.Size(742, 419);
            this.pnlGridContainer.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvRecipes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlDetails);
            this.splitContainer1.Size = new System.Drawing.Size(742, 409);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipes.Location = new System.Drawing.Point(0, 0);
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.Size = new System.Drawing.Size(350, 409);
            this.dgvRecipes.TabIndex = 0;
            this.dgvRecipes.SelectionChanged += new System.EventHandler(this.dgvRecipes_SelectionChanged);
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Controls.Add(this.tableLayoutPanel1);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDetails.Size = new System.Drawing.Size(388, 409);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 379);
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
            this.lblDetailDescription.Size = new System.Drawing.Size(352, 49);
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
            this.lstDetailCategories.Size = new System.Drawing.Size(352, 74);
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
            this.lstDetailSteps.Size = new System.Drawing.Size(352, 145);
            this.lstDetailSteps.TabIndex = 5;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.cmbCategoryFilter);
            this.pnlSearch.Controls.Add(this.pnlSearchContainer);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(20, 100);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.pnlSearch.Size = new System.Drawing.Size(742, 50);
            this.pnlSearch.TabIndex = 4;
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(332, 14);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(200, 25);
            this.cmbCategoryFilter.TabIndex = 4;
            this.cmbCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryFilter_SelectedIndexChanged);
            // 
            // pnlSearchContainer
            // 
            this.pnlSearchContainer.BackColor = System.Drawing.Color.White;
            this.pnlSearchContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchContainer.Controls.Add(this.txtSearch);
            this.pnlSearchContainer.Controls.Add(this.picSearchIcon);
            this.pnlSearchContainer.Location = new System.Drawing.Point(6, 12);
            this.pnlSearchContainer.Name = "pnlSearchContainer";
            this.pnlSearchContainer.Size = new System.Drawing.Size(320, 30);
            this.pnlSearchContainer.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(30, 0);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Buscar por nombre, autor...";
            this.txtSearch.Size = new System.Drawing.Size(288, 28);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // picSearchIcon
            // 
            this.picSearchIcon.BackColor = System.Drawing.Color.White;
            this.picSearchIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.picSearchIcon.Image = global::CookingSharp.WindowsForms.Properties.Resources.searchIcon;
            this.picSearchIcon.Location = new System.Drawing.Point(0, 0);
            this.picSearchIcon.Name = "picSearchIcon";
            this.picSearchIcon.Padding = new System.Windows.Forms.Padding(5);
            this.picSearchIcon.Size = new System.Drawing.Size(30, 28);
            this.picSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSearchIcon.TabIndex = 2;
            this.picSearchIcon.TabStop = false;
            // 
            // UC_Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlGridContainer);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_Recipes";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(782, 589);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlGridContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearchContainer.ResumeLayout(false);
            this.pnlSearchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).EndInit();
            this.ResumeLayout(false);

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