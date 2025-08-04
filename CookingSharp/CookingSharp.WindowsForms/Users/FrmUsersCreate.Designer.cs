namespace CookingSharp.WindowsForms.Users
{
    partial class FrmUsersCreate
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
            btnCancel = new Button();
            btnSave = new Button();
            lblSurname = new Label();
            lblName = new Label();
            txtBoxName = new TextBox();
            lblCRUDCategories = new Label();
            txtBoxSurname = new TextBox();
            txtBoxEmail = new TextBox();
            lblEmail = new Label();
            txtBoxPassword = new TextBox();
            lblPassword = new Label();
            SuspendLayout();
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
            btnCancel.Location = new Point(40, 352);
            btnCancel.Margin = new Padding(0, 17, 0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 44);
            btnCancel.TabIndex = 15;
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
            btnSave.Location = new Point(276, 352);
            btnSave.Margin = new Padding(0, 17, 0, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 44);
            btnSave.TabIndex = 14;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(40, 150);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(51, 15);
            lblSurname.TabIndex = 13;
            lblSurname.Text = "Apellido";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(40, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 11;
            lblName.Text = "Nombre";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(40, 118);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(380, 23);
            txtBoxName.TabIndex = 10;
            // 
            // lblCRUDCategories
            // 
            lblCRUDCategories.AutoSize = true;
            lblCRUDCategories.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCRUDCategories.Location = new Point(134, 41);
            lblCRUDCategories.Name = "lblCRUDCategories";
            lblCRUDCategories.Size = new Size(182, 32);
            lblCRUDCategories.TabIndex = 9;
            lblCRUDCategories.Text = "Nuevo usuario";
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Location = new Point(40, 168);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(380, 23);
            txtBoxSurname.TabIndex = 16;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(40, 223);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(380, 23);
            txtBoxEmail.TabIndex = 18;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(40, 205);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(40, 278);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(380, 23);
            txtBoxPassword.TabIndex = 20;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(40, 260);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 15);
            lblPassword.TabIndex = 19;
            lblPassword.Text = "Contraseña";
            // 
            // FrmUsersCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 437);
            Controls.Add(txtBoxPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtBoxEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtBoxSurname);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Controls.Add(txtBoxName);
            Controls.Add(lblCRUDCategories);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmUsersCreate";
            Text = "FrmUsersCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label lblSurname;
        private Label lblName;
        private TextBox txtBoxName;
        private Label lblCRUDCategories;
        private TextBox txtBoxSurname;
        private TextBox txtBoxEmail;
        private Label lblEmail;
        private TextBox txtBoxPassword;
        private Label lblPassword;
    }
}