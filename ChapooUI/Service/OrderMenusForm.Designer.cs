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
            this.lbl_Table = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Terug = new MaterialSkin.Controls.MaterialFlatButton();
            this.mlblWerknemer = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(50, 350);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(198, 50);
            this.btnDrinks.TabIndex = 0;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click_1);
            // 
            // btnDiner
            // 
            this.btnDiner.Location = new System.Drawing.Point(50, 462);
            this.btnDiner.Name = "btnDiner";
            this.btnDiner.Size = new System.Drawing.Size(198, 50);
            this.btnDiner.TabIndex = 1;
            this.btnDiner.Text = "Diner";
            this.btnDiner.UseVisualStyleBackColor = true;
            this.btnDiner.Click += new System.EventHandler(this.btnDiner_Click_1);
            // 
            // btnLunch
            // 
            this.btnLunch.Location = new System.Drawing.Point(50, 406);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(198, 50);
            this.btnLunch.TabIndex = 2;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = true;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(50, 518);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(203, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbl_Table
            // 
            this.lbl_Table.AutoSize = true;
            this.lbl_Table.Depth = 0;
            this.lbl_Table.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Table.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Table.Location = new System.Drawing.Point(12, 37);
            this.lbl_Table.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Table.Name = "lbl_Table";
            this.lbl_Table.Size = new System.Drawing.Size(53, 24);
            this.lbl_Table.TabIndex = 5;
            this.lbl_Table.Text = "Tafel";
            // 
            // btn_Terug
            // 
            this.btn_Terug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Terug.Depth = 0;
            this.btn_Terug.Icon = null;
            this.btn_Terug.Location = new System.Drawing.Point(244, 25);
            this.btn_Terug.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Terug.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Terug.Name = "btn_Terug";
            this.btn_Terug.Primary = false;
            this.btn_Terug.Size = new System.Drawing.Size(76, 36);
            this.btn_Terug.TabIndex = 6;
            this.btn_Terug.Text = "Terug";
            this.btn_Terug.UseVisualStyleBackColor = true;
            this.btn_Terug.Click += new System.EventHandler(this.btn_Terug_Click);
            // 
            // mlblWerknemer
            // 
            this.mlblWerknemer.AutoSize = true;
            this.mlblWerknemer.Depth = 0;
            this.mlblWerknemer.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblWerknemer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblWerknemer.Location = new System.Drawing.Point(91, 37);
            this.mlblWerknemer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblWerknemer.Name = "mlblWerknemer";
            this.mlblWerknemer.Size = new System.Drawing.Size(103, 24);
            this.mlblWerknemer.TabIndex = 9;
            this.mlblWerknemer.Text = "werknemer";
            // 
            // OrderMenusForm
            // 
            this.ClientSize = new System.Drawing.Size(327, 575);
            this.Controls.Add(this.mlblWerknemer);
            this.Controls.Add(this.btn_Terug);
            this.Controls.Add(this.lbl_Table);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.btnDiner);
            this.Controls.Add(this.btnDrinks);
            this.Name = "OrderMenusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private MaterialSkin.Controls.MaterialLabel lbl_Table;
        private MaterialSkin.Controls.MaterialFlatButton btn_Terug;
        private MaterialSkin.Controls.MaterialLabel mlblWerknemer;
    }
}