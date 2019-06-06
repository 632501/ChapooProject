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
            this.btnActionBekijken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActionOpnemen
            // 
            this.btnActionOpnemen.Location = new System.Drawing.Point(52, 192);
            this.btnActionOpnemen.Name = "btnActionOpnemen";
            this.btnActionOpnemen.Size = new System.Drawing.Size(267, 118);
            this.btnActionOpnemen.TabIndex = 0;
            this.btnActionOpnemen.Text = "Bestelling opnemen";
            this.btnActionOpnemen.UseVisualStyleBackColor = true;
            this.btnActionOpnemen.Click += new System.EventHandler(this.btnActionOpnemen_Click);
            // 
            // btnActionBekijken
            // 
            this.btnActionBekijken.Location = new System.Drawing.Point(52, 357);
            this.btnActionBekijken.Name = "btnActionBekijken";
            this.btnActionBekijken.Size = new System.Drawing.Size(266, 118);
            this.btnActionBekijken.TabIndex = 1;
            this.btnActionBekijken.Text = "Bekijken en\r\nAanpassen\r\n";
            this.btnActionBekijken.UseVisualStyleBackColor = true;
            this.btnActionBekijken.Click += new System.EventHandler(this.btnActionBekijken_Click);
            // 
            // OrderActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 566);
            this.Controls.Add(this.btnActionBekijken);
            this.Controls.Add(this.btnActionOpnemen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OrderActionForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActionOpnemen;
        private System.Windows.Forms.Button btnActionBekijken;
    }
}