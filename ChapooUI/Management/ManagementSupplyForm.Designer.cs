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
            this.btn_Back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Voorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListView_ViewSupply
            // 
            this.ListView_ViewSupply.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView_ViewSupply.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Voorraad});
            this.ListView_ViewSupply.Depth = 0;
            this.ListView_ViewSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ListView_ViewSupply.FullRowSelect = true;
            this.ListView_ViewSupply.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView_ViewSupply.Location = new System.Drawing.Point(65, 129);
            this.ListView_ViewSupply.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListView_ViewSupply.MouseState = MaterialSkin.MouseState.OUT;
            this.ListView_ViewSupply.Name = "ListView_ViewSupply";
            this.ListView_ViewSupply.OwnerDraw = true;
            this.ListView_ViewSupply.Size = new System.Drawing.Size(803, 344);
            this.ListView_ViewSupply.TabIndex = 0;
            this.ListView_ViewSupply.UseCompatibleStateImageBehavior = false;
            this.ListView_ViewSupply.View = System.Windows.Forms.View.Details;
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
            // Name
            // 
            this.Name.Text = "Naam";
            this.Name.Width = 600;
            // 
            // Voorraad
            // 
            this.Voorraad.Text = "Voorraad";
            this.Voorraad.Width = 200;
            // 
            // ManagementSupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 737);
            this.ControlBox = false;
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
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Voorraad;
    }
}