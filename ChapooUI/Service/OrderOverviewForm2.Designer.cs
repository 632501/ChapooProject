namespace ChapooUI
{
    partial class OrderOverviewForm2
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
            this.mbtnTerug = new MaterialSkin.Controls.MaterialFlatButton();
            this.mlblNaam = new MaterialSkin.Controls.MaterialLabel();
            this.mbtnUitloggen = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnBetalen = new MaterialSkin.Controls.MaterialFlatButton();
            this.listviewOverview = new System.Windows.Forms.ListView();
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
            this.mlblTafel.TabIndex = 18;
            this.mlblTafel.Text = "Tafel";
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
            this.mbtnTerug.TabIndex = 19;
            this.mbtnTerug.Text = "Terug";
            this.mbtnTerug.UseVisualStyleBackColor = true;
            this.mbtnTerug.Click += new System.EventHandler(this.MbtnTerug_Click);
            // 
            // mlblNaam
            // 
            this.mlblNaam.Depth = 0;
            this.mlblNaam.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblNaam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblNaam.Location = new System.Drawing.Point(12, 36);
            this.mlblNaam.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblNaam.Name = "mlblNaam";
            this.mlblNaam.Size = new System.Drawing.Size(103, 24);
            this.mlblNaam.TabIndex = 20;
            this.mlblNaam.Text = "werknemer";
            this.mlblNaam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.mbtnUitloggen.TabIndex = 21;
            this.mbtnUitloggen.Text = "Logout";
            this.mbtnUitloggen.UseVisualStyleBackColor = true;
            this.mbtnUitloggen.Click += new System.EventHandler(this.MbtnUitloggen_Click);
            // 
            // mbtnBetalen
            // 
            this.mbtnBetalen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnBetalen.Depth = 0;
            this.mbtnBetalen.Icon = null;
            this.mbtnBetalen.Location = new System.Drawing.Point(40, 404);
            this.mbtnBetalen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnBetalen.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnBetalen.Name = "mbtnBetalen";
            this.mbtnBetalen.Primary = false;
            this.mbtnBetalen.Size = new System.Drawing.Size(203, 23);
            this.mbtnBetalen.TabIndex = 22;
            this.mbtnBetalen.Text = "Betalen";
            this.mbtnBetalen.UseVisualStyleBackColor = true;
            this.mbtnBetalen.Click += new System.EventHandler(this.MbtnBetalen_Click);
            // 
            // listviewOverview
            // 
            this.listviewOverview.HideSelection = false;
            this.listviewOverview.Location = new System.Drawing.Point(16, 119);
            this.listviewOverview.Name = "listviewOverview";
            this.listviewOverview.Size = new System.Drawing.Size(271, 197);
            this.listviewOverview.TabIndex = 23;
            this.listviewOverview.UseCompatibleStateImageBehavior = false;
            this.listviewOverview.SelectedIndexChanged += new System.EventHandler(this.ListviewOverview_SelectedIndexChanged);
            // 
            // OrderOverviewForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.listviewOverview);
            this.Controls.Add(this.mbtnBetalen);
            this.Controls.Add(this.mbtnUitloggen);
            this.Controls.Add(this.mlblNaam);
            this.Controls.Add(this.mbtnTerug);
            this.Controls.Add(this.mlblTafel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OrderOverviewForm2";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel mlblTafel;
        private MaterialSkin.Controls.MaterialFlatButton mbtnTerug;
        private MaterialSkin.Controls.MaterialLabel mlblNaam;
        private MaterialSkin.Controls.MaterialFlatButton mbtnUitloggen;
        private MaterialSkin.Controls.MaterialFlatButton mbtnBetalen;
        private System.Windows.Forms.ListView listviewOverview;
    }
}