namespace CookingSharp.WindowsForms.Features.Dashboard
{
    partial class FrmApprenticeDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApprenticeDashboard));
            this.tlpMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tlpHeaderLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHeaderLeft = new System.Windows.Forms.TableLayoutPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblSubtittleNav = new System.Windows.Forms.Label();
            this.tlpHeaderRight = new System.Windows.Forms.TableLayoutPanel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.tlpUserDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.btnUserOptions = new System.Windows.Forms.Button();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.tlpNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.lblMenuExplorarTitle = new System.Windows.Forms.Label();
            this.btnNavRecetas = new System.Windows.Forms.Button();
            this.lblMenuPersonalTitle = new System.Windows.Forms.Label();
            this.btnNavSolicitudes = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.tlpMainLayout.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tlpHeaderLayout.SuspendLayout();
            this.tlpHeaderLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tlpHeaderRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.tlpUserDetails.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.tlpNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainLayout
            // 
            this.tlpMainLayout.BackColor = System.Drawing.Color.Transparent;
            this.tlpMainLayout.ColumnCount = 2;
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpMainLayout.Controls.Add(this.pnlNavigation, 0, 1);
            this.tlpMainLayout.Controls.Add(this.pnlMainContent, 1, 1);
            this.tlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpMainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMainLayout.Name = "tlpMainLayout";
            this.tlpMainLayout.RowCount = 2;
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.Size = new System.Drawing.Size(1264, 729);
            this.tlpMainLayout.TabIndex = 2;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.tlpMainLayout.SetColumnSpan(this.pnlHeader, 2);
            this.pnlHeader.Controls.Add(this.tlpHeaderLayout);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1264, 62);
            this.pnlHeader.TabIndex = 0;
            // 
            // tlpHeaderLayout
            // 
            this.tlpHeaderLayout.BackColor = System.Drawing.Color.Transparent;
            this.tlpHeaderLayout.ColumnCount = 3;
            this.tlpHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeaderLayout.Controls.Add(this.tlpHeaderLeft, 0, 0);
            this.tlpHeaderLayout.Controls.Add(this.tlpHeaderRight, 2, 0);
            this.tlpHeaderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeaderLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpHeaderLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpHeaderLayout.Name = "tlpHeaderLayout";
            this.tlpHeaderLayout.RowCount = 1;
            this.tlpHeaderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeaderLayout.Size = new System.Drawing.Size(1264, 62);
            this.tlpHeaderLayout.TabIndex = 0;
            // 
            // tlpHeaderLeft
            // 
            this.tlpHeaderLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpHeaderLeft.AutoSize = true;
            this.tlpHeaderLeft.ColumnCount = 3;
            this.tlpHeaderLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeaderLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeaderLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeaderLeft.Controls.Add(this.picLogo, 0, 0);
            this.tlpHeaderLeft.Controls.Add(this.lblAppName, 1, 0);
            this.tlpHeaderLeft.Controls.Add(this.lblSubtittleNav, 2, 0);
            this.tlpHeaderLeft.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tlpHeaderLeft.Location = new System.Drawing.Point(3, 15);
            this.tlpHeaderLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpHeaderLeft.Name = "tlpHeaderLeft";
            this.tlpHeaderLeft.RowCount = 1;
            this.tlpHeaderLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeaderLeft.Size = new System.Drawing.Size(262, 32);
            this.tlpHeaderLeft.TabIndex = 2;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::CookingSharp.WindowsForms.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(2, 2);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(32, 28);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAppName.Location = new System.Drawing.Point(46, 5);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(83, 21);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Cooking#";
            // 
            // lblSubtittleNav
            // 
            this.lblSubtittleNav.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubtittleNav.AutoSize = true;
            this.lblSubtittleNav.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubtittleNav.Location = new System.Drawing.Point(131, 8);
            this.lblSubtittleNav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtittleNav.Name = "lblSubtittleNav";
            this.lblSubtittleNav.Size = new System.Drawing.Size(129, 15);
            this.lblSubtittleNav.TabIndex = 2;
            this.lblSubtittleNav.Text = "Panel de Aprendiz";
            // 
            // tlpHeaderRight
            // 
            this.tlpHeaderRight.ColumnCount = 3;
            this.tlpHeaderRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeaderRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeaderRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeaderRight.Controls.Add(this.picUser, 0, 0);
            this.tlpHeaderRight.Controls.Add(this.tlpUserDetails, 1, 0);
            this.tlpHeaderRight.Controls.Add(this.btnUserOptions, 2, 0);
            this.tlpHeaderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlpHeaderRight.Location = new System.Drawing.Point(1061, 2);
            this.tlpHeaderRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpHeaderRight.Name = "tlpHeaderRight";
            this.tlpHeaderRight.RowCount = 1;
            this.tlpHeaderRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeaderRight.Size = new System.Drawing.Size(200, 58);
            this.tlpHeaderRight.TabIndex = 0;
            // 
            // picUser
            // 
            this.picUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picUser.Cursor = System.Windows.Forms.Cursors.No;
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(3, 12);
            this.picUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(40, 34);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // tlpUserDetails
            // 
            this.tlpUserDetails.ColumnCount = 1;
            this.tlpUserDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUserDetails.Controls.Add(this.lblUserRole, 0, 0);
            this.tlpUserDetails.Controls.Add(this.lblUserEmail, 0, 1);
            this.tlpUserDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUserDetails.Location = new System.Drawing.Point(49, 2);
            this.tlpUserDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpUserDetails.Name = "tlpUserDetails";
            this.tlpUserDetails.RowCount = 2;
            this.tlpUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUserDetails.Size = new System.Drawing.Size(112, 54);
            this.tlpUserDetails.TabIndex = 1;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserRole.Location = new System.Drawing.Point(3, 0);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(106, 27);
            this.lblUserRole.TabIndex = 0;
            this.lblUserRole.Text = "Aprendiz";
            this.lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoEllipsis = true;
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserEmail.Location = new System.Drawing.Point(3, 27);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(106, 27);
            this.lblUserEmail.TabIndex = 1;
            this.lblUserEmail.Text = "aprendiz@email.com";
            this.lblUserEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUserOptions
            // 
            this.btnUserOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserOptions.Cursor = System.Windows.Forms.Cursors.No;
            this.btnUserOptions.FlatAppearance.BorderSize = 0;
            this.btnUserOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserOptions.Image")));
            this.btnUserOptions.Location = new System.Drawing.Point(167, 16);
            this.btnUserOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserOptions.Name = "btnUserOptions";
            this.btnUserOptions.Size = new System.Drawing.Size(30, 26);
            this.btnUserOptions.TabIndex = 2;
            this.btnUserOptions.UseVisualStyleBackColor = true;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.AutoScroll = true;
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.pnlNavigation.Controls.Add(this.tlpNavigation);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 62);
            this.pnlNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(250, 667);
            this.pnlNavigation.TabIndex = 1;
            // 
            // tlpNavigation
            // 
            this.tlpNavigation.AutoSize = true;
            this.tlpNavigation.BackColor = System.Drawing.Color.Transparent;
            this.tlpNavigation.ColumnCount = 1;
            this.tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavigation.Controls.Add(this.lblMenuExplorarTitle, 0, 0);
            this.tlpNavigation.Controls.Add(this.btnNavRecetas, 0, 1);
            this.tlpNavigation.Controls.Add(this.lblMenuPersonalTitle, 0, 2);
            this.tlpNavigation.Controls.Add(this.btnNavSolicitudes, 0, 3);
            this.tlpNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpNavigation.Location = new System.Drawing.Point(0, 0);
            this.tlpNavigation.Margin = new System.Windows.Forms.Padding(2);
            this.tlpNavigation.Name = "tlpNavigation";
            this.tlpNavigation.RowCount = 4;
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNavigation.Size = new System.Drawing.Size(250, 150);
            this.tlpNavigation.TabIndex = 2;
            // 
            // lblMenuExplorarTitle
            // 
            this.lblMenuExplorarTitle.AutoSize = true;
            this.lblMenuExplorarTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenuExplorarTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuExplorarTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMenuExplorarTitle.Location = new System.Drawing.Point(3, 0);
            this.lblMenuExplorarTitle.Name = "lblMenuExplorarTitle";
            this.lblMenuExplorarTitle.Padding = new System.Windows.Forms.Padding(10, 17, 0, 4);
            this.lblMenuExplorarTitle.Size = new System.Drawing.Size(244, 34);
            this.lblMenuExplorarTitle.TabIndex = 1;
            this.lblMenuExplorarTitle.Text = "EXPLORAR";
            this.lblMenuExplorarTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNavRecetas
            // 
            this.btnNavRecetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavRecetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNavRecetas.FlatAppearance.BorderSize = 0;
            this.btnNavRecetas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnNavRecetas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnNavRecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRecetas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavRecetas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNavRecetas.Image = global::CookingSharp.WindowsForms.Properties.Resources.recipesIcon;
            this.btnNavRecetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavRecetas.Location = new System.Drawing.Point(3, 36);
            this.btnNavRecetas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNavRecetas.Name = "btnNavRecetas";
            this.btnNavRecetas.Size = new System.Drawing.Size(244, 35);
            this.btnNavRecetas.TabIndex = 2;
            this.btnNavRecetas.Text = "    Recetas";
            this.btnNavRecetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavRecetas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavRecetas.UseVisualStyleBackColor = true;
            this.btnNavRecetas.Click += new System.EventHandler(this.btnNavRecetas_Click);
            // 
            // lblMenuPersonalTitle
            // 
            this.lblMenuPersonalTitle.AutoSize = true;
            this.lblMenuPersonalTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenuPersonalTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPersonalTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMenuPersonalTitle.Location = new System.Drawing.Point(3, 73);
            this.lblMenuPersonalTitle.Name = "lblMenuPersonalTitle";
            this.lblMenuPersonalTitle.Padding = new System.Windows.Forms.Padding(10, 17, 0, 4);
            this.lblMenuPersonalTitle.Size = new System.Drawing.Size(244, 34);
            this.lblMenuPersonalTitle.TabIndex = 3;
            this.lblMenuPersonalTitle.Text = "PERSONAL";
            this.lblMenuPersonalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNavSolicitudes
            // 
            this.btnNavSolicitudes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNavSolicitudes.FlatAppearance.BorderSize = 0;
            this.btnNavSolicitudes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnNavSolicitudes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnNavSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSolicitudes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavSolicitudes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNavSolicitudes.Image = global::CookingSharp.WindowsForms.Properties.Resources.measurementUnitIcon;
            this.btnNavSolicitudes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSolicitudes.Location = new System.Drawing.Point(3, 109);
            this.btnNavSolicitudes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNavSolicitudes.Name = "btnNavSolicitudes";
            this.btnNavSolicitudes.Size = new System.Drawing.Size(244, 39);
            this.btnNavSolicitudes.TabIndex = 5;
            this.btnNavSolicitudes.Text = "    Mis Solicitudes";
            this.btnNavSolicitudes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSolicitudes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavSolicitudes.UseVisualStyleBackColor = true;
            this.btnNavSolicitudes.Click += new System.EventHandler(this.btnNavSolicitudes_Click);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.White;
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(252, 64);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.pnlMainContent.Size = new System.Drawing.Size(1010, 663);
            this.pnlMainContent.TabIndex = 2;
            // 
            // FrmApprenticeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.tlpMainLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 768);
            this.Name = "FrmApprenticeDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cooking # - Panel de Aprendiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpMainLayout.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.tlpHeaderLayout.ResumeLayout(false);
            this.tlpHeaderLayout.PerformLayout();
            this.tlpHeaderLeft.ResumeLayout(false);
            this.tlpHeaderLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tlpHeaderRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.tlpUserDetails.ResumeLayout(false);
            this.tlpUserDetails.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.tlpNavigation.ResumeLayout(false);
            this.tlpNavigation.PerformLayout();
            this.ResumeLayout(false);

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
        internal System.Windows.Forms.Label lblMenuExplorarTitle;
        internal System.Windows.Forms.Button btnNavRecetas;
        private System.Windows.Forms.TableLayoutPanel tlpNavigation;
        private System.Windows.Forms.Label lblSubtittleNav;
        internal System.Windows.Forms.Panel pnlMainContent;
        internal System.Windows.Forms.Label lblMenuPersonalTitle;
        internal System.Windows.Forms.Button btnNavSolicitudes;
    }
}