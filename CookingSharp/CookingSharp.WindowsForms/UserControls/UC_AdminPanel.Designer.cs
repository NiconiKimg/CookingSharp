namespace CookingSharp.WindowsForms.UserControls
{
    partial class UC_AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AdminPanel));
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
            flpQuickActionsButtons = new FlowLayoutPanel();
            btnNewUser = new Button();
            btnViewReports = new Button();
            btnCheckPending = new Button();
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
            flpQuickActionsButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainContent
            // 
            pnlMainContent.BackColor = Color.White;
            pnlMainContent.Controls.Add(tlpContentLayout);
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(0, 0);
            pnlMainContent.Margin = new Padding(2);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Padding = new Padding(14, 13, 14, 13);
            pnlMainContent.Size = new Size(782, 589);
            pnlMainContent.TabIndex = 3;
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
            tlpContentLayout.Size = new Size(754, 563);
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
            flpTitleContainer.Size = new Size(748, 72);
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
            flpKPIs.Size = new Size(748, 256);
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
            tlpKpiCategoryLayout.RowCount = 3;
            tlpKpiCategoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKpiCategoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKpiCategoryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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
            lblKpiCategoryValue.Size = new Size(104, 46);
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
            lblKpiCategoryTittle.Location = new Point(3, 46);
            lblKpiCategoryTittle.Name = "lblKpiCategoryTittle";
            lblKpiCategoryTittle.Size = new Size(150, 21);
            lblKpiCategoryTittle.TabIndex = 3;
            lblKpiCategoryTittle.Text = "Categorias Activas";
            // 
            // flpQuickActions
            // 
            flpQuickActions.Controls.Add(lblQuickActionsTittle);
            flpQuickActions.Controls.Add(flpQuickActionsButtons);
            flpQuickActions.Dock = DockStyle.Fill;
            flpQuickActions.FlowDirection = FlowDirection.TopDown;
            flpQuickActions.Location = new Point(2, 338);
            flpQuickActions.Margin = new Padding(2);
            flpQuickActions.Name = "flpQuickActions";
            flpQuickActions.Padding = new Padding(0, 12, 0, 0);
            flpQuickActions.Size = new Size(750, 223);
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
            lblQuickActionsTittle.TabIndex = 1;
            lblQuickActionsTittle.Text = "Acciones Rápidas";
            // 
            // flpQuickActionsButtons
            // 
            flpQuickActionsButtons.AutoSize = true;
            flpQuickActionsButtons.Controls.Add(btnNewUser);
            flpQuickActionsButtons.Controls.Add(btnViewReports);
            flpQuickActionsButtons.Controls.Add(btnCheckPending);
            flpQuickActionsButtons.Location = new Point(3, 53);
            flpQuickActionsButtons.Margin = new Padding(3, 2, 3, 2);
            flpQuickActionsButtons.Name = "flpQuickActionsButtons";
            flpQuickActionsButtons.Size = new Size(732, 58);
            flpQuickActionsButtons.TabIndex = 5;
            // 
            // btnNewUser
            // 
            btnNewUser.BackColor = Color.FromArgb(165, 182, 252);
            btnNewUser.FlatAppearance.BorderSize = 0;
            btnNewUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(193, 220, 253);
            btnNewUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(193, 220, 253);
            btnNewUser.FlatStyle = FlatStyle.Flat;
            btnNewUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewUser.ForeColor = Color.Black;
            btnNewUser.Image = (Image)resources.GetObject("btnNewUser.Image");
            btnNewUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewUser.Location = new Point(3, 2);
            btnNewUser.Margin = new Padding(3, 2, 3, 4);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Padding = new Padding(4);
            btnNewUser.Size = new Size(238, 52);
            btnNewUser.TabIndex = 1;
            btnNewUser.Text = "Crear Usuario";
            btnNewUser.UseVisualStyleBackColor = false;
            // 
            // btnViewReports
            // 
            btnViewReports.BackColor = Color.FromArgb(193, 152, 243);
            btnViewReports.FlatAppearance.BorderSize = 0;
            btnViewReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(227, 209, 250);
            btnViewReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 209, 250);
            btnViewReports.FlatStyle = FlatStyle.Flat;
            btnViewReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnViewReports.ForeColor = Color.Black;
            btnViewReports.Image = (Image)resources.GetObject("btnViewReports.Image");
            btnViewReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewReports.Location = new Point(247, 2);
            btnViewReports.Margin = new Padding(3, 2, 3, 4);
            btnViewReports.Name = "btnViewReports";
            btnViewReports.Padding = new Padding(4);
            btnViewReports.Size = new Size(238, 52);
            btnViewReports.TabIndex = 3;
            btnViewReports.Text = "Ver Reportes";
            btnViewReports.UseVisualStyleBackColor = false;
            // 
            // btnCheckPending
            // 
            btnCheckPending.BackColor = Color.FromArgb(192, 255, 192);
            btnCheckPending.FlatAppearance.BorderSize = 0;
            btnCheckPending.FlatAppearance.MouseDownBackColor = Color.FromArgb(215, 255, 215);
            btnCheckPending.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 255, 215);
            btnCheckPending.FlatStyle = FlatStyle.Flat;
            btnCheckPending.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCheckPending.ForeColor = Color.Black;
            btnCheckPending.Image = (Image)resources.GetObject("btnCheckPending.Image");
            btnCheckPending.ImageAlign = ContentAlignment.MiddleLeft;
            btnCheckPending.Location = new Point(491, 2);
            btnCheckPending.Margin = new Padding(3, 2, 3, 4);
            btnCheckPending.Name = "btnCheckPending";
            btnCheckPending.Padding = new Padding(4);
            btnCheckPending.Size = new Size(238, 52);
            btnCheckPending.TabIndex = 2;
            btnCheckPending.Text = "Revisar Pendientes";
            btnCheckPending.UseVisualStyleBackColor = false;
            // 
            // UC_AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMainContent);
            Name = "UC_AdminPanel";
            Size = new Size(782, 589);
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
            flpQuickActionsButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        internal Panel pnlMainContent;
        internal TableLayoutPanel tlpContentLayout;
        internal FlowLayoutPanel flpTitleContainer;
        internal Label lblContentTitle;
        internal Label lblContentSubtitle;
        internal FlowLayoutPanel flpKPIs;
        internal Panel pnlKpiUsersBorder;
        internal Panel pnlKpiUsuariosContent;
        internal TableLayoutPanel tlpKpiUsersLayout;
        internal Label lblKpiUsersValue;
        internal PictureBox picKpiUsers;
        internal Label lblKpiUsuariosTittle;
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
        internal FlowLayoutPanel flpQuickActionsButtons;
        internal Button btnNewUser;
        internal Button btnViewReports;
        internal Button btnCheckPending;
    }
}
