namespace ChapooUI
{
    partial class PaymentForm
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
            this.listviewBestelling = new System.Windows.Forms.ListView();
            this.btnBetaald = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.lblTotaalbedrag = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listviewBestelling
            // 
            this.listviewBestelling.Location = new System.Drawing.Point(12, 182);
            this.listviewBestelling.Name = "listviewBestelling";
            this.listviewBestelling.Size = new System.Drawing.Size(351, 221);
            this.listviewBestelling.TabIndex = 36;
            this.listviewBestelling.UseCompatibleStateImageBehavior = false;
            // 
            // btnBetaald
            // 
            this.btnBetaald.Location = new System.Drawing.Point(12, 462);
            this.btnBetaald.Name = "btnBetaald";
            this.btnBetaald.Size = new System.Drawing.Size(351, 53);
            this.btnBetaald.TabIndex = 35;
            this.btnBetaald.Text = "Betaald";
            this.btnBetaald.UseVisualStyleBackColor = true;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 521);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(351, 33);
            this.btnTerug.TabIndex = 34;
            this.btnTerug.Text = "Terug naar overzicht";
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // lblTotaalbedrag
            // 
            this.lblTotaalbedrag.AutoSize = true;
            this.lblTotaalbedrag.Location = new System.Drawing.Point(188, 406);
            this.lblTotaalbedrag.Name = "lblTotaalbedrag";
            this.lblTotaalbedrag.Size = new System.Drawing.Size(0, 17);
            this.lblTotaalbedrag.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Totaalbedrag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Bestelling:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(267, 74);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(96, 29);
            this.btnLogOut.TabIndex = 37;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 566);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.listviewBestelling);
            this.Controls.Add(this.btnBetaald);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.lblTotaalbedrag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "PaymentForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewBestelling;
        private System.Windows.Forms.Button btnBetaald;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label lblTotaalbedrag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogOut;
    }
}