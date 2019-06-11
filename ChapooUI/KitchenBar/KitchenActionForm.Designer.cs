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
            this.layoutPanel = new System.Windows.Forms.Panel();
            this.loadingPicture = new System.Windows.Forms.PictureBox();
            this.ordersListView = new MaterialSkin.Controls.MaterialListView();
            this.getOrdersWorker = new System.ComponentModel.BackgroundWorker();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.loginLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.currentTime = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.gereedButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.layoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.Controls.Add(this.loadingPicture);
            this.layoutPanel.Controls.Add(this.ordersListView);
            this.layoutPanel.Location = new System.Drawing.Point(0, 64);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(984, 672);
            this.layoutPanel.TabIndex = 14;
            // 
            // loadingPicture
            // 
            this.loadingPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.loadingPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingPicture.Image = global::ChapooUI.Properties.Resources.loadingGif;
            this.loadingPicture.InitialImage = null;
            this.loadingPicture.Location = new System.Drawing.Point(0, 0);
            this.loadingPicture.Name = "loadingPicture";
            this.loadingPicture.Size = new System.Drawing.Size(984, 672);
            this.loadingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadingPicture.TabIndex = 15;
            this.loadingPicture.TabStop = false;
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
            this.updateTimer.Interval = 60000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Depth = 0;
            this.loginLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginLabel.Location = new System.Drawing.Point(384, 12);
            this.loginLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(108, 19);
            this.loginLabel.TabIndex = 15;
            this.loginLabel.Text = "materialLabel1";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(888, 16);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(72, 36);
            this.materialRaisedButton1.TabIndex = 16;
            this.materialRaisedButton1.Text = "LOG UIT";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // currentTime
            // 
            this.currentTime.Enabled = true;
            this.currentTime.Interval = 1;
            this.currentTime.Tick += new System.EventHandler(this.currentTime_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Depth = 0;
            this.timeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeLabel.Location = new System.Drawing.Point(384, 36);
            this.timeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(108, 19);
            this.timeLabel.TabIndex = 17;
            this.timeLabel.Text = "materialLabel1";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gereedButton
            // 
            this.gereedButton.AutoSize = true;
            this.gereedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gereedButton.Depth = 0;
            this.gereedButton.Icon = null;
            this.gereedButton.Location = new System.Drawing.Point(608, 16);
            this.gereedButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gereedButton.Name = "gereedButton";
            this.gereedButton.Primary = true;
            this.gereedButton.Size = new System.Drawing.Size(204, 36);
            this.gereedButton.TabIndex = 18;
            this.gereedButton.Text = "Gereed bestellingen zien";
            this.gereedButton.UseVisualStyleBackColor = true;
            this.gereedButton.Click += new System.EventHandler(this.gereedButton_Click);
            // 
            // KitchenActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 737);
            this.ControlBox = false;
            this.Controls.Add(this.gereedButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.layoutPanel);
            this.MaximizeBox = false;
            this.Name = "KitchenActionForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overzicht";
            this.Load += new System.EventHandler(this.KitchenActionForm_Load);
            this.layoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel layoutPanel;
        private MaterialSkin.Controls.MaterialListView ordersListView;
        private System.Windows.Forms.PictureBox loadingPicture;
        private System.ComponentModel.BackgroundWorker getOrdersWorker;
        private System.Windows.Forms.Timer updateTimer;
        private MaterialSkin.Controls.MaterialLabel loginLabel;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Timer currentTime;
        private MaterialSkin.Controls.MaterialLabel timeLabel;
        private MaterialSkin.Controls.MaterialRaisedButton gereedButton;
    }
}