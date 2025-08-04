namespace CookingSharp.WindowsForms.CategoriesControl
{
    partial class UC_Categories
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
            components = new System.ComponentModel.Container();
            dgvCategories = new DataGridView();
            class1BindingSource = new BindingSource(components);
            class1BindingSource1 = new BindingSource(components);
            btnCreateCategory = new Button();
            btnDeleteCategory = new Button();
            btnModifyCategory = new Button();
            lblCategories = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(58, 109);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.Size = new Size(667, 370);
            dgvCategories.TabIndex = 0;
            // 
            // btnCreateCategory
            // 
            btnCreateCategory.Location = new Point(618, 69);
            btnCreateCategory.Name = "btnCreateCategory";
            btnCreateCategory.Size = new Size(107, 23);
            btnCreateCategory.TabIndex = 1;
            btnCreateCategory.Text = "Crear Categoria";
            btnCreateCategory.UseVisualStyleBackColor = true;
            btnCreateCategory.Click += btnCreateCategory_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(610, 497);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(115, 23);
            btnDeleteCategory.TabIndex = 2;
            btnDeleteCategory.Text = "Eliminar Categoría";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnModifyCategory
            // 
            btnModifyCategory.Location = new Point(472, 497);
            btnModifyCategory.Name = "btnModifyCategory";
            btnModifyCategory.Size = new Size(121, 23);
            btnModifyCategory.TabIndex = 3;
            btnModifyCategory.Text = "Modificar Categoría";
            btnModifyCategory.UseVisualStyleBackColor = true;
            btnModifyCategory.Click += btnModifyCategory_Click;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCategories.Location = new Point(58, 22);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(264, 32);
            lblCategories.TabIndex = 4;
            lblCategories.Text = "Gestión de Categorías";
            // 
            // UC_Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCategories);
            Controls.Add(btnModifyCategory);
            Controls.Add(btnDeleteCategory);
            Controls.Add(btnCreateCategory);
            Controls.Add(dgvCategories);
            Name = "UC_Categories";
            Size = new Size(782, 589);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategories;
        private BindingSource class1BindingSource;
        private BindingSource class1BindingSource1;
        private Button btnCreateCategory;
        private Button btnDeleteCategory;
        private Button btnModifyCategory;
        private Label lblCategories;
    }
}
