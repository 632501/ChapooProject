namespace ChapooUI
{
    partial class PaymentActionForm
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
            this.btnBetaald = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lbl_Naam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.radioBtnCreditcard = new System.Windows.Forms.RadioButton();
            this.radioBtnPinpas = new System.Windows.Forms.RadioButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.radioBtnContant = new System.Windows.Forms.RadioButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblBtw = new MaterialSkin.Controls.MaterialLabel();
            this.lblAmount = new MaterialSkin.Controls.MaterialLabel();
            this.lblBtwAmount = new MaterialSkin.Controls.MaterialLabel();
            this.lblTip = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalAmount = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtboxOpmerking = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBetaald
            // 
            this.btnBetaald.Location = new System.Drawing.Point(12, 462);
            this.btnBetaald.Name = "btnBetaald";
            this.btnBetaald.Size = new System.Drawing.Size(351, 53);
            this.btnBetaald.TabIndex = 35;
            this.btnBetaald.Text = "Betaald";
            this.btnBetaald.UseVisualStyleBackColor = true;
            this.btnBetaald.Click += new System.EventHandler(this.btnBetaald_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 521);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(351, 33);
            this.btnTerug.TabIndex = 34;
            this.btnTerug.Text = "Terug naar overzicht";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
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
            // lbl_Naam
            // 
            this.lbl_Naam.AutoSize = true;
            this.lbl_Naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Naam.Location = new System.Drawing.Point(8, 75);
            this.lbl_Naam.Name = "lbl_Naam";
            this.lbl_Naam.Size = new System.Drawing.Size(64, 24);
            this.lbl_Naam.TabIndex = 38;
            this.lbl_Naam.Text = "Naam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "TafelNr";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 159);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(70, 24);
            this.materialLabel1.TabIndex = 41;
            this.materialLabel1.Text = "Bedrag";
            // 
            // radioBtnCreditcard
            // 
            this.radioBtnCreditcard.AutoSize = true;
            this.radioBtnCreditcard.Location = new System.Drawing.Point(21, 425);
            this.radioBtnCreditcard.Name = "radioBtnCreditcard";
            this.radioBtnCreditcard.Size = new System.Drawing.Size(94, 21);
            this.radioBtnCreditcard.TabIndex = 42;
            this.radioBtnCreditcard.TabStop = true;
            this.radioBtnCreditcard.Text = "Creditcard";
            this.radioBtnCreditcard.UseVisualStyleBackColor = true;
            // 
            // radioBtnPinpas
            // 
            this.radioBtnPinpas.AutoSize = true;
            this.radioBtnPinpas.Location = new System.Drawing.Point(163, 425);
            this.radioBtnPinpas.Name = "radioBtnPinpas";
            this.radioBtnPinpas.Size = new System.Drawing.Size(72, 21);
            this.radioBtnPinpas.TabIndex = 43;
            this.radioBtnPinpas.TabStop = true;
            this.radioBtnPinpas.Text = "Pinpas";
            this.radioBtnPinpas.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 226);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(158, 24);
            this.materialLabel2.TabIndex = 44;
            this.materialLabel2.Text = "Bedrag met BTW:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 193);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(119, 24);
            this.materialLabel3.TabIndex = 45;
            this.materialLabel3.Text = "BTW-bedrag:";
            // 
            // radioBtnContant
            // 
            this.radioBtnContant.AutoSize = true;
            this.radioBtnContant.Location = new System.Drawing.Point(285, 425);
            this.radioBtnContant.Name = "radioBtnContant";
            this.radioBtnContant.Size = new System.Drawing.Size(78, 21);
            this.radioBtnContant.TabIndex = 46;
            this.radioBtnContant.TabStop = true;
            this.radioBtnContant.Text = "Contant";
            this.radioBtnContant.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 259);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(53, 24);
            this.materialLabel4.TabIndex = 47;
            this.materialLabel4.Text = "Fooi:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 305);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(127, 24);
            this.materialLabel5.TabIndex = 48;
            this.materialLabel5.Text = "Totaalbedrag:";
            // 
            // lblBtw
            // 
            this.lblBtw.AutoSize = true;
            this.lblBtw.Depth = 0;
            this.lblBtw.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBtw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBtw.Location = new System.Drawing.Point(263, 193);
            this.lblBtw.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBtw.Name = "lblBtw";
            this.lblBtw.Size = new System.Drawing.Size(0, 24);
            this.lblBtw.TabIndex = 49;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Depth = 0;
            this.lblAmount.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAmount.Location = new System.Drawing.Point(263, 159);
            this.lblAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 24);
            this.lblAmount.TabIndex = 50;
            // 
            // lblBtwAmount
            // 
            this.lblBtwAmount.AutoSize = true;
            this.lblBtwAmount.Depth = 0;
            this.lblBtwAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBtwAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBtwAmount.Location = new System.Drawing.Point(263, 226);
            this.lblBtwAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBtwAmount.Name = "lblBtwAmount";
            this.lblBtwAmount.Size = new System.Drawing.Size(0, 24);
            this.lblBtwAmount.TabIndex = 51;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Depth = 0;
            this.lblTip.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTip.Location = new System.Drawing.Point(263, 259);
            this.lblTip.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(0, 24);
            this.lblTip.TabIndex = 52;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Depth = 0;
            this.lblTotalAmount.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(263, 305);
            this.lblTotalAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 24);
            this.lblTotalAmount.TabIndex = 53;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(17, 362);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(128, 24);
            this.materialLabel6.TabIndex = 54;
            this.materialLabel6.Text = "Opmerkingen:";
            // 
            // txtboxOpmerking
            // 
            this.txtboxOpmerking.Location = new System.Drawing.Point(163, 364);
            this.txtboxOpmerking.Name = "txtboxOpmerking";
            this.txtboxOpmerking.Size = new System.Drawing.Size(200, 22);
            this.txtboxOpmerking.TabIndex = 55;
            // 
            // PaymentActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 566);
            this.Controls.Add(this.txtboxOpmerking);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblBtwAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblBtw);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.radioBtnContant);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.radioBtnPinpas);
            this.Controls.Add(this.radioBtnCreditcard);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Naam);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBetaald);
            this.Controls.Add(this.btnTerug);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PaymentActionForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBetaald;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lbl_Naam;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.RadioButton radioBtnCreditcard;
        private System.Windows.Forms.RadioButton radioBtnPinpas;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.RadioButton radioBtnContant;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lblBtw;
        private MaterialSkin.Controls.MaterialLabel lblAmount;
        private MaterialSkin.Controls.MaterialLabel lblBtwAmount;
        private MaterialSkin.Controls.MaterialLabel lblTip;
        private MaterialSkin.Controls.MaterialLabel lblTotalAmount;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox txtboxOpmerking;
    }
}