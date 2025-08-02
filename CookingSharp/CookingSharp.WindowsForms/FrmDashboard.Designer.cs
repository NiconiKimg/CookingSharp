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
            tlpContentLayout = new TableLayoutPanel();
            flpTitleContainer = new FlowLayoutPanel();
            lblContentTitle = new Label();
            lblContentSubtitle = new Label();
            flpKPIs = new FlowLayoutPanel();
            pnlKpiUsersBorder = new Panel();
            pnlKpiUsuariosContent = new Panel();
            tlpKpiUsersLayout = new TableLayoutPanel();
            lblKpiUsersValue = new Label();
            picKpiUsers = new PictureBox();
            lblKpiUsuariosTittle = new Label();
            pnlKpiRecipesBorder = new Panel();
            pnlKpiRecipesContent = new Panel();
            tlpKpiRecipesLayout = new TableLayoutPanel();
            lblKpiRecipesValue = new Label();
            picKpiRecipes = new PictureBox();
            lblKpiRecipesTittle = new Label();
            pnlKpiPendingBorder = new Panel();
            pnlKpiPendingContent = new Panel();
            tlpKpiPendingLayout = new TableLayoutPanel();
            lblKpiPendingValue = new Label();
            picKpiPending = new PictureBox();
            lblKpiPendingTittle = new Label();
            pnlKpiCategoryBorder = new Panel();
            pnlKpiCategoryContent = new Panel();
            tlpKpiCategoryLayout = new TableLayoutPanel();
            lblKpiCategoryValue = new Label();
            picKpiCategory = new PictureBox();
            lblKpiCategoryTittle = new Label();
            flpQuickActions = new FlowLayoutPanel();
            lblQuickActionsTittle = new Label();
            btnNewUser = new Button();
            btnCheckPending = new Button();
            button1 = new Button();
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
            pnlMainContent.SuspendLayout();
            tlpContentLayout.SuspendLayout();
            flpTitleContainer.SuspendLayout();
            flpKPIs.SuspendLayout();
            pnlKpiUsersBorder.SuspendLayout();
            pnlKpiUsuariosContent.SuspendLayout();
            tlpKpiUsersLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picKpiUsers).BeginInit();
            pnlKpiRecipesBorder.SuspendLayout();
            pnlKpiRecipesContent.SuspendLayout();
            tlpKpiRecipesLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picKpiRecipes).BeginInit();
            pnlKpiPendingBorder.SuspendLayout();
            pnlKpiPendingContent.SuspendLayout();
            tlpKpiPendingLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picKpiPending).BeginInit();
            pnlKpiCategoryBorder.SuspendLayout();
            pnlKpiCategoryContent.SuspendLayout();
            tlpKpiCategoryLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picKpiCategory).BeginInit();
            flpQuickActions.SuspendLayout();
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
            tlpMainLayout.Size = new Size(1033, 629);
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
            pnlHeader.Size = new Size(1033, 62);
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
            tlpHeaderLayout.Size = new Size(1033, 62);
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
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(2, 2);
            picLogo.Margin = new Padding(2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(32, 28);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
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
            tlpHeaderRight.Location = new Point(830, 2);
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
            pnlNavigation.Size = new Size(250, 567);
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
            pnlMainContent.Controls.Add(tlpContentLayout);
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(252, 64);
            pnlMainContent.Margin = new Padding(2);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Padding = new Padding(14, 13, 14, 13);
            pnlMainContent.Size = new Size(779, 563);
            pnlMainContent.TabIndex = 2;
            // 
            // tlpContentLayout
            // 
            tlpContentLayout.BackColor = Color.Transparent;
            tlpContentLayout.ColumnCount = 1;
            tlpContentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContentLayout.Controls.Add(flpTitleContainer, 0, 0);
            tlpContentLayout.Controls.Add(flpKPIs, 0, 1);
            tlpContentLayout.Controls.Add(flpQuickActions, 0, 2);
            tlpContentLayout.Dock = DockStyle.Fill;
            tlpContentLayout.Location = new Point(14, 13);
            tlpContentLayout.Margin = new Padding(3, 2, 3, 2);
            tlpContentLayout.Name = "tlpContentLayout";
            tlpContentLayout.RowCount = 3;
            tlpContentLayout.RowStyles.Add(new RowStyle());
            tlpContentLayout.RowStyles.Add(new RowStyle());
            tlpContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tlpContentLayout.Size = new Size(751, 537);
            tlpContentLayout.TabIndex = 0;
            // 
            // flpTitleContainer
            // 
            flpTitleContainer.AutoSize = true;
            flpTitleContainer.Controls.Add(lblContentTitle);
            flpTitleContainer.Controls.Add(lblContentSubtitle);
            flpTitleContainer.Dock = DockStyle.Fill;
            flpTitleContainer.FlowDirection = FlowDirection.TopDown;
            flpTitleContainer.Location = new Point(3, 2);
            flpTitleContainer.Margin = new Padding(3, 2, 3, 2);
            flpTitleContainer.Name = "flpTitleContainer";
            flpTitleContainer.Size = new Size(745, 72);
            flpTitleContainer.TabIndex = 0;
            // 
            // lblContentTitle
            // 
            lblContentTitle.AutoSize = true;
            lblContentTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContentTitle.Location = new Point(0, 0);
            lblContentTitle.Margin = new Padding(0, 0, 0, 4);
            lblContentTitle.Name = "lblContentTitle";
            lblContentTitle.Size = new Size(293, 32);
            lblContentTitle.TabIndex = 0;
            lblContentTitle.Text = "Panel de Administración";
            // 
            // lblContentSubtitle
            // 
            lblContentSubtitle.AutoSize = true;
            lblContentSubtitle.Font = new Font("Segoe UI", 10F);
            lblContentSubtitle.ForeColor = Color.DimGray;
            lblContentSubtitle.Location = new Point(0, 36);
            lblContentSubtitle.Margin = new Padding(0, 0, 0, 17);
            lblContentSubtitle.Name = "lblContentSubtitle";
            lblContentSubtitle.Size = new Size(445, 19);
            lblContentSubtitle.TabIndex = 1;
            lblContentSubtitle.Text = "Gestiona todos los aspectos de Cooking# desde este panel centralizado";
            // 
            // flpKPIs
            // 
            flpKPIs.AutoSize = true;
            flpKPIs.Controls.Add(pnlKpiUsersBorder);
            flpKPIs.Controls.Add(pnlKpiRecipesBorder);
            flpKPIs.Controls.Add(pnlKpiPendingBorder);
            flpKPIs.Controls.Add(pnlKpiCategoryBorder);
            flpKPIs.Dock = DockStyle.Fill;
            flpKPIs.Location = new Point(3, 78);
            flpKPIs.Margin = new Padding(3, 2, 3, 2);
            flpKPIs.Name = "flpKPIs";
            flpKPIs.Size = new Size(745, 256);
            flpKPIs.TabIndex = 1;
            // 
            // pnlKpiUsersBorder
            // 
            pnlKpiUsersBorder.BackColor = Color.FromArgb(31, 41, 55);
            pnlKpiUsersBorder.Controls.Add(pnlKpiUsuariosContent);
            pnlKpiUsersBorder.Location = new Point(0, 0);
            pnlKpiUsersBorder.Margin = new Padding(0, 0, 15, 13);
            pnlKpiUsersBorder.Name = "pnlKpiUsersBorder";
            pnlKpiUsersBorder.Padding = new Padding(1);
            pnlKpiUsersBorder.Size = new Size(240, 115);
            pnlKpiUsersBorder.TabIndex = 0;
            // 
            // pnlKpiUsuariosContent
            // 
            pnlKpiUsuariosContent.BackColor = Color.White;
            pnlKpiUsuariosContent.Controls.Add(tlpKpiUsersLayout);
            pnlKpiUsuariosContent.Dock = DockStyle.Fill;
            pnlKpiUsuariosContent.Location = new Point(1, 1);
            pnlKpiUsuariosContent.Margin = new Padding(0);
            pnlKpiUsuariosContent.Name = "pnlKpiUsuariosContent";
            pnlKpiUsuariosContent.Size = new Size(238, 113);
            pnlKpiUsuariosContent.TabIndex = 0;
            // 
            // tlpKpiUsersLayout
            // 
            tlpKpiUsersLayout.ColumnCount = 2;
            tlpKpiUsersLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKpiUsersLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKpiUsersLayout.Controls.Add(lblKpiUsersValue, 1, 0);
            tlpKpiUsersLayout.Controls.Add(picKpiUsers, 0, 0);
            tlpKpiUsersLayout.Controls.Add(lblKpiUsuariosTittle, 0, 1);
            tlpKpiUsersLayout.Dock = DockStyle.Fill;
            tlpKpiUsersLayout.Location = new Point(0, 0);
            tlpKpiUsersLayout.Margin = new Padding(3, 2, 3, 2);
            tlpKpiUsersLayout.Name = "tlpKpiUsersLayout";
            tlpKpiUsersLayout.RowCount = 2;
            tlpKpiUsersLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKpiUsersLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKpiUsersLayout.Size = new Size(238, 113);
            tlpKpiUsersLayout.TabIndex = 0;
            // 
            // lblKpiUsersValue
            // 
            lblKpiUsersValue.AutoSize = true;
            lblKpiUsersValue.Dock = DockStyle.Fill;
            lblKpiUsersValue.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiUsersValue.Location = new Point(119, 0);
            lblKpiUsersValue.Margin = new Padding(0, 0, 15, 0);
            lblKpiUsersValue.Name = "lblKpiUsersValue";
            lblKpiUsersValue.Size = new Size(104, 56);
            lblKpiUsersValue.TabIndex = 1;
            lblKpiUsersValue.Text = "1,234";
            lblKpiUsersValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picKpiUsers
            // 
            picKpiUsers.Image = Properties.Resources.userKpiIcon;
            picKpiUsers.Location = new Point(15, 13);
            picKpiUsers.Margin = new Padding(15, 13, 0, 0);
            picKpiUsers.Name = "picKpiUsers";
            picKpiUsers.Size = new Size(32, 28);
            picKpiUsers.SizeMode = PictureBoxSizeMode.StretchImage;
            picKpiUsers.TabIndex = 2;
            picKpiUsers.TabStop = false;
            // 
            // lblKpiUsuariosTittle
            // 
            lblKpiUsuariosTittle.AutoSize = true;
            tlpKpiUsersLayout.SetColumnSpan(lblKpiUsuariosTittle, 2);
            lblKpiUsuariosTittle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiUsuariosTittle.ForeColor = Color.Black;
            lblKpiUsuariosTittle.Location = new Point(3, 56);
            lblKpiUsuariosTittle.Name = "lblKpiUsuariosTittle";
            lblKpiUsuariosTittle.Size = new Size(169, 21);
            lblKpiUsuariosTittle.TabIndex = 3;
            lblKpiUsuariosTittle.Text = "Usuarios Registrados";
            // 
            // pnlKpiRecipesBorder
            // 
            pnlKpiRecipesBorder.BackColor = Color.FromArgb(31, 41, 55);
            pnlKpiRecipesBorder.Controls.Add(pnlKpiRecipesContent);
            pnlKpiRecipesBorder.Location = new Point(255, 0);
            pnlKpiRecipesBorder.Margin = new Padding(0, 0, 15, 13);
            pnlKpiRecipesBorder.Name = "pnlKpiRecipesBorder";
            pnlKpiRecipesBorder.Padding = new Padding(1);
            pnlKpiRecipesBorder.Size = new Size(240, 115);
            pnlKpiRecipesBorder.TabIndex = 1;
            // 
            // pnlKpiRecipesContent
            // 
            pnlKpiRecipesContent.BackColor = Color.White;
            pnlKpiRecipesContent.Controls.Add(tlpKpiRecipesLayout);
            pnlKpiRecipesContent.Dock = DockStyle.Fill;
            pnlKpiRecipesContent.Location = new Point(1, 1);
            pnlKpiRecipesContent.Margin = new Padding(0);
            pnlKpiRecipesContent.Name = "pnlKpiRecipesContent";
            pnlKpiRecipesContent.Size = new Size(238, 113);
            pnlKpiRecipesContent.TabIndex = 0;
            // 
            // tlpKpiRecipesLayout
            // 
            tlpKpiRecipesLayout.ColumnCount = 2;
            tlpKpiRecipesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKpiRecipesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKpiRecipesLayout.Controls.Add(lblKpiRecipesValue, 1, 0);
            tlpKpiRecipesLayout.Controls.Add(picKpiRecipes, 0, 0);
            tlpKpiRecipesLayout.Controls.Add(lblKpiRecipesTittle, 0, 1);
            tlpKpiRecipesLayout.Dock = DockStyle.Fill;
            tlpKpiRecipesLayout.Location = new Point(0, 0);
            tlpKpiRecipesLayout.Margin = new Padding(3, 2, 3, 2);
            tlpKpiRecipesLayout.Name = "tlpKpiRecipesLayout";
            tlpKpiRecipesLayout.RowCount = 2;
            tlpKpiRecipesLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKpiRecipesLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKpiRecipesLayout.Size = new Size(238, 113);
            tlpKpiRecipesLayout.TabIndex = 0;
            // 
            // lblKpiRecipesValue
            // 
            lblKpiRecipesValue.AutoSize = true;
            lblKpiRecipesValue.Dock = DockStyle.Fill;
            lblKpiRecipesValue.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiRecipesValue.Location = new Point(119, 0);
            lblKpiRecipesValue.Margin = new Padding(0, 0, 15, 0);
            lblKpiRecipesValue.Name = "lblKpiRecipesValue";
            lblKpiRecipesValue.Size = new Size(104, 56);
            lblKpiRecipesValue.TabIndex = 1;
            lblKpiRecipesValue.Text = "3,456";
            lblKpiRecipesValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picKpiRecipes
            // 
            picKpiRecipes.Image = (Image)resources.GetObject("picKpiRecipes.Image");
            picKpiRecipes.Location = new Point(15, 13);
            picKpiRecipes.Margin = new Padding(15, 13, 0, 0);
            picKpiRecipes.Name = "picKpiRecipes";
            picKpiRecipes.Size = new Size(32, 28);
            picKpiRecipes.SizeMode = PictureBoxSizeMode.StretchImage;
            picKpiRecipes.TabIndex = 2;
            picKpiRecipes.TabStop = false;
            // 
            // lblKpiRecipesTittle
            // 
            lblKpiRecipesTittle.AutoSize = true;
            tlpKpiRecipesLayout.SetColumnSpan(lblKpiRecipesTittle, 2);
            lblKpiRecipesTittle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiRecipesTittle.ForeColor = Color.Black;
            lblKpiRecipesTittle.Location = new Point(3, 56);
            lblKpiRecipesTittle.Name = "lblKpiRecipesTittle";
            lblKpiRecipesTittle.Size = new Size(155, 21);
            lblKpiRecipesTittle.TabIndex = 3;
            lblKpiRecipesTittle.Text = "Recetas Publicadas";
            // 
            // pnlKpiPendingBorder
            // 
            pnlKpiPendingBorder.BackColor = Color.FromArgb(31, 41, 55);
            pnlKpiPendingBorder.Controls.Add(pnlKpiPendingContent);
            pnlKpiPendingBorder.Location = new Point(0, 128);
            pnlKpiPendingBorder.Margin = new Padding(0, 0, 15, 13);
            pnlKpiPendingBorder.Name = "pnlKpiPendingBorder";
            pnlKpiPendingBorder.Padding = new Padding(1);
            pnlKpiPendingBorder.Size = new Size(240, 115);
            pnlKpiPendingBorder.TabIndex = 2;
            // 
            // pnlKpiPendingContent
            // 
            pnlKpiPendingContent.BackColor = Color.White;
            pnlKpiPendingContent.Controls.Add(tlpKpiPendingLayout);
            pnlKpiPendingContent.Dock = DockStyle.Fill;
            pnlKpiPendingContent.Location = new Point(1, 1);
            pnlKpiPendingContent.Margin = new Padding(0);
            pnlKpiPendingContent.Name = "pnlKpiPendingContent";
            pnlKpiPendingContent.Size = new Size(238, 113);
            pnlKpiPendingContent.TabIndex = 0;
            // 
            // tlpKpiPendingLayout
            // 
            tlpKpiPendingLayout.ColumnCount = 2;
            tlpKpiPendingLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKpiPendingLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKpiPendingLayout.Controls.Add(lblKpiPendingValue, 1, 0);
            tlpKpiPendingLayout.Controls.Add(picKpiPending, 0, 0);
            tlpKpiPendingLayout.Controls.Add(lblKpiPendingTittle, 0, 1);
            tlpKpiPendingLayout.Dock = DockStyle.Fill;
            tlpKpiPendingLayout.Location = new Point(0, 0);
            tlpKpiPendingLayout.Margin = new Padding(3, 2, 3, 2);
            tlpKpiPendingLayout.Name = "tlpKpiPendingLayout";
            tlpKpiPendingLayout.RowCount = 2;
            tlpKpiPendingLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKpiPendingLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKpiPendingLayout.Size = new Size(238, 113);
            tlpKpiPendingLayout.TabIndex = 0;
            // 
            // lblKpiPendingValue
            // 
            lblKpiPendingValue.AutoSize = true;
            lblKpiPendingValue.Dock = DockStyle.Fill;
            lblKpiPendingValue.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiPendingValue.Location = new Point(119, 0);
            lblKpiPendingValue.Margin = new Padding(0, 0, 15, 0);
            lblKpiPendingValue.Name = "lblKpiPendingValue";
            lblKpiPendingValue.Size = new Size(104, 56);
            lblKpiPendingValue.TabIndex = 1;
            lblKpiPendingValue.Text = "8";
            lblKpiPendingValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picKpiPending
            // 
            picKpiPending.Image = (Image)resources.GetObject("picKpiPending.Image");
            picKpiPending.Location = new Point(15, 13);
            picKpiPending.Margin = new Padding(15, 13, 0, 0);
            picKpiPending.Name = "picKpiPending";
            picKpiPending.Size = new Size(32, 28);
            picKpiPending.SizeMode = PictureBoxSizeMode.StretchImage;
            picKpiPending.TabIndex = 2;
            picKpiPending.TabStop = false;
            // 
            // lblKpiPendingTittle
            // 
            lblKpiPendingTittle.AutoSize = true;
            tlpKpiPendingLayout.SetColumnSpan(lblKpiPendingTittle, 2);
            lblKpiPendingTittle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiPendingTittle.ForeColor = Color.Black;
            lblKpiPendingTittle.Location = new Point(3, 56);
            lblKpiPendingTittle.Name = "lblKpiPendingTittle";
            lblKpiPendingTittle.Size = new Size(188, 21);
            lblKpiPendingTittle.TabIndex = 3;
            lblKpiPendingTittle.Text = "Pendientes Aprobación";
            // 
            // pnlKpiCategoryBorder
            // 
            pnlKpiCategoryBorder.BackColor = Color.FromArgb(31, 41, 55);
            pnlKpiCategoryBorder.Controls.Add(pnlKpiCategoryContent);
            pnlKpiCategoryBorder.Location = new Point(255, 128);
            pnlKpiCategoryBorder.Margin = new Padding(0, 0, 15, 13);
            pnlKpiCategoryBorder.Name = "pnlKpiCategoryBorder";
            pnlKpiCategoryBorder.Padding = new Padding(1);
            pnlKpiCategoryBorder.Size = new Size(240, 115);
            pnlKpiCategoryBorder.TabIndex = 3;
            // 
            // pnlKpiCategoryContent
            // 
            pnlKpiCategoryContent.BackColor = Color.White;
            pnlKpiCategoryContent.Controls.Add(tlpKpiCategoryLayout);
            pnlKpiCategoryContent.Dock = DockStyle.Fill;
            pnlKpiCategoryContent.Location = new Point(1, 1);
            pnlKpiCategoryContent.Margin = new Padding(0);
            pnlKpiCategoryContent.Name = "pnlKpiCategoryContent";
            pnlKpiCategoryContent.Size = new Size(238, 113);
            pnlKpiCategoryContent.TabIndex = 0;
            // 
            // tlpKpiCategoryLayout
            // 
            tlpKpiCategoryLayout.ColumnCount = 2;
            tlpKpiCategoryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKpiCategoryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKpiCategoryLayout.Controls.Add(lblKpiCategoryValue, 1, 0);
            tlpKpiCategoryLayout.Controls.Add(picKpiCategory, 0, 0);
            tlpKpiCategoryLayout.Controls.Add(lblKpiCategoryTittle, 0, 1);
            tlpKpiCategoryLayout.Dock = DockStyle.Fill;
            tlpKpiCategoryLayout.Location = new Point(0, 0);
            tlpKpiCategoryLayout.Margin = new Padding(3, 2, 3, 2);
            tlpKpiCategoryLayout.Name = "tlpKpiCategoryLayout";
            tlpKpiCategoryLayout.RowCount = 2;
            tlpKpiCategoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKpiCategoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKpiCategoryLayout.Size = new Size(238, 113);
            tlpKpiCategoryLayout.TabIndex = 0;
            // 
            // lblKpiCategoryValue
            // 
            lblKpiCategoryValue.AutoSize = true;
            lblKpiCategoryValue.Dock = DockStyle.Fill;
            lblKpiCategoryValue.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiCategoryValue.Location = new Point(119, 0);
            lblKpiCategoryValue.Margin = new Padding(0, 0, 15, 0);
            lblKpiCategoryValue.Name = "lblKpiCategoryValue";
            lblKpiCategoryValue.Size = new Size(104, 56);
            lblKpiCategoryValue.TabIndex = 1;
            lblKpiCategoryValue.Text = "24";
            lblKpiCategoryValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picKpiCategory
            // 
            picKpiCategory.Image = (Image)resources.GetObject("picKpiCategory.Image");
            picKpiCategory.Location = new Point(15, 13);
            picKpiCategory.Margin = new Padding(15, 13, 0, 0);
            picKpiCategory.Name = "picKpiCategory";
            picKpiCategory.Size = new Size(32, 28);
            picKpiCategory.SizeMode = PictureBoxSizeMode.StretchImage;
            picKpiCategory.TabIndex = 2;
            picKpiCategory.TabStop = false;
            // 
            // lblKpiCategoryTittle
            // 
            lblKpiCategoryTittle.AutoSize = true;
            tlpKpiCategoryLayout.SetColumnSpan(lblKpiCategoryTittle, 2);
            lblKpiCategoryTittle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiCategoryTittle.ForeColor = Color.Black;
            lblKpiCategoryTittle.Location = new Point(3, 56);
            lblKpiCategoryTittle.Name = "lblKpiCategoryTittle";
            lblKpiCategoryTittle.Size = new Size(150, 21);
            lblKpiCategoryTittle.TabIndex = 3;
            lblKpiCategoryTittle.Text = "Categorias Activas";
            // 
            // flpQuickActions
            // 
            flpQuickActions.Controls.Add(lblQuickActionsTittle);
            flpQuickActions.Controls.Add(btnNewUser);
            flpQuickActions.Controls.Add(btnCheckPending);
            flpQuickActions.Controls.Add(button1);
            flpQuickActions.Dock = DockStyle.Fill;
            flpQuickActions.FlowDirection = FlowDirection.TopDown;
            flpQuickActions.Location = new Point(2, 338);
            flpQuickActions.Margin = new Padding(2);
            flpQuickActions.Name = "flpQuickActions";
            flpQuickActions.Padding = new Padding(0, 12, 0, 0);
            flpQuickActions.Size = new Size(747, 197);
            flpQuickActions.TabIndex = 2;
            // 
            // lblQuickActionsTittle
            // 
            lblQuickActionsTittle.AutoSize = true;
            lblQuickActionsTittle.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuickActionsTittle.ForeColor = Color.DimGray;
            lblQuickActionsTittle.Location = new Point(0, 24);
            lblQuickActionsTittle.Margin = new Padding(0, 12, 0, 6);
            lblQuickActionsTittle.Name = "lblQuickActionsTittle";
            lblQuickActionsTittle.Size = new Size(146, 21);
            lblQuickActionsTittle.TabIndex = 0;
            lblQuickActionsTittle.Text = "Acciones Rápidas";
            // 
            // btnNewUser
            // 
            btnNewUser.BackColor = Color.FromArgb(165, 182, 252);
            btnNewUser.FlatAppearance.BorderSize = 0;
            btnNewUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 62, 83);
            btnNewUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 62, 83);
            btnNewUser.FlatStyle = FlatStyle.Flat;
            btnNewUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewUser.ForeColor = Color.Black;
            btnNewUser.Image = (Image)resources.GetObject("btnNewUser.Image");
            btnNewUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewUser.Location = new Point(3, 53);
            btnNewUser.Margin = new Padding(3, 2, 3, 4);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(238, 35);
            btnNewUser.TabIndex = 1;
            btnNewUser.Text = "Crear Usuario";
            btnNewUser.UseVisualStyleBackColor = false;
            // 
            // btnCheckPending
            // 
            btnCheckPending.BackColor = Color.FromArgb(192, 255, 192);
            btnCheckPending.FlatAppearance.BorderSize = 0;
            btnCheckPending.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 62, 83);
            btnCheckPending.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 62, 83);
            btnCheckPending.FlatStyle = FlatStyle.Flat;
            btnCheckPending.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCheckPending.ForeColor = Color.Black;
            btnCheckPending.Image = (Image)resources.GetObject("btnCheckPending.Image");
            btnCheckPending.ImageAlign = ContentAlignment.MiddleLeft;
            btnCheckPending.Location = new Point(3, 94);
            btnCheckPending.Margin = new Padding(3, 2, 3, 4);
            btnCheckPending.Name = "btnCheckPending";
            btnCheckPending.Size = new Size(238, 35);
            btnCheckPending.TabIndex = 2;
            btnCheckPending.Text = "Revisar Pendientes";
            btnCheckPending.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(193, 152, 243);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 62, 83);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 62, 83);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 135);
            button1.Margin = new Padding(3, 2, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(238, 35);
            button1.TabIndex = 3;
            button1.Text = "Ver Reportes";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 629);
            Controls.Add(tlpMainLayout);
            Margin = new Padding(2);
            MinimumSize = new Size(899, 490);
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
            pnlMainContent.ResumeLayout(false);
            tlpContentLayout.ResumeLayout(false);
            tlpContentLayout.PerformLayout();
            flpTitleContainer.ResumeLayout(false);
            flpTitleContainer.PerformLayout();
            flpKPIs.ResumeLayout(false);
            pnlKpiUsersBorder.ResumeLayout(false);
            pnlKpiUsuariosContent.ResumeLayout(false);
            tlpKpiUsersLayout.ResumeLayout(false);
            tlpKpiUsersLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picKpiUsers).EndInit();
            pnlKpiRecipesBorder.ResumeLayout(false);
            pnlKpiRecipesContent.ResumeLayout(false);
            tlpKpiRecipesLayout.ResumeLayout(false);
            tlpKpiRecipesLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picKpiRecipes).EndInit();
            pnlKpiPendingBorder.ResumeLayout(false);
            pnlKpiPendingContent.ResumeLayout(false);
            tlpKpiPendingLayout.ResumeLayout(false);
            tlpKpiPendingLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picKpiPending).EndInit();
            pnlKpiCategoryBorder.ResumeLayout(false);
            pnlKpiCategoryContent.ResumeLayout(false);
            tlpKpiCategoryLayout.ResumeLayout(false);
            tlpKpiCategoryLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picKpiCategory).EndInit();
            flpQuickActions.ResumeLayout(false);
            flpQuickActions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal TableLayoutPanel tlpMainLayout;
        internal Panel pnlHeader;
        internal Panel pnlNavigation;
        internal Panel pnlMainContent;
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
        internal TableLayoutPanel tlpContentLayout;
        internal Label lblContentTitle;
        internal Label lblContentSubtitle;
        internal FlowLayoutPanel flpTitleContainer;
        internal FlowLayoutPanel flpKPIs;
        internal Panel pnlKpiUsersBorder;
        internal Panel pnlKpiUsuariosContent;
        internal TableLayoutPanel tlpKpiUsersLayout;
        internal Label lblKpiUsersValue;
        internal PictureBox picKpiUsers;
        internal Label lblKpiUsuariosTittle;
        private TableLayoutPanel tlpNavigation;
        private Label lblSubtittleNav;
        internal Panel pnlKpiRecipesBorder;
        internal Panel pnlKpiRecipesContent;
        internal TableLayoutPanel tlpKpiRecipesLayout;
        internal Label lblKpiRecipesValue;
        internal PictureBox picKpiRecipes;
        internal Label lblKpiRecipesTittle;
        internal Panel pnlKpiPendingBorder;
        internal Panel pnlKpiPendingContent;
        internal TableLayoutPanel tlpKpiPendingLayout;
        internal Label lblKpiPendingValue;
        internal PictureBox picKpiPending;
        internal Label lblKpiPendingTittle;
        internal Panel pnlKpiCategoryBorder;
        internal Panel pnlKpiCategoryContent;
        internal TableLayoutPanel tlpKpiCategoryLayout;
        internal Label lblKpiCategoryValue;
        internal PictureBox picKpiCategory;
        internal Label lblKpiCategoryTittle;
        private FlowLayoutPanel flpQuickActions;
        private Label lblQuickActionsTittle;
        internal Button btnNewUser;
        internal Button btnCheckPending;
        internal Button button1;
    }
}
