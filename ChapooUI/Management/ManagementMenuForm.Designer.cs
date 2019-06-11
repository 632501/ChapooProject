namespace ChapooUI
{
    partial class ManagementMenuForm
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
            this.ListView_ViewMenu = new MaterialSkin.Controls.MaterialListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_ItemID = new System.Windows.Forms.TextBox();
            this.txt_ItemNaam = new System.Windows.Forms.TextBox();
            this.txt_ItemPrijs = new System.Windows.Forms.TextBox();
            this.txt_ItemCategorie = new System.Windows.Forms.TextBox();
            this.lbl_ItemID = new System.Windows.Forms.Label();
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.lbl_Prijs = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            this.lbl_Supply = new System.Windows.Forms.Label();
            this.txt_Supply = new System.Windows.Forms.TextBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.lbl_btw = new System.Windows.Forms.Label();
            this.txt_Btw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListView_ViewMenu
            // 
            this.ListView_ViewMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView_ViewMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ItemName,
            this.Prijs,
            this.Category});
            this.ListView_ViewMenu.Depth = 0;
            this.ListView_ViewMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ListView_ViewMenu.FullRowSelect = true;
            this.ListView_ViewMenu.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView_ViewMenu.Location = new System.Drawing.Point(12, 142);
            this.ListView_ViewMenu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListView_ViewMenu.MouseState = MaterialSkin.MouseState.OUT;
            this.ListView_ViewMenu.Name = "ListView_ViewMenu";
            this.ListView_ViewMenu.OwnerDraw = true;
            this.ListView_ViewMenu.Size = new System.Drawing.Size(913, 344);
            this.ListView_ViewMenu.TabIndex = 0;
            this.ListView_ViewMenu.UseCompatibleStateImageBehavior = false;
            this.ListView_ViewMenu.View = System.Windows.Forms.View.Details;
            this.ListView_ViewMenu.SelectedIndexChanged += new System.EventHandler(this.ListView_ViewMenu_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Naam";
            this.ItemName.Width = 570;
            // 
            // Prijs
            // 
            this.Prijs.Text = "Prijs";
            this.Prijs.Width = 80;
            // 
            // Category
            // 
            this.Category.Text = "Categorie";
            this.Category.Width = 180;
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
            // txt_ItemID
            // 
            this.txt_ItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemID.Location = new System.Drawing.Point(304, 492);
            this.txt_ItemID.Name = "txt_ItemID";
            this.txt_ItemID.Size = new System.Drawing.Size(50, 31);
            this.txt_ItemID.TabIndex = 2;
            this.txt_ItemID.TextChanged += new System.EventHandler(this.txt_ItemID_TextChanged);
            // 
            // txt_ItemNaam
            // 
            this.txt_ItemNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemNaam.Location = new System.Drawing.Point(304, 528);
            this.txt_ItemNaam.Name = "txt_ItemNaam";
            this.txt_ItemNaam.Size = new System.Drawing.Size(394, 31);
            this.txt_ItemNaam.TabIndex = 3;
            // 
            // txt_ItemPrijs
            // 
            this.txt_ItemPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemPrijs.Location = new System.Drawing.Point(304, 568);
            this.txt_ItemPrijs.Name = "txt_ItemPrijs";
            this.txt_ItemPrijs.Size = new System.Drawing.Size(74, 31);
            this.txt_ItemPrijs.TabIndex = 4;
            this.txt_ItemPrijs.TextChanged += new System.EventHandler(this.txt_ItemPrijs_TextChanged);
            // 
            // txt_ItemCategorie
            // 
            this.txt_ItemCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemCategorie.Location = new System.Drawing.Point(304, 607);
            this.txt_ItemCategorie.Name = "txt_ItemCategorie";
            this.txt_ItemCategorie.Size = new System.Drawing.Size(148, 31);
            this.txt_ItemCategorie.TabIndex = 5;
            // 
            // lbl_ItemID
            // 
            this.lbl_ItemID.AutoSize = true;
            this.lbl_ItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ItemID.Location = new System.Drawing.Point(27, 495);
            this.lbl_ItemID.Name = "lbl_ItemID";
            this.lbl_ItemID.Size = new System.Drawing.Size(84, 25);
            this.lbl_ItemID.TabIndex = 6;
            this.lbl_ItemID.Text = "Item ID:";
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.AutoSize = true;
            this.lbl_ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ItemName.Location = new System.Drawing.Point(27, 531);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(117, 25);
            this.lbl_ItemName.TabIndex = 7;
            this.lbl_ItemName.Text = "Item naam:";
            // 
            // lbl_Prijs
            // 
            this.lbl_Prijs.AutoSize = true;
            this.lbl_Prijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prijs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Prijs.Location = new System.Drawing.Point(27, 569);
            this.lbl_Prijs.Name = "lbl_Prijs";
            this.lbl_Prijs.Size = new System.Drawing.Size(104, 25);
            this.lbl_Prijs.TabIndex = 8;
            this.lbl_Prijs.Text = "Item prijs:";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Category.Location = new System.Drawing.Point(27, 608);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(153, 25);
            this.lbl_Category.TabIndex = 9;
            this.lbl_Category.Text = "Item categorie:";
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(713, 492);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(212, 171);
            this.btn_Change.TabIndex = 10;
            this.btn_Change.Text = "Pas toe";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // lbl_Supply
            // 
            this.lbl_Supply.AutoSize = true;
            this.lbl_Supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Supply.Location = new System.Drawing.Point(27, 647);
            this.lbl_Supply.Name = "lbl_Supply";
            this.lbl_Supply.Size = new System.Drawing.Size(106, 25);
            this.lbl_Supply.TabIndex = 11;
            this.lbl_Supply.Text = "Voorraad:";
            // 
            // txt_Supply
            // 
            this.txt_Supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Supply.Location = new System.Drawing.Point(304, 645);
            this.txt_Supply.Name = "txt_Supply";
            this.txt_Supply.Size = new System.Drawing.Size(74, 31);
            this.txt_Supply.TabIndex = 12;
            this.txt_Supply.TextChanged += new System.EventHandler(this.txt_Supply_TextChanged);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(713, 667);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(212, 57);
            this.btn_Remove.TabIndex = 13;
            this.btn_Remove.Text = "Verwijder";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // lbl_btw
            // 
            this.lbl_btw.AutoSize = true;
            this.lbl_btw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_btw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_btw.Location = new System.Drawing.Point(27, 686);
            this.lbl_btw.Name = "lbl_btw";
            this.lbl_btw.Size = new System.Drawing.Size(53, 25);
            this.lbl_btw.TabIndex = 14;
            this.lbl_btw.Text = "Btw:";
            // 
            // txt_Btw
            // 
            this.txt_Btw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Btw.Location = new System.Drawing.Point(304, 684);
            this.txt_Btw.Name = "txt_Btw";
            this.txt_Btw.Size = new System.Drawing.Size(74, 31);
            this.txt_Btw.TabIndex = 15;
            // 
            // ManagementMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 737);
            this.ControlBox = false;
            this.Controls.Add(this.txt_Btw);
            this.Controls.Add(this.lbl_btw);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.txt_Supply);
            this.Controls.Add(this.lbl_Supply);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_Prijs);
            this.Controls.Add(this.lbl_ItemName);
            this.Controls.Add(this.lbl_ItemID);
            this.Controls.Add(this.txt_ItemCategorie);
            this.Controls.Add(this.txt_ItemPrijs);
            this.Controls.Add(this.txt_ItemNaam);
            this.Controls.Add(this.txt_ItemID);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.ListView_ViewMenu);
            this.MaximizeBox = false;
            this.Name = "ManagementMenuForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management menu";
            this.Load += new System.EventHandler(this.ManagementMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView ListView_ViewMenu;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Back;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.TextBox txt_ItemID;
        private System.Windows.Forms.TextBox txt_ItemNaam;
        private System.Windows.Forms.TextBox txt_ItemPrijs;
        private System.Windows.Forms.TextBox txt_ItemCategorie;
        private System.Windows.Forms.Label lbl_ItemID;
        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.Label lbl_Prijs;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Label lbl_Supply;
        private System.Windows.Forms.TextBox txt_Supply;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label lbl_btw;
        private System.Windows.Forms.TextBox txt_Btw;
    }
}