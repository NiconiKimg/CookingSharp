namespace CookingSharp.WindowsForms.Features.Authentication
{
    partial class FrmLogin
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
            tlpMainLayout = new TableLayoutPanel();
            pnlBranding = new Panel();
            tlpBrandingContent = new TableLayoutPanel();
            flpBrandingStack = new FlowLayoutPanel();
            picLogo = new PictureBox();
            lblAppName = new Label();
            lblSlogan = new Label();
            lblFeature1 = new Label();
            lblFeature2 = new Label();
            lblFeature3 = new Label();
            pnlForm = new Panel();
            btnClose = new Button();
            tlpFormContent = new TableLayoutPanel();
            flpFormControls = new FlowLayoutPanel();
            lblLoginTitle = new Label();
            lblLoginSubtitle = new Label();
            lblEmailPrompt = new Label();
            txtEmail = new TextBox();
            pnlEmailUnderline = new Panel();
            lblPasswordPrompt = new Label();
            pnlPasswordContainer = new Panel();
            txtPassword = new TextBox();
            picTogglePassword = new PictureBox();
            pnlPasswordUnderline = new Panel();
            chkVerPassword = new CheckBox();
            btnAcceder = new Button();
            tlpMainLayout.SuspendLayout();
            pnlBranding.SuspendLayout();
            tlpBrandingContent.SuspendLayout();
            flpBrandingStack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlForm.SuspendLayout();
            tlpFormContent.SuspendLayout();
            flpFormControls.SuspendLayout();
            pnlPasswordContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTogglePassword).BeginInit();
            SuspendLayout();
            // 
            // tlpMainLayout
            // 
            tlpMainLayout.ColumnCount = 2;
            tlpMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpMainLayout.Controls.Add(pnlBranding, 0, 0);
            tlpMainLayout.Controls.Add(pnlForm, 1, 0);
            tlpMainLayout.Dock = DockStyle.Fill;
            tlpMainLayout.Location = new Point(0, 0);
            tlpMainLayout.Margin = new Padding(4, 3, 4, 3);
            tlpMainLayout.Name = "tlpMainLayout";
            tlpMainLayout.RowCount = 1;
            tlpMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainLayout.Size = new Size(1105, 701);
            tlpMainLayout.TabIndex = 0;
            // 
            // pnlBranding
            // 
            pnlBranding.BackColor = Color.FromArgb(31, 41, 55);
            pnlBranding.Controls.Add(tlpBrandingContent);
            pnlBranding.Dock = DockStyle.Fill;
            pnlBranding.Location = new Point(4, 3);
            pnlBranding.Margin = new Padding(4, 3, 4, 3);
            pnlBranding.Name = "pnlBranding";
            pnlBranding.Padding = new Padding(38, 0, 38, 0);
            pnlBranding.Size = new Size(489, 695);
            pnlBranding.TabIndex = 0;
            // 
            // tlpBrandingContent
            // 
            tlpBrandingContent.BackColor = Color.Transparent;
            tlpBrandingContent.ColumnCount = 1;
            tlpBrandingContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBrandingContent.Controls.Add(flpBrandingStack, 0, 1);
            tlpBrandingContent.Dock = DockStyle.Fill;
            tlpBrandingContent.Location = new Point(38, 0);
            tlpBrandingContent.Margin = new Padding(4, 3, 4, 3);
            tlpBrandingContent.Name = "tlpBrandingContent";
            tlpBrandingContent.RowCount = 3;
            tlpBrandingContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBrandingContent.RowStyles.Add(new RowStyle());
            tlpBrandingContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBrandingContent.Size = new Size(413, 695);
            tlpBrandingContent.TabIndex = 0;
            // 
            // flpBrandingStack
            // 
            flpBrandingStack.Anchor = AnchorStyles.None;
            flpBrandingStack.AutoSize = true;
            flpBrandingStack.Controls.Add(picLogo);
            flpBrandingStack.Controls.Add(lblAppName);
            flpBrandingStack.Controls.Add(lblSlogan);
            flpBrandingStack.Controls.Add(lblFeature1);
            flpBrandingStack.Controls.Add(lblFeature2);
            flpBrandingStack.Controls.Add(lblFeature3);
            flpBrandingStack.FlowDirection = FlowDirection.TopDown;
            flpBrandingStack.Location = new Point(79, 206);
            flpBrandingStack.Margin = new Padding(4, 3, 4, 3);
            flpBrandingStack.Name = "flpBrandingStack";
            flpBrandingStack.Size = new Size(254, 282);
            flpBrandingStack.TabIndex = 2;
            flpBrandingStack.WrapContents = false;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.Image = Properties.Resources.roundedLogo;
            picLogo.Location = new Point(77, 0);
            picLogo.Margin = new Padding(0, 0, 0, 25);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(100, 100);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.Anchor = AnchorStyles.None;
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(53, 125);
            lblAppName.Margin = new Padding(4, 0, 4, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(148, 40);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Cooking#";
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.ForeColor = Color.WhiteSmoke;
            lblSlogan.Location = new Point(0, 165);
            lblSlogan.Margin = new Padding(0, 0, 0, 37);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(254, 17);
            lblSlogan.TabIndex = 2;
            lblSlogan.Text = "Sistema de gestión de recetas profesional";
            // 
            // lblFeature1
            // 
            lblFeature1.AutoSize = true;
            lblFeature1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFeature1.ForeColor = Color.White;
            lblFeature1.Image = Properties.Resources.circleCheck;
            lblFeature1.ImageAlign = ContentAlignment.MiddleLeft;
            lblFeature1.Location = new Point(12, 219);
            lblFeature1.Margin = new Padding(12, 0, 0, 6);
            lblFeature1.Name = "lblFeature1";
            lblFeature1.Size = new Size(207, 17);
            lblFeature1.TabIndex = 1;
            lblFeature1.Text = "        Gestión completa de recetas";
            lblFeature1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFeature2
            // 
            lblFeature2.AutoSize = true;
            lblFeature2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFeature2.ForeColor = Color.White;
            lblFeature2.Image = Properties.Resources.circleCheck;
            lblFeature2.ImageAlign = ContentAlignment.MiddleLeft;
            lblFeature2.Location = new Point(12, 242);
            lblFeature2.Margin = new Padding(12, 0, 0, 6);
            lblFeature2.Name = "lblFeature2";
            lblFeature2.Size = new Size(239, 17);
            lblFeature2.TabIndex = 3;
            lblFeature2.Text = "        Panel de administración avanzado";
            lblFeature2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFeature3
            // 
            lblFeature3.AutoSize = true;
            lblFeature3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFeature3.ForeColor = Color.White;
            lblFeature3.Image = Properties.Resources.circleCheck;
            lblFeature3.ImageAlign = ContentAlignment.MiddleLeft;
            lblFeature3.Location = new Point(12, 265);
            lblFeature3.Margin = new Padding(12, 0, 0, 0);
            lblFeature3.Name = "lblFeature3";
            lblFeature3.Size = new Size(218, 17);
            lblFeature3.TabIndex = 4;
            lblFeature3.Text = "        Seguridad y control de acceso";
            lblFeature3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(btnClose);
            pnlForm.Controls.Add(tlpFormContent);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(501, 3);
            pnlForm.Margin = new Padding(4, 3, 4, 3);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(62, 0, 62, 0);
            pnlForm.Size = new Size(600, 695);
            pnlForm.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.White;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 224);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(64, 64, 64);
            btnClose.Location = new Point(560, 0);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 38);
            btnClose.TabIndex = 99;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // tlpFormContent
            // 
            tlpFormContent.BackColor = Color.Transparent;
            tlpFormContent.ColumnCount = 1;
            tlpFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFormContent.Controls.Add(flpFormControls, 0, 1);
            tlpFormContent.Dock = DockStyle.Fill;
            tlpFormContent.Location = new Point(62, 0);
            tlpFormContent.Margin = new Padding(4, 3, 4, 3);
            tlpFormContent.Name = "tlpFormContent";
            tlpFormContent.RowCount = 3;
            tlpFormContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFormContent.Size = new Size(476, 695);
            tlpFormContent.TabIndex = 0;
            // 
            // flpFormControls
            // 
            flpFormControls.Anchor = AnchorStyles.None;
            flpFormControls.AutoSize = true;
            flpFormControls.Controls.Add(lblLoginTitle);
            flpFormControls.Controls.Add(lblLoginSubtitle);
            flpFormControls.Controls.Add(lblEmailPrompt);
            flpFormControls.Controls.Add(txtEmail);
            flpFormControls.Controls.Add(pnlEmailUnderline);
            flpFormControls.Controls.Add(lblPasswordPrompt);
            flpFormControls.Controls.Add(pnlPasswordContainer);
            flpFormControls.Controls.Add(chkVerPassword);
            flpFormControls.Controls.Add(btnAcceder);
            flpFormControls.FlowDirection = FlowDirection.TopDown;
            flpFormControls.Location = new Point(13, 169);
            flpFormControls.Margin = new Padding(4, 3, 4, 3);
            flpFormControls.Name = "flpFormControls";
            flpFormControls.Size = new Size(450, 356);
            flpFormControls.TabIndex = 0;
            flpFormControls.WrapContents = false;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblLoginTitle.Location = new Point(0, 0);
            lblLoginTitle.Margin = new Padding(0, 0, 0, 6);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(218, 45);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.Text = "Iniciar Sesión";
            // 
            // lblLoginSubtitle
            // 
            lblLoginSubtitle.AutoSize = true;
            lblLoginSubtitle.Font = new Font("Segoe UI", 9.75F);
            lblLoginSubtitle.ForeColor = Color.DimGray;
            lblLoginSubtitle.Location = new Point(0, 51);
            lblLoginSubtitle.Margin = new Padding(0, 0, 0, 63);
            lblLoginSubtitle.Name = "lblLoginSubtitle";
            lblLoginSubtitle.Size = new Size(176, 17);
            lblLoginSubtitle.TabIndex = 1;
            lblLoginSubtitle.Text = "Accede a tu panel de control";
            // 
            // lblEmailPrompt
            // 
            lblEmailPrompt.AutoSize = true;
            lblEmailPrompt.Font = new Font("Segoe UI", 9F);
            lblEmailPrompt.Location = new Point(0, 131);
            lblEmailPrompt.Margin = new Padding(0, 0, 0, 6);
            lblEmailPrompt.Name = "lblEmailPrompt";
            lblEmailPrompt.Size = new Size(36, 15);
            lblEmailPrompt.TabIndex = 2;
            lblEmailPrompt.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(6, 152);
            txtEmail.Margin = new Padding(6, 0, 6, 0);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "tu@email.com";
            txtEmail.Size = new Size(438, 20);
            txtEmail.TabIndex = 1;
            // 
            // pnlEmailUnderline
            // 
            pnlEmailUnderline.BackColor = Color.Gainsboro;
            pnlEmailUnderline.Location = new Point(6, 172);
            pnlEmailUnderline.Margin = new Padding(6, 0, 6, 25);
            pnlEmailUnderline.Name = "pnlEmailUnderline";
            pnlEmailUnderline.Size = new Size(438, 1);
            pnlEmailUnderline.TabIndex = 4;
            // 
            // lblPasswordPrompt
            // 
            lblPasswordPrompt.AutoSize = true;
            lblPasswordPrompt.Font = new Font("Segoe UI", 9F);
            lblPasswordPrompt.Location = new Point(0, 211);
            lblPasswordPrompt.Margin = new Padding(0, 13, 0, 6);
            lblPasswordPrompt.Name = "lblPasswordPrompt";
            lblPasswordPrompt.Size = new Size(67, 15);
            lblPasswordPrompt.TabIndex = 5;
            lblPasswordPrompt.Text = "Contraseña";
            // 
            // pnlPasswordContainer
            // 
            pnlPasswordContainer.Controls.Add(txtPassword);
            pnlPasswordContainer.Controls.Add(picTogglePassword);
            pnlPasswordContainer.Controls.Add(pnlPasswordUnderline);
            pnlPasswordContainer.Location = new Point(6, 232);
            pnlPasswordContainer.Margin = new Padding(6, 0, 6, 8);
            pnlPasswordContainer.Name = "pnlPasswordContainer";
            pnlPasswordContainer.Size = new Size(438, 30);
            pnlPasswordContainer.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 11.25F);
            txtPassword.Location = new Point(0, 0);
            txtPassword.Margin = new Padding(0);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(412, 20);
            txtPassword.TabIndex = 2;
            // 
            // picTogglePassword
            // 
            picTogglePassword.Cursor = Cursors.Hand;
            picTogglePassword.Dock = DockStyle.Right;
            picTogglePassword.Location = new Point(412, 0);
            picTogglePassword.Name = "picTogglePassword";
            picTogglePassword.Size = new Size(26, 29);
            picTogglePassword.SizeMode = PictureBoxSizeMode.CenterImage;
            picTogglePassword.TabIndex = 9;
            picTogglePassword.TabStop = false;
            picTogglePassword.Click += picTogglePassword_Click;
            // 
            // pnlPasswordUnderline
            // 
            pnlPasswordUnderline.BackColor = Color.Gainsboro;
            pnlPasswordUnderline.Dock = DockStyle.Bottom;
            pnlPasswordUnderline.Location = new Point(0, 29);
            pnlPasswordUnderline.Name = "pnlPasswordUnderline";
            pnlPasswordUnderline.Size = new Size(438, 1);
            pnlPasswordUnderline.TabIndex = 5;
            // 
            // chkVerPassword
            // 
            chkVerPassword.AutoSize = true;
            chkVerPassword.Cursor = Cursors.Hand;
            chkVerPassword.Font = new Font("Segoe UI", 9F);
            chkVerPassword.Location = new Point(6, 270);
            chkVerPassword.Margin = new Padding(6, 0, 4, 17);
            chkVerPassword.Name = "chkVerPassword";
            chkVerPassword.Size = new Size(130, 19);
            chkVerPassword.TabIndex = 3;
            chkVerPassword.Text = "Mostrar Contraseña";
            chkVerPassword.UseVisualStyleBackColor = true;
            chkVerPassword.CheckedChanged += chkVerPassword_CheckedChanged;
            // 
            // btnAcceder
            // 
            btnAcceder.Anchor = AnchorStyles.None;
            btnAcceder.BackColor = Color.FromArgb(31, 41, 55);
            btnAcceder.Cursor = Cursors.Hand;
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 62, 83);
            btnAcceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 62, 83);
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(37, 306);
            btnAcceder.Margin = new Padding(0);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(375, 50);
            btnAcceder.TabIndex = 4;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1105, 701);
            Controls.Add(tlpMainLayout);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cooking# - Iniciar Sesión";
            tlpMainLayout.ResumeLayout(false);
            pnlBranding.ResumeLayout(false);
            tlpBrandingContent.ResumeLayout(false);
            tlpBrandingContent.PerformLayout();
            flpBrandingStack.ResumeLayout(false);
            flpBrandingStack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlForm.ResumeLayout(false);
            tlpFormContent.ResumeLayout(false);
            tlpFormContent.PerformLayout();
            flpFormControls.ResumeLayout(false);
            flpFormControls.PerformLayout();
            pnlPasswordContainer.ResumeLayout(false);
            pnlPasswordContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTogglePassword).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainLayout;
        private System.Windows.Forms.Panel pnlBranding;
        private System.Windows.Forms.TableLayoutPanel tlpBrandingContent;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.FlowLayoutPanel flpBrandingStack;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblFeature1;
        private System.Windows.Forms.Label lblFeature2;
        private System.Windows.Forms.Label lblFeature3;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.TableLayoutPanel tlpFormContent;
        private System.Windows.Forms.FlowLayoutPanel flpFormControls;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblLoginSubtitle;
        private System.Windows.Forms.Label lblEmailPrompt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlEmailUnderline;
        private System.Windows.Forms.Label lblPasswordPrompt;
        private System.Windows.Forms.Panel pnlPasswordUnderline;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlPasswordContainer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picTogglePassword;
        private System.Windows.Forms.CheckBox chkVerPassword;
    }
}