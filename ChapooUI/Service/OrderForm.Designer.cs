namespace ChapooUI
{
    partial class OrderForm
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
            this.listviewMenu = new System.Windows.Forms.ListView();
            this.mlblSoortBestelling = new MaterialSkin.Controls.MaterialLabel();
            this.mlblBestelling = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // listviewMenu
            // 
            this.listviewMenu.Location = new System.Drawing.Point(12, 185);
            this.listviewMenu.Name = "listviewMenu";
            this.listviewMenu.Size = new System.Drawing.Size(173, 284);
            this.listviewMenu.TabIndex = 0;
            this.listviewMenu.UseCompatibleStateImageBehavior = false;
            this.listviewMenu.SelectedIndexChanged += new System.EventHandler(this.listviewMenu_SelectedIndexChanged);
            // 
            // mlblSoortBestelling
            // 
            this.mlblSoortBestelling.AutoSize = true;
            this.mlblSoortBestelling.Depth = 0;
            this.mlblSoortBestelling.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblSoortBestelling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblSoortBestelling.Location = new System.Drawing.Point(102, 83);
            this.mlblSoortBestelling.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblSoortBestelling.Name = "mlblSoortBestelling";
            this.mlblSoortBestelling.Size = new System.Drawing.Size(144, 24);
            this.mlblSoortBestelling.TabIndex = 1;
            this.mlblSoortBestelling.Text = "Soort Bestelling";
            // 
            // mlblBestelling
            // 
            this.mlblBestelling.AutoSize = true;
            this.mlblBestelling.Depth = 0;
            this.mlblBestelling.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblBestelling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblBestelling.Location = new System.Drawing.Point(18, 140);
            this.mlblBestelling.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblBestelling.Name = "mlblBestelling";
            this.mlblBestelling.Size = new System.Drawing.Size(152, 24);
            this.mlblBestelling.TabIndex = 2;
            this.mlblBestelling.Text = "Wat is er besteld";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 566);
            this.Controls.Add(this.mlblBestelling);
            this.Controls.Add(this.mlblSoortBestelling);
            this.Controls.Add(this.listviewMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewMenu;
        private MaterialSkin.Controls.MaterialLabel mlblSoortBestelling;
        private MaterialSkin.Controls.MaterialLabel mlblBestelling;
    }
}