namespace ChapooUI
{
    partial class OrderDoActionForm
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
            this.finishOrderButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.orderInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // finishOrderButton
            // 
            this.finishOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishOrderButton.Location = new System.Drawing.Point(16, 88);
            this.finishOrderButton.Name = "finishOrderButton";
            this.finishOrderButton.Size = new System.Drawing.Size(376, 128);
            this.finishOrderButton.TabIndex = 0;
            this.finishOrderButton.Text = "GEREED MELDEN";
            this.finishOrderButton.UseVisualStyleBackColor = true;
            this.finishOrderButton.Click += new System.EventHandler(this.finishOrderButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(16, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(376, 128);
            this.button2.TabIndex = 2;
            this.button2.Text = "ANNULEREN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // orderInfo
            // 
            this.orderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderInfo.Location = new System.Drawing.Point(400, 88);
            this.orderInfo.Multiline = true;
            this.orderInfo.Name = "orderInfo";
            this.orderInfo.ReadOnly = true;
            this.orderInfo.Size = new System.Drawing.Size(304, 280);
            this.orderInfo.TabIndex = 3;
            // 
            // OrderDoActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 400);
            this.ControlBox = false;
            this.Controls.Add(this.orderInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.finishOrderButton);
            this.MaximizeBox = false;
            this.Name = "OrderDoActionForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actie";
            this.Load += new System.EventHandler(this.OrdersOverviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finishOrderButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox orderInfo;
    }
}