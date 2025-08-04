namespace CookingSharp.WindowsForms.UserControls
{
    partial class UC_Users
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
            dgvUsers = new DataGridView();
            class1BindingSource = new BindingSource(components);
            class1BindingSource1 = new BindingSource(components);
            lblUsers = new Label();
            btnModifyUser = new Button();
            btnDeleteUser = new Button();
            btnCreateUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(57, 133);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(667, 370);
            dgvUsers.TabIndex = 5;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblUsers.Location = new Point(57, 46);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(242, 32);
            lblUsers.TabIndex = 9;
            lblUsers.Text = "Gestión de Usuarios";
            // 
            // btnModifyUser
            // 
            btnModifyUser.Location = new Point(471, 521);
            btnModifyUser.Name = "btnModifyUser";
            btnModifyUser.Size = new Size(121, 23);
            btnModifyUser.TabIndex = 8;
            btnModifyUser.Text = "Modificar Usuario";
            btnModifyUser.UseVisualStyleBackColor = true;
            btnModifyUser.Click += btnModifyUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(609, 521);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(115, 23);
            btnDeleteUser.TabIndex = 7;
            btnDeleteUser.Text = "Eliminar Usuarios";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(617, 93);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(107, 23);
            btnCreateUser.TabIndex = 6;
            btnCreateUser.Text = "Crear Usuarios";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // UC_Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvUsers);
            Controls.Add(lblUsers);
            Controls.Add(btnModifyUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnCreateUser);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UC_Users";
            Size = new Size(782, 589);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private BindingSource class1BindingSource;
        private BindingSource class1BindingSource1;
        private Label lblUsers;
        private Button btnModifyUser;
        private Button btnDeleteUser;
        private Button btnCreateUser;
    }
}
