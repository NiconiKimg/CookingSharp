namespace CookingSharp.WindowsForms.Features.Dashboard
{
    partial class FrmApprenticeDashboard
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnRecipes = new Button();
            pnlMainContent = new Panel();
            btnAppeals = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            tableLayoutPanel1.Controls.Add(btnRecipes, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlMainContent, 0, 1);
            tableLayoutPanel1.Controls.Add(btnAppeals, 0, 0);
            tableLayoutPanel1.Location = new Point(1, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2449884F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.75501F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 449);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRecipes
            // 
            btnRecipes.Location = new Point(659, 3);
            btnRecipes.Name = "btnRecipes";
            btnRecipes.Size = new Size(138, 23);
            btnRecipes.TabIndex = 6;
            btnRecipes.Text = "Ver recetas";
            btnRecipes.UseVisualStyleBackColor = true;
            btnRecipes.Click += btnRecipes_Click;
            // 
            // pnlMainContent
            // 
            pnlMainContent.BackColor = Color.White;
            pnlMainContent.Location = new Point(2, 48);
            pnlMainContent.Margin = new Padding(2);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Padding = new Padding(14, 13, 14, 13);
            pnlMainContent.Size = new Size(652, 399);
            pnlMainContent.TabIndex = 4;
            // 
            // btnAppeals
            // 
            btnAppeals.Location = new Point(3, 3);
            btnAppeals.Name = "btnAppeals";
            btnAppeals.Size = new Size(186, 23);
            btnAppeals.TabIndex = 5;
            btnAppeals.Text = "Ver solicitudes";
            btnAppeals.UseVisualStyleBackColor = true;
            btnAppeals.Click += btnAppeals_Click;
            // 
            // FrmApprenticeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmApprenticeDashboard";
            Text = "FrmApprenticeDashboard";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnRecipes;
        internal Panel pnlMainContent;
        private Button btnAppeals;
    }
}