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
            tlpMainLayout = new TableLayoutPanel();
            pnlHeader = new Panel();
            tlpHeaderLayout = new TableLayoutPanel();
            tlpHeaderLeft = new TableLayoutPanel();
            picLogo = new PictureBox();
            lblAppName = new Label();
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
            pnlKpiUsuariosBorder = new Panel();
            pnlKpiUsuariosContent = new Panel();
            tlpKpiCardLayout = new TableLayoutPanel();
            lblKpiUsuariosValue = new Label();
            pictureBox1 = new PictureBox();
            lblKpiUsuariosTitle = new Label();
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
            pnlKpiUsuariosBorder.SuspendLayout();
            pnlKpiUsuariosContent.SuspendLayout();
            tlpKpiCardLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tlpMainLayout
            // 
            tlpMainLayout.BackColor = Color.Transparent;
            tlpMainLayout.ColumnCount = 2;
            tlpMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 357F));
            tlpMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainLayout.Controls.Add(pnlHeader, 0, 0);
            tlpMainLayout.Controls.Add(pnlNavigation, 0, 1);
            tlpMainLayout.Controls.Add(pnlMainContent, 1, 1);
            tlpMainLayout.Dock = DockStyle.Fill;
            tlpMainLayout.Location = new Point(0, 0);
            tlpMainLayout.Name = "tlpMainLayout";
            tlpMainLayout.RowCount = 2;
            tlpMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 103F));
            tlpMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainLayout.Size = new Size(1329, 837);
            tlpMainLayout.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            tlpMainLayout.SetColumnSpan(pnlHeader, 2);
            pnlHeader.Controls.Add(tlpHeaderLayout);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1323, 97);
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
            tlpHeaderLayout.Name = "tlpHeaderLayout";
            tlpHeaderLayout.RowCount = 1;
            tlpHeaderLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeaderLayout.Size = new Size(1323, 97);
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
            tlpHeaderLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tlpHeaderLeft.Controls.Add(picLogo, 0, 0);
            tlpHeaderLeft.Controls.Add(lblAppName, 1, 0);
            tlpHeaderLeft.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tlpHeaderLeft.Location = new Point(4, 22);
            tlpHeaderLeft.Margin = new Padding(4);
            tlpHeaderLeft.Name = "tlpHeaderLeft";
            tlpHeaderLeft.RowCount = 1;
            tlpHeaderLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeaderLeft.Size = new Size(218, 53);
            tlpHeaderLeft.TabIndex = 2;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Left;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(46, 47);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.Anchor = AnchorStyles.Left;
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.Location = new Point(66, 10);
            lblAppName.Margin = new Padding(14, 0, 0, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(123, 32);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Cooking#";
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
            tlpHeaderRight.Location = new Point(1033, 4);
            tlpHeaderRight.Margin = new Padding(4);
            tlpHeaderRight.Name = "tlpHeaderRight";
            tlpHeaderRight.RowCount = 1;
            tlpHeaderRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeaderRight.Size = new Size(286, 89);
            tlpHeaderRight.TabIndex = 0;
            // 
            // picUser
            // 
            picUser.Anchor = AnchorStyles.None;
            picUser.Image = Properties.Resources.defaultProfileIcon;
            picUser.Location = new Point(4, 16);
            picUser.Margin = new Padding(4);
            picUser.Name = "picUser";
            picUser.Size = new Size(57, 56);
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
            tlpUserDetails.Location = new Point(69, 4);
            tlpUserDetails.Margin = new Padding(4);
            tlpUserDetails.Name = "tlpUserDetails";
            tlpUserDetails.RowCount = 2;
            tlpUserDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpUserDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpUserDetails.Size = new Size(162, 81);
            tlpUserDetails.TabIndex = 1;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Dock = DockStyle.Fill;
            lblUserRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserRole.Location = new Point(4, 0);
            lblUserRole.Margin = new Padding(4, 0, 4, 0);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(154, 40);
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
            lblUserEmail.ForeColor = Color.DimGray;
            lblUserEmail.Location = new Point(4, 40);
            lblUserEmail.Margin = new Padding(4, 0, 4, 0);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(154, 41);
            lblUserEmail.TabIndex = 1;
            lblUserEmail.Text = "admin@cookingsharp.com";
            lblUserEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnUserOptions
            // 
            btnUserOptions.Anchor = AnchorStyles.None;
            btnUserOptions.FlatAppearance.BorderSize = 0;
            btnUserOptions.FlatStyle = FlatStyle.Flat;
            btnUserOptions.Image = Properties.Resources.closeSessionIcon;
            btnUserOptions.Location = new Point(239, 22);
            btnUserOptions.Margin = new Padding(4);
            btnUserOptions.Name = "btnUserOptions";
            btnUserOptions.Size = new Size(43, 44);
            btnUserOptions.TabIndex = 2;
            btnUserOptions.UseVisualStyleBackColor = true;
            // 
            // pnlNavigation
            // 
            pnlNavigation.AutoScroll = true;
            pnlNavigation.BackColor = Color.White;
            pnlNavigation.Controls.Add(tlpNavigation);
            pnlNavigation.Dock = DockStyle.Fill;
            pnlNavigation.Location = new Point(3, 106);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(351, 728);
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
            tlpNavigation.Size = new Size(351, 602);
            tlpNavigation.TabIndex = 2;
            // 
            // lblMenuGestionTitle
            // 
            lblMenuGestionTitle.AutoSize = true;
            lblMenuGestionTitle.Dock = DockStyle.Fill;
            lblMenuGestionTitle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuGestionTitle.ForeColor = Color.Gray;
            lblMenuGestionTitle.Location = new Point(4, 0);
            lblMenuGestionTitle.Margin = new Padding(4, 0, 4, 0);
            lblMenuGestionTitle.Name = "lblMenuGestionTitle";
            lblMenuGestionTitle.Padding = new Padding(0, 29, 0, 7);
            lblMenuGestionTitle.Size = new Size(343, 59);
            lblMenuGestionTitle.TabIndex = 1;
            lblMenuGestionTitle.Text = "GESTIÓN";
            lblMenuGestionTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnNavRecetas
            // 
            btnNavRecetas.Dock = DockStyle.Fill;
            btnNavRecetas.FlatAppearance.BorderSize = 0;
            btnNavRecetas.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnNavRecetas.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnNavRecetas.FlatStyle = FlatStyle.Flat;
            btnNavRecetas.Font = new Font("Segoe UI", 10F);
            btnNavRecetas.Image = Properties.Resources.recipesIcon;
            btnNavRecetas.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavRecetas.Location = new Point(4, 63);
            btnNavRecetas.Margin = new Padding(4);
            btnNavRecetas.Name = "btnNavRecetas";
            btnNavRecetas.Size = new Size(343, 59);
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
            btnNavUsuarios.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnNavUsuarios.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnNavUsuarios.FlatStyle = FlatStyle.Flat;
            btnNavUsuarios.Font = new Font("Segoe UI", 10F);
            btnNavUsuarios.Image = Properties.Resources.usersIcon;
            btnNavUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavUsuarios.Location = new Point(4, 130);
            btnNavUsuarios.Margin = new Padding(4);
            btnNavUsuarios.Name = "btnNavUsuarios";
            btnNavUsuarios.Size = new Size(343, 59);
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
            btnNavUnidadesMedida.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnNavUnidadesMedida.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnNavUnidadesMedida.FlatStyle = FlatStyle.Flat;
            btnNavUnidadesMedida.Font = new Font("Segoe UI", 10F);
            btnNavUnidadesMedida.Image = Properties.Resources.measurementUnitIcon;
            btnNavUnidadesMedida.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavUnidadesMedida.Location = new Point(4, 197);
            btnNavUnidadesMedida.Margin = new Padding(4);
            btnNavUnidadesMedida.Name = "btnNavUnidadesMedida";
            btnNavUnidadesMedida.Size = new Size(343, 59);
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
            btnNavDificultades.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnNavDificultades.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnNavDificultades.FlatStyle = FlatStyle.Flat;
            btnNavDificultades.Font = new Font("Segoe UI", 10F);
            btnNavDificultades.Image = Properties.Resources.difficultyIcon;
            btnNavDificultades.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavDificultades.Location = new Point(4, 264);
            btnNavDificultades.Margin = new Padding(4);
            btnNavDificultades.Name = "btnNavDificultades";
            btnNavDificultades.Size = new Size(343, 59);
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
            btnNavCategorias.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnNavCategorias.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnNavCategorias.FlatStyle = FlatStyle.Flat;
            btnNavCategorias.Font = new Font("Segoe UI", 10F);
            btnNavCategorias.Image = Properties.Resources.categoryIcon;
            btnNavCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavCategorias.Location = new Point(4, 331);
            btnNavCategorias.Margin = new Padding(4);
            btnNavCategorias.Name = "btnNavCategorias";
            btnNavCategorias.Size = new Size(343, 59);
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
            lblMenuModeracionTitle.ForeColor = Color.Gray;
            lblMenuModeracionTitle.Location = new Point(4, 394);
            lblMenuModeracionTitle.Margin = new Padding(4, 0, 4, 0);
            lblMenuModeracionTitle.Name = "lblMenuModeracionTitle";
            lblMenuModeracionTitle.Padding = new Padding(14, 44, 0, 7);
            lblMenuModeracionTitle.Size = new Size(343, 74);
            lblMenuModeracionTitle.TabIndex = 6;
            lblMenuModeracionTitle.Text = "MODERACIÓN";
            lblMenuModeracionTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnNavAprobacionRecetas
            // 
            btnNavAprobacionRecetas.Dock = DockStyle.Fill;
            btnNavAprobacionRecetas.FlatAppearance.BorderSize = 0;
            btnNavAprobacionRecetas.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnNavAprobacionRecetas.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnNavAprobacionRecetas.FlatStyle = FlatStyle.Flat;
            btnNavAprobacionRecetas.Font = new Font("Segoe UI", 10F);
            btnNavAprobacionRecetas.Image = Properties.Resources.recipeConfirmationIcon;
            btnNavAprobacionRecetas.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavAprobacionRecetas.Location = new Point(4, 472);
            btnNavAprobacionRecetas.Margin = new Padding(4);
            btnNavAprobacionRecetas.Name = "btnNavAprobacionRecetas";
            btnNavAprobacionRecetas.Size = new Size(343, 59);
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
            btnNavAprobacionIngredientes.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnNavAprobacionIngredientes.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnNavAprobacionIngredientes.FlatStyle = FlatStyle.Flat;
            btnNavAprobacionIngredientes.Font = new Font("Segoe UI", 10F);
            btnNavAprobacionIngredientes.Image = Properties.Resources.ingredientsIcon;
            btnNavAprobacionIngredientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavAprobacionIngredientes.Location = new Point(4, 539);
            btnNavAprobacionIngredientes.Margin = new Padding(4);
            btnNavAprobacionIngredientes.Name = "btnNavAprobacionIngredientes";
            btnNavAprobacionIngredientes.Size = new Size(343, 59);
            btnNavAprobacionIngredientes.TabIndex = 9;
            btnNavAprobacionIngredientes.Text = "    Aprobación de Ingredientes";
            btnNavAprobacionIngredientes.TextAlign = ContentAlignment.MiddleLeft;
            btnNavAprobacionIngredientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavAprobacionIngredientes.UseVisualStyleBackColor = true;
            // 
            // pnlMainContent
            // 
            pnlMainContent.BackColor = Color.FromArgb(240, 242, 245);
            pnlMainContent.Controls.Add(tlpContentLayout);
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(360, 106);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Padding = new Padding(20, 21, 20, 21);
            pnlMainContent.Size = new Size(966, 728);
            pnlMainContent.TabIndex = 2;
            // 
            // tlpContentLayout
            // 
            tlpContentLayout.BackColor = Color.Transparent;
            tlpContentLayout.ColumnCount = 1;
            tlpContentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContentLayout.Controls.Add(flpTitleContainer, 0, 0);
            tlpContentLayout.Controls.Add(flpKPIs, 0, 1);
            tlpContentLayout.Dock = DockStyle.Fill;
            tlpContentLayout.Location = new Point(20, 21);
            tlpContentLayout.Margin = new Padding(4);
            tlpContentLayout.Name = "tlpContentLayout";
            tlpContentLayout.RowCount = 3;
            tlpContentLayout.RowStyles.Add(new RowStyle());
            tlpContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 294F));
            tlpContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tlpContentLayout.Size = new Size(926, 686);
            tlpContentLayout.TabIndex = 0;
            // 
            // flpTitleContainer
            // 
            flpTitleContainer.AutoSize = true;
            flpTitleContainer.Controls.Add(lblContentTitle);
            flpTitleContainer.Controls.Add(lblContentSubtitle);
            flpTitleContainer.Dock = DockStyle.Fill;
            flpTitleContainer.FlowDirection = FlowDirection.TopDown;
            flpTitleContainer.Location = new Point(4, 4);
            flpTitleContainer.Margin = new Padding(4);
            flpTitleContainer.Name = "flpTitleContainer";
            flpTitleContainer.Size = new Size(918, 112);
            flpTitleContainer.TabIndex = 0;
            // 
            // lblContentTitle
            // 
            lblContentTitle.AutoSize = true;
            lblContentTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContentTitle.Location = new Point(0, 0);
            lblContentTitle.Margin = new Padding(0, 0, 0, 7);
            lblContentTitle.Name = "lblContentTitle";
            lblContentTitle.Size = new Size(428, 48);
            lblContentTitle.TabIndex = 0;
            lblContentTitle.Text = "Panel de Administración";
            // 
            // lblContentSubtitle
            // 
            lblContentSubtitle.AutoSize = true;
            lblContentSubtitle.Font = new Font("Segoe UI", 10F);
            lblContentSubtitle.ForeColor = Color.DimGray;
            lblContentSubtitle.Location = new Point(0, 55);
            lblContentSubtitle.Margin = new Padding(0, 0, 0, 29);
            lblContentSubtitle.Name = "lblContentSubtitle";
            lblContentSubtitle.Size = new Size(636, 28);
            lblContentSubtitle.TabIndex = 1;
            lblContentSubtitle.Text = "Gestiona todos los aspectos de Cooking# desde este panel centralizado";
            // 
            // flpKPIs
            // 
            flpKPIs.AutoSize = true;
            flpKPIs.Controls.Add(pnlKpiUsuariosBorder);
            flpKPIs.Dock = DockStyle.Fill;
            flpKPIs.Location = new Point(4, 124);
            flpKPIs.Margin = new Padding(4);
            flpKPIs.Name = "flpKPIs";
            flpKPIs.Size = new Size(918, 286);
            flpKPIs.TabIndex = 1;
            // 
            // pnlKpiUsuariosBorder
            // 
            pnlKpiUsuariosBorder.BackColor = Color.Gainsboro;
            pnlKpiUsuariosBorder.Controls.Add(pnlKpiUsuariosContent);
            pnlKpiUsuariosBorder.Location = new Point(0, 0);
            pnlKpiUsuariosBorder.Margin = new Padding(0, 0, 21, 22);
            pnlKpiUsuariosBorder.Name = "pnlKpiUsuariosBorder";
            pnlKpiUsuariosBorder.Padding = new Padding(1);
            pnlKpiUsuariosBorder.Size = new Size(343, 191);
            pnlKpiUsuariosBorder.TabIndex = 0;
            // 
            // pnlKpiUsuariosContent
            // 
            pnlKpiUsuariosContent.BackColor = Color.White;
            pnlKpiUsuariosContent.Controls.Add(tlpKpiCardLayout);
            pnlKpiUsuariosContent.Dock = DockStyle.Fill;
            pnlKpiUsuariosContent.Location = new Point(1, 1);
            pnlKpiUsuariosContent.Margin = new Padding(0);
            pnlKpiUsuariosContent.Name = "pnlKpiUsuariosContent";
            pnlKpiUsuariosContent.Size = new Size(341, 189);
            pnlKpiUsuariosContent.TabIndex = 0;
            // 
            // tlpKpiCardLayout
            // 
            tlpKpiCardLayout.ColumnCount = 2;
            tlpKpiCardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKpiCardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKpiCardLayout.Controls.Add(lblKpiUsuariosValue, 1, 0);
            tlpKpiCardLayout.Controls.Add(pictureBox1, 0, 0);
            tlpKpiCardLayout.Controls.Add(lblKpiUsuariosTitle, 0, 1);
            tlpKpiCardLayout.Dock = DockStyle.Fill;
            tlpKpiCardLayout.Location = new Point(0, 0);
            tlpKpiCardLayout.Margin = new Padding(4);
            tlpKpiCardLayout.Name = "tlpKpiCardLayout";
            tlpKpiCardLayout.RowCount = 2;
            tlpKpiCardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKpiCardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKpiCardLayout.Size = new Size(341, 189);
            tlpKpiCardLayout.TabIndex = 0;
            // 
            // lblKpiUsuariosValue
            // 
            lblKpiUsuariosValue.AutoSize = true;
            lblKpiUsuariosValue.Dock = DockStyle.Fill;
            lblKpiUsuariosValue.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiUsuariosValue.Location = new Point(170, 0);
            lblKpiUsuariosValue.Margin = new Padding(0, 0, 21, 0);
            lblKpiUsuariosValue.Name = "lblKpiUsuariosValue";
            lblKpiUsuariosValue.Size = new Size(150, 94);
            lblKpiUsuariosValue.TabIndex = 1;
            lblKpiUsuariosValue.Text = "1,234";
            lblKpiUsuariosValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.userKpiIcon;
            pictureBox1.Location = new Point(21, 22);
            pictureBox1.Margin = new Padding(21, 22, 0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblKpiUsuariosTitle
            // 
            lblKpiUsuariosTitle.AutoSize = true;
            tlpKpiCardLayout.SetColumnSpan(lblKpiUsuariosTitle, 2);
            lblKpiUsuariosTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiUsuariosTitle.ForeColor = Color.Black;
            lblKpiUsuariosTitle.Location = new Point(4, 94);
            lblKpiUsuariosTitle.Margin = new Padding(4, 0, 4, 0);
            lblKpiUsuariosTitle.Name = "lblKpiUsuariosTitle";
            lblKpiUsuariosTitle.Size = new Size(254, 32);
            lblKpiUsuariosTitle.TabIndex = 3;
            lblKpiUsuariosTitle.Text = "Usuarios Registrados";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 837);
            Controls.Add(tlpMainLayout);
            MinimumSize = new Size(1278, 791);
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
            pnlKpiUsuariosBorder.ResumeLayout(false);
            pnlKpiUsuariosContent.ResumeLayout(false);
            tlpKpiCardLayout.ResumeLayout(false);
            tlpKpiCardLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        internal RoundedLabel rlblAppSubtitle;
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
        internal Panel pnlKpiUsuariosBorder;
        internal Panel pnlKpiUsuariosContent;
        internal TableLayoutPanel tlpKpiCardLayout;
        internal Label lblKpiUsuariosValue;
        internal PictureBox pictureBox1;
        internal Label lblKpiUsuariosTitle;
        private TableLayoutPanel tlpNavigation;
    }
}
