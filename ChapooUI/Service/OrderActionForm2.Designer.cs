namespace ChapooUI
{
    partial class OrderActionForm2
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
            this.mlblTafel = new MaterialSkin.Controls.MaterialLabel();
            this.mbtnActionOpnemen = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnBestellingOverview = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnTerug = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnUitloggen = new MaterialSkin.Controls.MaterialFlatButton();
            this.mlblWerknemer = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // mlblTafel
            // 
            this.mlblTafel.AutoSize = true;
            this.mlblTafel.Depth = 0;
            this.mlblTafel.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblTafel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblTafel.Location = new System.Drawing.Point(12, 73);
            this.mlblTafel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblTafel.Name = "mlblTafel";
            this.mlblTafel.Size = new System.Drawing.Size(53, 24);
            this.mlblTafel.TabIndex = 6;
            this.mlblTafel.Text = "Tafel";
            this.mlblTafel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mbtnActionOpnemen
            // 
            this.mbtnActionOpnemen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnActionOpnemen.Depth = 0;
            this.mbtnActionOpnemen.Icon = null;
            this.mbtnActionOpnemen.Location = new System.Drawing.Point(58, 163);
            this.mbtnActionOpnemen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnActionOpnemen.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnActionOpnemen.Name = "mbtnActionOpnemen";
            this.mbtnActionOpnemen.Primary = false;
            this.mbtnActionOpnemen.Size = new System.Drawing.Size(170, 83);
            this.mbtnActionOpnemen.TabIndex = 11;
            this.mbtnActionOpnemen.Text = "Bestelling Opnemen";
            this.mbtnActionOpnemen.UseVisualStyleBackColor = true;
            this.mbtnActionOpnemen.Click += new System.EventHandler(this.MbtnActionOpnemen_Click);
            // 
            // mbtnBestellingOverview
            // 
            this.mbtnBestellingOverview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnBestellingOverview.Depth = 0;
            this.mbtnBestellingOverview.Icon = null;
            this.mbtnBestellingOverview.Location = new System.Drawing.Point(58, 303);
            this.mbtnBestellingOverview.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnBestellingOverview.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnBestellingOverview.Name = "mbtnBestellingOverview";
            this.mbtnBestellingOverview.Primary = false;
            this.mbtnBestellingOverview.Size = new System.Drawing.Size(170, 83);
            this.mbtnBestellingOverview.TabIndex = 12;
            this.mbtnBestellingOverview.Text = "Bestelling Overzicht";
            this.mbtnBestellingOverview.UseVisualStyleBackColor = true;
            this.mbtnBestellingOverview.Click += new System.EventHandler(this.MbtnBestellingOverview_Click);
            // 
            // mbtnTerug
            // 
            this.mbtnTerug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnTerug.Depth = 0;
            this.mbtnTerug.Icon = null;
            this.mbtnTerug.Location = new System.Drawing.Point(210, 73);
            this.mbtnTerug.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnTerug.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnTerug.Name = "mbtnTerug";
            this.mbtnTerug.Primary = false;
            this.mbtnTerug.Size = new System.Drawing.Size(77, 24);
            this.mbtnTerug.TabIndex = 13;
            this.mbtnTerug.Text = "Terug";
            this.mbtnTerug.UseVisualStyleBackColor = true;
            this.mbtnTerug.Click += new System.EventHandler(this.MbtnTerug_Click);
            // 
            // mbtnUitloggen
            // 
            this.mbtnUitloggen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnUitloggen.Depth = 0;
            this.mbtnUitloggen.Icon = null;
            this.mbtnUitloggen.Location = new System.Drawing.Point(210, 36);
            this.mbtnUitloggen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnUitloggen.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnUitloggen.Name = "mbtnUitloggen";
            this.mbtnUitloggen.Primary = false;
            this.mbtnUitloggen.Size = new System.Drawing.Size(77, 24);
            this.mbtnUitloggen.TabIndex = 14;
            this.mbtnUitloggen.Text = "Logout";
            this.mbtnUitloggen.UseVisualStyleBackColor = true;
            this.mbtnUitloggen.Click += new System.EventHandler(this.MbtnUitloggen_Click);
            // 
            // mlblWerknemer
            // 
            this.mlblWerknemer.Depth = 0;
            this.mlblWerknemer.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblWerknemer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblWerknemer.Location = new System.Drawing.Point(12, 36);
            this.mlblWerknemer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblWerknemer.Name = "mlblWerknemer";
            this.mlblWerknemer.Size = new System.Drawing.Size(103, 24);
            this.mlblWerknemer.TabIndex = 10;
            this.mlblWerknemer.Text = "werknemer";
            this.mlblWerknemer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderActionForm2
            // 
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.mbtnUitloggen);
            this.Controls.Add(this.mbtnTerug);
            this.Controls.Add(this.mbtnBestellingOverview);
            this.Controls.Add(this.mbtnActionOpnemen);
            this.Controls.Add(this.mlblWerknemer);
            this.Controls.Add(this.mlblTafel);
            this.Name = "OrderActionForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OrderActionForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel mlblTafel;
        private MaterialSkin.Controls.MaterialFlatButton mbtnActionOpnemen;
        private MaterialSkin.Controls.MaterialFlatButton mbtnBestellingOverview;
        private MaterialSkin.Controls.MaterialFlatButton mbtnTerug;
        private MaterialSkin.Controls.MaterialFlatButton mbtnUitloggen;
        private MaterialSkin.Controls.MaterialLabel mlblWerknemer;
    }
}