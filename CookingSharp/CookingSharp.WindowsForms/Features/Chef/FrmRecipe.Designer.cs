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
            checkedListBox1 = new CheckedListBox();
            lblCategories = new Label();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(97, 177);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(104, 25);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Descripción";
            // 
            // lblSteps
            // 
            lblSteps.AutoSize = true;
            lblSteps.Location = new Point(97, 295);
            lblSteps.Margin = new Padding(4, 0, 4, 0);
            lblSteps.Name = "lblSteps";
            lblSteps.Size = new Size(57, 25);
            lblSteps.TabIndex = 1;
            lblSteps.Text = "Pasos";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 20F);
            lblTitle.Location = new Point(437, 63);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(257, 46);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Crear Receta";
            // 
            // txtSteps
            // 
            txtSteps.Location = new Point(97, 325);
            txtSteps.Margin = new Padding(4, 5, 4, 5);
            txtSteps.MaxLength = 5000;
            txtSteps.Name = "txtSteps";
            txtSteps.Size = new Size(980, 31);
            txtSteps.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(97, 207);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.MaxLength = 100;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(980, 31);
            txtDescription.TabIndex = 4;
            // 
            // btnCreateRecipe
            // 
            btnCreateRecipe.Location = new Point(451, 642);
            btnCreateRecipe.Margin = new Padding(4, 5, 4, 5);
            btnCreateRecipe.Name = "btnCreateRecipe";
            btnCreateRecipe.Size = new Size(209, 38);
            btnCreateRecipe.TabIndex = 5;
            btnCreateRecipe.Text = "Crear Receta";
            btnCreateRecipe.UseVisualStyleBackColor = true;
            btnCreateRecipe.Click += btnCreateRecipe_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(97, 409);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(980, 172);
            checkedListBox1.TabIndex = 6;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Location = new Point(97, 381);
            lblCategories.Margin = new Padding(4, 0, 4, 0);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(88, 25);
            lblCategories.TabIndex = 7;
            lblCategories.Text = "Categoría";
            // 
            // FrmRecipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(lblCategories);
            Controls.Add(checkedListBox1);
            Controls.Add(btnCreateRecipe);
            Controls.Add(txtDescription);
            Controls.Add(txtSteps);
            Controls.Add(lblTitle);
            Controls.Add(lblSteps);
            Controls.Add(lblDescription);
            Margin = new Padding(4, 5, 4, 5);
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
        private CheckedListBox checkedListBox1;
        private Label lblCategories;
    }
}