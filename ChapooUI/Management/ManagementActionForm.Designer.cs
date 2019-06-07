namespace ChapooUI
{
    partial class ManagementActionForm
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
            this.btn_EmployeeFiles = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Supply = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_name = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btn_EmployeeFiles
            // 
            this.btn_EmployeeFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EmployeeFiles.Location = new System.Drawing.Point(85, 159);
            this.btn_EmployeeFiles.Margin = new System.Windows.Forms.Padding(1);
            this.btn_EmployeeFiles.Name = "btn_EmployeeFiles";
            this.btn_EmployeeFiles.Size = new System.Drawing.Size(756, 171);
            this.btn_EmployeeFiles.TabIndex = 0;
            this.btn_EmployeeFiles.Text = "Personeelsbestand";
            this.btn_EmployeeFiles.UseVisualStyleBackColor = true;
            this.btn_EmployeeFiles.Click += new System.EventHandler(this.btn_EmployeeFiles_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.Location = new System.Drawing.Point(85, 352);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(756, 171);
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Supply
            // 
            this.btn_Supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supply.Location = new System.Drawing.Point(85, 551);
            this.btn_Supply.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Supply.Name = "btn_Supply";
            this.btn_Supply.Size = new System.Drawing.Size(756, 171);
            this.btn_Supply.TabIndex = 2;
            this.btn_Supply.Text = "Voorraad";
            this.btn_Supply.UseVisualStyleBackColor = true;
            this.btn_Supply.Click += new System.EventHandler(this.btn_Supply_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.Location = new System.Drawing.Point(611, 75);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(1);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(230, 70);
            this.btn_LogOut.TabIndex = 3;
            this.btn_LogOut.Text = "Log uit";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Depth = 0;
            this.lbl_name.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_name.Location = new System.Drawing.Point(452, 35);
            this.lbl_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 19);
            this.lbl_name.TabIndex = 4;
            // 
            // ManagementActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 737);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Supply);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_EmployeeFiles);
            this.Name = "ManagementActionForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management home";
            this.Load += new System.EventHandler(this.ManagementActionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EmployeeFiles;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Supply;
        private System.Windows.Forms.Button btn_LogOut;
        private MaterialSkin.Controls.MaterialLabel lbl_name;
    }
}