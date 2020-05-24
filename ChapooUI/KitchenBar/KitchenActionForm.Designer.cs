namespace ChapooUI
{
    partial class KitchenActionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenActionForm));
            this.layoutPanel = new System.Windows.Forms.Panel();
            this.ordersListView = new MaterialSkin.Controls.MaterialListView();
            this.getOrdersWorker = new System.ComponentModel.BackgroundWorker();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.loginLabel = new MaterialSkin.Controls.MaterialLabel();
            this.logOutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.filterButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.stockButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.uncheckPicture = new System.Windows.Forms.PictureBox();
            this.checkPicture = new System.Windows.Forms.PictureBox();
            this.layoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uncheckPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.Controls.Add(this.ordersListView);
            this.layoutPanel.Location = new System.Drawing.Point(0, 112);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(984, 672);
            this.layoutPanel.TabIndex = 14;
            // 
            // ordersListView
            // 
            this.ordersListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersListView.Depth = 0;
            this.ordersListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ordersListView.FullRowSelect = true;
            this.ordersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ordersListView.Location = new System.Drawing.Point(0, 0);
            this.ordersListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ordersListView.MouseState = MaterialSkin.MouseState.OUT;
            this.ordersListView.Name = "ordersListView";
            this.ordersListView.OwnerDraw = true;
            this.ordersListView.Size = new System.Drawing.Size(984, 672);
            this.ordersListView.TabIndex = 14;
            this.ordersListView.UseCompatibleStateImageBehavior = false;
            this.ordersListView.View = System.Windows.Forms.View.Details;
            this.ordersListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ordersListView_ColumnWidthChanging);
            this.ordersListView.SelectedIndexChanged += new System.EventHandler(this.ordersListView_SelectedIndexChanged);
            this.ordersListView.Click += new System.EventHandler(this.ordersListView_Click);
            // 
            // getOrdersWorker
            // 
            this.getOrdersWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.getOrdersWorker_DoWork);
            this.getOrdersWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.getOrdersWorker_RunWorkerCompleted);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 30000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Depth = 0;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginLabel.Location = new System.Drawing.Point(449, 33);
            this.loginLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(74, 18);
            this.loginLabel.TabIndex = 15;
            this.loginLabel.Text = "loginLabel";
            // 
            // logOutButton
            // 
            this.logOutButton.AutoSize = true;
            this.logOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logOutButton.Depth = 0;
            this.logOutButton.Icon = null;
            this.logOutButton.Location = new System.Drawing.Point(897, 69);
            this.logOutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Primary = true;
            this.logOutButton.Size = new System.Drawing.Size(72, 36);
            this.logOutButton.TabIndex = 16;
            this.logOutButton.Text = "LOG UIT";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.AutoSize = true;
            this.filterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.filterButton.Depth = 0;
            this.filterButton.Icon = null;
            this.filterButton.Location = new System.Drawing.Point(112, 69);
            this.filterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterButton.Name = "filterButton";
            this.filterButton.Primary = true;
            this.filterButton.Size = new System.Drawing.Size(204, 36);
            this.filterButton.TabIndex = 18;
            this.filterButton.Text = "Gereed bestellingen zien";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // stockButton
            // 
            this.stockButton.AutoSize = true;
            this.stockButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stockButton.Depth = 0;
            this.stockButton.Icon = null;
            this.stockButton.Location = new System.Drawing.Point(8, 69);
            this.stockButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.stockButton.Name = "stockButton";
            this.stockButton.Primary = true;
            this.stockButton.Size = new System.Drawing.Size(93, 36);
            this.stockButton.TabIndex = 19;
            this.stockButton.Text = "Voorraad";
            this.stockButton.UseVisualStyleBackColor = true;
            this.stockButton.Click += new System.EventHandler(this.stockButton_Click);
            // 
            // uncheckPicture
            // 
            this.uncheckPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.uncheckPicture.Image = ((System.Drawing.Image)(resources.GetObject("uncheckPicture.Image")));
            this.uncheckPicture.Location = new System.Drawing.Point(312, 69);
            this.uncheckPicture.Name = "uncheckPicture";
            this.uncheckPicture.Size = new System.Drawing.Size(40, 36);
            this.uncheckPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.uncheckPicture.TabIndex = 21;
            this.uncheckPicture.TabStop = false;
            // 
            // checkPicture
            // 
            this.checkPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.checkPicture.Image = global::ChapooUI.Properties.Resources.check;
            this.checkPicture.Location = new System.Drawing.Point(312, 69);
            this.checkPicture.Name = "checkPicture";
            this.checkPicture.Size = new System.Drawing.Size(40, 36);
            this.checkPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkPicture.TabIndex = 20;
            this.checkPicture.TabStop = false;
            this.checkPicture.Visible = false;
            // 
            // KitchenActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 737);
            this.ControlBox = false;
            this.Controls.Add(this.stockButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.checkPicture);
            this.Controls.Add(this.uncheckPicture);
            this.Controls.Add(this.filterButton);
            this.MaximizeBox = false;
            this.Name = "KitchenActionForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overzicht";
            this.Load += new System.EventHandler(this.KitchenActionForm_Load);
            this.layoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uncheckPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel layoutPanel;
        private MaterialSkin.Controls.MaterialListView ordersListView;
        private System.ComponentModel.BackgroundWorker getOrdersWorker;
        private System.Windows.Forms.Timer updateTimer;
        private MaterialSkin.Controls.MaterialLabel loginLabel;
        private MaterialSkin.Controls.MaterialRaisedButton logOutButton;
        private MaterialSkin.Controls.MaterialRaisedButton filterButton;
        private MaterialSkin.Controls.MaterialRaisedButton stockButton;
        private System.Windows.Forms.PictureBox checkPicture;
        private System.Windows.Forms.PictureBox uncheckPicture;
    }
}