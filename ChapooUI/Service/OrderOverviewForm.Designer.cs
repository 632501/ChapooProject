namespace ChapooUI
{
    partial class OrderOverviewForm
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
            this.listviewOverview = new System.Windows.Forms.ListView();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btn_Terug = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDeleteFullOrder = new System.Windows.Forms.Button();
            this.txtGetOrderNr = new System.Windows.Forms.TextBox();
            this.lblGetOrderNr = new System.Windows.Forms.Label();
            this.mlblTafel = new MaterialSkin.Controls.MaterialLabel();
            this.mlblWerknemer = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // listviewOverview
            // 
            this.listviewOverview.Location = new System.Drawing.Point(12, 80);
            this.listviewOverview.Name = "listviewOverview";
            this.listviewOverview.Size = new System.Drawing.Size(351, 261);
            this.listviewOverview.TabIndex = 0;
            this.listviewOverview.UseCompatibleStateImageBehavior = false;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(224, 357);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(139, 59);
            this.btnDeleteOrder.TabIndex = 1;
            this.btnDeleteOrder.Text = "Delete Item";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btn_Terug
            // 
            this.btn_Terug.AutoSize = true;
            this.btn_Terug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Terug.Depth = 0;
            this.btn_Terug.Icon = null;
            this.btn_Terug.Location = new System.Drawing.Point(297, 25);
            this.btn_Terug.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Terug.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Terug.Name = "btn_Terug";
            this.btn_Terug.Primary = false;
            this.btn_Terug.Size = new System.Drawing.Size(76, 36);
            this.btn_Terug.TabIndex = 7;
            this.btn_Terug.Text = "Terug";
            this.btn_Terug.UseVisualStyleBackColor = true;
            this.btn_Terug.Click += new System.EventHandler(this.btn_Terug_Click);
            // 
            // btnDeleteFullOrder
            // 
            this.btnDeleteFullOrder.Location = new System.Drawing.Point(224, 422);
            this.btnDeleteFullOrder.Name = "btnDeleteFullOrder";
            this.btnDeleteFullOrder.Size = new System.Drawing.Size(139, 58);
            this.btnDeleteFullOrder.TabIndex = 8;
            this.btnDeleteFullOrder.Text = "Delete bestelling";
            this.btnDeleteFullOrder.UseVisualStyleBackColor = true;
            this.btnDeleteFullOrder.Click += new System.EventHandler(this.btnDeleteFullOrder_Click);
            // 
            // txtGetOrderNr
            // 
            this.txtGetOrderNr.Location = new System.Drawing.Point(71, 458);
            this.txtGetOrderNr.Name = "txtGetOrderNr";
            this.txtGetOrderNr.Size = new System.Drawing.Size(119, 22);
            this.txtGetOrderNr.TabIndex = 9;
            // 
            // lblGetOrderNr
            // 
            this.lblGetOrderNr.AutoSize = true;
            this.lblGetOrderNr.ForeColor = System.Drawing.Color.White;
            this.lblGetOrderNr.Location = new System.Drawing.Point(80, 422);
            this.lblGetOrderNr.Name = "lblGetOrderNr";
            this.lblGetOrderNr.Size = new System.Drawing.Size(90, 17);
            this.lblGetOrderNr.TabIndex = 10;
            this.lblGetOrderNr.Text = "Bestelling nr:";
            // 
            // mlblTafel
            // 
            this.mlblTafel.AutoSize = true;
            this.mlblTafel.Depth = 0;
            this.mlblTafel.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblTafel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblTafel.Location = new System.Drawing.Point(12, 37);
            this.mlblTafel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblTafel.Name = "mlblTafel";
            this.mlblTafel.Size = new System.Drawing.Size(53, 24);
            this.mlblTafel.TabIndex = 11;
            this.mlblTafel.Text = "Tafel";
            // 
            // mlblWerknemer
            // 
            this.mlblWerknemer.AutoSize = true;
            this.mlblWerknemer.Depth = 0;
            this.mlblWerknemer.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblWerknemer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblWerknemer.Location = new System.Drawing.Point(104, 37);
            this.mlblWerknemer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblWerknemer.Name = "mlblWerknemer";
            this.mlblWerknemer.Size = new System.Drawing.Size(106, 24);
            this.mlblWerknemer.TabIndex = 12;
            this.mlblWerknemer.Text = "Werknemer";
            // 
            // OrderOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 566);
            this.Controls.Add(this.mlblWerknemer);
            this.Controls.Add(this.mlblTafel);
            this.Controls.Add(this.lblGetOrderNr);
            this.Controls.Add(this.txtGetOrderNr);
            this.Controls.Add(this.btnDeleteFullOrder);
            this.Controls.Add(this.btn_Terug);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.listviewOverview);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OrderOverviewForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewOverview;
        private System.Windows.Forms.Button btnDeleteOrder;
        private MaterialSkin.Controls.MaterialFlatButton btn_Terug;
        private System.Windows.Forms.Button btnDeleteFullOrder;
        private System.Windows.Forms.TextBox txtGetOrderNr;
        private System.Windows.Forms.Label lblGetOrderNr;
        private MaterialSkin.Controls.MaterialLabel mlblTafel;
        private MaterialSkin.Controls.MaterialLabel mlblWerknemer;
    }
}