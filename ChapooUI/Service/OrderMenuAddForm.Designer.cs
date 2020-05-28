namespace ChapooUI.Service
{
    partial class OrderMenuAddForm
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
            this.mlblMenuItem = new MaterialSkin.Controls.MaterialLabel();
            this.mlblItem = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.mlblVoorraad = new MaterialSkin.Controls.MaterialLabel();
            this.mlblVoorraadAantal = new MaterialSkin.Controls.MaterialLabel();
            this.mbtnToevoegen = new MaterialSkin.Controls.MaterialFlatButton();
            this.mtextCommentaar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mlblCommentaar = new MaterialSkin.Controls.MaterialLabel();
            this.numAantal = new System.Windows.Forms.NumericUpDown();
            this.mbtnAfbreken = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.numAantal)).BeginInit();
            this.SuspendLayout();
            // 
            // mlblMenuItem
            // 
            this.mlblMenuItem.AutoSize = true;
            this.mlblMenuItem.Depth = 0;
            this.mlblMenuItem.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblMenuItem.Location = new System.Drawing.Point(12, 74);
            this.mlblMenuItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblMenuItem.Name = "mlblMenuItem";
            this.mlblMenuItem.Size = new System.Drawing.Size(100, 24);
            this.mlblMenuItem.TabIndex = 0;
            this.mlblMenuItem.Text = "Menu Item";
            // 
            // mlblItem
            // 
            this.mlblItem.AutoSize = true;
            this.mlblItem.Depth = 0;
            this.mlblItem.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblItem.Location = new System.Drawing.Point(12, 113);
            this.mlblItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblItem.Name = "mlblItem";
            this.mlblItem.Size = new System.Drawing.Size(48, 24);
            this.mlblItem.TabIndex = 1;
            this.mlblItem.Text = "Item";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 170);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(63, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Aantal";
            // 
            // mlblVoorraad
            // 
            this.mlblVoorraad.AutoSize = true;
            this.mlblVoorraad.Depth = 0;
            this.mlblVoorraad.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblVoorraad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblVoorraad.Location = new System.Drawing.Point(154, 170);
            this.mlblVoorraad.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblVoorraad.Name = "mlblVoorraad";
            this.mlblVoorraad.Size = new System.Drawing.Size(87, 24);
            this.mlblVoorraad.TabIndex = 4;
            this.mlblVoorraad.Text = "Voorraad";
            // 
            // mlblVoorraadAantal
            // 
            this.mlblVoorraadAantal.AutoSize = true;
            this.mlblVoorraadAantal.Depth = 0;
            this.mlblVoorraadAantal.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblVoorraadAantal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblVoorraadAantal.Location = new System.Drawing.Point(154, 208);
            this.mlblVoorraadAantal.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblVoorraadAantal.Name = "mlblVoorraadAantal";
            this.mlblVoorraadAantal.Size = new System.Drawing.Size(63, 24);
            this.mlblVoorraadAantal.TabIndex = 5;
            this.mlblVoorraadAantal.Text = "Aantal";
            // 
            // mbtnToevoegen
            // 
            this.mbtnToevoegen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnToevoegen.Depth = 0;
            this.mbtnToevoegen.Icon = null;
            this.mbtnToevoegen.Location = new System.Drawing.Point(12, 380);
            this.mbtnToevoegen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnToevoegen.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnToevoegen.Name = "mbtnToevoegen";
            this.mbtnToevoegen.Primary = false;
            this.mbtnToevoegen.Size = new System.Drawing.Size(278, 74);
            this.mbtnToevoegen.TabIndex = 6;
            this.mbtnToevoegen.Text = "Toevoegen";
            this.mbtnToevoegen.UseVisualStyleBackColor = true;
            this.mbtnToevoegen.Click += new System.EventHandler(this.MbtnToevoegen_Click);
            // 
            // mtextCommentaar
            // 
            this.mtextCommentaar.Depth = 0;
            this.mtextCommentaar.Hint = "";
            this.mtextCommentaar.Location = new System.Drawing.Point(11, 301);
            this.mtextCommentaar.MaxLength = 32767;
            this.mtextCommentaar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtextCommentaar.Name = "mtextCommentaar";
            this.mtextCommentaar.PasswordChar = '\0';
            this.mtextCommentaar.SelectedText = "";
            this.mtextCommentaar.SelectionLength = 0;
            this.mtextCommentaar.SelectionStart = 0;
            this.mtextCommentaar.Size = new System.Drawing.Size(278, 28);
            this.mtextCommentaar.TabIndex = 7;
            this.mtextCommentaar.TabStop = false;
            this.mtextCommentaar.UseSystemPasswordChar = false;
            // 
            // mlblCommentaar
            // 
            this.mlblCommentaar.AutoSize = true;
            this.mlblCommentaar.Depth = 0;
            this.mlblCommentaar.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblCommentaar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblCommentaar.Location = new System.Drawing.Point(11, 265);
            this.mlblCommentaar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblCommentaar.Name = "mlblCommentaar";
            this.mlblCommentaar.Size = new System.Drawing.Size(119, 24);
            this.mlblCommentaar.TabIndex = 8;
            this.mlblCommentaar.Text = "Commentaar";
            // 
            // numAantal
            // 
            this.numAantal.Location = new System.Drawing.Point(16, 211);
            this.numAantal.Name = "numAantal";
            this.numAantal.Size = new System.Drawing.Size(59, 22);
            this.numAantal.TabIndex = 9;
            this.numAantal.ValueChanged += new System.EventHandler(this.NumAantal_ValueChanged);
            // 
            // mbtnAfbreken
            // 
            this.mbtnAfbreken.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAfbreken.Depth = 0;
            this.mbtnAfbreken.Icon = null;
            this.mbtnAfbreken.Location = new System.Drawing.Point(12, 464);
            this.mbtnAfbreken.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAfbreken.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAfbreken.Name = "mbtnAfbreken";
            this.mbtnAfbreken.Primary = false;
            this.mbtnAfbreken.Size = new System.Drawing.Size(278, 23);
            this.mbtnAfbreken.TabIndex = 10;
            this.mbtnAfbreken.Text = "Afbreken";
            this.mbtnAfbreken.UseVisualStyleBackColor = true;
            this.mbtnAfbreken.Click += new System.EventHandler(this.MbtnAfbreken_Click);
            // 
            // OrderMenuAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.mbtnAfbreken);
            this.Controls.Add(this.numAantal);
            this.Controls.Add(this.mlblCommentaar);
            this.Controls.Add(this.mtextCommentaar);
            this.Controls.Add(this.mbtnToevoegen);
            this.Controls.Add(this.mlblVoorraadAantal);
            this.Controls.Add(this.mlblVoorraad);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.mlblItem);
            this.Controls.Add(this.mlblMenuItem);
            this.Name = "OrderMenuAddForm";
            this.Text = "Add Menu Item";
            this.Load += new System.EventHandler(this.OrderMenuAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAantal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel mlblMenuItem;
        private MaterialSkin.Controls.MaterialLabel mlblItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel mlblVoorraad;
        private MaterialSkin.Controls.MaterialLabel mlblVoorraadAantal;
        private MaterialSkin.Controls.MaterialFlatButton mbtnToevoegen;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtextCommentaar;
        private MaterialSkin.Controls.MaterialLabel mlblCommentaar;
        private System.Windows.Forms.NumericUpDown numAantal;
        private MaterialSkin.Controls.MaterialFlatButton mbtnAfbreken;
    }
}