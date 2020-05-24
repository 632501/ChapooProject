namespace ChapooUI
{
    partial class OrderActionForm
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
            this.btnActionOpnemen = new System.Windows.Forms.Button();
            this.btn_Afronden = new System.Windows.Forms.Button();
            this.lbl_Name = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Tafel = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Terug = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBestellingOverview = new System.Windows.Forms.Button();
            this.btn_Uitlog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActionOpnemen
            // 
            this.btnActionOpnemen.Location = new System.Drawing.Point(29, 177);
            this.btnActionOpnemen.Name = "btnActionOpnemen";
            this.btnActionOpnemen.Size = new System.Drawing.Size(267, 82);
            this.btnActionOpnemen.TabIndex = 0;
            this.btnActionOpnemen.Text = "Bestelling opnemen";
            this.btnActionOpnemen.UseVisualStyleBackColor = true;
            this.btnActionOpnemen.Click += new System.EventHandler(this.btnActionOpnemen_Click);
            // 
            // btn_Afronden
            // 
            this.btn_Afronden.Location = new System.Drawing.Point(30, 390);
            this.btn_Afronden.Name = "btn_Afronden";
            this.btn_Afronden.Size = new System.Drawing.Size(266, 82);
            this.btn_Afronden.TabIndex = 1;
            this.btn_Afronden.Text = "Afronden";
            this.btn_Afronden.UseVisualStyleBackColor = true;
            this.btn_Afronden.Click += new System.EventHandler(this.btnActionBekijken_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Depth = 0;
            this.lbl_Name.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Name.Location = new System.Drawing.Point(91, 37);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(106, 24);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Werknemer";
            // 
            // lbl_Tafel
            // 
            this.lbl_Tafel.AutoSize = true;
            this.lbl_Tafel.Depth = 0;
            this.lbl_Tafel.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Tafel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Tafel.Location = new System.Drawing.Point(12, 37);
            this.lbl_Tafel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Tafel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Tafel.Name = "lbl_Tafel";
            this.lbl_Tafel.Size = new System.Drawing.Size(53, 24);
            this.lbl_Tafel.TabIndex = 4;
            this.lbl_Tafel.Text = "Tafel";
            // 
            // btn_Terug
            // 
            this.btn_Terug.AutoSize = true;
            this.btn_Terug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Terug.Depth = 0;
            this.btn_Terug.Icon = null;
            this.btn_Terug.Location = new System.Drawing.Point(244, 25);
            this.btn_Terug.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Terug.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Terug.Name = "btn_Terug";
            this.btn_Terug.Primary = false;
            this.btn_Terug.Size = new System.Drawing.Size(76, 36);
            this.btn_Terug.TabIndex = 5;
            this.btn_Terug.Text = "Terug";
            this.btn_Terug.UseVisualStyleBackColor = true;
            this.btn_Terug.Click += new System.EventHandler(this.btn_Terug_Click);
            // 
            // btnBestellingOverview
            // 
            this.btnBestellingOverview.Location = new System.Drawing.Point(29, 289);
            this.btnBestellingOverview.Name = "btnBestellingOverview";
            this.btnBestellingOverview.Size = new System.Drawing.Size(263, 75);
            this.btnBestellingOverview.TabIndex = 6;
            this.btnBestellingOverview.Text = "Bestelling overview";
            this.btnBestellingOverview.UseVisualStyleBackColor = true;
            this.btnBestellingOverview.Click += new System.EventHandler(this.btnBestellingOverview_Click);
            // 
            // btn_Uitlog
            // 
            this.btn_Uitlog.Location = new System.Drawing.Point(225, 91);
            this.btn_Uitlog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Uitlog.Name = "btn_Uitlog";
            this.btn_Uitlog.Size = new System.Drawing.Size(90, 29);
            this.btn_Uitlog.TabIndex = 15;
            this.btn_Uitlog.Text = "Uitloggen";
            this.btn_Uitlog.UseVisualStyleBackColor = true;
            this.btn_Uitlog.Click += new System.EventHandler(this.btn_Uitlog_Click);
            // 
            // OrderActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 575);
            this.Controls.Add(this.btn_Uitlog);
            this.Controls.Add(this.btnBestellingOverview);
            this.Controls.Add(this.btn_Terug);
            this.Controls.Add(this.lbl_Tafel);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Afronden);
            this.Controls.Add(this.btnActionOpnemen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OrderActionForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActionOpnemen;
        private System.Windows.Forms.Button btn_Afronden;
        private MaterialSkin.Controls.MaterialLabel lbl_Name;
        private MaterialSkin.Controls.MaterialLabel lbl_Tafel;
        private MaterialSkin.Controls.MaterialFlatButton btn_Terug;
        private System.Windows.Forms.Button btnBestellingOverview;
        private System.Windows.Forms.Button btn_Uitlog;
    }
}