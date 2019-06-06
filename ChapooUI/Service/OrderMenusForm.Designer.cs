namespace ChapooUI
{
    partial class OrderMenusForm
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
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnDiner = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mlblHuidigeBestelling = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(55, 243);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(198, 50);
            this.btnDrinks.TabIndex = 0;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click_1);
            // 
            // btnDiner
            // 
            this.btnDiner.Location = new System.Drawing.Point(55, 355);
            this.btnDiner.Name = "btnDiner";
            this.btnDiner.Size = new System.Drawing.Size(198, 50);
            this.btnDiner.TabIndex = 1;
            this.btnDiner.Text = "Diner";
            this.btnDiner.UseVisualStyleBackColor = true;
            this.btnDiner.Click += new System.EventHandler(this.btnDiner_Click_1);
            // 
            // btnLunch
            // 
            this.btnLunch.Location = new System.Drawing.Point(55, 299);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(198, 50);
            this.btnLunch.TabIndex = 2;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = true;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(55, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(203, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // mlblHuidigeBestelling
            // 
            this.mlblHuidigeBestelling.AutoSize = true;
            this.mlblHuidigeBestelling.Depth = 0;
            this.mlblHuidigeBestelling.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblHuidigeBestelling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblHuidigeBestelling.Location = new System.Drawing.Point(64, 134);
            this.mlblHuidigeBestelling.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblHuidigeBestelling.Name = "mlblHuidigeBestelling";
            this.mlblHuidigeBestelling.Size = new System.Drawing.Size(22, 24);
            this.mlblHuidigeBestelling.TabIndex = 4;
            this.mlblHuidigeBestelling.Text = "X";
            // 
            // OrderMenusForm
            // 
            this.ClientSize = new System.Drawing.Size(345, 484);
            this.Controls.Add(this.mlblHuidigeBestelling);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.btnDiner);
            this.Controls.Add(this.btnDrinks);
            this.Name = "OrderMenusForm";
            this.Load += new System.EventHandler(this.OrderMenusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewMenu;
        private MaterialSkin.Controls.MaterialLabel mlblSoortBestelling;
        private MaterialSkin.Controls.MaterialLabel mlblBestelling;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnDiner;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnAdd;
        private MaterialSkin.Controls.MaterialLabel mlblHuidigeBestelling;
    }
}