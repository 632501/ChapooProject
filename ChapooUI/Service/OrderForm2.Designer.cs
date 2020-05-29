namespace ChapooUI.Service
{
    partial class OrderForm2
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
            this.mlblWerknemer = new MaterialSkin.Controls.MaterialLabel();
            this.mbtnUitloggen = new MaterialSkin.Controls.MaterialFlatButton();
            this.mlblTafel = new MaterialSkin.Controls.MaterialLabel();
            this.mbtnTerug = new MaterialSkin.Controls.MaterialFlatButton();
            this.mlblSoortBestelling = new MaterialSkin.Controls.MaterialLabel();
            this.listviewMenu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.mlblWerknemer.TabIndex = 11;
            this.mlblWerknemer.Text = "werknemer";
            this.mlblWerknemer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.mbtnUitloggen.TabIndex = 15;
            this.mbtnUitloggen.Text = "Logout";
            this.mbtnUitloggen.UseVisualStyleBackColor = true;
            this.mbtnUitloggen.Click += new System.EventHandler(this.MbtnUitloggen_Click);
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
            this.mlblTafel.TabIndex = 16;
            this.mlblTafel.Text = "Tafel";
            this.mlblTafel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.mbtnTerug.TabIndex = 17;
            this.mbtnTerug.Text = "Terug";
            this.mbtnTerug.UseVisualStyleBackColor = true;
            this.mbtnTerug.Click += new System.EventHandler(this.MbtnTerug_Click);
            // 
            // mlblSoortBestelling
            // 
            this.mlblSoortBestelling.Depth = 0;
            this.mlblSoortBestelling.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblSoortBestelling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblSoortBestelling.Location = new System.Drawing.Point(71, 119);
            this.mlblSoortBestelling.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblSoortBestelling.Name = "mlblSoortBestelling";
            this.mlblSoortBestelling.Size = new System.Drawing.Size(144, 24);
            this.mlblSoortBestelling.TabIndex = 19;
            this.mlblSoortBestelling.Text = "Soort Bestelling";
            this.mlblSoortBestelling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listviewMenu
            // 
            this.listviewMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listviewMenu.HideSelection = false;
            this.listviewMenu.Location = new System.Drawing.Point(16, 174);
            this.listviewMenu.Name = "listviewMenu";
            this.listviewMenu.ShowItemToolTips = true;
            this.listviewMenu.Size = new System.Drawing.Size(271, 246);
            this.listviewMenu.TabIndex = 20;
            this.listviewMenu.UseCompatibleStateImageBehavior = false;
            this.listviewMenu.SelectedIndexChanged += new System.EventHandler(this.ListviewMenu_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naam";
            this.columnHeader1.Width = 220;
            // 
            // OrderForm2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.ControlBox = false;
            this.Controls.Add(this.listviewMenu);
            this.Controls.Add(this.mlblSoortBestelling);
            this.Controls.Add(this.mbtnTerug);
            this.Controls.Add(this.mlblTafel);
            this.Controls.Add(this.mbtnUitloggen);
            this.Controls.Add(this.mlblWerknemer);
            this.Name = "OrderForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OrderForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel mlblWerknemer;
        private MaterialSkin.Controls.MaterialFlatButton mbtnUitloggen;
        private MaterialSkin.Controls.MaterialLabel mlblTafel;
        private MaterialSkin.Controls.MaterialFlatButton mbtnTerug;
        private MaterialSkin.Controls.MaterialLabel mlblSoortBestelling;
        private System.Windows.Forms.ListView listviewMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}