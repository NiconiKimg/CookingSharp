namespace CookingSharp.WindowsForms
{
    partial class FrmDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            tlpMainLayout = new System.Windows.Forms.TableLayoutPanel();
            pnlHeader = new System.Windows.Forms.Panel();
            tlpHeaderLayout = new System.Windows.Forms.TableLayoutPanel();
            tlpHeaderLeft = new System.Windows.Forms.TableLayoutPanel();
            picLogo = new System.Windows.Forms.PictureBox();
            lblAppName = new System.Windows.Forms.Label();
            lblSubtittleNav = new System.Windows.Forms.Label();
            tlpHeaderRight = new System.Windows.Forms.TableLayoutPanel();
            picUser = new System.Windows.Forms.PictureBox();
            tlpUserDetails = new System.Windows.Forms.TableLayoutPanel();
            lblUserRole = new System.Windows.Forms.Label();
            lblUserEmail = new System.Windows.Forms.Label();
            btnUserOptions = new System.Windows.Forms.Button();
            pnlNavigation = new System.Windows.Forms.Panel();
            tlpNavigation = new System.Windows.Forms.TableLayoutPanel();
            lblMenuGestionTitle = new System.Windows.Forms.Label();
            btnNavRecetas = new System.Windows.Forms.Button();
            btnNavUsuarios = new System.Windows.Forms.Button();
            btnNavSolicitudes = new System.Windows.Forms.Button();
            btnNavCategorias = new System.Windows.Forms.Button();
            btnNavReportes = new System.Windows.Forms.Button();
            pnlMainContent = new System.Windows.Forms.Panel();
            tlpMainLayout.SuspendLayout();
            pnlHeader.SuspendLayout();
            tlpHeaderLayout.SuspendLayout();
            tlpHeaderLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(picLogo)).BeginInit();
            tlpHeaderRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(picUser)).BeginInit();
            tlpUserDetails.SuspendLayout();
            pnlNavigation.SuspendLayout();
            tlpNavigation.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainLayout
            // 
            tlpMainLayout.BackColor = System.Drawing.Color.Transparent;
            tlpMainLayout.ColumnCount = 2;
            tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMainLayout.Controls.Add(pnlHeader, 0, 0);
            tlpMainLayout.Controls.Add(pnlNavigation, 0, 1);
            tlpMainLayout.Controls.Add(pnlMainContent, 1, 1);
            tlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpMainLayout.Location = new System.Drawing.Point(0, 0);
            tlpMainLayout.Margin = new System.Windows.Forms.Padding(0);
            tlpMainLayout.Name = "tlpMainLayout";
            tlpMainLayout.RowCount = 2;
            tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMainLayout.Size = new System.Drawing.Size(1036, 630);
            tlpMainLayout.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            tlpMainLayout.SetColumnSpan(pnlHeader, 2);
            pnlHeader.Controls.Add(tlpHeaderLayout);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(1036, 62);
            pnlHeader.TabIndex = 0;
            // 
            // tlpHeaderLayout
            // 
            tlpHeaderLayout.BackColor = System.Drawing.Color.Transparent;
            tlpHeaderLayout.ColumnCount = 3;
            tlpHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpHeaderLayout.Controls.Add(tlpHeaderLeft, 0, 0);
            tlpHeaderLayout.Controls.Add(tlpHeaderRight, 2, 0);
            tlpHeaderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpHeaderLayout.Location = new System.Drawing.Point(0, 0);
            tlpHeaderLayout.Margin = new System.Windows.Forms.Padding(2);
            tlpHeaderLayout.Name = "tlpHeaderLayout";
            tlpHeaderLayout.RowCount = 1;
            tlpHeaderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpHeaderLayout.Size = new System.Drawing.Size(1036, 62);
            tlpHeaderLayout.TabIndex = 0;
            // 
            // tlpHeaderLeft
            // 
            tlpHeaderLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            tlpHeaderLeft.AutoSize = true;
            tlpHeaderLeft.ColumnCount = 3;
            tlpHeaderLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpHeaderLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpHeaderLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpHeaderLeft.Controls.Add(picLogo, 0, 0);
            tlpHeaderLeft.Controls.Add(lblAppName, 1, 0);
            tlpHeaderLeft.Controls.Add(lblSubtittleNav, 2, 0);
            tlpHeaderLeft.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            tlpHeaderLeft.Location = new System.Drawing.Point(3, 15);
            tlpHeaderLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tlpHeaderLeft.Name = "tlpHeaderLeft";
            tlpHeaderLeft.RowCount = 1;
            tlpHeaderLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpHeaderLeft.Size = new System.Drawing.Size(262, 32);
            tlpHeaderLeft.TabIndex = 2;
            // 
            // picLogo
            // 
            picLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new System.Drawing.Point(2, 2);
            picLogo.Margin = new System.Windows.Forms.Padding(2);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(32, 28);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // lblAppName
            // 
            lblAppName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblAppName.AutoSize = true;
            lblAppName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAppName.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblAppName.Location = new System.Drawing.Point(46, 5);
            lblAppName.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new System.Drawing.Size(83, 21);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Cooking#";
            // 
            // lblSubtittleNav
            // 
            lblSubtittleNav.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblSubtittleNav.AutoSize = true;
            lblSubtittleNav.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblSubtittleNav.Location = new System.Drawing.Point(131, 8);
            lblSubtittleNav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSubtittleNav.Name = "lblSubtittleNav";
            lblSubtittleNav.Size = new System.Drawing.Size(129, 15);
            lblSubtittleNav.TabIndex = 2;
            lblSubtittleNav.Text = "Panel de Administración";
            // 
            // tlpHeaderRight
            // 
            tlpHeaderRight.ColumnCount = 3;
            tlpHeaderRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpHeaderRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpHeaderRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpHeaderRight.Controls.Add(picUser, 0, 0);
            tlpHeaderRight.Controls.Add(tlpUserDetails, 1, 0);
            tlpHeaderRight.Controls.Add(btnUserOptions, 2, 0);
            tlpHeaderRight.Dock = System.Windows.Forms.DockStyle.Right;
            tlpHeaderRight.Location = new System.Drawing.Point(833, 2);
            tlpHeaderRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tlpHeaderRight.Name = "tlpHeaderRight";
            tlpHeaderRight.RowCount = 1;
            tlpHeaderRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpHeaderRight.Size = new System.Drawing.Size(200, 58);
            tlpHeaderRight.TabIndex = 0;
            // 
            // picUser
            // 
            picUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            picUser.Location = new System.Drawing.Point(3, 12);
            picUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            picUser.Name = "picUser";
            picUser.Size = new System.Drawing.Size(40, 34);
            picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // tlpUserDetails
            // 
            tlpUserDetails.ColumnCount = 1;
            tlpUserDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpUserDetails.Controls.Add(lblUserRole, 0, 0);
            tlpUserDetails.Controls.Add(lblUserEmail, 0, 1);
            tlpUserDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpUserDetails.Location = new System.Drawing.Point(49, 2);
            tlpUserDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tlpUserDetails.Name = "tlpUserDetails";
            tlpUserDetails.RowCount = 2;
            tlpUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpUserDetails.Size = new System.Drawing.Size(112, 54);
            tlpUserDetails.TabIndex = 1;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Dock = System.Windows.Forms.DockStyle.Fill;
            lblUserRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUserRole.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblUserRole.Location = new System.Drawing.Point(3, 0);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new System.Drawing.Size(106, 27);
            lblUserRole.TabIndex = 0;
            lblUserRole.Text = "Administrador";
            lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoEllipsis = true;
            lblUserEmail.AutoSize = true;
            lblUserEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            lblUserEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUserEmail.ForeColor = System.Drawing.Color.Gainsboro;
            lblUserEmail.Location = new System.Drawing.Point(3, 27);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new System.Drawing.Size(106, 27);
            lblUserEmail.TabIndex = 1;
            lblUserEmail.Text = "admin@cookingsharp.com";
            lblUserEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUserOptions
            // 
            btnUserOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnUserOptions.FlatAppearance.BorderSize = 0;
            btnUserOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUserOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserOptions.Image")));
            btnUserOptions.Location = new System.Drawing.Point(167, 16);
            btnUserOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnUserOptions.Name = "btnUserOptions";
            btnUserOptions.Size = new System.Drawing.Size(30, 26);
            btnUserOptions.TabIndex = 2;
            btnUserOptions.UseVisualStyleBackColor = true;
            btnUserOptions.Click += new System.EventHandler(this.btnUserOptions_Click);
            // 
            // pnlNavigation
            // 
            pnlNavigation.AutoScroll = true;
            pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            pnlNavigation.Controls.Add(tlpNavigation);
            pnlNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlNavigation.Location = new System.Drawing.Point(0, 62);
            pnlNavigation.Margin = new System.Windows.Forms.Padding(0);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new System.Drawing.Size(250, 568);
            pnlNavigation.TabIndex = 1;
            // 
            // tlpNavigation
            // 
            tlpNavigation.AutoSize = true;
            tlpNavigation.BackColor = System.Drawing.Color.Transparent;
            tlpNavigation.ColumnCount = 1;
            tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpNavigation.Controls.Add(this.lblMenuGestionTitle, 0, 0);
            tlpNavigation.Controls.Add(this.btnNavRecetas, 0, 1);
            tlpNavigation.Controls.Add(this.btnNavUsuarios, 0, 2);
            tlpNavigation.Controls.Add(this.btnNavSolicitudes, 0, 3);
            tlpNavigation.Controls.Add(this.btnNavCategorias, 0, 4);
            tlpNavigation.Controls.Add(this.btnNavReportes, 0, 5);
            tlpNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            tlpNavigation.Location = new System.Drawing.Point(0, 0);
            tlpNavigation.Margin = new System.Windows.Forms.Padding(2);
            tlpNavigation.Name = "tlpNavigation";
            tlpNavigation.RowCount = 6; // RowCount actualizado
            tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpNavigation.Size = new System.Drawing.Size(250, 230);
            tlpNavigation.TabIndex = 2;
            // 
            // lblMenuGestionTitle
            // 
            lblMenuGestionTitle.AutoSize = true;
            lblMenuGestionTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            lblMenuGestionTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMenuGestionTitle.ForeColor = System.Drawing.Color.Gainsboro;
            lblMenuGestionTitle.Location = new System.Drawing.Point(3, 0);
            lblMenuGestionTitle.Name = "lblMenuGestionTitle";
            lblMenuGestionTitle.Padding = new System.Windows.Forms.Padding(10, 17, 0, 4);
            lblMenuGestionTitle.Size = new System.Drawing.Size(244, 34);
            lblMenuGestionTitle.TabIndex = 1;
            lblMenuGestionTitle.Text = "GESTIÓN";
            lblMenuGestionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNavRecetas
            // 
            btnNavRecetas.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavRecetas.Dock = System.Windows.Forms.DockStyle.Fill;
            btnNavRecetas.FlatAppearance.BorderSize = 0;
            btnNavRecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavRecetas.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnNavRecetas.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnNavRecetas.Image = Properties.Resources.recipesIcon;
            btnNavRecetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavRecetas.Location = new System.Drawing.Point(3, 36);
            btnNavRecetas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNavRecetas.Name = "btnNavRecetas";
            btnNavRecetas.Size = new System.Drawing.Size(244, 35);
            btnNavRecetas.TabIndex = 2;
            btnNavRecetas.Text = "    Recetas";
            btnNavRecetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavRecetas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnNavRecetas.UseVisualStyleBackColor = true;
            btnNavRecetas.Click += new System.EventHandler(this.btnNavRecetas_Click);
            // 
            // btnNavUsuarios
            // 
            btnNavUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            btnNavUsuarios.FlatAppearance.BorderSize = 0;
            btnNavUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnNavUsuarios.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnNavUsuarios.Image = Properties.Resources.usersIcon;
            btnNavUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavUsuarios.Location = new System.Drawing.Point(3, 75);
            btnNavUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNavUsuarios.Name = "btnNavUsuarios";
            btnNavUsuarios.Size = new System.Drawing.Size(244, 35);
            btnNavUsuarios.TabIndex = 0;
            btnNavUsuarios.Text = "    Usuarios";
            btnNavUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnNavUsuarios.UseVisualStyleBackColor = true;
            btnNavUsuarios.Click += new System.EventHandler(this.btnNavUsuarios_Click);
            // 
            // btnNavSolicitudes
            // 
            btnNavSolicitudes.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            btnNavSolicitudes.FlatAppearance.BorderSize = 0;
            btnNavSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavSolicitudes.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnNavSolicitudes.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnNavSolicitudes.Image = Properties.Resources.measurementUnitIcon;
            btnNavSolicitudes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavSolicitudes.Location = new System.Drawing.Point(3, 114);
            btnNavSolicitudes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNavSolicitudes.Name = "btnNavSolicitudes";
            btnNavSolicitudes.Size = new System.Drawing.Size(244, 35);
            btnNavSolicitudes.TabIndex = 5;
            btnNavSolicitudes.Text = "    Solicitudes";
            btnNavSolicitudes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavSolicitudes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnNavSolicitudes.UseVisualStyleBackColor = true;
            btnNavSolicitudes.Click += new System.EventHandler(this.btnNavSolicitudes_Click);
            // 
            // btnNavCategorias
            // 
            btnNavCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            btnNavCategorias.FlatAppearance.BorderSize = 0;
            btnNavCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavCategorias.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnNavCategorias.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnNavCategorias.Image = Properties.Resources.categoryIcon;
            btnNavCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavCategorias.Location = new System.Drawing.Point(3, 153);
            btnNavCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNavCategorias.Name = "btnNavCategorias";
            btnNavCategorias.Size = new System.Drawing.Size(244, 35);
            btnNavCategorias.TabIndex = 3;
            btnNavCategorias.Text = "    Categorias";
            btnNavCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnNavCategorias.UseVisualStyleBackColor = true;
            btnNavCategorias.Click += new System.EventHandler(this.btnNavCategorias_Click);
            // 
            // btnNavReportes
            // 
            btnNavReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            btnNavReportes.FlatAppearance.BorderSize = 0;
            btnNavReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavReportes.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnNavReportes.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnNavReportes.Image = Properties.Resources.recipeConfirmationIcon;
            btnNavReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavReportes.Location = new System.Drawing.Point(3, 192);
            btnNavReportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNavReportes.Name = "btnNavReportes";
            btnNavReportes.Size = new System.Drawing.Size(244, 36);
            btnNavReportes.TabIndex = 6;
            btnNavReportes.Text = "    Reportes";
            btnNavReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnNavReportes.UseVisualStyleBackColor = true;
            btnNavReportes.Click += new System.EventHandler(this.btnNavReportes_Click);
            // 
            // pnlMainContent
            // 
            pnlMainContent.BackColor = System.Drawing.Color.White;
            pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMainContent.Location = new System.Drawing.Point(252, 64);
            pnlMainContent.Margin = new System.Windows.Forms.Padding(2);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            pnlMainContent.Size = new System.Drawing.Size(782, 564);
            pnlMainContent.TabIndex = 2;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1036, 630);
            Controls.Add(tlpMainLayout);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            Margin = new System.Windows.Forms.Padding(2);
            MinimumSize = new System.Drawing.Size(898, 644);
            Name = "FrmDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cooking # - Panel de Administración";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            tlpMainLayout.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            tlpHeaderLayout.ResumeLayout(false);
            tlpHeaderLayout.PerformLayout();
            tlpHeaderLeft.ResumeLayout(false);
            tlpHeaderLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(picLogo)).EndInit();
            tlpHeaderRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(picUser)).EndInit();
            tlpUserDetails.ResumeLayout(false);
            tlpUserDetails.PerformLayout();
            pnlNavigation.ResumeLayout(false);
            pnlNavigation.PerformLayout();
            tlpNavigation.ResumeLayout(false);
            tlpNavigation.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel tlpMainLayout;
        internal System.Windows.Forms.Panel pnlHeader;
        internal System.Windows.Forms.Panel pnlNavigation;
        internal System.Windows.Forms.TableLayoutPanel tlpHeaderLayout;
        internal System.Windows.Forms.TableLayoutPanel tlpHeaderLeft;
        internal System.Windows.Forms.PictureBox picLogo;
        internal System.Windows.Forms.Label lblAppName;
        internal System.Windows.Forms.TableLayoutPanel tlpHeaderRight;
        internal System.Windows.Forms.PictureBox picUser;
        internal System.Windows.Forms.TableLayoutPanel tlpUserDetails;
        internal System.Windows.Forms.Label lblUserRole;
        internal System.Windows.Forms.Label lblUserEmail;
        internal System.Windows.Forms.Button btnUserOptions;
        internal System.Windows.Forms.Button btnNavUsuarios;
        internal System.Windows.Forms.Label lblMenuGestionTitle;
        internal System.Windows.Forms.Button btnNavRecetas;
        internal System.Windows.Forms.Button btnNavCategorias;
        private System.Windows.Forms.TableLayoutPanel tlpNavigation;
        private System.Windows.Forms.Label lblSubtittleNav;
        internal System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnNavSolicitudes;
        private System.Windows.Forms.Button btnNavReportes;
    }
}