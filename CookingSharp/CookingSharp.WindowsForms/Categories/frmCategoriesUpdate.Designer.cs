namespace CookingSharp.WindowsForms
{
    partial class frmCategoriesUpdate
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
            btnSave = new Button();
            btnCancel = new Button();
            lblDescription = new Label();
            txtBoxDescription = new TextBox();
            lblName = new Label();
            txtBoxName = new TextBox();
            lblCRUDCategories = new Label();
            lblId = new Label();
            txtBoxId = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(276, 352);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 44);
            btnSave.TabIndex = 13;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(40, 352);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 44);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(40, 195);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(69, 15);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "Descripcion";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(40, 213);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(380, 86);
            txtBoxDescription.TabIndex = 10;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(40, 139);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 15);
            lblName.TabIndex = 9;
            lblName.Text = "Nombre de Categoría";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(40, 157);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(380, 23);
            txtBoxName.TabIndex = 8;
            // 
            // lblCRUDCategories
            // 
            lblCRUDCategories.AutoSize = true;
            lblCRUDCategories.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCRUDCategories.Location = new Point(134, 41);
            lblCRUDCategories.Name = "lblCRUDCategories";
            lblCRUDCategories.Size = new Size(198, 32);
            lblCRUDCategories.TabIndex = 7;
            lblCRUDCategories.Text = "Editar Categoria";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(40, 86);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 15;
            lblId.Text = "ID";
            // 
            // txtBoxId
            // 
            txtBoxId.Location = new Point(40, 104);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.Size = new Size(380, 23);
            txtBoxId.TabIndex = 14;
            // 
            // frmCategoriesUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 437);
            Controls.Add(lblId);
            Controls.Add(txtBoxId);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(lblDescription);
            Controls.Add(txtBoxDescription);
            Controls.Add(lblName);
            Controls.Add(txtBoxName);
            Controls.Add(lblCRUDCategories);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCategoriesUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategoriesDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Label lblDescription;
        private TextBox txtBoxDescription;
        private Label lblName;
        private TextBox txtBoxName;
        private Label lblCRUDCategories;
        private Label lblId;
        private TextBox txtBoxId;
    }
}