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
            this.btn_NewOrder = new System.Windows.Forms.Button();
            this.lbl_Name = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Tafel = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Terug = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // btnActionOpnemen
            // 
            this.btnActionOpnemen.Location = new System.Drawing.Point(106, 119);
            this.btnActionOpnemen.Margin = new System.Windows.Forms.Padding(6);
            this.btnActionOpnemen.Name = "btnActionOpnemen";
            this.btnActionOpnemen.Size = new System.Drawing.Size(534, 229);
            this.btnActionOpnemen.TabIndex = 0;
            this.btnActionOpnemen.Text = "Bestelling opnemen";
            this.btnActionOpnemen.UseVisualStyleBackColor = true;
            this.btnActionOpnemen.Click += new System.EventHandler(this.btnActionOpnemen_Click);
            // 
            // btn_Afronden
            // 
            this.btn_Afronden.Location = new System.Drawing.Point(108, 397);
            this.btn_Afronden.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Afronden.Name = "btn_Afronden";
            this.btn_Afronden.Size = new System.Drawing.Size(532, 229);
            this.btn_Afronden.TabIndex = 1;
            this.btn_Afronden.Text = "Afronden";
            this.btn_Afronden.UseVisualStyleBackColor = true;
            this.btn_Afronden.Click += new System.EventHandler(this.btnActionBekijken_Click);
            // 
            // btn_NewOrder
            // 
            this.btn_NewOrder.Location = new System.Drawing.Point(106, 672);
            this.btn_NewOrder.Name = "btn_NewOrder";
            this.btn_NewOrder.Size = new System.Drawing.Size(534, 126);
            this.btn_NewOrder.TabIndex = 2;
            this.btn_NewOrder.Text = "Nieuwe bestelling maken";
            this.btn_NewOrder.UseVisualStyleBackColor = true;
            this.btn_NewOrder.Click += new System.EventHandler(this.btn_NewOrder_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Depth = 0;
            this.lbl_Name.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Name.Location = new System.Drawing.Point(337, 9);
            this.lbl_Name.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(0, 46);
            this.lbl_Name.TabIndex = 3;
            // 
            // lbl_Tafel
            // 
            this.lbl_Tafel.AutoSize = true;
            this.lbl_Tafel.Depth = 0;
            this.lbl_Tafel.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Tafel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Tafel.Location = new System.Drawing.Point(511, 22);
            this.lbl_Tafel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Tafel.Name = "lbl_Tafel";
            this.lbl_Tafel.Size = new System.Drawing.Size(0, 46);
            this.lbl_Tafel.TabIndex = 4;
            // 
            // btn_Terug
            // 
            this.btn_Terug.AutoSize = true;
            this.btn_Terug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Terug.Depth = 0;
            this.btn_Terug.Icon = null;
            this.btn_Terug.Location = new System.Drawing.Point(295, 29);
            this.btn_Terug.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Terug.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Terug.Name = "btn_Terug";
            this.btn_Terug.Primary = false;
            this.btn_Terug.Size = new System.Drawing.Size(456, 36);
            this.btn_Terug.TabIndex = 5;
            this.btn_Terug.Text = "Terug naar tafel keuze";
            this.btn_Terug.UseVisualStyleBackColor = true;
            this.btn_Terug.Click += new System.EventHandler(this.btn_Terug_Click);
            // 
            // OrderActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 1097);
            this.Controls.Add(this.btn_Terug);
            this.Controls.Add(this.lbl_Tafel);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_NewOrder);
            this.Controls.Add(this.btn_Afronden);
            this.Controls.Add(this.btnActionOpnemen);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "OrderActionForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActionOpnemen;
        private System.Windows.Forms.Button btn_Afronden;
        private System.Windows.Forms.Button btn_NewOrder;
        private MaterialSkin.Controls.MaterialLabel lbl_Name;
        private MaterialSkin.Controls.MaterialLabel lbl_Tafel;
        private MaterialSkin.Controls.MaterialFlatButton btn_Terug;
    }
}