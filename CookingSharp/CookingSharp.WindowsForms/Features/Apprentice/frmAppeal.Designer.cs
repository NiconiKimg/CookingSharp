namespace CookingSharp.WindowsForms.Features.Apprentice
{
    partial class frmAppeal
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
            btnCreate = new Button();
            lblDesciption = new Label();
            txtDescription = new TextBox();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(129, 407);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 23);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Crear Solitud";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblDesciption
            // 
            lblDesciption.AutoSize = true;
            lblDesciption.Location = new Point(34, 173);
            lblDesciption.Name = "lblDesciption";
            lblDesciption.Size = new Size(69, 15);
            lblDesciption.TabIndex = 1;
            lblDesciption.Text = "Descripcion";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(34, 191);
            txtDescription.MaxLength = 500;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(315, 23);
            txtDescription.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 20F);
            lblTitle.Location = new Point(72, 86);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(243, 31);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Solicitud para Chef";
            // 
            // frmAppeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(lblTitle);
            Controls.Add(txtDescription);
            Controls.Add(lblDesciption);
            Controls.Add(btnCreate);
            Name = "frmAppeal";
            Text = "Crear Solicitud";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Label lblDesciption;
        private TextBox txtDescription;
        private Label lblTitle;
    }
}