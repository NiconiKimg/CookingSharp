namespace CookingSharp.WindowsForms.Features.Reports
{
    partial class UC_Reports
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Reports));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.flpReports = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGeneratePopularityReport = new System.Windows.Forms.Button();
            this.btnGenerateContributionReport = new System.Windows.Forms.Button();
            this.btnGenerateEngagementReport = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.flpReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(742, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Generación de Reportes";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.flpReports);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(20, 100);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(742, 469);
            this.pnlContent.TabIndex = 1;
            // 
            // flpReports
            // 
            this.flpReports.Controls.Add(this.btnGeneratePopularityReport);
            this.flpReports.Controls.Add(this.btnGenerateContributionReport);
            this.flpReports.Controls.Add(this.btnGenerateEngagementReport);
            this.flpReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpReports.Location = new System.Drawing.Point(0, 0);
            this.flpReports.Name = "flpReports";
            this.flpReports.Padding = new System.Windows.Forms.Padding(3);
            this.flpReports.Size = new System.Drawing.Size(742, 469);
            this.flpReports.TabIndex = 0;
            // 
            // btnGeneratePopularityReport
            // 
            this.btnGeneratePopularityReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnGeneratePopularityReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneratePopularityReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnGeneratePopularityReport.FlatAppearance.BorderSize = 2;
            this.btnGeneratePopularityReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratePopularityReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGeneratePopularityReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGeneratePopularityReport.Image = ((System.Drawing.Image)(resources.GetObject("btnViewReports.Image")));
            this.btnGeneratePopularityReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneratePopularityReport.Location = new System.Drawing.Point(6, 5);
            this.btnGeneratePopularityReport.Margin = new System.Windows.Forms.Padding(3, 2, 10, 4);
            this.btnGeneratePopularityReport.Name = "btnGeneratePopularityReport";
            this.btnGeneratePopularityReport.Padding = new System.Windows.Forms.Padding(4);
            this.btnGeneratePopularityReport.Size = new System.Drawing.Size(238, 52);
            this.btnGeneratePopularityReport.TabIndex = 2;
            this.btnGeneratePopularityReport.Text = "     Ranking de Recetas";
            this.btnGeneratePopularityReport.UseVisualStyleBackColor = false;
            this.btnGeneratePopularityReport.Click += new System.EventHandler(this.btnGeneratePopularityReport_Click);
            // 
            // btnGenerateContributionReport
            // 
            this.btnGenerateContributionReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnGenerateContributionReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateContributionReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnGenerateContributionReport.FlatAppearance.BorderSize = 2;
            this.btnGenerateContributionReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateContributionReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerateContributionReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerateContributionReport.Image = ((System.Drawing.Image)(resources.GetObject("btnNewUser.Image")));
            this.btnGenerateContributionReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateContributionReport.Location = new System.Drawing.Point(257, 5);
            this.btnGenerateContributionReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 4);
            this.btnGenerateContributionReport.Name = "btnGenerateContributionReport";
            this.btnGenerateContributionReport.Padding = new System.Windows.Forms.Padding(4);
            this.btnGenerateContributionReport.Size = new System.Drawing.Size(260, 52);
            this.btnGenerateContributionReport.TabIndex = 3;
            this.btnGenerateContributionReport.Text = "     Contribución por Chef";
            this.btnGenerateContributionReport.UseVisualStyleBackColor = false;
            this.btnGenerateContributionReport.Click += new System.EventHandler(this.btnGenerateContributionReport_Click);
            // 
            // btnGenerateEngagementReport
            // 
            this.btnGenerateEngagementReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnGenerateEngagementReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateEngagementReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnGenerateEngagementReport.FlatAppearance.BorderSize = 2;
            this.btnGenerateEngagementReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateEngagementReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerateEngagementReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerateEngagementReport.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckPending.Image")));
            this.btnGenerateEngagementReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateEngagementReport.Location = new System.Drawing.Point(6, 63);
            this.btnGenerateEngagementReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 4);
            this.btnGenerateEngagementReport.Name = "btnGenerateEngagementReport";
            this.btnGenerateEngagementReport.Padding = new System.Windows.Forms.Padding(4);
            this.btnGenerateEngagementReport.Size = new System.Drawing.Size(260, 52);
            this.btnGenerateEngagementReport.TabIndex = 4;
            this.btnGenerateEngagementReport.Text = "     Análisis de Recetas";
            this.btnGenerateEngagementReport.UseVisualStyleBackColor = false;
            this.btnGenerateEngagementReport.Click += new System.EventHandler(this.btnGenerateEngagementReport_Click);
            // 
            // UC_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_Reports";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(782, 589);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.flpReports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel flpReports;
        private System.Windows.Forms.Button btnGeneratePopularityReport;
        private System.Windows.Forms.Button btnGenerateContributionReport;
        private System.Windows.Forms.Button btnGenerateEngagementReport;
    }
}