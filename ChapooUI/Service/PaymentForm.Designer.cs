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
            this.BtnBetalen = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.lblTotaalbedrag = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lbl_Naam = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialListViewBestelling = new MaterialSkin.Controls.MaterialListView();
            this.txtboxTotalPayment = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamePayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnBetalen
            // 
            this.BtnBetalen.Location = new System.Drawing.Point(12, 462);
            this.BtnBetalen.Name = "BtnBetalen";
            this.BtnBetalen.Size = new System.Drawing.Size(351, 53);
            this.BtnBetalen.TabIndex = 35;
            this.BtnBetalen.Text = "Betalen";
            this.BtnBetalen.UseVisualStyleBackColor = true;
            this.BtnBetalen.Click += new System.EventHandler(this.btnBetaald_Click);
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
            this.lblTotaalbedrag.Location = new System.Drawing.Point(228, 402);
            this.lblTotaalbedrag.Name = "lblTotaalbedrag";
            this.lblTotaalbedrag.Size = new System.Drawing.Size(0, 17);
            this.lblTotaalbedrag.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Bedrag:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(267, 86);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(96, 29);
            this.btnLogOut.TabIndex = 37;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // lbl_Naam
            // 
            this.lbl_Naam.AutoSize = true;
            this.lbl_Naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Naam.Location = new System.Drawing.Point(8, 87);
            this.lbl_Naam.Name = "lbl_Naam";
            this.lbl_Naam.Size = new System.Drawing.Size(64, 24);
            this.lbl_Naam.TabIndex = 38;
            this.lbl_Naam.Text = "Naam";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(133, 155);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(94, 24);
            this.materialLabel1.TabIndex = 39;
            this.materialLabel1.Text = "Bestelling";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "TafelNr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Betaalde bedrag:";
            // 
            // materialListViewBestelling
            // 
            this.materialListViewBestelling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewBestelling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Amount,
            this.NamePayment,
            this.Price});
            this.materialListViewBestelling.Depth = 0;
            this.materialListViewBestelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListViewBestelling.FullRowSelect = true;
            this.materialListViewBestelling.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListViewBestelling.Location = new System.Drawing.Point(12, 182);
            this.materialListViewBestelling.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewBestelling.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListViewBestelling.Name = "materialListViewBestelling";
            this.materialListViewBestelling.OwnerDraw = true;
            this.materialListViewBestelling.Size = new System.Drawing.Size(351, 193);
            this.materialListViewBestelling.TabIndex = 42;
            this.materialListViewBestelling.UseCompatibleStateImageBehavior = false;
            this.materialListViewBestelling.View = System.Windows.Forms.View.Details;
            // 
            // txtboxTotalPayment
            // 
            this.txtboxTotalPayment.Location = new System.Drawing.Point(225, 424);
            this.txtboxTotalPayment.Name = "txtboxTotalPayment";
            this.txtboxTotalPayment.Size = new System.Drawing.Size(100, 22);
            this.txtboxTotalPayment.TabIndex = 43;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(222, 402);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(0, 17);
            this.lblPayment.TabIndex = 44;
            // 
            // Amount
            // 
            this.Amount.Text = "Aantal";
            this.Amount.Width = 70;
            // 
            // NamePayment
            // 
            this.NamePayment.Text = "Naam";
            this.NamePayment.Width = 100;
            // 
            // Price
            // 
            this.Price.Text = "Prijs";
            this.Price.Width = 70;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 566);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.txtboxTotalPayment);
            this.Controls.Add(this.materialListViewBestelling);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lbl_Naam);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.BtnBetalen);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.lblTotaalbedrag);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button BtnBetalen;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label lblTotaalbedrag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lbl_Naam;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialListView materialListViewBestelling;
        private System.Windows.Forms.TextBox txtboxTotalPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader NamePayment;
        private System.Windows.Forms.ColumnHeader Price;
    }
}