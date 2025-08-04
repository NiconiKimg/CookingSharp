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
            btnSave.Location = new Point(394, 587);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(206, 73);
            btnSave.TabIndex = 13;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(57, 587);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(206, 73);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(57, 325);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(104, 25);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "Descripcion";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(57, 355);
            txtBoxDescription.Margin = new Padding(4, 5, 4, 5);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(541, 141);
            txtBoxDescription.TabIndex = 10;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(57, 232);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(184, 25);
            lblName.TabIndex = 9;
            lblName.Text = "Nombre de Categoría";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(57, 262);
            txtBoxName.Margin = new Padding(4, 5, 4, 5);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(541, 31);
            txtBoxName.TabIndex = 8;
            // 
            // lblCRUDCategories
            // 
            lblCRUDCategories.AutoSize = true;
            lblCRUDCategories.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCRUDCategories.Location = new Point(191, 68);
            lblCRUDCategories.Margin = new Padding(4, 0, 4, 0);
            lblCRUDCategories.Name = "lblCRUDCategories";
            lblCRUDCategories.Size = new Size(289, 48);
            lblCRUDCategories.TabIndex = 7;
            lblCRUDCategories.Text = "Editar Categoria";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(57, 143);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
            lblId.TabIndex = 15;
            lblId.Text = "ID";
            // 
            // txtBoxId
            // 
            txtBoxId.Location = new Point(57, 173);
            txtBoxId.Margin = new Padding(4, 5, 4, 5);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.Size = new Size(541, 31);
            txtBoxId.TabIndex = 14;
            // 
            // frmCategoriesUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 728);
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
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCategoriesUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cooking # - Editar Categoría";
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