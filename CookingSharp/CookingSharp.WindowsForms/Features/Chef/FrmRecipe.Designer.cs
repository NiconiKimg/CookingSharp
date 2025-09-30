namespace CookingSharp.WindowsForms.Features.Chef
{
    partial class FrmRecipe
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
            lblDescription = new Label();
            lblSteps = new Label();
            lblTitle = new Label();
            txtSteps = new TextBox();
            txtDescription = new TextBox();
            btnCreateRecipe = new Button();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(68, 106);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(69, 15);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Descripción";
            // 
            // lblSteps
            // 
            lblSteps.AutoSize = true;
            lblSteps.Location = new Point(68, 177);
            lblSteps.Name = "lblSteps";
            lblSteps.Size = new Size(37, 15);
            lblSteps.TabIndex = 1;
            lblSteps.Text = "Pasos";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 20F);
            lblTitle.Location = new Point(306, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(176, 31);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Crear Receta";
            // 
            // txtSteps
            // 
            txtSteps.Location = new Point(68, 195);
            txtSteps.MaxLength = 5000;
            txtSteps.Name = "txtSteps";
            txtSteps.Size = new Size(687, 23);
            txtSteps.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(68, 124);
            txtDescription.MaxLength = 100;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(687, 23);
            txtDescription.TabIndex = 4;
            // 
            // btnCreateRecipe
            // 
            btnCreateRecipe.Location = new Point(316, 385);
            btnCreateRecipe.Name = "btnCreateRecipe";
            btnCreateRecipe.Size = new Size(146, 23);
            btnCreateRecipe.TabIndex = 5;
            btnCreateRecipe.Text = "Crear Receta";
            btnCreateRecipe.UseVisualStyleBackColor = true;
            btnCreateRecipe.Click += btnCreateRecipe_Click;
            // 
            // FrmRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateRecipe);
            Controls.Add(txtDescription);
            Controls.Add(txtSteps);
            Controls.Add(lblTitle);
            Controls.Add(lblSteps);
            Controls.Add(lblDescription);
            Name = "FrmRecipe";
            Text = "Crear Receta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescription;
        private Label lblSteps;
        private Label lblTitle;
        private TextBox txtSteps;
        private TextBox txtDescription;
        private Button btnCreateRecipe;
    }
}