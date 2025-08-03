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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            class1BindingSource = new BindingSource(components);
            class1BindingSource1 = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, DescriptionDataGridViewTextBoxColumn });
            dgvCategories.Location = new Point(58, 109);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.Size = new Size(667, 370);
            dgvCategories.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // DescriptionDataGridViewTextBoxColumn
            // 
            DescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DescriptionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            button1.Location = new Point(618, 69);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 1;
            button1.Text = "Crear Categoria";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UC_Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(dgvCategories);
            Name = "UC_Categories";
            Size = new Size(782, 589);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategories;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DescriptionDataGridViewTextBoxColumn;
        private BindingSource class1BindingSource;
        private BindingSource class1BindingSource1;
        private Button button1;
    }
}
