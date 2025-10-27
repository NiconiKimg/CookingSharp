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
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.tlpContentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.flpTitleContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblContentTitle = new System.Windows.Forms.Label();
            this.lblContentSubtitle = new System.Windows.Forms.Label();
            this.flpKPIs = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlKpiUsersBorder = new System.Windows.Forms.Panel();
            this.pnlKpiUsuariosContent = new System.Windows.Forms.Panel();
            this.tlpKpiUsersLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblKpiUsersValue = new System.Windows.Forms.Label();
            this.picKpiUsers = new System.Windows.Forms.PictureBox();
            this.lblKpiUsuariosTittle = new System.Windows.Forms.Label();
            this.pnlKpiRecipesBorder = new System.Windows.Forms.Panel();
            this.pnlKpiRecipesContent = new System.Windows.Forms.Panel();
            this.tlpKpiRecipesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblKpiRecipesValue = new System.Windows.Forms.Label();
            this.picKpiRecipes = new System.Windows.Forms.PictureBox();
            this.lblKpiRecipesTittle = new System.Windows.Forms.Label();
            this.pnlKpiPendingBorder = new System.Windows.Forms.Panel();
            this.pnlKpiPendingContent = new System.Windows.Forms.Panel();
            this.tlpKpiPendingLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblKpiPendingValue = new System.Windows.Forms.Label();
            this.picKpiPending = new System.Windows.Forms.PictureBox();
            this.lblKpiPendingTittle = new System.Windows.Forms.Label();
            this.pnlKpiCategoryBorder = new System.Windows.Forms.Panel();
            this.pnlKpiCategoryContent = new System.Windows.Forms.Panel();
            this.tlpKpiCategoryLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblKpiCategoryValue = new System.Windows.Forms.Label();
            this.picKpiCategory = new System.Windows.Forms.PictureBox();
            this.lblKpiCategoryTittle = new System.Windows.Forms.Label();
            this.flpQuickActions = new System.Windows.Forms.FlowLayoutPanel();
            this.lblQuickActionsTittle = new System.Windows.Forms.Label();
            this.flpQuickActionsButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnCheckPending = new System.Windows.Forms.Button();
            this.pnlMainContent.SuspendLayout();
            this.tlpContentLayout.SuspendLayout();
            this.flpTitleContainer.SuspendLayout();
            this.flpKPIs.SuspendLayout();
            this.pnlKpiUsersBorder.SuspendLayout();
            this.pnlKpiUsuariosContent.SuspendLayout();
            this.tlpKpiUsersLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKpiUsers)).BeginInit();
            this.pnlKpiRecipesBorder.SuspendLayout();
            this.pnlKpiRecipesContent.SuspendLayout();
            this.tlpKpiRecipesLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKpiRecipes)).BeginInit();
            this.pnlKpiPendingBorder.SuspendLayout();
            this.pnlKpiPendingContent.SuspendLayout();
            this.tlpKpiPendingLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKpiPending)).BeginInit();
            this.pnlKpiCategoryBorder.SuspendLayout();
            this.pnlKpiCategoryContent.SuspendLayout();
            this.tlpKpiCategoryLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKpiCategory)).BeginInit();
            this.flpQuickActions.SuspendLayout();
            this.flpQuickActionsButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.White;
            this.pnlMainContent.Controls.Add(this.tlpContentLayout);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.pnlMainContent.Size = new System.Drawing.Size(782, 589);
            this.pnlMainContent.TabIndex = 3;
            // 
            // tlpContentLayout
            // 
            this.tlpContentLayout.BackColor = System.Drawing.Color.Transparent;
            this.tlpContentLayout.ColumnCount = 1;
            this.tlpContentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContentLayout.Controls.Add(this.flpTitleContainer, 0, 0);
            this.tlpContentLayout.Controls.Add(this.flpKPIs, 0, 1);
            this.tlpContentLayout.Controls.Add(this.flpQuickActions, 0, 2);
            this.tlpContentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContentLayout.Location = new System.Drawing.Point(14, 13);
            this.tlpContentLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpContentLayout.Name = "tlpContentLayout";
            this.tlpContentLayout.RowCount = 3;
            this.tlpContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContentLayout.Size = new System.Drawing.Size(754, 563);
            this.tlpContentLayout.TabIndex = 0;
            // 
            // flpTitleContainer
            // 
            this.flpTitleContainer.AutoSize = true;
            this.flpTitleContainer.Controls.Add(this.lblContentTitle);
            this.flpTitleContainer.Controls.Add(this.lblContentSubtitle);
            this.flpTitleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTitleContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTitleContainer.Location = new System.Drawing.Point(3, 2);
            this.flpTitleContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTitleContainer.Name = "flpTitleContainer";
            this.flpTitleContainer.Size = new System.Drawing.Size(748, 72);
            this.flpTitleContainer.TabIndex = 0;
            // 
            // lblContentTitle
            // 
            this.lblContentTitle.AutoSize = true;
            this.lblContentTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentTitle.Location = new System.Drawing.Point(0, 0);
            this.lblContentTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblContentTitle.Name = "lblContentTitle";
            this.lblContentTitle.Size = new System.Drawing.Size(293, 32);
            this.lblContentTitle.TabIndex = 0;
            this.lblContentTitle.Text = "Panel de Administración";
            // 
            // lblContentSubtitle
            // 
            this.lblContentSubtitle.AutoSize = true;
            this.lblContentSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblContentSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblContentSubtitle.Location = new System.Drawing.Point(0, 36);
            this.lblContentSubtitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 17);
            this.lblContentSubtitle.Name = "lblContentSubtitle";
            this.lblContentSubtitle.Size = new System.Drawing.Size(445, 19);
            this.lblContentSubtitle.TabIndex = 1;
            this.lblContentSubtitle.Text = "Gestiona todos los aspectos de Cooking# desde este panel centralizado";
            // 
            // flpKPIs
            // 
            this.flpKPIs.AutoSize = true;
            this.flpKPIs.Controls.Add(this.pnlKpiUsersBorder);
            this.flpKPIs.Controls.Add(this.pnlKpiRecipesBorder);
            this.flpKPIs.Controls.Add(this.pnlKpiPendingBorder);
            this.flpKPIs.Controls.Add(this.pnlKpiCategoryBorder);
            this.flpKPIs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKPIs.Location = new System.Drawing.Point(3, 78);
            this.flpKPIs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpKPIs.Name = "flpKPIs";
            this.flpKPIs.Size = new System.Drawing.Size(748, 128);
            this.flpKPIs.TabIndex = 1;
            // 
            // pnlKpiUsersBorder
            // 
            this.pnlKpiUsersBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.pnlKpiUsersBorder.Controls.Add(this.pnlKpiUsuariosContent);
            this.pnlKpiUsersBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlKpiUsersBorder.Margin = new System.Windows.Forms.Padding(0, 0, 15, 13);
            this.pnlKpiUsersBorder.Name = "pnlKpiUsersBorder";
            this.pnlKpiUsersBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlKpiUsersBorder.Size = new System.Drawing.Size(240, 115);
            this.pnlKpiUsersBorder.TabIndex = 0;
            // 
            // pnlKpiUsuariosContent
            // 
            this.pnlKpiUsuariosContent.BackColor = System.Drawing.Color.White;
            this.pnlKpiUsuariosContent.Controls.Add(this.tlpKpiUsersLayout);
            this.pnlKpiUsuariosContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiUsuariosContent.Location = new System.Drawing.Point(1, 1);
            this.pnlKpiUsuariosContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlKpiUsuariosContent.Name = "pnlKpiUsuariosContent";
            this.pnlKpiUsuariosContent.Size = new System.Drawing.Size(238, 113);
            this.pnlKpiUsuariosContent.TabIndex = 0;
            // 
            // tlpKpiUsersLayout
            // 
            this.tlpKpiUsersLayout.ColumnCount = 2;
            this.tlpKpiUsersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiUsersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiUsersLayout.Controls.Add(this.lblKpiUsersValue, 1, 0);
            this.tlpKpiUsersLayout.Controls.Add(this.picKpiUsers, 0, 0);
            this.tlpKpiUsersLayout.Controls.Add(this.lblKpiUsuariosTittle, 0, 1);
            this.tlpKpiUsersLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKpiUsersLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpKpiUsersLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpKpiUsersLayout.Name = "tlpKpiUsersLayout";
            this.tlpKpiUsersLayout.RowCount = 2;
            this.tlpKpiUsersLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiUsersLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiUsersLayout.Size = new System.Drawing.Size(238, 113);
            this.tlpKpiUsersLayout.TabIndex = 0;
            // 
            // lblKpiUsersValue
            // 
            this.lblKpiUsersValue.AutoSize = true;
            this.lblKpiUsersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKpiUsersValue.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiUsersValue.Location = new System.Drawing.Point(119, 0);
            this.lblKpiUsersValue.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.lblKpiUsersValue.Name = "lblKpiUsersValue";
            this.lblKpiUsersValue.Size = new System.Drawing.Size(104, 56);
            this.lblKpiUsersValue.TabIndex = 1;
            this.lblKpiUsersValue.Text = "1,234";
            this.lblKpiUsersValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picKpiUsers
            // 
            this.picKpiUsers.Image = global::CookingSharp.WindowsForms.Properties.Resources.userKpiIcon;
            this.picKpiUsers.Location = new System.Drawing.Point(15, 13);
            this.picKpiUsers.Margin = new System.Windows.Forms.Padding(15, 13, 0, 0);
            this.picKpiUsers.Name = "picKpiUsers";
            this.picKpiUsers.Size = new System.Drawing.Size(32, 28);
            this.picKpiUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKpiUsers.TabIndex = 2;
            this.picKpiUsers.TabStop = false;
            // 
            // lblKpiUsuariosTittle
            // 
            this.lblKpiUsuariosTittle.AutoSize = true;
            this.tlpKpiUsersLayout.SetColumnSpan(this.lblKpiUsuariosTittle, 2);
            this.lblKpiUsuariosTittle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiUsuariosTittle.ForeColor = System.Drawing.Color.Black;
            this.lblKpiUsuariosTittle.Location = new System.Drawing.Point(3, 56);
            this.lblKpiUsuariosTittle.Name = "lblKpiUsuariosTittle";
            this.lblKpiUsuariosTittle.Size = new System.Drawing.Size(169, 21);
            this.lblKpiUsuariosTittle.TabIndex = 3;
            this.lblKpiUsuariosTittle.Text = "Usuarios Registrados";
            // 
            // pnlKpiRecipesBorder
            // 
            this.pnlKpiRecipesBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.pnlKpiRecipesBorder.Controls.Add(this.pnlKpiRecipesContent);
            this.pnlKpiRecipesBorder.Location = new System.Drawing.Point(255, 0);
            this.pnlKpiRecipesBorder.Margin = new System.Windows.Forms.Padding(0, 0, 15, 13);
            this.pnlKpiRecipesBorder.Name = "pnlKpiRecipesBorder";
            this.pnlKpiRecipesBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlKpiRecipesBorder.Size = new System.Drawing.Size(240, 115);
            this.pnlKpiRecipesBorder.TabIndex = 1;
            // 
            // pnlKpiRecipesContent
            // 
            this.pnlKpiRecipesContent.BackColor = System.Drawing.Color.White;
            this.pnlKpiRecipesContent.Controls.Add(this.tlpKpiRecipesLayout);
            this.pnlKpiRecipesContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiRecipesContent.Location = new System.Drawing.Point(1, 1);
            this.pnlKpiRecipesContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlKpiRecipesContent.Name = "pnlKpiRecipesContent";
            this.pnlKpiRecipesContent.Size = new System.Drawing.Size(238, 113);
            this.pnlKpiRecipesContent.TabIndex = 0;
            // 
            // tlpKpiRecipesLayout
            // 
            this.tlpKpiRecipesLayout.ColumnCount = 2;
            this.tlpKpiRecipesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiRecipesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiRecipesLayout.Controls.Add(this.lblKpiRecipesValue, 1, 0);
            this.tlpKpiRecipesLayout.Controls.Add(this.picKpiRecipes, 0, 0);
            this.tlpKpiRecipesLayout.Controls.Add(this.lblKpiRecipesTittle, 0, 1);
            this.tlpKpiRecipesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKpiRecipesLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpKpiRecipesLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpKpiRecipesLayout.Name = "tlpKpiRecipesLayout";
            this.tlpKpiRecipesLayout.RowCount = 2;
            this.tlpKpiRecipesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiRecipesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiRecipesLayout.Size = new System.Drawing.Size(238, 113);
            this.tlpKpiRecipesLayout.TabIndex = 0;
            // 
            // lblKpiRecipesValue
            // 
            this.lblKpiRecipesValue.AutoSize = true;
            this.lblKpiRecipesValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKpiRecipesValue.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiRecipesValue.Location = new System.Drawing.Point(119, 0);
            this.lblKpiRecipesValue.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.lblKpiRecipesValue.Name = "lblKpiRecipesValue";
            this.lblKpiRecipesValue.Size = new System.Drawing.Size(104, 56);
            this.lblKpiRecipesValue.TabIndex = 1;
            this.lblKpiRecipesValue.Text = "3,456";
            this.lblKpiRecipesValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picKpiRecipes
            // 
            this.picKpiRecipes.Image = ((System.Drawing.Image)(resources.GetObject("picKpiRecipes.Image")));
            this.picKpiRecipes.Location = new System.Drawing.Point(15, 13);
            this.picKpiRecipes.Margin = new System.Windows.Forms.Padding(15, 13, 0, 0);
            this.picKpiRecipes.Name = "picKpiRecipes";
            this.picKpiRecipes.Size = new System.Drawing.Size(32, 28);
            this.picKpiRecipes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKpiRecipes.TabIndex = 2;
            this.picKpiRecipes.TabStop = false;
            // 
            // lblKpiRecipesTittle
            // 
            this.lblKpiRecipesTittle.AutoSize = true;
            this.tlpKpiRecipesLayout.SetColumnSpan(this.lblKpiRecipesTittle, 2);
            this.lblKpiRecipesTittle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiRecipesTittle.ForeColor = System.Drawing.Color.Black;
            this.lblKpiRecipesTittle.Location = new System.Drawing.Point(3, 56);
            this.lblKpiRecipesTittle.Name = "lblKpiRecipesTittle";
            this.lblKpiRecipesTittle.Size = new System.Drawing.Size(155, 21);
            this.lblKpiRecipesTittle.TabIndex = 3;
            this.lblKpiRecipesTittle.Text = "Recetas Publicadas";
            // 
            // pnlKpiPendingBorder
            // 
            this.pnlKpiPendingBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.pnlKpiPendingBorder.Controls.Add(this.pnlKpiPendingContent);
            this.pnlKpiPendingBorder.Location = new System.Drawing.Point(510, 0);
            this.pnlKpiPendingBorder.Margin = new System.Windows.Forms.Padding(0, 0, 15, 13);
            this.pnlKpiPendingBorder.Name = "pnlKpiPendingBorder";
            this.pnlKpiPendingBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlKpiPendingBorder.Size = new System.Drawing.Size(240, 115);
            this.pnlKpiPendingBorder.TabIndex = 2;
            // 
            // pnlKpiPendingContent
            // 
            this.pnlKpiPendingContent.BackColor = System.Drawing.Color.White;
            this.pnlKpiPendingContent.Controls.Add(this.tlpKpiPendingLayout);
            this.pnlKpiPendingContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiPendingContent.Location = new System.Drawing.Point(1, 1);
            this.pnlKpiPendingContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlKpiPendingContent.Name = "pnlKpiPendingContent";
            this.pnlKpiPendingContent.Size = new System.Drawing.Size(238, 113);
            this.pnlKpiPendingContent.TabIndex = 0;
            // 
            // tlpKpiPendingLayout
            // 
            this.tlpKpiPendingLayout.ColumnCount = 2;
            this.tlpKpiPendingLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiPendingLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiPendingLayout.Controls.Add(this.lblKpiPendingValue, 1, 0);
            this.tlpKpiPendingLayout.Controls.Add(this.picKpiPending, 0, 0);
            this.tlpKpiPendingLayout.Controls.Add(this.lblKpiPendingTittle, 0, 1);
            this.tlpKpiPendingLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKpiPendingLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpKpiPendingLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpKpiPendingLayout.Name = "tlpKpiPendingLayout";
            this.tlpKpiPendingLayout.RowCount = 2;
            this.tlpKpiPendingLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiPendingLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiPendingLayout.Size = new System.Drawing.Size(238, 113);
            this.tlpKpiPendingLayout.TabIndex = 0;
            // 
            // lblKpiPendingValue
            // 
            this.lblKpiPendingValue.AutoSize = true;
            this.lblKpiPendingValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKpiPendingValue.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiPendingValue.Location = new System.Drawing.Point(119, 0);
            this.lblKpiPendingValue.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.lblKpiPendingValue.Name = "lblKpiPendingValue";
            this.lblKpiPendingValue.Size = new System.Drawing.Size(104, 56);
            this.lblKpiPendingValue.TabIndex = 1;
            this.lblKpiPendingValue.Text = "8";
            this.lblKpiPendingValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picKpiPending
            // 
            this.picKpiPending.Image = ((System.Drawing.Image)(resources.GetObject("picKpiPending.Image")));
            this.picKpiPending.Location = new System.Drawing.Point(15, 13);
            this.picKpiPending.Margin = new System.Windows.Forms.Padding(15, 13, 0, 0);
            this.picKpiPending.Name = "picKpiPending";
            this.picKpiPending.Size = new System.Drawing.Size(32, 28);
            this.picKpiPending.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKpiPending.TabIndex = 2;
            this.picKpiPending.TabStop = false;
            // 
            // lblKpiPendingTittle
            // 
            this.lblKpiPendingTittle.AutoSize = true;
            this.tlpKpiPendingLayout.SetColumnSpan(this.lblKpiPendingTittle, 2);
            this.lblKpiPendingTittle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiPendingTittle.ForeColor = System.Drawing.Color.Black;
            this.lblKpiPendingTittle.Location = new System.Drawing.Point(3, 56);
            this.lblKpiPendingTittle.Name = "lblKpiPendingTittle";
            this.lblKpiPendingTittle.Size = new System.Drawing.Size(188, 21);
            this.lblKpiPendingTittle.TabIndex = 3;
            this.lblKpiPendingTittle.Text = "Pendientes Aprobación";
            // 
            // pnlKpiCategoryBorder
            // 
            this.pnlKpiCategoryBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.pnlKpiCategoryBorder.Controls.Add(this.pnlKpiCategoryContent);
            this.pnlKpiCategoryBorder.Location = new System.Drawing.Point(0, 128);
            this.pnlKpiCategoryBorder.Margin = new System.Windows.Forms.Padding(0, 0, 15, 13);
            this.pnlKpiCategoryBorder.Name = "pnlKpiCategoryBorder";
            this.pnlKpiCategoryBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlKpiCategoryBorder.Size = new System.Drawing.Size(240, 115);
            this.pnlKpiCategoryBorder.TabIndex = 3;
            // 
            // pnlKpiCategoryContent
            // 
            this.pnlKpiCategoryContent.BackColor = System.Drawing.Color.White;
            this.pnlKpiCategoryContent.Controls.Add(this.tlpKpiCategoryLayout);
            this.pnlKpiCategoryContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiCategoryContent.Location = new System.Drawing.Point(1, 1);
            this.pnlKpiCategoryContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlKpiCategoryContent.Name = "pnlKpiCategoryContent";
            this.pnlKpiCategoryContent.Size = new System.Drawing.Size(238, 113);
            this.pnlKpiCategoryContent.TabIndex = 0;
            // 
            // tlpKpiCategoryLayout
            // 
            this.tlpKpiCategoryLayout.ColumnCount = 2;
            this.tlpKpiCategoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiCategoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiCategoryLayout.Controls.Add(this.lblKpiCategoryValue, 1, 0);
            this.tlpKpiCategoryLayout.Controls.Add(this.picKpiCategory, 0, 0);
            this.tlpKpiCategoryLayout.Controls.Add(this.lblKpiCategoryTittle, 0, 1);
            this.tlpKpiCategoryLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKpiCategoryLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpKpiCategoryLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpKpiCategoryLayout.Name = "tlpKpiCategoryLayout";
            this.tlpKpiCategoryLayout.RowCount = 2;
            this.tlpKpiCategoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiCategoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKpiCategoryLayout.Size = new System.Drawing.Size(238, 113);
            this.tlpKpiCategoryLayout.TabIndex = 0;
            // 
            // lblKpiCategoryValue
            // 
            this.lblKpiCategoryValue.AutoSize = true;
            this.lblKpiCategoryValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKpiCategoryValue.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiCategoryValue.Location = new System.Drawing.Point(119, 0);
            this.lblKpiCategoryValue.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.lblKpiCategoryValue.Name = "lblKpiCategoryValue";
            this.lblKpiCategoryValue.Size = new System.Drawing.Size(104, 56);
            this.lblKpiCategoryValue.TabIndex = 1;
            this.lblKpiCategoryValue.Text = "24";
            this.lblKpiCategoryValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picKpiCategory
            // 
            this.picKpiCategory.Image = ((System.Drawing.Image)(resources.GetObject("picKpiCategory.Image")));
            this.picKpiCategory.Location = new System.Drawing.Point(15, 13);
            this.picKpiCategory.Margin = new System.Windows.Forms.Padding(15, 13, 0, 0);
            this.picKpiCategory.Name = "picKpiCategory";
            this.picKpiCategory.Size = new System.Drawing.Size(32, 28);
            this.picKpiCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKpiCategory.TabIndex = 2;
            this.picKpiCategory.TabStop = false;
            // 
            // lblKpiCategoryTittle
            // 
            this.lblKpiCategoryTittle.AutoSize = true;
            this.tlpKpiCategoryLayout.SetColumnSpan(this.lblKpiCategoryTittle, 2);
            this.lblKpiCategoryTittle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiCategoryTittle.ForeColor = System.Drawing.Color.Black;
            this.lblKpiCategoryTittle.Location = new System.Drawing.Point(3, 56);
            this.lblKpiCategoryTittle.Name = "lblKpiCategoryTittle";
            this.lblKpiCategoryTittle.Size = new System.Drawing.Size(150, 21);
            this.lblKpiCategoryTittle.TabIndex = 3;
            this.lblKpiCategoryTittle.Text = "Categorias Activas";
            // 
            // flpQuickActions
            // 
            this.flpQuickActions.AutoSize = true;
            this.flpQuickActions.Controls.Add(this.lblQuickActionsTittle);
            this.flpQuickActions.Controls.Add(this.flpQuickActionsButtons);
            this.flpQuickActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpQuickActions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpQuickActions.Location = new System.Drawing.Point(2, 210);
            this.flpQuickActions.Margin = new System.Windows.Forms.Padding(2);
            this.flpQuickActions.Name = "flpQuickActions";
            this.flpQuickActions.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.flpQuickActions.Size = new System.Drawing.Size(750, 351);
            this.flpQuickActions.TabIndex = 2;
            // 
            // lblQuickActionsTittle
            // 
            this.lblQuickActionsTittle.AutoSize = true;
            this.lblQuickActionsTittle.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickActionsTittle.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuickActionsTittle.Location = new System.Drawing.Point(0, 24);
            this.lblQuickActionsTittle.Margin = new System.Windows.Forms.Padding(0, 12, 0, 6);
            this.lblQuickActionsTittle.Name = "lblQuickActionsTittle";
            this.lblQuickActionsTittle.Size = new System.Drawing.Size(146, 21);
            this.lblQuickActionsTittle.TabIndex = 1;
            this.lblQuickActionsTittle.Text = "Acciones Rápidas";
            // 
            // flpQuickActionsButtons
            // 
            this.flpQuickActionsButtons.AutoSize = true;
            this.flpQuickActionsButtons.Controls.Add(this.btnNewUser);
            this.flpQuickActionsButtons.Controls.Add(this.btnViewReports);
            this.flpQuickActionsButtons.Controls.Add(this.btnCheckPending);
            this.flpQuickActionsButtons.Location = new System.Drawing.Point(3, 53);
            this.flpQuickActionsButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpQuickActionsButtons.Name = "flpQuickActionsButtons";
            this.flpQuickActionsButtons.Size = new System.Drawing.Size(732, 58);
            this.flpQuickActionsButtons.TabIndex = 5;
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnNewUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnNewUser.FlatAppearance.BorderSize = 2;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnNewUser.Image")));
            this.btnNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewUser.Location = new System.Drawing.Point(3, 2);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 4);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Padding = new System.Windows.Forms.Padding(4);
            this.btnNewUser.Size = new System.Drawing.Size(238, 52);
            this.btnNewUser.TabIndex = 1;
            this.btnNewUser.Text = "     Crear Usuario";
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnViewReports
            // 
            this.btnViewReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnViewReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnViewReports.FlatAppearance.BorderSize = 2;
            this.btnViewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewReports.Image = ((System.Drawing.Image)(resources.GetObject("btnViewReports.Image")));
            this.btnViewReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewReports.Location = new System.Drawing.Point(247, 2);
            this.btnViewReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 4);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Padding = new System.Windows.Forms.Padding(4);
            this.btnViewReports.Size = new System.Drawing.Size(238, 52);
            this.btnViewReports.TabIndex = 3;
            this.btnViewReports.Text = "     Ver Reportes";
            this.btnViewReports.UseVisualStyleBackColor = false;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);
            // 
            // btnCheckPending
            // 
            this.btnCheckPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnCheckPending.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnCheckPending.FlatAppearance.BorderSize = 2;
            this.btnCheckPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckPending.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCheckPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheckPending.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckPending.Image")));
            this.btnCheckPending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckPending.Location = new System.Drawing.Point(491, 2);
            this.btnCheckPending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 4);
            this.btnCheckPending.Name = "btnCheckPending";
            this.btnCheckPending.Padding = new System.Windows.Forms.Padding(4);
            this.btnCheckPending.Size = new System.Drawing.Size(238, 52);
            this.btnCheckPending.TabIndex = 2;
            this.btnCheckPending.Text = "     Revisar Pendientes";
            this.btnCheckPending.UseVisualStyleBackColor = false;
            this.btnCheckPending.Click += new System.EventHandler(this.btnCheckPending_Click);
            // 
            // UC_AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainContent);
            this.Name = "UC_AdminPanel";
            this.Size = new System.Drawing.Size(782, 589);
            this.pnlMainContent.ResumeLayout(false);
            this.tlpContentLayout.ResumeLayout(false);
            this.tlpContentLayout.PerformLayout();
            this.flpTitleContainer.ResumeLayout(false);
            this.flpTitleContainer.PerformLayout();
            this.flpKPIs.ResumeLayout(false);
            this.pnlKpiUsersBorder.ResumeLayout(false);
            this.pnlKpiUsuariosContent.ResumeLayout(false);
            this.tlpKpiUsersLayout.ResumeLayout(false);
            this.tlpKpiUsersLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKpiUsers)).EndInit();
            this.pnlKpiRecipesBorder.ResumeLayout(false);
            this.pnlKpiRecipesContent.ResumeLayout(false);
            this.tlpKpiRecipesLayout.ResumeLayout(false);
            this.tlpKpiRecipesLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKpiRecipes)).EndInit();
            this.pnlKpiPendingBorder.ResumeLayout(false);
            this.pnlKpiPendingContent.ResumeLayout(false);
            this.tlpKpiPendingLayout.ResumeLayout(false);
            this.tlpKpiPendingLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKpiPending)).EndInit();
            this.pnlKpiCategoryBorder.ResumeLayout(false);
            this.pnlKpiCategoryContent.ResumeLayout(false);
            this.tlpKpiCategoryLayout.ResumeLayout(false);
            this.tlpKpiCategoryLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKpiCategory)).EndInit();
            this.flpQuickActions.ResumeLayout(false);
            this.flpQuickActions.PerformLayout();
            this.flpQuickActionsButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlMainContent;
        internal System.Windows.Forms.TableLayoutPanel tlpContentLayout;
        internal System.Windows.Forms.FlowLayoutPanel flpTitleContainer;
        internal System.Windows.Forms.Label lblContentTitle;
        internal System.Windows.Forms.Label lblContentSubtitle;
        internal System.Windows.Forms.FlowLayoutPanel flpKPIs;
        internal System.Windows.Forms.Panel pnlKpiUsersBorder;
        internal System.Windows.Forms.Panel pnlKpiUsuariosContent;
        internal System.Windows.Forms.TableLayoutPanel tlpKpiUsersLayout;
        internal System.Windows.Forms.Label lblKpiUsersValue;
        internal System.Windows.Forms.PictureBox picKpiUsers;
        internal System.Windows.Forms.Label lblKpiUsuariosTittle;
        internal System.Windows.Forms.Panel pnlKpiRecipesBorder;
        internal System.Windows.Forms.Panel pnlKpiRecipesContent;
        internal System.Windows.Forms.TableLayoutPanel tlpKpiRecipesLayout;
        internal System.Windows.Forms.Label lblKpiRecipesValue;
        internal System.Windows.Forms.PictureBox picKpiRecipes;
        internal System.Windows.Forms.Label lblKpiRecipesTittle;
        internal System.Windows.Forms.Panel pnlKpiPendingBorder;
        internal System.Windows.Forms.Panel pnlKpiPendingContent;
        internal System.Windows.Forms.TableLayoutPanel tlpKpiPendingLayout;
        internal System.Windows.Forms.Label lblKpiPendingValue;
        internal System.Windows.Forms.PictureBox picKpiPending;
        internal System.Windows.Forms.Label lblKpiPendingTittle;
        internal System.Windows.Forms.Panel pnlKpiCategoryBorder;
        internal System.Windows.Forms.Panel pnlKpiCategoryContent;
        internal System.Windows.Forms.TableLayoutPanel tlpKpiCategoryLayout;
        internal System.Windows.Forms.Label lblKpiCategoryValue;
        internal System.Windows.Forms.PictureBox picKpiCategory;
        internal System.Windows.Forms.Label lblKpiCategoryTittle;
        private System.Windows.Forms.FlowLayoutPanel flpQuickActions;
        private System.Windows.Forms.Label lblQuickActionsTittle;
        internal System.Windows.Forms.FlowLayoutPanel flpQuickActionsButtons;
        internal System.Windows.Forms.Button btnNewUser;
        internal System.Windows.Forms.Button btnViewReports;
        internal System.Windows.Forms.Button btnCheckPending;
    }
}