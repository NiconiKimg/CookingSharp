namespace CookingSharp.WindowsForms
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
            txtPassword = new TextBox();
            pnlPasswordUnderline = new Panel();
            tlpOptions = new TableLayoutPanel();
            chkRecordarme = new CheckBox();
            lnkForgotPassword = new LinkLabel();
            btnAcceder = new Button();
            tlpMainLayout.SuspendLayout();
            pnlBranding.SuspendLayout();
            tlpBrandingContent.SuspendLayout();
            flpBrandingStack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlForm.SuspendLayout();
            tlpFormContent.SuspendLayout();
            flpFormControls.SuspendLayout();
            tlpOptions.SuspendLayout();
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
            tlpMainLayout.Margin = new Padding(4);
            tlpMainLayout.Name = "tlpMainLayout";
            tlpMainLayout.RowCount = 1;
            tlpMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMainLayout.Size = new Size(1263, 825);
            tlpMainLayout.TabIndex = 0;
            // 
            // pnlBranding
            // 
            pnlBranding.BackColor = Color.FromArgb(31, 41, 55);
            pnlBranding.Controls.Add(tlpBrandingContent);
            pnlBranding.Dock = DockStyle.Fill;
            pnlBranding.Location = new Point(4, 4);
            pnlBranding.Margin = new Padding(4);
            pnlBranding.Name = "pnlBranding";
            pnlBranding.Padding = new Padding(43, 0, 43, 0);
            pnlBranding.Size = new Size(560, 817);
            pnlBranding.TabIndex = 0;
            // 
            // tlpBrandingContent
            // 
            tlpBrandingContent.BackColor = Color.Transparent;
            tlpBrandingContent.ColumnCount = 1;
            tlpBrandingContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBrandingContent.Controls.Add(flpBrandingStack, 0, 1);
            tlpBrandingContent.Dock = DockStyle.Fill;
            tlpBrandingContent.Location = new Point(43, 0);
            tlpBrandingContent.Margin = new Padding(4);
            tlpBrandingContent.Name = "tlpBrandingContent";
            tlpBrandingContent.RowCount = 3;
            tlpBrandingContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBrandingContent.RowStyles.Add(new RowStyle());
            tlpBrandingContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBrandingContent.Size = new Size(474, 817);
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
            flpBrandingStack.Location = new Point(56, 221);
            flpBrandingStack.Margin = new Padding(4);
            flpBrandingStack.Name = "flpBrandingStack";
            flpBrandingStack.Size = new Size(362, 374);
            flpBrandingStack.TabIndex = 2;
            flpBrandingStack.WrapContents = false;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.Image = Properties.Resources.roundedLogo;
            picLogo.Location = new Point(124, 0);
            picLogo.Margin = new Padding(0, 0, 0, 29);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(114, 118);
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
            lblAppName.Location = new Point(69, 147);
            lblAppName.Margin = new Padding(4, 0, 4, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(224, 60);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Cooking#";
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.ForeColor = Color.WhiteSmoke;
            lblSlogan.Location = new Point(0, 207);
            lblSlogan.Margin = new Padding(0, 0, 0, 44);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(342, 25);
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
            lblFeature1.Location = new Point(14, 276);
            lblFeature1.Margin = new Padding(14, 0, 0, 7);
            lblFeature1.Name = "lblFeature1";
            lblFeature1.Size = new Size(299, 28);
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
            lblFeature2.Location = new Point(14, 311);
            lblFeature2.Margin = new Padding(14, 0, 0, 7);
            lblFeature2.Name = "lblFeature2";
            lblFeature2.Size = new Size(348, 28);
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
            lblFeature3.Location = new Point(14, 346);
            lblFeature3.Margin = new Padding(14, 0, 0, 0);
            lblFeature3.Name = "lblFeature3";
            lblFeature3.Size = new Size(315, 28);
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
            pnlForm.Location = new Point(572, 4);
            pnlForm.Margin = new Padding(4);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(71, 0, 71, 0);
            pnlForm.Size = new Size(687, 817);
            pnlForm.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(31, 41, 55);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Red;
            btnClose.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(645, -3);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 45);
            btnClose.TabIndex = 1;
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
            tlpFormContent.Location = new Point(71, 0);
            tlpFormContent.Margin = new Padding(4);
            tlpFormContent.Name = "tlpFormContent";
            tlpFormContent.RowCount = 3;
            tlpFormContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFormContent.Size = new Size(545, 817);
            tlpFormContent.TabIndex = 0;
            // 
            // flpFormControls
            // 
            flpFormControls.AutoSize = true;
            flpFormControls.Controls.Add(lblLoginTitle);
            flpFormControls.Controls.Add(lblLoginSubtitle);
            flpFormControls.Controls.Add(lblEmailPrompt);
            flpFormControls.Controls.Add(txtEmail);
            flpFormControls.Controls.Add(pnlEmailUnderline);
            flpFormControls.Controls.Add(lblPasswordPrompt);
            flpFormControls.Controls.Add(txtPassword);
            flpFormControls.Controls.Add(pnlPasswordUnderline);
            flpFormControls.Controls.Add(tlpOptions);
            flpFormControls.Controls.Add(btnAcceder);
            flpFormControls.Dock = DockStyle.Top;
            flpFormControls.FlowDirection = FlowDirection.TopDown;
            flpFormControls.Location = new Point(4, 159);
            flpFormControls.Margin = new Padding(4);
            flpFormControls.Name = "flpFormControls";
            flpFormControls.Size = new Size(537, 499);
            flpFormControls.TabIndex = 0;
            flpFormControls.WrapContents = false;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitle.Location = new Point(0, 0);
            lblLoginTitle.Margin = new Padding(0, 0, 0, 7);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(327, 65);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.Text = "Iniciar Sesión";
            // 
            // lblLoginSubtitle
            // 
            lblLoginSubtitle.AutoSize = true;
            lblLoginSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginSubtitle.ForeColor = Color.DimGray;
            lblLoginSubtitle.Location = new Point(0, 72);
            lblLoginSubtitle.Margin = new Padding(0, 0, 0, 74);
            lblLoginSubtitle.Name = "lblLoginSubtitle";
            lblLoginSubtitle.Size = new Size(261, 28);
            lblLoginSubtitle.TabIndex = 1;
            lblLoginSubtitle.Text = "Accede a tu panel de control";
            // 
            // lblEmailPrompt
            // 
            lblEmailPrompt.AutoSize = true;
            lblEmailPrompt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailPrompt.Location = new Point(0, 174);
            lblEmailPrompt.Margin = new Padding(0, 0, 0, 7);
            lblEmailPrompt.Name = "lblEmailPrompt";
            lblEmailPrompt.Size = new Size(54, 25);
            lblEmailPrompt.TabIndex = 2;
            lblEmailPrompt.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(7, 206);
            txtEmail.Margin = new Padding(7, 0, 7, 0);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "tu@email.com";
            txtEmail.Size = new Size(500, 30);
            txtEmail.TabIndex = 3;
            // 
            // pnlEmailUnderline
            // 
            pnlEmailUnderline.BackColor = Color.Gainsboro;
            pnlEmailUnderline.Location = new Point(7, 236);
            pnlEmailUnderline.Margin = new Padding(7, 0, 7, 29);
            pnlEmailUnderline.Name = "pnlEmailUnderline";
            pnlEmailUnderline.Size = new Size(500, 1);
            pnlEmailUnderline.TabIndex = 4;
            // 
            // lblPasswordPrompt
            // 
            lblPasswordPrompt.AutoSize = true;
            lblPasswordPrompt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPasswordPrompt.Location = new Point(0, 281);
            lblPasswordPrompt.Margin = new Padding(0, 15, 0, 7);
            lblPasswordPrompt.Name = "lblPasswordPrompt";
            lblPasswordPrompt.Size = new Size(101, 25);
            lblPasswordPrompt.TabIndex = 5;
            lblPasswordPrompt.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(7, 313);
            txtPassword.Margin = new Padding(7, 0, 7, 0);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "***********";
            txtPassword.Size = new Size(500, 30);
            txtPassword.TabIndex = 7;
            // 
            // pnlPasswordUnderline
            // 
            pnlPasswordUnderline.BackColor = Color.Gainsboro;
            pnlPasswordUnderline.Location = new Point(7, 343);
            pnlPasswordUnderline.Margin = new Padding(7, 0, 7, 15);
            pnlPasswordUnderline.Name = "pnlPasswordUnderline";
            pnlPasswordUnderline.Size = new Size(500, 1);
            pnlPasswordUnderline.TabIndex = 5;
            // 
            // tlpOptions
            // 
            tlpOptions.Anchor = AnchorStyles.None;
            tlpOptions.AutoSize = true;
            tlpOptions.ColumnCount = 2;
            tlpOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpOptions.Controls.Add(chkRecordarme, 0, 0);
            tlpOptions.Controls.Add(lnkForgotPassword, 1, 0);
            tlpOptions.Location = new Point(38, 363);
            tlpOptions.Margin = new Padding(4);
            tlpOptions.Name = "tlpOptions";
            tlpOptions.RowCount = 1;
            tlpOptions.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpOptions.Size = new Size(438, 44);
            tlpOptions.TabIndex = 8;
            // 
            // chkRecordarme
            // 
            chkRecordarme.Anchor = AnchorStyles.Left;
            chkRecordarme.AutoSize = true;
            chkRecordarme.Cursor = Cursors.Hand;
            chkRecordarme.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRecordarme.Location = new Point(4, 7);
            chkRecordarme.Margin = new Padding(4);
            chkRecordarme.Name = "chkRecordarme";
            chkRecordarme.Size = new Size(163, 29);
            chkRecordarme.TabIndex = 0;
            chkRecordarme.Text = "Recordar sesión";
            chkRecordarme.UseVisualStyleBackColor = true;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.ActiveLinkColor = Color.Red;
            lnkForgotPassword.Anchor = AnchorStyles.Right;
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.LinkColor = Color.FromArgb(64, 64, 64);
            lnkForgotPassword.Location = new Point(223, 9);
            lnkForgotPassword.Margin = new Padding(4, 0, 4, 0);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(211, 25);
            lnkForgotPassword.TabIndex = 1;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "¿Olvidaste la contraseña?";
            lnkForgotPassword.TextAlign = ContentAlignment.MiddleRight;
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
            btnAcceder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(42, 440);
            btnAcceder.Margin = new Padding(0, 29, 0, 0);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(429, 59);
            btnAcceder.TabIndex = 1;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1263, 825);
            Controls.Add(tlpMainLayout);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
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
            tlpOptions.ResumeLayout(false);
            tlpOptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainLayout;
        private Panel pnlBranding;
        private TableLayoutPanel tlpBrandingContent;
        private PictureBox picLogo;
        private FlowLayoutPanel flpBrandingStack;
        private Label lblAppName;
        private Label lblSlogan;
        private Label lblFeature1;
        private Label lblFeature2;
        private Label lblFeature3;
        private Panel pnlForm;
        private TableLayoutPanel tlpFormContent;
        private FlowLayoutPanel flpFormControls;
        private Label lblLoginTitle;
        private Label lblLoginSubtitle;
        private Label lblEmailPrompt;
        private TextBox txtEmail;
        private Panel pnlEmailUnderline;
        private Label lblPasswordPrompt;
        private TextBox txtPassword;
        private Panel pnlPasswordUnderline;
        private TableLayoutPanel tlpOptions;
        private CheckBox chkRecordarme;
        private LinkLabel lnkForgotPassword;
        private Button btnAcceder;
        private Button btnClose;
    }
}