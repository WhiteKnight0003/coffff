namespace CoffeeApp.GUI.Main
{
    partial class FormManagement
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
            this.btnBackFormManagement = new Guna.UI2.WinForms.Guna2Button();
            this.tbAccount = new System.Windows.Forms.TabPage();
            this.tbTable = new System.Windows.Forms.TabPage();
            this.tbCategory = new System.Windows.Forms.TabPage();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnInsertCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnRepairCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteCategory = new Guna.UI2.WinForms.Guna2Button();
            this.tbFood = new System.Windows.Forms.TabPage();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnViewCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnInsertFood = new Guna.UI2.WinForms.Guna2Button();
            this.btnRepairFood = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteFood = new Guna.UI2.WinForms.Guna2Button();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.tcManagement = new System.Windows.Forms.TabControl();
            this.tbCategory.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.tbFood.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.tcManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackFormManagement
            // 
            this.btnBackFormManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackFormManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackFormManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackFormManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackFormManagement.FillColor = System.Drawing.Color.Cyan;
            this.btnBackFormManagement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackFormManagement.ForeColor = System.Drawing.Color.Black;
            this.btnBackFormManagement.Location = new System.Drawing.Point(730, 5);
            this.btnBackFormManagement.Name = "btnBackFormManagement";
            this.btnBackFormManagement.Size = new System.Drawing.Size(199, 26);
            this.btnBackFormManagement.TabIndex = 1;
            this.btnBackFormManagement.Text = "Về trang bán hàng";
            this.btnBackFormManagement.Click += new System.EventHandler(this.btnBackFormManagement_Click);
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(4, 32);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tbAccount.Size = new System.Drawing.Size(906, 490);
            this.tbAccount.TabIndex = 4;
            this.tbAccount.Text = "Tài khoản";
            this.tbAccount.UseVisualStyleBackColor = true;
            // 
            // tbTable
            // 
            this.tbTable.Location = new System.Drawing.Point(4, 32);
            this.tbTable.Name = "tbTable";
            this.tbTable.Padding = new System.Windows.Forms.Padding(3);
            this.tbTable.Size = new System.Drawing.Size(913, 490);
            this.tbTable.TabIndex = 3;
            this.tbTable.Text = "Bàn ăn";
            this.tbTable.UseVisualStyleBackColor = true;
            // 
            // tbCategory
            // 
            this.tbCategory.BackColor = System.Drawing.Color.Transparent;
            this.tbCategory.Controls.Add(this.guna2Panel6);
            this.tbCategory.Controls.Add(this.guna2Panel5);
            this.tbCategory.Controls.Add(this.guna2Panel4);
            this.tbCategory.ForeColor = System.Drawing.Color.Black;
            this.tbCategory.Location = new System.Drawing.Point(4, 32);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tbCategory.Size = new System.Drawing.Size(913, 490);
            this.tbCategory.TabIndex = 2;
            this.tbCategory.Text = "Doanh mục";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Location = new System.Drawing.Point(8, 85);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(377, 326);
            this.guna2Panel4.TabIndex = 1;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Location = new System.Drawing.Point(391, 85);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(393, 326);
            this.guna2Panel5.TabIndex = 2;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Controls.Add(this.btnDeleteCategory);
            this.guna2Panel6.Controls.Add(this.btnRepairCategory);
            this.guna2Panel6.Controls.Add(this.btnInsertCategory);
            this.guna2Panel6.Controls.Add(this.guna2Button4);
            this.guna2Panel6.Location = new System.Drawing.Point(8, 6);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(396, 72);
            this.guna2Panel6.TabIndex = 3;
            // 
            // guna2Button4
            // 
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(4, 4);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(90, 65);
            this.guna2Button4.TabIndex = 0;
            this.guna2Button4.Text = "Xem thông tin";
            // 
            // btnInsertCategory
            // 
            this.btnInsertCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsertCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsertCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInsertCategory.ForeColor = System.Drawing.Color.White;
            this.btnInsertCategory.Location = new System.Drawing.Point(100, 4);
            this.btnInsertCategory.Name = "btnInsertCategory";
            this.btnInsertCategory.Size = new System.Drawing.Size(90, 65);
            this.btnInsertCategory.TabIndex = 0;
            this.btnInsertCategory.Text = "Thêm";
            // 
            // btnRepairCategory
            // 
            this.btnRepairCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRepairCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRepairCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRepairCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRepairCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRepairCategory.ForeColor = System.Drawing.Color.White;
            this.btnRepairCategory.Location = new System.Drawing.Point(196, 4);
            this.btnRepairCategory.Name = "btnRepairCategory";
            this.btnRepairCategory.Size = new System.Drawing.Size(90, 65);
            this.btnRepairCategory.TabIndex = 0;
            this.btnRepairCategory.Text = "Sửa";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(292, 4);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(90, 65);
            this.btnDeleteCategory.TabIndex = 0;
            this.btnDeleteCategory.Text = "Xóa";
            // 
            // tbFood
            // 
            this.tbFood.Controls.Add(this.guna2Panel3);
            this.tbFood.Controls.Add(this.guna2Panel2);
            this.tbFood.Controls.Add(this.guna2Panel1);
            this.tbFood.Location = new System.Drawing.Point(4, 32);
            this.tbFood.Name = "tbFood";
            this.tbFood.Padding = new System.Windows.Forms.Padding(3);
            this.tbFood.Size = new System.Drawing.Size(913, 490);
            this.tbFood.TabIndex = 1;
            this.tbFood.Text = "Mặt hàng";
            this.tbFood.UseVisualStyleBackColor = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(7, 85);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(377, 326);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Location = new System.Drawing.Point(391, 85);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(393, 326);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.btnDeleteFood);
            this.guna2Panel3.Controls.Add(this.btnRepairFood);
            this.guna2Panel3.Controls.Add(this.btnInsertFood);
            this.guna2Panel3.Controls.Add(this.btnViewCategory);
            this.guna2Panel3.Location = new System.Drawing.Point(7, 6);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(396, 72);
            this.guna2Panel3.TabIndex = 2;
            // 
            // btnViewCategory
            // 
            this.btnViewCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewCategory.ForeColor = System.Drawing.Color.White;
            this.btnViewCategory.Location = new System.Drawing.Point(4, 4);
            this.btnViewCategory.Name = "btnViewCategory";
            this.btnViewCategory.Size = new System.Drawing.Size(90, 65);
            this.btnViewCategory.TabIndex = 0;
            this.btnViewCategory.Text = "Xem thông tin";
            // 
            // btnInsertFood
            // 
            this.btnInsertFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsertFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsertFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInsertFood.ForeColor = System.Drawing.Color.White;
            this.btnInsertFood.Location = new System.Drawing.Point(100, 4);
            this.btnInsertFood.Name = "btnInsertFood";
            this.btnInsertFood.Size = new System.Drawing.Size(90, 65);
            this.btnInsertFood.TabIndex = 0;
            this.btnInsertFood.Text = "Thêm";
            // 
            // btnRepairFood
            // 
            this.btnRepairFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRepairFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRepairFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRepairFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRepairFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRepairFood.ForeColor = System.Drawing.Color.White;
            this.btnRepairFood.Location = new System.Drawing.Point(196, 4);
            this.btnRepairFood.Name = "btnRepairFood";
            this.btnRepairFood.Size = new System.Drawing.Size(90, 65);
            this.btnRepairFood.TabIndex = 0;
            this.btnRepairFood.Text = "Sửa";
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteFood.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFood.Location = new System.Drawing.Point(292, 4);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(90, 65);
            this.btnDeleteFood.TabIndex = 0;
            this.btnDeleteFood.Text = "Xóa";
            // 
            // tpBill
            // 
            this.tpBill.Location = new System.Drawing.Point(4, 32);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(918, 518);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // tcManagement
            // 
            this.tcManagement.Controls.Add(this.tpBill);
            this.tcManagement.Controls.Add(this.tbFood);
            this.tcManagement.Controls.Add(this.tbCategory);
            this.tcManagement.Controls.Add(this.tbTable);
            this.tcManagement.Controls.Add(this.tbAccount);
            this.tcManagement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcManagement.Location = new System.Drawing.Point(3, 5);
            this.tcManagement.Name = "tcManagement";
            this.tcManagement.SelectedIndex = 0;
            this.tcManagement.Size = new System.Drawing.Size(926, 554);
            this.tcManagement.TabIndex = 0;
            // 
            // FormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 556);
            this.Controls.Add(this.btnBackFormManagement);
            this.Controls.Add(this.tcManagement);
            this.Name = "FormManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManagement";
            this.tbCategory.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.tbFood.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.tcManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnBackFormManagement;
        private System.Windows.Forms.TabPage tbAccount;
        private System.Windows.Forms.TabPage tbTable;
        private System.Windows.Forms.TabPage tbCategory;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCategory;
        private Guna.UI2.WinForms.Guna2Button btnRepairCategory;
        private Guna.UI2.WinForms.Guna2Button btnInsertCategory;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.TabPage tbFood;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnDeleteFood;
        private Guna.UI2.WinForms.Guna2Button btnRepairFood;
        private Guna.UI2.WinForms.Guna2Button btnInsertFood;
        private Guna.UI2.WinForms.Guna2Button btnViewCategory;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.TabControl tcManagement;
    }
}