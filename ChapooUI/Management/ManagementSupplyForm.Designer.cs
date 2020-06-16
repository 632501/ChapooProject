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
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Voorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_SelectedAmount = new System.Windows.Forms.TextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.lbl_SelectedName = new System.Windows.Forms.Label();
            this.btn_MinOne = new System.Windows.Forms.Button();
            this.btn_MinTen = new System.Windows.Forms.Button();
            this.btn_MinHundred = new System.Windows.Forms.Button();
            this.btn_PlusOne = new System.Windows.Forms.Button();
            this.btn_PlusTen = new System.Windows.Forms.Button();
            this.btn_PlusHundred = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rbtn_SupplyId = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtn_SupplyName = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtn_SupplyCategorie = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtn_Voorraad = new MaterialSkin.Controls.MaterialRadioButton();
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
            this.ListView_ViewSupply.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.ListView_ViewSupply.FullRowSelect = true;
            this.ListView_ViewSupply.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView_ViewSupply.HideSelection = false;
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
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 41;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Naam";
            this.ItemName.Width = 550;
            // 
            // Category
            // 
            this.Category.Text = "Categorie";
            this.Category.Width = 170;
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
            this.txt_SelectedAmount.TextChanged += new System.EventHandler(this.txt_SelectedAmount_TextChanged);
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
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(45, 82);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // rbtn_SupplyId
            // 
            this.rbtn_SupplyId.AutoSize = true;
            this.rbtn_SupplyId.Depth = 0;
            this.rbtn_SupplyId.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtn_SupplyId.Location = new System.Drawing.Point(211, 82);
            this.rbtn_SupplyId.Margin = new System.Windows.Forms.Padding(0);
            this.rbtn_SupplyId.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtn_SupplyId.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtn_SupplyId.Name = "rbtn_SupplyId";
            this.rbtn_SupplyId.Ripple = true;
            this.rbtn_SupplyId.Size = new System.Drawing.Size(42, 30);
            this.rbtn_SupplyId.TabIndex = 15;
            this.rbtn_SupplyId.TabStop = true;
            this.rbtn_SupplyId.Text = "ID";
            this.rbtn_SupplyId.UseVisualStyleBackColor = true;
            this.rbtn_SupplyId.CheckedChanged += new System.EventHandler(this.rbtn_SupplyId_CheckedChanged);
            // 
            // rbtn_SupplyName
            // 
            this.rbtn_SupplyName.AutoSize = true;
            this.rbtn_SupplyName.Depth = 0;
            this.rbtn_SupplyName.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtn_SupplyName.Location = new System.Drawing.Point(286, 82);
            this.rbtn_SupplyName.Margin = new System.Windows.Forms.Padding(0);
            this.rbtn_SupplyName.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtn_SupplyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtn_SupplyName.Name = "rbtn_SupplyName";
            this.rbtn_SupplyName.Ripple = true;
            this.rbtn_SupplyName.Size = new System.Drawing.Size(66, 30);
            this.rbtn_SupplyName.TabIndex = 16;
            this.rbtn_SupplyName.TabStop = true;
            this.rbtn_SupplyName.Text = "Naam";
            this.rbtn_SupplyName.UseVisualStyleBackColor = true;
            this.rbtn_SupplyName.CheckedChanged += new System.EventHandler(this.rbtn_SupplyName_CheckedChanged);
            // 
            // rbtn_SupplyCategorie
            // 
            this.rbtn_SupplyCategorie.AutoSize = true;
            this.rbtn_SupplyCategorie.Depth = 0;
            this.rbtn_SupplyCategorie.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtn_SupplyCategorie.Location = new System.Drawing.Point(386, 82);
            this.rbtn_SupplyCategorie.Margin = new System.Windows.Forms.Padding(0);
            this.rbtn_SupplyCategorie.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtn_SupplyCategorie.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtn_SupplyCategorie.Name = "rbtn_SupplyCategorie";
            this.rbtn_SupplyCategorie.Ripple = true;
            this.rbtn_SupplyCategorie.Size = new System.Drawing.Size(89, 30);
            this.rbtn_SupplyCategorie.TabIndex = 17;
            this.rbtn_SupplyCategorie.TabStop = true;
            this.rbtn_SupplyCategorie.Text = "Categorie";
            this.rbtn_SupplyCategorie.UseVisualStyleBackColor = true;
            this.rbtn_SupplyCategorie.CheckedChanged += new System.EventHandler(this.rbtn_SupplyCategorie_CheckedChanged);
            // 
            // rbtn_Voorraad
            // 
            this.rbtn_Voorraad.AutoSize = true;
            this.rbtn_Voorraad.Depth = 0;
            this.rbtn_Voorraad.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtn_Voorraad.Location = new System.Drawing.Point(514, 82);
            this.rbtn_Voorraad.Margin = new System.Windows.Forms.Padding(0);
            this.rbtn_Voorraad.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtn_Voorraad.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtn_Voorraad.Name = "rbtn_Voorraad";
            this.rbtn_Voorraad.Ripple = true;
            this.rbtn_Voorraad.Size = new System.Drawing.Size(86, 30);
            this.rbtn_Voorraad.TabIndex = 18;
            this.rbtn_Voorraad.TabStop = true;
            this.rbtn_Voorraad.Text = "Voorraad";
            this.rbtn_Voorraad.UseVisualStyleBackColor = true;
            this.rbtn_Voorraad.CheckedChanged += new System.EventHandler(this.rbtn_Voorraad_CheckedChanged);
            // 
            // ManagementSupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 718);
            this.ControlBox = false;
            this.Controls.Add(this.rbtn_Voorraad);
            this.Controls.Add(this.rbtn_SupplyCategorie);
            this.Controls.Add(this.rbtn_SupplyName);
            this.Controls.Add(this.rbtn_SupplyId);
            this.Controls.Add(this.materialLabel1);
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
            this.Name = "ManagementSupplyForm";
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
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton rbtn_SupplyId;
        private MaterialSkin.Controls.MaterialRadioButton rbtn_SupplyName;
        private MaterialSkin.Controls.MaterialRadioButton rbtn_SupplyCategorie;
        private MaterialSkin.Controls.MaterialRadioButton rbtn_Voorraad;
    }
}