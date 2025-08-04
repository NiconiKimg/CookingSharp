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
            tlpMainLayout = new TableLayoutPanel();
            pnlHeader = new Panel();
            tlpHeaderLayout = new TableLayoutPanel();
            tlpHeaderLeft = new TableLayoutPanel();
            picLogo = new PictureBox();
            lblAppName = new Label();
            lblSubtittleNav = new Label();
            tlpHeaderRight = new TableLayoutPanel();
            picUser = new PictureBox();
            tlpUserDetails = new TableLayoutPanel();
            lblUserRole = new Label();
            lblUserEmail = new Label();
            btnUserOptions = new Button();
            pnlNavigation = new Panel();
            tlpNavigation = new TableLayoutPanel();
            lblMenuGestionTitle = new Label();
            btnNavRecetas = new Button();
            btnNavUsuarios = new Button();
            btnNavUnidadesMedida = new Button();
            btnNavDificultades = new Button();
            btnNavCategorias = new Button();
            lblMenuModeracionTitle = new Label();
            btnNavAprobacionRecetas = new Button();
            btnNavAprobacionIngredientes = new Button();
            pnlMainContent = new Panel();
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
            tlpMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tlpMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainLayout.Controls.Add(pnlHeader, 0, 0);
            tlpMainLayout.Controls.Add(pnlNavigation, 0, 1);
            tlpMainLayout.Controls.Add(pnlMainContent, 1, 1);
            tlpMainLayout.Dock = DockStyle.Fill;
            tlpMainLayout.Location = new Point(0, 0);
            tlpMainLayout.Margin = new Padding(0);
            tlpMainLayout.Name = "tlpMainLayout";
            tlpMainLayout.RowCount = 2;
            tlpMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tlpMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainLayout.Size = new Size(1036, 655);
            tlpMainLayout.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(26, 34, 45);
            tlpMainLayout.SetColumnSpan(pnlHeader, 2);
            pnlHeader.Controls.Add(tlpHeaderLayout);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1036, 62);
            pnlHeader.TabIndex = 0;
            // 
            // tlpHeaderLayout
            // 
            tlpHeaderLayout.BackColor = Color.Transparent;
            tlpHeaderLayout.ColumnCount = 3;
            tlpHeaderLayout.ColumnStyles.Add(new ColumnStyle());
            tlpHeaderLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHeaderLayout.ColumnStyles.Add(new ColumnStyle());
            tlpHeaderLayout.Controls.Add(tlpHeaderLeft, 0, 0);
            tlpHeaderLayout.Controls.Add(tlpHeaderRight, 2, 0);
            tlpHeaderLayout.Dock = DockStyle.Fill;
            tlpHeaderLayout.Location = new Point(0, 0);
            tlpHeaderLayout.Margin = new Padding(2);
            tlpHeaderLayout.Name = "tlpHeaderLayout";
            tlpHeaderLayout.RowCount = 1;
            tlpHeaderLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeaderLayout.Size = new Size(1036, 62);
            tlpHeaderLayout.TabIndex = 0;
            // 
            // tlpHeaderLeft
            // 
            tlpHeaderLeft.Anchor = AnchorStyles.Left;
            tlpHeaderLeft.AutoSize = true;
            tlpHeaderLeft.ColumnCount = 4;
            tlpHeaderLeft.ColumnStyles.Add(new ColumnStyle());
            tlpHeaderLeft.ColumnStyles.Add(new ColumnStyle());
            tlpHeaderLeft.ColumnStyles.Add(new ColumnStyle());
            tlpHeaderLeft.ColumnStyles.Add(new ColumnStyle());
            tlpHeaderLeft.Controls.Add(picLogo, 0, 0);
            tlpHeaderLeft.Controls.Add(lblAppName, 1, 0);
            tlpHeaderLeft.Controls.Add(lblSubtittleNav, 3, 0);
            tlpHeaderLeft.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tlpHeaderLeft.Location = new Point(3, 15);
            tlpHeaderLeft.Margin = new Padding(3, 2, 3, 2);
            tlpHeaderLeft.Name = "tlpHeaderLeft";
            tlpHeaderLeft.RowCount = 1;
            tlpHeaderLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeaderLeft.Size = new Size(267, 32);
            tlpHeaderLeft.TabIndex = 2;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Left;
            picLogo.Cursor = Cursors.Hand;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(2, 2);
            picLogo.Margin = new Padding(2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(32, 28);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // lblAppName
            // 
            lblAppName.Anchor = AnchorStyles.Left;
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.WhiteSmoke;
            lblAppName.Location = new Point(46, 5);
            lblAppName.Margin = new Padding(10, 0, 0, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(83, 21);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Cooking#";
            // 
            // lblSubtittleNav
            // 
            lblSubtittleNav.Anchor = AnchorStyles.None;
            lblSubtittleNav.AutoSize = true;
            lblSubtittleNav.ForeColor = Color.WhiteSmoke;
            lblSubtittleNav.Location = new Point(131, 8);
            lblSubtittleNav.Margin = new Padding(2, 0, 2, 0);
            lblSubtittleNav.Name = "lblSubtittleNav";
            lblSubtittleNav.Size = new Size(134, 15);
            lblSubtittleNav.TabIndex = 2;
            lblSubtittleNav.Text = "Panel de administración";
            // 
            // tlpHeaderRight
            // 
            tlpHeaderRight.ColumnCount = 3;
            tlpHeaderRight.ColumnStyles.Add(new ColumnStyle());
            tlpHeaderRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHeaderRight.ColumnStyles.Add(new ColumnStyle());
            tlpHeaderRight.Controls.Add(picUser, 0, 0);
            tlpHeaderRight.Controls.Add(tlpUserDetails, 1, 0);
            tlpHeaderRight.Controls.Add(btnUserOptions, 2, 0);
            tlpHeaderRight.Dock = DockStyle.Right;
            tlpHeaderRight.Location = new Point(833, 2);
            tlpHeaderRight.Margin = new Padding(3, 2, 3, 2);
            tlpHeaderRight.Name = "tlpHeaderRight";
            tlpHeaderRight.RowCount = 1;
            tlpHeaderRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeaderRight.Size = new Size(200, 58);
            tlpHeaderRight.TabIndex = 0;
            // 
            // picUser
            // 
            picUser.Anchor = AnchorStyles.None;
            picUser.Image = (Image)resources.GetObject("picUser.Image");
            picUser.Location = new Point(3, 12);
            picUser.Margin = new Padding(3, 2, 3, 2);
            picUser.Name = "picUser";
            picUser.Size = new Size(40, 34);
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // tlpUserDetails
            // 
            tlpUserDetails.ColumnCount = 1;
            tlpUserDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUserDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUserDetails.Controls.Add(lblUserRole, 0, 0);
            tlpUserDetails.Controls.Add(lblUserEmail, 0, 1);
            tlpUserDetails.Dock = DockStyle.Fill;
            tlpUserDetails.Location = new Point(49, 2);
            tlpUserDetails.Margin = new Padding(3, 2, 3, 2);
            tlpUserDetails.Name = "tlpUserDetails";
            tlpUserDetails.RowCount = 2;
            tlpUserDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpUserDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpUserDetails.Size = new Size(112, 54);
            tlpUserDetails.TabIndex = 1;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Dock = DockStyle.Fill;
            lblUserRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserRole.ForeColor = Color.WhiteSmoke;
            lblUserRole.Location = new Point(3, 0);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(106, 27);
            lblUserRole.TabIndex = 0;
            lblUserRole.Text = "Administrador";
            lblUserRole.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoEllipsis = true;
            lblUserEmail.AutoSize = true;
            lblUserEmail.Dock = DockStyle.Fill;
            lblUserEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserEmail.ForeColor = Color.Gainsboro;
            lblUserEmail.Location = new Point(3, 27);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(106, 27);
            lblUserEmail.TabIndex = 1;
            lblUserEmail.Text = "admin@cookingsharp.com";
            lblUserEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnUserOptions
            // 
            btnUserOptions.Anchor = AnchorStyles.None;
            btnUserOptions.FlatAppearance.BorderSize = 0;
            btnUserOptions.FlatStyle = FlatStyle.Flat;
            btnUserOptions.Image = (Image)resources.GetObject("btnUserOptions.Image");
            btnUserOptions.Location = new Point(167, 16);
            btnUserOptions.Margin = new Padding(3, 2, 3, 2);
            btnUserOptions.Name = "btnUserOptions";
            btnUserOptions.Size = new Size(30, 26);
            btnUserOptions.TabIndex = 2;
            btnUserOptions.UseVisualStyleBackColor = true;
            // 
            // pnlNavigation
            // 
            pnlNavigation.AutoScroll = true;
            pnlNavigation.BackColor = Color.FromArgb(31, 41, 55);
            pnlNavigation.Controls.Add(tlpNavigation);
            pnlNavigation.Dock = DockStyle.Fill;
            pnlNavigation.Location = new Point(0, 62);
            pnlNavigation.Margin = new Padding(0);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(250, 593);
            pnlNavigation.TabIndex = 1;
            // 
            // tlpNavigation
            // 
            tlpNavigation.AutoSize = true;
            tlpNavigation.BackColor = Color.Transparent;
            tlpNavigation.ColumnCount = 1;
            tlpNavigation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpNavigation.Controls.Add(lblMenuGestionTitle, 0, 0);
            tlpNavigation.Controls.Add(btnNavRecetas, 0, 1);
            tlpNavigation.Controls.Add(btnNavUsuarios, 0, 2);
            tlpNavigation.Controls.Add(btnNavUnidadesMedida, 0, 3);
            tlpNavigation.Controls.Add(btnNavDificultades, 0, 4);
            tlpNavigation.Controls.Add(btnNavCategorias, 0, 5);
            tlpNavigation.Controls.Add(lblMenuModeracionTitle, 0, 6);
            tlpNavigation.Controls.Add(btnNavAprobacionRecetas, 0, 7);
            tlpNavigation.Controls.Add(btnNavAprobacionIngredientes, 0, 9);
            tlpNavigation.Dock = DockStyle.Top;
            tlpNavigation.Location = new Point(0, 0);
            tlpNavigation.Margin = new Padding(2);
            tlpNavigation.Name = "tlpNavigation";
            tlpNavigation.RowCount = 15;
            tlpNavigation.RowStyles.Add(new RowStyle());
            tlpNavigation.RowStyles.Add(new RowStyle());
            tlpNavigation.RowStyles.Add(new RowStyle());
            tlpNavigation.RowStyles.Add(new RowStyle());
            tlpNavigation.RowStyles.Add(new RowStyle());
            tlpNavigation.RowStyles.Add(new RowStyle());
            tlpNavigation.RowStyles.Add(new RowStyle());
            tlpNavigation.RowStyles.Add(new RowStyle());
            tlpNavigation.RowStyles.Add(new RowStyle());
            tlpNavigation.RowStyles.Add(new RowStyle());
            tlpNavigation.RowStyles.Add(new RowStyle());
            tlpNavigation.RowStyles.Add(new RowStyle());
            tlpNavigation.RowStyles.Add(new RowStyle());
            tlpNavigation.RowStyles.Add(new RowStyle());
            tlpNavigation.RowStyles.Add(new RowStyle());
            tlpNavigation.Size = new Size(250, 350);
            tlpNavigation.TabIndex = 2;
            // 
            // lblMenuGestionTitle
            // 
            lblMenuGestionTitle.AutoSize = true;
            lblMenuGestionTitle.Dock = DockStyle.Fill;
            lblMenuGestionTitle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuGestionTitle.ForeColor = Color.Gainsboro;
            lblMenuGestionTitle.Location = new Point(3, 0);
            lblMenuGestionTitle.Name = "lblMenuGestionTitle";
            lblMenuGestionTitle.Padding = new Padding(0, 17, 0, 4);
            lblMenuGestionTitle.Size = new Size(244, 34);
            lblMenuGestionTitle.TabIndex = 1;
            lblMenuGestionTitle.Text = "GESTIÓN";
            lblMenuGestionTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnNavRecetas
            // 
            btnNavRecetas.Dock = DockStyle.Fill;
            btnNavRecetas.FlatAppearance.BorderSize = 0;
            btnNavRecetas.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 62, 83);
            btnNavRecetas.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 62, 83);
            btnNavRecetas.FlatStyle = FlatStyle.Flat;
            btnNavRecetas.Font = new Font("Segoe UI", 10F);
            btnNavRecetas.ForeColor = Color.WhiteSmoke;
            btnNavRecetas.Image = Properties.Resources.recipesIcon;
            btnNavRecetas.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavRecetas.Location = new Point(3, 36);
            btnNavRecetas.Margin = new Padding(3, 2, 3, 2);
            btnNavRecetas.Name = "btnNavRecetas";
            btnNavRecetas.Size = new Size(244, 35);
            btnNavRecetas.TabIndex = 2;
            btnNavRecetas.Text = "    Recetas";
            btnNavRecetas.TextAlign = ContentAlignment.MiddleLeft;
            btnNavRecetas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavRecetas.UseVisualStyleBackColor = true;
            // 
            // btnNavUsuarios
            // 
            btnNavUsuarios.Dock = DockStyle.Fill;
            btnNavUsuarios.FlatAppearance.BorderSize = 0;
            btnNavUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 62, 83);
            btnNavUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 62, 83);
            btnNavUsuarios.FlatStyle = FlatStyle.Flat;
            btnNavUsuarios.Font = new Font("Segoe UI", 10F);
            btnNavUsuarios.ForeColor = Color.WhiteSmoke;
            btnNavUsuarios.Image = Properties.Resources.usersIcon;
            btnNavUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavUsuarios.Location = new Point(3, 75);
            btnNavUsuarios.Margin = new Padding(3, 2, 3, 2);
            btnNavUsuarios.Name = "btnNavUsuarios";
            btnNavUsuarios.Size = new Size(244, 35);
            btnNavUsuarios.TabIndex = 0;
            btnNavUsuarios.Text = "    Usuarios";
            btnNavUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnNavUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnNavUnidadesMedida
            // 
            btnNavUnidadesMedida.Dock = DockStyle.Fill;
            btnNavUnidadesMedida.FlatAppearance.BorderSize = 0;
            btnNavUnidadesMedida.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 62, 83);
            btnNavUnidadesMedida.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 62, 83);
            btnNavUnidadesMedida.FlatStyle = FlatStyle.Flat;
            btnNavUnidadesMedida.Font = new Font("Segoe UI", 10F);
            btnNavUnidadesMedida.ForeColor = Color.WhiteSmoke;
            btnNavUnidadesMedida.Image = Properties.Resources.measurementUnitIcon;
            btnNavUnidadesMedida.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavUnidadesMedida.Location = new Point(3, 114);
            btnNavUnidadesMedida.Margin = new Padding(3, 2, 3, 2);
            btnNavUnidadesMedida.Name = "btnNavUnidadesMedida";
            btnNavUnidadesMedida.Size = new Size(244, 35);
            btnNavUnidadesMedida.TabIndex = 5;
            btnNavUnidadesMedida.Text = "    Unidades de Medida";
            btnNavUnidadesMedida.TextAlign = ContentAlignment.MiddleLeft;
            btnNavUnidadesMedida.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavUnidadesMedida.UseVisualStyleBackColor = true;
            // 
            // btnNavDificultades
            // 
            btnNavDificultades.Dock = DockStyle.Fill;
            btnNavDificultades.FlatAppearance.BorderSize = 0;
            btnNavDificultades.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 62, 83);
            btnNavDificultades.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 62, 83);
            btnNavDificultades.FlatStyle = FlatStyle.Flat;
            btnNavDificultades.Font = new Font("Segoe UI", 10F);
            btnNavDificultades.ForeColor = Color.WhiteSmoke;
            btnNavDificultades.Image = Properties.Resources.difficultyIcon;
            btnNavDificultades.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavDificultades.Location = new Point(3, 153);
            btnNavDificultades.Margin = new Padding(3, 2, 3, 2);
            btnNavDificultades.Name = "btnNavDificultades";
            btnNavDificultades.Size = new Size(244, 35);
            btnNavDificultades.TabIndex = 4;
            btnNavDificultades.Text = "    Dificultades";
            btnNavDificultades.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDificultades.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavDificultades.UseVisualStyleBackColor = true;
            // 
            // btnNavCategorias
            // 
            btnNavCategorias.Dock = DockStyle.Fill;
            btnNavCategorias.FlatAppearance.BorderSize = 0;
            btnNavCategorias.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 62, 83);
            btnNavCategorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 62, 83);
            btnNavCategorias.FlatStyle = FlatStyle.Flat;
            btnNavCategorias.Font = new Font("Segoe UI", 10F);
            btnNavCategorias.ForeColor = Color.WhiteSmoke;
            btnNavCategorias.Image = Properties.Resources.categoryIcon;
            btnNavCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavCategorias.Location = new Point(3, 192);
            btnNavCategorias.Margin = new Padding(3, 2, 3, 2);
            btnNavCategorias.Name = "btnNavCategorias";
            btnNavCategorias.Size = new Size(244, 35);
            btnNavCategorias.TabIndex = 3;
            btnNavCategorias.Text = "    Categorias";
            btnNavCategorias.TextAlign = ContentAlignment.MiddleLeft;
            btnNavCategorias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavCategorias.UseVisualStyleBackColor = true;
            btnNavCategorias.Click += btnNavCategorias_Click;
            // 
            // lblMenuModeracionTitle
            // 
            lblMenuModeracionTitle.AutoSize = true;
            lblMenuModeracionTitle.Dock = DockStyle.Fill;
            lblMenuModeracionTitle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuModeracionTitle.ForeColor = Color.Gainsboro;
            lblMenuModeracionTitle.Location = new Point(3, 229);
            lblMenuModeracionTitle.Name = "lblMenuModeracionTitle";
            lblMenuModeracionTitle.Padding = new Padding(10, 26, 0, 4);
            lblMenuModeracionTitle.Size = new Size(244, 43);
            lblMenuModeracionTitle.TabIndex = 6;
            lblMenuModeracionTitle.Text = "MODERACIÓN";
            lblMenuModeracionTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnNavAprobacionRecetas
            // 
            btnNavAprobacionRecetas.Dock = DockStyle.Fill;
            btnNavAprobacionRecetas.FlatAppearance.BorderSize = 0;
            btnNavAprobacionRecetas.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 62, 83);
            btnNavAprobacionRecetas.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 62, 83);
            btnNavAprobacionRecetas.FlatStyle = FlatStyle.Flat;
            btnNavAprobacionRecetas.Font = new Font("Segoe UI", 10F);
            btnNavAprobacionRecetas.ForeColor = Color.WhiteSmoke;
            btnNavAprobacionRecetas.Image = Properties.Resources.recipeConfirmationIcon;
            btnNavAprobacionRecetas.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavAprobacionRecetas.Location = new Point(3, 274);
            btnNavAprobacionRecetas.Margin = new Padding(3, 2, 3, 2);
            btnNavAprobacionRecetas.Name = "btnNavAprobacionRecetas";
            btnNavAprobacionRecetas.Size = new Size(244, 35);
            btnNavAprobacionRecetas.TabIndex = 7;
            btnNavAprobacionRecetas.Text = "    Aprobación de Recetas";
            btnNavAprobacionRecetas.TextAlign = ContentAlignment.MiddleLeft;
            btnNavAprobacionRecetas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavAprobacionRecetas.UseVisualStyleBackColor = true;
            // 
            // btnNavAprobacionIngredientes
            // 
            btnNavAprobacionIngredientes.Dock = DockStyle.Fill;
            btnNavAprobacionIngredientes.FlatAppearance.BorderSize = 0;
            btnNavAprobacionIngredientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 62, 83);
            btnNavAprobacionIngredientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 62, 83);
            btnNavAprobacionIngredientes.FlatStyle = FlatStyle.Flat;
            btnNavAprobacionIngredientes.Font = new Font("Segoe UI", 10F);
            btnNavAprobacionIngredientes.ForeColor = Color.WhiteSmoke;
            btnNavAprobacionIngredientes.Image = Properties.Resources.ingredientsIcon;
            btnNavAprobacionIngredientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavAprobacionIngredientes.Location = new Point(3, 313);
            btnNavAprobacionIngredientes.Margin = new Padding(3, 2, 3, 2);
            btnNavAprobacionIngredientes.Name = "btnNavAprobacionIngredientes";
            btnNavAprobacionIngredientes.Size = new Size(244, 35);
            btnNavAprobacionIngredientes.TabIndex = 9;
            btnNavAprobacionIngredientes.Text = "    Aprobación de Ingredientes";
            btnNavAprobacionIngredientes.TextAlign = ContentAlignment.MiddleLeft;
            btnNavAprobacionIngredientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavAprobacionIngredientes.UseVisualStyleBackColor = true;
            // 
            // pnlMainContent
            // 
            pnlMainContent.BackColor = Color.White;
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(252, 64);
            pnlMainContent.Margin = new Padding(2);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Padding = new Padding(14, 13, 14, 13);
            pnlMainContent.Size = new Size(782, 589);
            pnlMainContent.TabIndex = 2;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 655);
            Controls.Add(tlpMainLayout);
            Margin = new Padding(2);
            MinimumSize = new Size(900, 670);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cooking # - Panel de Administración";
            WindowState = FormWindowState.Maximized;
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

        internal TableLayoutPanel tlpMainLayout;
        internal Panel pnlHeader;
        internal Panel pnlNavigation;
        internal TableLayoutPanel tlpHeaderLayout;
        internal TableLayoutPanel tlpHeaderLeft;
        internal PictureBox picLogo;
        internal Label lblAppName;
        internal TableLayoutPanel tlpHeaderRight;
        internal PictureBox picUser;
        internal TableLayoutPanel tlpUserDetails;
        internal Label lblUserRole;
        internal Label lblUserEmail;
        internal Button btnUserOptions;
        internal Button btnNavUsuarios;
        internal Label lblMenuGestionTitle;
        internal Button btnNavRecetas;
        internal Button btnNavCategorias;
        internal Button btnNavDificultades;
        internal Button btnNavUnidadesMedida;
        internal Label lblMenuModeracionTitle;
        internal Button btnNavAprobacionRecetas;
        internal Button btnNavAprobacionIngredientes;
        private TableLayoutPanel tlpNavigation;
        private Label lblSubtittleNav;
        internal Panel pnlMainContent;
    }
}
