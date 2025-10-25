namespace CookingSharp.WindowsForms.Features.Dashboard
{
    partial class FrmChefDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChefDashboard));
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
            pnlMainContent = new System.Windows.Forms.Panel();
            tlpMainLayout.SuspendLayout();
            pnlHeader.SuspendLayout();
            tlpHeaderLayout.SuspendLayout();
            tlpHeaderLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpHeaderRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            tlpUserDetails.SuspendLayout();
            pnlNavigation.SuspendLayout();
            tlpNavigation.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainLayout
            // 
            tlpMainLayout.BackColor = Color.Transparent;
            tlpMainLayout.ColumnCount = 2;
            tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 357F));
            tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMainLayout.Controls.Add(pnlHeader, 0, 0);
            tlpMainLayout.Controls.Add(pnlNavigation, 0, 1);
            tlpMainLayout.Controls.Add(pnlMainContent, 1, 1);
            tlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpMainLayout.Location = new System.Drawing.Point(0, 0);
            tlpMainLayout.Margin = new System.Windows.Forms.Padding(0);
            tlpMainLayout.Name = "tlpMainLayout";
            tlpMainLayout.RowCount = 2;
            tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMainLayout.Size = new System.Drawing.Size(1480, 969);
            tlpMainLayout.TabIndex = 1;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(26, 34, 45);
            tlpMainLayout.SetColumnSpan(pnlHeader, 2);
            pnlHeader.Controls.Add(tlpHeaderLayout);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(1480, 95);
            pnlHeader.TabIndex = 0;
            // 
            // tlpHeaderLayout
            // 
            tlpHeaderLayout.BackColor = Color.Transparent;
            tlpHeaderLayout.ColumnCount = 3;
            tlpHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpHeaderLayout.Controls.Add(tlpHeaderLeft, 0, 0);
            tlpHeaderLayout.Controls.Add(tlpHeaderRight, 2, 0);
            tlpHeaderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpHeaderLayout.Location = new System.Drawing.Point(0, 0);
            tlpHeaderLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tlpHeaderLayout.Name = "tlpHeaderLayout";
            tlpHeaderLayout.RowCount = 1;
            tlpHeaderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpHeaderLayout.Size = new System.Drawing.Size(1480, 95);
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
            tlpHeaderLeft.Location = new System.Drawing.Point(4, 21);
            tlpHeaderLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpHeaderLeft.Name = "tlpHeaderLeft";
            tlpHeaderLeft.RowCount = 1;
            tlpHeaderLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpHeaderLeft.Size = new System.Drawing.Size(378, 52);
            tlpHeaderLeft.TabIndex = 2;
            // 
            // picLogo
            // 
            picLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new System.Drawing.Point(3, 3);
            picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(46, 46);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // lblAppName
            // 
            lblAppName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblAppName.AutoSize = true;
            lblAppName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.WhiteSmoke;
            lblAppName.Location = new System.Drawing.Point(66, 12);
            lblAppName.Margin = new System.Windows.Forms.Padding(14, 0, 0, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new System.Drawing.Size(119, 28);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Cooking#";
            // 
            // lblSubtittleNav
            // 
            lblSubtittleNav.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblSubtittleNav.AutoSize = true;
            lblSubtittleNav.ForeColor = Color.WhiteSmoke;
            lblSubtittleNav.Location = new System.Drawing.Point(188, 16);
            lblSubtittleNav.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            lblSubtittleNav.Name = "lblSubtittleNav";
            lblSubtittleNav.Size = new System.Drawing.Size(187, 20);
            lblSubtittleNav.TabIndex = 2;
            lblSubtittleNav.Text = "Panel de Control del Chef";
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
            tlpHeaderRight.Location = new System.Drawing.Point(1193, 3);
            tlpHeaderRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpHeaderRight.Name = "tlpHeaderRight";
            tlpHeaderRight.RowCount = 1;
            tlpHeaderRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpHeaderRight.Size = new System.Drawing.Size(283, 89);
            tlpHeaderRight.TabIndex = 0;
            // 
            // picUser
            // 
            picUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            picUser.Cursor = System.Windows.Forms.Cursors.No;
            picUser.Image = (System.Drawing.Image)resources.GetObject("picUser.Image");
            picUser.Location = new System.Drawing.Point(4, 21);
            picUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            picUser.Name = "picUser";
            picUser.Size = new System.Drawing.Size(57, 46);
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
            tlpUserDetails.Location = new System.Drawing.Point(69, 3);
            tlpUserDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpUserDetails.Name = "tlpUserDetails";
            tlpUserDetails.RowCount = 2;
            tlpUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpUserDetails.Size = new System.Drawing.Size(167, 83);
            tlpUserDetails.TabIndex = 1;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Dock = System.Windows.Forms.DockStyle.Fill;
            lblUserRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblUserRole.ForeColor = Color.WhiteSmoke;
            lblUserRole.Location = new System.Drawing.Point(4, 0);
            lblUserRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new System.Drawing.Size(159, 41);
            lblUserRole.TabIndex = 0;
            lblUserRole.Text = "Chef";
            lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoEllipsis = true;
            lblUserEmail.AutoSize = true;
            lblUserEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            lblUserEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblUserEmail.ForeColor = Color.Gainsboro;
            lblUserEmail.Location = new System.Drawing.Point(4, 41);
            lblUserEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new System.Drawing.Size(159, 42);
            lblUserEmail.TabIndex = 1;
            lblUserEmail.Text = "chef@cookingsharp.com";
            lblUserEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUserOptions
            // 
            btnUserOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnUserOptions.Cursor = System.Windows.Forms.Cursors.No;
            btnUserOptions.FlatAppearance.BorderSize = 0;
            btnUserOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUserOptions.Image = (System.Drawing.Image)resources.GetObject("btnUserOptions.Image");
            btnUserOptions.Location = new System.Drawing.Point(244, 27);
            btnUserOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUserOptions.Name = "btnUserOptions";
            btnUserOptions.Size = new System.Drawing.Size(35, 34);
            btnUserOptions.TabIndex = 2;
            btnUserOptions.UseVisualStyleBackColor = true;
            // 
            // pnlNavigation
            // 
            pnlNavigation.AutoScroll = true;
            pnlNavigation.BackColor = Color.FromArgb(31, 41, 55);
            pnlNavigation.Controls.Add(tlpNavigation);
            pnlNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlNavigation.Location = new System.Drawing.Point(0, 95);
            pnlNavigation.Margin = new System.Windows.Forms.Padding(0);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new System.Drawing.Size(357, 874);
            pnlNavigation.TabIndex = 1;
            // 
            // tlpNavigation
            // 
            tlpNavigation.AutoSize = true;
            tlpNavigation.BackColor = Color.Transparent;
            tlpNavigation.ColumnCount = 1;
            tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpNavigation.Controls.Add(lblMenuGestionTitle, 0, 0);
            tlpNavigation.Controls.Add(btnNavRecetas, 0, 1);
            tlpNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            tlpNavigation.Location = new System.Drawing.Point(0, 0);
            tlpNavigation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tlpNavigation.Name = "tlpNavigation";
            tlpNavigation.RowCount = 2;
            tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpNavigation.Size = new System.Drawing.Size(357, 105);
            tlpNavigation.TabIndex = 2;
            // 
            // lblMenuGestionTitle
            // 
            lblMenuGestionTitle.AutoSize = true;
            lblMenuGestionTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            lblMenuGestionTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMenuGestionTitle.ForeColor = Color.Gainsboro;
            lblMenuGestionTitle.Location = new System.Drawing.Point(4, 0);
            lblMenuGestionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMenuGestionTitle.Name = "lblMenuGestionTitle";
            lblMenuGestionTitle.Padding = new System.Windows.Forms.Padding(0, 26, 0, 6);
            lblMenuGestionTitle.Size = new System.Drawing.Size(349, 51);
            lblMenuGestionTitle.TabIndex = 1;
            lblMenuGestionTitle.Text = "GESTIÓN";
            lblMenuGestionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNavRecetas
            // 
            btnNavRecetas.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavRecetas.Dock = System.Windows.Forms.DockStyle.Fill;
            btnNavRecetas.FlatAppearance.BorderSize = 0;
            btnNavRecetas.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 62, 83);
            btnNavRecetas.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 62, 83);
            btnNavRecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavRecetas.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnNavRecetas.ForeColor = Color.WhiteSmoke;
            btnNavRecetas.Image = Properties.Resources.recipesIcon;
            btnNavRecetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavRecetas.Location = new System.Drawing.Point(4, 54);
            btnNavRecetas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNavRecetas.Name = "btnNavRecetas";
            btnNavRecetas.Size = new System.Drawing.Size(349, 48);
            btnNavRecetas.TabIndex = 2;
            btnNavRecetas.Text = "    Recetas";
            btnNavRecetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavRecetas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnNavRecetas.UseVisualStyleBackColor = true;
            btnNavRecetas.Click += btnNavRecetas_Click;
            // 
            // pnlMainContent
            // 
            pnlMainContent.BackColor = Color.White;
            pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMainContent.Location = new System.Drawing.Point(360, 97);
            pnlMainContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            pnlMainContent.Size = new System.Drawing.Size(1117, 870);
            pnlMainContent.TabIndex = 2;
            // 
            // FrmChefDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1480, 969);
            Controls.Add(tlpMainLayout);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MinimumSize = new System.Drawing.Size(1278, 971);
            Name = "FrmChefDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cooking # - Panel de Chef";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            tlpMainLayout.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            tlpHeaderLayout.ResumeLayout(false);
            tlpHeaderLayout.PerformLayout();
            tlpHeaderLeft.ResumeLayout(false);
            tlpHeaderLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpHeaderRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
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
        internal System.Windows.Forms.Label lblMenuGestionTitle;
        internal System.Windows.Forms.Button btnNavRecetas;
        private System.Windows.Forms.TableLayoutPanel tlpNavigation;
        private System.Windows.Forms.Label lblSubtittleNav;
        internal System.Windows.Forms.Panel pnlMainContent;
    }
}