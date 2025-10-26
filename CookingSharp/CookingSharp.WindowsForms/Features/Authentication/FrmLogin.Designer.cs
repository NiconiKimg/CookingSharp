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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.tlpMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBranding = new System.Windows.Forms.Panel();
            this.tlpBrandingContent = new System.Windows.Forms.TableLayoutPanel();
            this.flpBrandingStack = new System.Windows.Forms.FlowLayoutPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblFeature1 = new System.Windows.Forms.Label();
            this.lblFeature2 = new System.Windows.Forms.Label();
            this.lblFeature3 = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tlpFormContent = new System.Windows.Forms.TableLayoutPanel();
            this.flpFormControls = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblLoginSubtitle = new System.Windows.Forms.Label();
            this.lblEmailPrompt = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlEmailUnderline = new System.Windows.Forms.Panel();
            this.lblPasswordPrompt = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlPasswordUnderline = new System.Windows.Forms.Panel();
            this.tlpOptions = new System.Windows.Forms.TableLayoutPanel();
            this.chkRecordarme = new System.Windows.Forms.CheckBox();
            this.lnkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.tlpMainLayout.SuspendLayout();
            this.pnlBranding.SuspendLayout();
            this.tlpBrandingContent.SuspendLayout();
            this.flpBrandingStack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.tlpFormContent.SuspendLayout();
            this.flpFormControls.SuspendLayout();
            this.tlpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainLayout
            // 
            this.tlpMainLayout.ColumnCount = 2;
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpMainLayout.Controls.Add(this.pnlBranding, 0, 0);
            this.tlpMainLayout.Controls.Add(this.pnlForm, 1, 0);
            this.tlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpMainLayout.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMainLayout.Name = "tlpMainLayout";
            this.tlpMainLayout.RowCount = 1;
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainLayout.Size = new System.Drawing.Size(1263, 825);
            this.tlpMainLayout.TabIndex = 0;
            // 
            // pnlBranding
            // 
            this.pnlBranding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.pnlBranding.Controls.Add(this.tlpBrandingContent);
            this.pnlBranding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBranding.Location = new System.Drawing.Point(4, 4);
            this.pnlBranding.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBranding.Name = "pnlBranding";
            this.pnlBranding.Padding = new System.Windows.Forms.Padding(43, 0, 43, 0);
            this.pnlBranding.Size = new System.Drawing.Size(560, 817);
            this.pnlBranding.TabIndex = 0;
            // 
            // tlpBrandingContent
            // 
            this.tlpBrandingContent.BackColor = System.Drawing.Color.Transparent;
            this.tlpBrandingContent.ColumnCount = 1;
            this.tlpBrandingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBrandingContent.Controls.Add(this.flpBrandingStack, 0, 1);
            this.tlpBrandingContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBrandingContent.Location = new System.Drawing.Point(43, 0);
            this.tlpBrandingContent.Margin = new System.Windows.Forms.Padding(4);
            this.tlpBrandingContent.Name = "tlpBrandingContent";
            this.tlpBrandingContent.RowCount = 3;
            this.tlpBrandingContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBrandingContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBrandingContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBrandingContent.Size = new System.Drawing.Size(474, 817);
            this.tlpBrandingContent.TabIndex = 0;
            // 
            // flpBrandingStack
            // 
            this.flpBrandingStack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpBrandingStack.AutoSize = true;
            this.flpBrandingStack.Controls.Add(this.picLogo);
            this.flpBrandingStack.Controls.Add(this.lblAppName);
            this.flpBrandingStack.Controls.Add(this.lblSlogan);
            this.flpBrandingStack.Controls.Add(this.lblFeature1);
            this.flpBrandingStack.Controls.Add(this.lblFeature2);
            this.flpBrandingStack.Controls.Add(this.lblFeature3);
            this.flpBrandingStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpBrandingStack.Location = new System.Drawing.Point(56, 221);
            this.flpBrandingStack.Margin = new System.Windows.Forms.Padding(4);
            this.flpBrandingStack.Name = "flpBrandingStack";
            this.flpBrandingStack.Size = new System.Drawing.Size(362, 374);
            this.flpBrandingStack.TabIndex = 2;
            this.flpBrandingStack.WrapContents = false;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.Image = global::CookingSharp.WindowsForms.Properties.Resources.roundedLogo;
            this.picLogo.Location = new System.Drawing.Point(124, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 29);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(114, 118);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            this.lblAppName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(69, 147);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(224, 40);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Cooking#";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSlogan.Location = new System.Drawing.Point(0, 187);
            this.lblSlogan.Margin = new System.Windows.Forms.Padding(0, 0, 0, 44);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(342, 25);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Sistema de gestión de recetas profesional";
            // 
            // lblFeature1
            // 
            this.lblFeature1.AutoSize = true;
            this.lblFeature1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeature1.ForeColor = System.Drawing.Color.White;
            this.lblFeature1.Image = global::CookingSharp.WindowsForms.Properties.Resources.circleCheck;
            this.lblFeature1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFeature1.Location = new System.Drawing.Point(14, 256);
            this.lblFeature1.Margin = new System.Windows.Forms.Padding(14, 0, 0, 7);
            this.lblFeature1.Name = "lblFeature1";
            this.lblFeature1.Size = new System.Drawing.Size(299, 28);
            this.lblFeature1.TabIndex = 1;
            this.lblFeature1.Text = "        Gestión completa de recetas";
            this.lblFeature1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFeature2
            // 
            this.lblFeature2.AutoSize = true;
            this.lblFeature2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeature2.ForeColor = System.Drawing.Color.White;
            this.lblFeature2.Image = global::CookingSharp.WindowsForms.Properties.Resources.circleCheck;
            this.lblFeature2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFeature2.Location = new System.Drawing.Point(14, 291);
            this.lblFeature2.Margin = new System.Windows.Forms.Padding(14, 0, 0, 7);
            this.lblFeature2.Name = "lblFeature2";
            this.lblFeature2.Size = new System.Drawing.Size(348, 28);
            this.lblFeature2.TabIndex = 3;
            this.lblFeature2.Text = "        Panel de administración avanzado";
            this.lblFeature2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFeature3
            // 
            this.lblFeature3.AutoSize = true;
            this.lblFeature3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeature3.ForeColor = System.Drawing.Color.White;
            this.lblFeature3.Image = global::CookingSharp.WindowsForms.Properties.Resources.circleCheck;
            this.lblFeature3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFeature3.Location = new System.Drawing.Point(14, 326);
            this.lblFeature3.Margin = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblFeature3.Name = "lblFeature3";
            this.lblFeature3.Size = new System.Drawing.Size(315, 28);
            this.lblFeature3.TabIndex = 4;
            this.lblFeature3.Text = "        Seguridad y control de acceso";
            this.lblFeature3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.btnClose);
            this.pnlForm.Controls.Add(this.tlpFormContent);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(572, 4);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(71, 0, 71, 0);
            this.pnlForm.Size = new System.Drawing.Size(687, 817);
            this.pnlForm.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(641, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tlpFormContent
            // 
            this.tlpFormContent.BackColor = System.Drawing.Color.Transparent;
            this.tlpFormContent.ColumnCount = 1;
            this.tlpFormContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFormContent.Controls.Add(this.flpFormControls, 0, 1);
            this.tlpFormContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFormContent.Location = new System.Drawing.Point(71, 0);
            this.tlpFormContent.Margin = new System.Windows.Forms.Padding(4);
            this.tlpFormContent.Name = "tlpFormContent";
            this.tlpFormContent.RowCount = 3;
            this.tlpFormContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFormContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFormContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFormContent.Size = new System.Drawing.Size(545, 817);
            this.tlpFormContent.TabIndex = 0;
            // 
            // flpFormControls
            // 
            this.flpFormControls.AutoSize = true;
            this.flpFormControls.Controls.Add(this.lblLoginTitle);
            this.flpFormControls.Controls.Add(this.lblLoginSubtitle);
            this.flpFormControls.Controls.Add(this.lblEmailPrompt);
            this.flpFormControls.Controls.Add(this.txtEmail);
            this.flpFormControls.Controls.Add(this.pnlEmailUnderline);
            this.flpFormControls.Controls.Add(this.lblPasswordPrompt);
            this.flpFormControls.Controls.Add(this.txtPassword);
            this.flpFormControls.Controls.Add(this.pnlPasswordUnderline);
            this.flpFormControls.Controls.Add(this.tlpOptions);
            this.flpFormControls.Controls.Add(this.btnAcceder);
            this.flpFormControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFormControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFormControls.Location = new System.Drawing.Point(4, 159);
            this.flpFormControls.Margin = new System.Windows.Forms.Padding(4);
            this.flpFormControls.Name = "flpFormControls";
            this.flpFormControls.Size = new System.Drawing.Size(537, 499);
            this.flpFormControls.TabIndex = 0;
            this.flpFormControls.WrapContents = false;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.Location = new System.Drawing.Point(0, 0);
            this.lblLoginTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(225, 45);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "Iniciar Sesión";
            // 
            // lblLoginSubtitle
            // 
            this.lblLoginSubtitle.AutoSize = true;
            this.lblLoginSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblLoginSubtitle.Location = new System.Drawing.Point(0, 52);
            this.lblLoginSubtitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 74);
            this.lblLoginSubtitle.Name = "lblLoginSubtitle";
            this.lblLoginSubtitle.Size = new System.Drawing.Size(176, 17);
            this.lblLoginSubtitle.TabIndex = 1;
            this.lblLoginSubtitle.Text = "Accede a tu panel de control";
            // 
            // lblEmailPrompt
            // 
            this.lblEmailPrompt.AutoSize = true;
            this.lblEmailPrompt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailPrompt.Location = new System.Drawing.Point(0, 143);
            this.lblEmailPrompt.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblEmailPrompt.Name = "lblEmailPrompt";
            this.lblEmailPrompt.Size = new System.Drawing.Size(36, 15);
            this.lblEmailPrompt.TabIndex = 2;
            this.lblEmailPrompt.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(7, 165);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "tu@email.com";
            this.txtEmail.Size = new System.Drawing.Size(500, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // pnlEmailUnderline
            // 
            this.pnlEmailUnderline.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlEmailUnderline.Location = new System.Drawing.Point(7, 185);
            this.pnlEmailUnderline.Margin = new System.Windows.Forms.Padding(7, 0, 7, 29);
            this.pnlEmailUnderline.Name = "pnlEmailUnderline";
            this.pnlEmailUnderline.Size = new System.Drawing.Size(500, 1);
            this.pnlEmailUnderline.TabIndex = 4;
            // 
            // lblPasswordPrompt
            // 
            this.lblPasswordPrompt.AutoSize = true;
            this.lblPasswordPrompt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordPrompt.Location = new System.Drawing.Point(0, 230);
            this.lblPasswordPrompt.Margin = new System.Windows.Forms.Padding(0, 15, 0, 7);
            this.lblPasswordPrompt.Name = "lblPasswordPrompt";
            this.lblPasswordPrompt.Size = new System.Drawing.Size(67, 15);
            this.lblPasswordPrompt.TabIndex = 5;
            this.lblPasswordPrompt.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(7, 252);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "***********";
            this.txtPassword.Size = new System.Drawing.Size(500, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // pnlPasswordUnderline
            // 
            this.pnlPasswordUnderline.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlPasswordUnderline.Location = new System.Drawing.Point(7, 272);
            this.pnlPasswordUnderline.Margin = new System.Windows.Forms.Padding(7, 0, 7, 15);
            this.pnlPasswordUnderline.Name = "pnlPasswordUnderline";
            this.pnlPasswordUnderline.Size = new System.Drawing.Size(500, 1);
            this.pnlPasswordUnderline.TabIndex = 5;
            // 
            // tlpOptions
            // 
            this.tlpOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpOptions.AutoSize = true;
            this.tlpOptions.ColumnCount = 2;
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOptions.Controls.Add(this.chkRecordarme, 0, 0);
            this.tlpOptions.Controls.Add(this.lnkForgotPassword, 1, 0);
            this.tlpOptions.Location = new System.Drawing.Point(38, 292);
            this.tlpOptions.Margin = new System.Windows.Forms.Padding(4);
            this.tlpOptions.Name = "tlpOptions";
            this.tlpOptions.RowCount = 1;
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpOptions.Size = new System.Drawing.Size(438, 44);
            this.tlpOptions.TabIndex = 8;
            // 
            // chkRecordarme
            // 
            this.chkRecordarme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkRecordarme.AutoSize = true;
            this.chkRecordarme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRecordarme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRecordarme.Location = new System.Drawing.Point(4, 12);
            this.chkRecordarme.Margin = new System.Windows.Forms.Padding(4);
            this.chkRecordarme.Name = "chkRecordarme";
            this.chkRecordarme.Size = new System.Drawing.Size(111, 19);
            this.chkRecordarme.TabIndex = 0;
            this.chkRecordarme.Text = "Recordar sesión";
            this.chkRecordarme.UseVisualStyleBackColor = true;
            // 
            // lnkForgotPassword
            // 
            this.lnkForgotPassword.ActiveLinkColor = System.Drawing.Color.Red;
            this.lnkForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lnkForgotPassword.AutoSize = true;
            this.lnkForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnkForgotPassword.Location = new System.Drawing.Point(298, 14);
            this.lnkForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkForgotPassword.Name = "lnkForgotPassword";
            this.lnkForgotPassword.Size = new System.Drawing.Size(136, 15);
            this.lnkForgotPassword.TabIndex = 1;
            this.lnkForgotPassword.TabStop = true;
            this.lnkForgotPassword.Text = "¿Olvidaste la contraseña?";
            this.lnkForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAcceder
            // 
            this.btnAcceder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(42, 369);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(0, 29, 0, 0);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(429, 59);
            this.btnAcceder.TabIndex = 1;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 825);
            this.Controls.Add(this.tlpMainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cooking# - Iniciar Sesión";
            this.tlpMainLayout.ResumeLayout(false);
            this.pnlBranding.ResumeLayout(false);
            this.tlpBrandingContent.ResumeLayout(false);
            this.tlpBrandingContent.PerformLayout();
            this.flpBrandingStack.ResumeLayout(false);
            this.flpBrandingStack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.tlpFormContent.ResumeLayout(false);
            this.tlpFormContent.PerformLayout();
            this.flpFormControls.ResumeLayout(false);
            this.flpFormControls.PerformLayout();
            this.tlpOptions.ResumeLayout(false);
            this.tlpOptions.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlPasswordUnderline;
        private System.Windows.Forms.TableLayoutPanel tlpOptions;
        private System.Windows.Forms.CheckBox chkRecordarme;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnClose;
    }
}