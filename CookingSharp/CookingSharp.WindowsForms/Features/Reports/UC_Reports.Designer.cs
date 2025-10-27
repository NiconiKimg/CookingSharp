namespace CookingSharp.WindowsForms.Features.Reports
{
    partial class UC_Reports
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

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlContent = new Panel();
            flpReports = new FlowLayoutPanel();
            btnGeneratePopularityReport = new Button();
            btnGenerateContributionReport = new Button();
            btnGenerateEngagementReport = new Button();
            btnGenerateCategoryPerformanceReport = new Button();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            flpReports.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(20, 23);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(742, 91);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(3, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(288, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Generación de Reportes";
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(flpReports);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(20, 114);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(742, 531);
            pnlContent.TabIndex = 1;
            // 
            // flpReports
            // 
            flpReports.Controls.Add(btnGeneratePopularityReport);
            flpReports.Controls.Add(btnGenerateContributionReport);
            flpReports.Controls.Add(btnGenerateEngagementReport);
            flpReports.Controls.Add(btnGenerateCategoryPerformanceReport);
            flpReports.Dock = DockStyle.Fill;
            flpReports.Location = new Point(0, 0);
            flpReports.Name = "flpReports";
            flpReports.Padding = new Padding(3);
            flpReports.Size = new Size(742, 531);
            flpReports.TabIndex = 0;
            // 
            // btnGeneratePopularityReport
            // 
            btnGeneratePopularityReport.BackColor = Color.FromArgb(248, 249, 250);
            btnGeneratePopularityReport.Cursor = Cursors.Hand;
            btnGeneratePopularityReport.FlatAppearance.BorderColor = Color.FromArgb(222, 226, 230);
            btnGeneratePopularityReport.FlatAppearance.BorderSize = 2;
            btnGeneratePopularityReport.FlatStyle = FlatStyle.Flat;
            btnGeneratePopularityReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGeneratePopularityReport.ForeColor = Color.FromArgb(64, 64, 64);
            btnGeneratePopularityReport.Image = Properties.Resources.reporte;
            btnGeneratePopularityReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnGeneratePopularityReport.Location = new Point(6, 5);
            btnGeneratePopularityReport.Margin = new Padding(3, 2, 10, 5);
            btnGeneratePopularityReport.Name = "btnGeneratePopularityReport";
            btnGeneratePopularityReport.Padding = new Padding(4, 5, 4, 5);
            btnGeneratePopularityReport.Size = new Size(238, 59);
            btnGeneratePopularityReport.TabIndex = 2;
            btnGeneratePopularityReport.Text = "     Ranking de Recetas";
            btnGeneratePopularityReport.UseVisualStyleBackColor = false;
            btnGeneratePopularityReport.Click += btnGeneratePopularityReport_Click;
            // 
            // btnGenerateContributionReport
            // 
            btnGenerateContributionReport.BackColor = Color.FromArgb(248, 249, 250);
            btnGenerateContributionReport.Cursor = Cursors.Hand;
            btnGenerateContributionReport.FlatAppearance.BorderColor = Color.FromArgb(222, 226, 230);
            btnGenerateContributionReport.FlatAppearance.BorderSize = 2;
            btnGenerateContributionReport.FlatStyle = FlatStyle.Flat;
            btnGenerateContributionReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGenerateContributionReport.ForeColor = Color.FromArgb(64, 64, 64);
            btnGenerateContributionReport.Image = Properties.Resources.reporte;
            btnGenerateContributionReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerateContributionReport.Location = new Point(257, 5);
            btnGenerateContributionReport.Margin = new Padding(3, 2, 3, 5);
            btnGenerateContributionReport.Name = "btnGenerateContributionReport";
            btnGenerateContributionReport.Padding = new Padding(4, 5, 4, 5);
            btnGenerateContributionReport.Size = new Size(260, 59);
            btnGenerateContributionReport.TabIndex = 3;
            btnGenerateContributionReport.Text = "     Contribución por Chef";
            btnGenerateContributionReport.UseVisualStyleBackColor = false;
            btnGenerateContributionReport.Click += btnGenerateContributionReport_Click;
            // 
            // btnGenerateEngagementReport
            // 
            btnGenerateEngagementReport.BackColor = Color.FromArgb(248, 249, 250);
            btnGenerateEngagementReport.Cursor = Cursors.Hand;
            btnGenerateEngagementReport.FlatAppearance.BorderColor = Color.FromArgb(222, 226, 230);
            btnGenerateEngagementReport.FlatAppearance.BorderSize = 2;
            btnGenerateEngagementReport.FlatStyle = FlatStyle.Flat;
            btnGenerateEngagementReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGenerateEngagementReport.ForeColor = Color.FromArgb(64, 64, 64);
            btnGenerateEngagementReport.Image = Properties.Resources.reporte;
            btnGenerateEngagementReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerateEngagementReport.Location = new Point(6, 71);
            btnGenerateEngagementReport.Margin = new Padding(3, 2, 3, 5);
            btnGenerateEngagementReport.Name = "btnGenerateEngagementReport";
            btnGenerateEngagementReport.Padding = new Padding(4, 5, 4, 5);
            btnGenerateEngagementReport.Size = new Size(260, 59);
            btnGenerateEngagementReport.TabIndex = 4;
            btnGenerateEngagementReport.Text = "     Análisis de Recetas";
            btnGenerateEngagementReport.UseVisualStyleBackColor = false;
            btnGenerateEngagementReport.Click += btnGenerateEngagementReport_Click;
            // 
            // btnGenerateCategoryPerformanceReport
            // 
            btnGenerateCategoryPerformanceReport.BackColor = Color.FromArgb(248, 249, 250);
            btnGenerateCategoryPerformanceReport.Cursor = Cursors.Hand;
            btnGenerateCategoryPerformanceReport.FlatAppearance.BorderColor = Color.FromArgb(222, 226, 230);
            btnGenerateCategoryPerformanceReport.FlatAppearance.BorderSize = 2;
            btnGenerateCategoryPerformanceReport.FlatStyle = FlatStyle.Flat;
            btnGenerateCategoryPerformanceReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGenerateCategoryPerformanceReport.ForeColor = Color.FromArgb(64, 64, 64);
            btnGenerateCategoryPerformanceReport.Image = Properties.Resources.reporte;
            btnGenerateCategoryPerformanceReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerateCategoryPerformanceReport.Location = new Point(272, 71);
            btnGenerateCategoryPerformanceReport.Margin = new Padding(3, 2, 3, 5);
            btnGenerateCategoryPerformanceReport.Name = "btnGenerateCategoryPerformanceReport";
            btnGenerateCategoryPerformanceReport.Padding = new Padding(4, 5, 4, 5);
            btnGenerateCategoryPerformanceReport.Size = new Size(260, 59);
            btnGenerateCategoryPerformanceReport.TabIndex = 5;
            btnGenerateCategoryPerformanceReport.Text = "     Rendimiento Categorías";
            btnGenerateCategoryPerformanceReport.UseVisualStyleBackColor = false;
            btnGenerateCategoryPerformanceReport.Click += btnGenerateCategoryPerformanceReport_Click;
            // 
            // UC_Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Name = "UC_Reports";
            Padding = new Padding(20, 23, 20, 23);
            Size = new Size(782, 668);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            flpReports.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel flpReports;
        private System.Windows.Forms.Button btnGeneratePopularityReport;
        private System.Windows.Forms.Button btnGenerateContributionReport;
        private System.Windows.Forms.Button btnGenerateEngagementReport;
        private System.Windows.Forms.Button btnGenerateCategoryPerformanceReport;
    }
}