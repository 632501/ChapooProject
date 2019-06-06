namespace ChapooUI
{
    partial class ManagementSupplyForm
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
            this.ListView_ViewSupply = new MaterialSkin.Controls.MaterialListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Voorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_SelectedAmount = new System.Windows.Forms.TextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_SelectedName = new System.Windows.Forms.Label();
            this.btn_MinOne = new System.Windows.Forms.Button();
            this.btn_MinTen = new System.Windows.Forms.Button();
            this.btn_MinHundred = new System.Windows.Forms.Button();
            this.btn_PlusOne = new System.Windows.Forms.Button();
            this.btn_PlusTen = new System.Windows.Forms.Button();
            this.btn_PlusHundred = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListView_ViewSupply
            // 
            this.ListView_ViewSupply.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView_ViewSupply.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ItemName,
            this.Category,
            this.Voorraad});
            this.ListView_ViewSupply.Depth = 0;
            this.ListView_ViewSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ListView_ViewSupply.FullRowSelect = true;
            this.ListView_ViewSupply.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView_ViewSupply.Location = new System.Drawing.Point(12, 129);
            this.ListView_ViewSupply.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListView_ViewSupply.MouseState = MaterialSkin.MouseState.OUT;
            this.ListView_ViewSupply.Name = "ListView_ViewSupply";
            this.ListView_ViewSupply.OwnerDraw = true;
            this.ListView_ViewSupply.Size = new System.Drawing.Size(913, 344);
            this.ListView_ViewSupply.TabIndex = 0;
            this.ListView_ViewSupply.UseCompatibleStateImageBehavior = false;
            this.ListView_ViewSupply.View = System.Windows.Forms.View.Details;
            this.ListView_ViewSupply.SelectedIndexChanged += new System.EventHandler(this.ListView_ViewSupply_SelectedIndexChanged);
            // 
            // ItemName
            // 
            this.ItemName.Text = "Naam";
            this.ItemName.Width = 570;
            // 
            // Voorraad
            // 
            this.Voorraad.Text = "Voorraad";
            this.Voorraad.Width = 100;
            // 
            // btn_Back
            // 
            this.btn_Back.AutoSize = true;
            this.btn_Back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Back.Depth = 0;
            this.btn_Back.Icon = null;
            this.btn_Back.Location = new System.Drawing.Point(861, 27);
            this.btn_Back.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Primary = true;
            this.btn_Back.Size = new System.Drawing.Size(64, 36);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Terug";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // txt_SelectedAmount
            // 
            this.txt_SelectedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SelectedAmount.Location = new System.Drawing.Point(421, 563);
            this.txt_SelectedAmount.Name = "txt_SelectedAmount";
            this.txt_SelectedAmount.Size = new System.Drawing.Size(99, 38);
            this.txt_SelectedAmount.TabIndex = 4;
            // 
            // btn_Change
            // 
            this.btn_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.Location = new System.Drawing.Point(273, 633);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(404, 76);
            this.btn_Change.TabIndex = 5;
            this.btn_Change.Text = "Pas toe";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // Category
            // 
            this.Category.Text = "Categorie";
            this.Category.Width = 200;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // lbl_SelectedName
            // 
            this.lbl_SelectedName.AutoSize = true;
            this.lbl_SelectedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectedName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_SelectedName.Location = new System.Drawing.Point(395, 502);
            this.lbl_SelectedName.Name = "lbl_SelectedName";
            this.lbl_SelectedName.Size = new System.Drawing.Size(0, 31);
            this.lbl_SelectedName.TabIndex = 7;
            // 
            // btn_MinOne
            // 
            this.btn_MinOne.Location = new System.Drawing.Point(317, 563);
            this.btn_MinOne.Name = "btn_MinOne";
            this.btn_MinOne.Size = new System.Drawing.Size(65, 38);
            this.btn_MinOne.TabIndex = 8;
            this.btn_MinOne.Text = "-1";
            this.btn_MinOne.UseVisualStyleBackColor = true;
            this.btn_MinOne.Click += new System.EventHandler(this.btn_MinOne_Click);
            // 
            // btn_MinTen
            // 
            this.btn_MinTen.Location = new System.Drawing.Point(226, 563);
            this.btn_MinTen.Name = "btn_MinTen";
            this.btn_MinTen.Size = new System.Drawing.Size(65, 38);
            this.btn_MinTen.TabIndex = 9;
            this.btn_MinTen.Text = "-10";
            this.btn_MinTen.UseVisualStyleBackColor = true;
            this.btn_MinTen.Click += new System.EventHandler(this.btn_MinTen_Click);
            // 
            // btn_MinHundred
            // 
            this.btn_MinHundred.Location = new System.Drawing.Point(135, 563);
            this.btn_MinHundred.Name = "btn_MinHundred";
            this.btn_MinHundred.Size = new System.Drawing.Size(65, 38);
            this.btn_MinHundred.TabIndex = 10;
            this.btn_MinHundred.Text = "-100";
            this.btn_MinHundred.UseVisualStyleBackColor = true;
            this.btn_MinHundred.Click += new System.EventHandler(this.btn_MinHonderd_Click);
            // 
            // btn_PlusOne
            // 
            this.btn_PlusOne.Location = new System.Drawing.Point(560, 563);
            this.btn_PlusOne.Name = "btn_PlusOne";
            this.btn_PlusOne.Size = new System.Drawing.Size(65, 38);
            this.btn_PlusOne.TabIndex = 11;
            this.btn_PlusOne.Text = "+1";
            this.btn_PlusOne.UseVisualStyleBackColor = true;
            this.btn_PlusOne.Click += new System.EventHandler(this.btn_PlusOne_Click);
            // 
            // btn_PlusTen
            // 
            this.btn_PlusTen.Location = new System.Drawing.Point(654, 563);
            this.btn_PlusTen.Name = "btn_PlusTen";
            this.btn_PlusTen.Size = new System.Drawing.Size(65, 38);
            this.btn_PlusTen.TabIndex = 12;
            this.btn_PlusTen.Text = "+10";
            this.btn_PlusTen.UseVisualStyleBackColor = true;
            this.btn_PlusTen.Click += new System.EventHandler(this.btn_PlusTen_Click);
            // 
            // btn_PlusHundred
            // 
            this.btn_PlusHundred.Location = new System.Drawing.Point(746, 563);
            this.btn_PlusHundred.Name = "btn_PlusHundred";
            this.btn_PlusHundred.Size = new System.Drawing.Size(65, 38);
            this.btn_PlusHundred.TabIndex = 13;
            this.btn_PlusHundred.Text = "+100";
            this.btn_PlusHundred.UseVisualStyleBackColor = true;
            this.btn_PlusHundred.Click += new System.EventHandler(this.button6_Click);
            // 
            // ManagementSupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 737);
            this.ControlBox = false;
            this.Controls.Add(this.btn_PlusHundred);
            this.Controls.Add(this.btn_PlusTen);
            this.Controls.Add(this.btn_PlusOne);
            this.Controls.Add(this.btn_MinHundred);
            this.Controls.Add(this.btn_MinTen);
            this.Controls.Add(this.btn_MinOne);
            this.Controls.Add(this.lbl_SelectedName);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.txt_SelectedAmount);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.ListView_ViewSupply);
            this.MaximizeBox = false;
            //this.Name = "ManagementSupplyForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management voorraad ";
            this.Load += new System.EventHandler(this.ManagementSupplyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView ListView_ViewSupply;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Back;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Voorraad;
        private System.Windows.Forms.TextBox txt_SelectedAmount;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Label lbl_SelectedName;
        private System.Windows.Forms.Button btn_MinOne;
        private System.Windows.Forms.Button btn_MinTen;
        private System.Windows.Forms.Button btn_MinHundred;
        private System.Windows.Forms.Button btn_PlusOne;
        private System.Windows.Forms.Button btn_PlusTen;
        private System.Windows.Forms.Button btn_PlusHundred;
    }
}