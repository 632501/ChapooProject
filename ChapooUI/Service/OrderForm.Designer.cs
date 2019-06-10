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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.mlblMenu = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // listviewMenu
            // 
            this.listviewMenu.Location = new System.Drawing.Point(12, 176);
            this.listviewMenu.Name = "listviewMenu";
            this.listviewMenu.Size = new System.Drawing.Size(190, 284);
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
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(237, 176);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(76, 72);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(237, 307);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(76, 72);
            this.btnRemoveItem.TabIndex = 4;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(77, 482);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(169, 72);
            this.btnAddOrder.TabIndex = 5;
            this.btnAddOrder.Text = "Toevoegen";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // mlblMenu
            // 
            this.mlblMenu.AutoSize = true;
            this.mlblMenu.Depth = 0;
            this.mlblMenu.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblMenu.Location = new System.Drawing.Point(12, 138);
            this.mlblMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblMenu.Name = "mlblMenu";
            this.mlblMenu.Size = new System.Drawing.Size(57, 24);
            this.mlblMenu.TabIndex = 7;
            this.mlblMenu.Text = "Menu";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 566);
            this.Controls.Add(this.mlblMenu);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.mlblSoortBestelling);
            this.Controls.Add(this.listviewMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddOrder;
        private MaterialSkin.Controls.MaterialLabel mlblMenu;
    }
}