namespace CookingSharp.WindowsForms
{
    partial class frmCategoriesCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCRUDCategories = new Label();
            txtBoxName = new TextBox();
            lblName = new Label();
            lblDescription = new Label();
            txtBoxDescription = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblCRUDCategories
            // 
            lblCRUDCategories.AutoSize = true;
            lblCRUDCategories.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCRUDCategories.Location = new Point(134, 22);
            lblCRUDCategories.Name = "lblCRUDCategories";
            lblCRUDCategories.Size = new Size(204, 32);
            lblCRUDCategories.TabIndex = 0;
            lblCRUDCategories.Text = "Nueva Categoria";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(40, 114);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(380, 23);
            txtBoxName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(40, 96);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Nombre de Categoría";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(40, 176);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(69, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Descripcion";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(40, 194);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(380, 86);
            txtBoxDescription.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(40, 333);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 44);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(276, 333);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 44);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmCategoriesCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 437);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(lblDescription);
            Controls.Add(txtBoxDescription);
            Controls.Add(lblName);
            Controls.Add(txtBoxName);
            Controls.Add(lblCRUDCategories);
            Name = "frmCategoriesCreate";
            Text = "frmCategoriesCU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCRUDCategories;
        private TextBox txtBoxName;
        private Label lblName;
        private Label lblDescription;
        private TextBox txtBoxDescription;
        private Button btnCancel;
        private Button btnSave;
    }
}