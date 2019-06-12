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
            this.btnDeleteOrder.Location = new System.Drawing.Point(23, 365);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(109, 59);
            this.btnDeleteOrder.TabIndex = 1;
            this.btnDeleteOrder.Text = "Delete Order";
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
            // OrderOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 566);
            this.Controls.Add(this.btn_Terug);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.listviewOverview);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "OrderOverviewForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderOverviewForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewOverview;
        private System.Windows.Forms.Button btnDeleteOrder;
        private MaterialSkin.Controls.MaterialFlatButton btn_Terug;
    }
}