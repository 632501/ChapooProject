﻿namespace ChapooUI
{
    partial class ManagementEmployeeForm
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
            this.ListView_Employee = new MaterialSkin.Controls.MaterialListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Function = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_Function = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Function = new System.Windows.Forms.TextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rbtn_PersID = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtn_PersNaam = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtn_PersFunctie = new MaterialSkin.Controls.MaterialRadioButton();
            this.SuspendLayout();
            // 
            // ListView_Employee
            // 
            this.ListView_Employee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView_Employee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.EmployeeName,
            this.Password,
            this.Function});
            this.ListView_Employee.Depth = 0;
            this.ListView_Employee.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.ListView_Employee.FullRowSelect = true;
            this.ListView_Employee.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView_Employee.HideSelection = false;
            this.ListView_Employee.Location = new System.Drawing.Point(12, 122);
            this.ListView_Employee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListView_Employee.MouseState = MaterialSkin.MouseState.OUT;
            this.ListView_Employee.Name = "ListView_Employee";
            this.ListView_Employee.OwnerDraw = true;
            this.ListView_Employee.Size = new System.Drawing.Size(914, 344);
            this.ListView_Employee.TabIndex = 0;
            this.ListView_Employee.UseCompatibleStateImageBehavior = false;
            this.ListView_Employee.View = System.Windows.Forms.View.Details;
            this.ListView_Employee.SelectedIndexChanged += new System.EventHandler(this.ListView_Employee_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 100;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Text = "Naam";
            this.EmployeeName.Width = 500;
            // 
            // Password
            // 
            this.Password.Text = "Wachtwoord";
            this.Password.Width = 150;
            // 
            // Function
            // 
            this.Function.Text = "Functie";
            this.Function.Width = 150;
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
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ID.Location = new System.Drawing.Point(49, 489);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(154, 25);
            this.lbl_ID.TabIndex = 2;
            this.lbl_ID.Text = "Werknemer ID:";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(301, 486);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(81, 31);
            this.txt_ID.TabIndex = 6;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // lbl_Function
            // 
            this.lbl_Function.AutoSize = true;
            this.lbl_Function.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Function.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Function.Location = new System.Drawing.Point(49, 666);
            this.lbl_Function.Name = "lbl_Function";
            this.lbl_Function.Size = new System.Drawing.Size(198, 25);
            this.lbl_Function.TabIndex = 7;
            this.lbl_Function.Text = "Werknemer functie:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Password.Location = new System.Drawing.Point(49, 607);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(248, 25);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Werknemer wachtwoord:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Name.Location = new System.Drawing.Point(49, 548);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(187, 25);
            this.lbl_Name.TabIndex = 9;
            this.lbl_Name.Text = "Werknemer naam:";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(301, 545);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(302, 31);
            this.txt_Name.TabIndex = 10;
            this.txt_Name.Leave += new System.EventHandler(this.txt_Name_Leave);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(301, 604);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(136, 31);
            this.txt_Password.TabIndex = 11;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // txt_Function
            // 
            this.txt_Function.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Function.Location = new System.Drawing.Point(301, 663);
            this.txt_Function.Name = "txt_Function";
            this.txt_Function.Size = new System.Drawing.Size(202, 31);
            this.txt_Function.TabIndex = 12;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(660, 486);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(265, 161);
            this.btn_Change.TabIndex = 13;
            this.btn_Change.Text = "Pas toe";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(661, 663);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(265, 61);
            this.btn_Remove.TabIndex = 14;
            this.btn_Remove.Text = "Ontsla";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(33, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Sorteer op:";
            // 
            // rbtn_PersID
            // 
            this.rbtn_PersID.AutoSize = true;
            this.rbtn_PersID.Depth = 0;
            this.rbtn_PersID.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtn_PersID.Location = new System.Drawing.Point(167, 84);
            this.rbtn_PersID.Margin = new System.Windows.Forms.Padding(0);
            this.rbtn_PersID.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtn_PersID.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtn_PersID.Name = "rbtn_PersID";
            this.rbtn_PersID.Ripple = true;
            this.rbtn_PersID.Size = new System.Drawing.Size(42, 30);
            this.rbtn_PersID.TabIndex = 16;
            this.rbtn_PersID.TabStop = true;
            this.rbtn_PersID.Text = "ID";
            this.rbtn_PersID.UseVisualStyleBackColor = true;
            this.rbtn_PersID.CheckedChanged += new System.EventHandler(this.rbtn_PersID_CheckedChanged);
            // 
            // rbtn_PersNaam
            // 
            this.rbtn_PersNaam.AutoSize = true;
            this.rbtn_PersNaam.Depth = 0;
            this.rbtn_PersNaam.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtn_PersNaam.Location = new System.Drawing.Point(243, 84);
            this.rbtn_PersNaam.Margin = new System.Windows.Forms.Padding(0);
            this.rbtn_PersNaam.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtn_PersNaam.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtn_PersNaam.Name = "rbtn_PersNaam";
            this.rbtn_PersNaam.Ripple = true;
            this.rbtn_PersNaam.Size = new System.Drawing.Size(66, 30);
            this.rbtn_PersNaam.TabIndex = 17;
            this.rbtn_PersNaam.TabStop = true;
            this.rbtn_PersNaam.Text = "Naam";
            this.rbtn_PersNaam.UseVisualStyleBackColor = true;
            this.rbtn_PersNaam.CheckedChanged += new System.EventHandler(this.rbtn_PersNaam_CheckedChanged);
            // 
            // rbtn_PersFunctie
            // 
            this.rbtn_PersFunctie.AutoSize = true;
            this.rbtn_PersFunctie.Depth = 0;
            this.rbtn_PersFunctie.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtn_PersFunctie.Location = new System.Drawing.Point(340, 84);
            this.rbtn_PersFunctie.Margin = new System.Windows.Forms.Padding(0);
            this.rbtn_PersFunctie.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtn_PersFunctie.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtn_PersFunctie.Name = "rbtn_PersFunctie";
            this.rbtn_PersFunctie.Ripple = true;
            this.rbtn_PersFunctie.Size = new System.Drawing.Size(74, 30);
            this.rbtn_PersFunctie.TabIndex = 18;
            this.rbtn_PersFunctie.TabStop = true;
            this.rbtn_PersFunctie.Text = "Functie";
            this.rbtn_PersFunctie.UseVisualStyleBackColor = true;
            this.rbtn_PersFunctie.CheckedChanged += new System.EventHandler(this.rbtn_PersFunctie_CheckedChanged);
            // 
            // ManagementEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 737);
            this.ControlBox = false;
            this.Controls.Add(this.rbtn_PersFunctie);
            this.Controls.Add(this.rbtn_PersNaam);
            this.Controls.Add(this.rbtn_PersID);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.txt_Function);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Function);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.ListView_Employee);
            this.MaximizeBox = false;
            this.Name = "ManagementEmployeeForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management personeelbeheer ";
            this.Load += new System.EventHandler(this.ManagementEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView ListView_Employee;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Back;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_Function;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Function;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.ColumnHeader Function;
        private System.Windows.Forms.ColumnHeader EmployeeName;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button btn_Remove;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton rbtn_PersID;
        private MaterialSkin.Controls.MaterialRadioButton rbtn_PersNaam;
        private MaterialSkin.Controls.MaterialRadioButton rbtn_PersFunctie;
    }
}