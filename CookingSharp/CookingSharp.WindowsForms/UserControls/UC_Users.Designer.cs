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
            dgvUsers.Location = new Point(82, 222);
            dgvUsers.Margin = new Padding(4, 5, 4, 5);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(953, 617);
            dgvUsers.TabIndex = 5;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblUsers.Location = new Point(82, 77);
            lblUsers.Margin = new Padding(4, 0, 4, 0);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(355, 48);
            lblUsers.TabIndex = 9;
            lblUsers.Text = "Gestión de Usuarios";
            // 
            // btnModifyUser
            // 
            btnModifyUser.Location = new Point(673, 868);
            btnModifyUser.Margin = new Padding(4, 5, 4, 5);
            btnModifyUser.Name = "btnModifyUser";
            btnModifyUser.Size = new Size(173, 38);
            btnModifyUser.TabIndex = 8;
            btnModifyUser.Text = "Modificar Usuario";
            btnModifyUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(870, 868);
            btnDeleteUser.Margin = new Padding(4, 5, 4, 5);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(164, 38);
            btnDeleteUser.TabIndex = 7;
            btnDeleteUser.Text = "Eliminar Usuarios";
            btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(882, 155);
            btnCreateUser.Margin = new Padding(4, 5, 4, 5);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(153, 38);
            btnCreateUser.TabIndex = 6;
            btnCreateUser.Text = "Crear Usuarios";
            btnCreateUser.UseVisualStyleBackColor = true;
            // 
            // UC_Users
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvUsers);
            Controls.Add(lblUsers);
            Controls.Add(btnModifyUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnCreateUser);
            Name = "UC_Users";
            Size = new Size(1117, 982);
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
