namespace CookingSharp.WindowsForms.Users
{
    partial class FrmUsersUpdate
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
            txtBoxEmail = new TextBox();
            lblEmail = new Label();
            txtBoxSurname = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            lblSurname = new Label();
            lblName = new Label();
            txtBoxName = new TextBox();
            lblCRUDCategories = new Label();
            SuspendLayout();
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(57, 408);
            txtBoxEmail.Margin = new Padding(4, 5, 4, 5);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(541, 31);
            txtBoxEmail.TabIndex = 29;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(57, 378);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "Email";
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Location = new Point(57, 318);
            txtBoxSurname.Margin = new Padding(4, 5, 4, 5);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(541, 31);
            txtBoxSurname.TabIndex = 27;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.FromArgb(224, 224, 224);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(57, 587);
            btnCancel.Margin = new Padding(0, 28, 0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(206, 73);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.FromArgb(31, 41, 55);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 62, 83);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 62, 83);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(394, 587);
            btnSave.Margin = new Padding(0, 28, 0, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(206, 73);
            btnSave.TabIndex = 25;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(57, 288);
            lblSurname.Margin = new Padding(4, 0, 4, 0);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(78, 25);
            lblSurname.TabIndex = 24;
            lblSurname.Text = "Apellido";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(57, 203);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 25);
            lblName.TabIndex = 23;
            lblName.Text = "Nombre";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(57, 233);
            txtBoxName.Margin = new Padding(4, 5, 4, 5);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(541, 31);
            txtBoxName.TabIndex = 22;
            // 
            // lblCRUDCategories
            // 
            lblCRUDCategories.AutoSize = true;
            lblCRUDCategories.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCRUDCategories.Location = new Point(191, 68);
            lblCRUDCategories.Margin = new Padding(4, 0, 4, 0);
            lblCRUDCategories.Name = "lblCRUDCategories";
            lblCRUDCategories.Size = new Size(253, 48);
            lblCRUDCategories.TabIndex = 21;
            lblCRUDCategories.Text = "Editar usuario";
            // 
            // FrmUsersUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 728);
            Controls.Add(txtBoxEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtBoxSurname);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Controls.Add(txtBoxName);
            Controls.Add(lblCRUDCategories);
            Name = "FrmUsersUpdate";
            Text = "Cooking # - Editar Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxEmail;
        private Label lblEmail;
        private TextBox txtBoxSurname;
        private Button btnCancel;
        private Button btnSave;
        private Label lblSurname;
        private Label lblName;
        private TextBox txtBoxName;
        private Label lblCRUDCategories;
    }
}