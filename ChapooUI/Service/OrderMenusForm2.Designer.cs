namespace ChapooUI
{
    partial class OrderMenusForm2
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
            this.mbtnUitloggen = new MaterialSkin.Controls.MaterialFlatButton();
            this.mlblNaam = new MaterialSkin.Controls.MaterialLabel();
            this.mlblTafel = new MaterialSkin.Controls.MaterialLabel();
            this.mbtnTerug = new MaterialSkin.Controls.MaterialFlatButton();
            this.mlistviewOrderMenus = new MaterialSkin.Controls.MaterialListView();
            this.mbtnDrinken = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnLunch = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnDiner = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnToevoegen = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
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
            // mlblNaam
            // 
            this.mlblNaam.Depth = 0;
            this.mlblNaam.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblNaam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblNaam.Location = new System.Drawing.Point(12, 36);
            this.mlblNaam.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblNaam.Name = "mlblNaam";
            this.mlblNaam.Size = new System.Drawing.Size(103, 24);
            this.mlblNaam.TabIndex = 16;
            this.mlblNaam.Text = "werknemer";
            this.mlblNaam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.mlblTafel.TabIndex = 17;
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
            this.mbtnTerug.TabIndex = 18;
            this.mbtnTerug.Text = "Terug";
            this.mbtnTerug.UseVisualStyleBackColor = true;
            this.mbtnTerug.Click += new System.EventHandler(this.MbtnTerug_Click);
            // 
            // mlistviewOrderMenus
            // 
            this.mlistviewOrderMenus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlistviewOrderMenus.Depth = 0;
            this.mlistviewOrderMenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.mlistviewOrderMenus.FullRowSelect = true;
            this.mlistviewOrderMenus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlistviewOrderMenus.HideSelection = false;
            this.mlistviewOrderMenus.Location = new System.Drawing.Point(13, 101);
            this.mlistviewOrderMenus.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlistviewOrderMenus.MouseState = MaterialSkin.MouseState.OUT;
            this.mlistviewOrderMenus.Name = "mlistviewOrderMenus";
            this.mlistviewOrderMenus.OwnerDraw = true;
            this.mlistviewOrderMenus.Size = new System.Drawing.Size(275, 176);
            this.mlistviewOrderMenus.TabIndex = 19;
            this.mlistviewOrderMenus.UseCompatibleStateImageBehavior = false;
            this.mlistviewOrderMenus.View = System.Windows.Forms.View.Details;
            // 
            // mbtnDrinken
            // 
            this.mbtnDrinken.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnDrinken.Depth = 0;
            this.mbtnDrinken.Icon = null;
            this.mbtnDrinken.Location = new System.Drawing.Point(69, 286);
            this.mbtnDrinken.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnDrinken.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnDrinken.Name = "mbtnDrinken";
            this.mbtnDrinken.Primary = false;
            this.mbtnDrinken.Size = new System.Drawing.Size(141, 38);
            this.mbtnDrinken.TabIndex = 20;
            this.mbtnDrinken.Text = "Drinken";
            this.mbtnDrinken.UseVisualStyleBackColor = true;
            this.mbtnDrinken.Click += new System.EventHandler(this.MbtnDrinken_Click);
            // 
            // mbtnLunch
            // 
            this.mbtnLunch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnLunch.Depth = 0;
            this.mbtnLunch.Icon = null;
            this.mbtnLunch.Location = new System.Drawing.Point(69, 336);
            this.mbtnLunch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnLunch.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnLunch.Name = "mbtnLunch";
            this.mbtnLunch.Primary = false;
            this.mbtnLunch.Size = new System.Drawing.Size(141, 38);
            this.mbtnLunch.TabIndex = 21;
            this.mbtnLunch.Text = "Lunch";
            this.mbtnLunch.UseVisualStyleBackColor = true;
            this.mbtnLunch.Click += new System.EventHandler(this.MbtnLunch_Click);
            // 
            // mbtnDiner
            // 
            this.mbtnDiner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnDiner.Depth = 0;
            this.mbtnDiner.Icon = null;
            this.mbtnDiner.Location = new System.Drawing.Point(69, 386);
            this.mbtnDiner.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnDiner.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnDiner.Name = "mbtnDiner";
            this.mbtnDiner.Primary = false;
            this.mbtnDiner.Size = new System.Drawing.Size(141, 38);
            this.mbtnDiner.TabIndex = 22;
            this.mbtnDiner.Text = "Diner";
            this.mbtnDiner.UseVisualStyleBackColor = true;
            this.mbtnDiner.Click += new System.EventHandler(this.MbtnDiner_Click);
            // 
            // mbtnToevoegen
            // 
            this.mbtnToevoegen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnToevoegen.Depth = 0;
            this.mbtnToevoegen.Icon = null;
            this.mbtnToevoegen.Location = new System.Drawing.Point(16, 449);
            this.mbtnToevoegen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnToevoegen.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnToevoegen.Name = "mbtnToevoegen";
            this.mbtnToevoegen.Primary = false;
            this.mbtnToevoegen.Size = new System.Drawing.Size(255, 36);
            this.mbtnToevoegen.TabIndex = 23;
            this.mbtnToevoegen.Text = "Toevoegen";
            this.mbtnToevoegen.UseVisualStyleBackColor = true;
            this.mbtnToevoegen.Click += new System.EventHandler(this.MbtnToevoegen_Click);
            // 
            // OrderMenusForm2
            // 
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.mbtnToevoegen);
            this.Controls.Add(this.mbtnDiner);
            this.Controls.Add(this.mbtnLunch);
            this.Controls.Add(this.mbtnDrinken);
            this.Controls.Add(this.mlistviewOrderMenus);
            this.Controls.Add(this.mbtnTerug);
            this.Controls.Add(this.mlblTafel);
            this.Controls.Add(this.mlblNaam);
            this.Controls.Add(this.mbtnUitloggen);
            this.Name = "OrderMenusForm2";
            this.Load += new System.EventHandler(this.OrderMenusForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.ListView listviewMenu;
        //private MaterialSkin.Controls.MaterialLabel mlblSoortBestelling;
        //private MaterialSkin.Controls.MaterialLabel mlblBestelling;
        private MaterialSkin.Controls.MaterialFlatButton mbtnUitloggen;
        private MaterialSkin.Controls.MaterialLabel mlblNaam;
        private MaterialSkin.Controls.MaterialLabel mlblTafel;
        private MaterialSkin.Controls.MaterialFlatButton mbtnTerug;
        private MaterialSkin.Controls.MaterialListView mlistviewOrderMenus;
        private MaterialSkin.Controls.MaterialFlatButton mbtnDrinken;
        private MaterialSkin.Controls.MaterialFlatButton mbtnLunch;
        private MaterialSkin.Controls.MaterialFlatButton mbtnDiner;
        private MaterialSkin.Controls.MaterialFlatButton mbtnToevoegen;
    }
}