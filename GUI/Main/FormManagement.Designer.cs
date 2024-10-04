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
            this.TabStatisticsProceeds = new System.Windows.Forms.TabPage();
            this.tcManagement = new System.Windows.Forms.TabControl();
            this.TabBillDetail = new System.Windows.Forms.TabPage();
            this.TabProduct = new System.Windows.Forms.TabPage();
            this.TabCategory = new System.Windows.Forms.TabPage();
            this.TabManagementUser = new System.Windows.Forms.TabPage();
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
            // TabStatisticsProceeds
            // 
            this.TabStatisticsProceeds.Location = new System.Drawing.Point(4, 29);
            this.TabStatisticsProceeds.Name = "TabStatisticsProceeds";
            this.TabStatisticsProceeds.Padding = new System.Windows.Forms.Padding(3);
            this.TabStatisticsProceeds.Size = new System.Drawing.Size(918, 521);
            this.TabStatisticsProceeds.TabIndex = 5;
            this.TabStatisticsProceeds.Text = "Thống kê doanh thu";
            this.TabStatisticsProceeds.UseVisualStyleBackColor = true;
            // 
            // tcManagement
            // 
            this.tcManagement.Controls.Add(this.TabStatisticsProceeds);
            this.tcManagement.Controls.Add(this.TabBillDetail);
            this.tcManagement.Controls.Add(this.TabProduct);
            this.tcManagement.Controls.Add(this.TabCategory);
            this.tcManagement.Controls.Add(this.TabManagementUser);
            this.tcManagement.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcManagement.Location = new System.Drawing.Point(3, 5);
            this.tcManagement.Name = "tcManagement";
            this.tcManagement.SelectedIndex = 0;
            this.tcManagement.Size = new System.Drawing.Size(926, 554);
            this.tcManagement.TabIndex = 0;
            // 
            // TabBillDetail
            // 
            this.TabBillDetail.Location = new System.Drawing.Point(4, 29);
            this.TabBillDetail.Name = "TabBillDetail";
            this.TabBillDetail.Padding = new System.Windows.Forms.Padding(3);
            this.TabBillDetail.Size = new System.Drawing.Size(918, 521);
            this.TabBillDetail.TabIndex = 6;
            this.TabBillDetail.Text = "Chi tiết hóa đơn";
            this.TabBillDetail.UseVisualStyleBackColor = true;
            // 
            // TabProduct
            // 
            this.TabProduct.Location = new System.Drawing.Point(4, 29);
            this.TabProduct.Name = "TabProduct";
            this.TabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.TabProduct.Size = new System.Drawing.Size(918, 521);
            this.TabProduct.TabIndex = 7;
            this.TabProduct.Text = "Sản phẩm";
            this.TabProduct.UseVisualStyleBackColor = true;
            // 
            // TabCategory
            // 
            this.TabCategory.Location = new System.Drawing.Point(4, 29);
            this.TabCategory.Name = "TabCategory";
            this.TabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.TabCategory.Size = new System.Drawing.Size(918, 521);
            this.TabCategory.TabIndex = 8;
            this.TabCategory.Text = "Loại sản phẩm";
            this.TabCategory.UseVisualStyleBackColor = true;
            // 
            // TabManagementUser
            // 
            this.TabManagementUser.Location = new System.Drawing.Point(4, 29);
            this.TabManagementUser.Name = "TabManagementUser";
            this.TabManagementUser.Padding = new System.Windows.Forms.Padding(3);
            this.TabManagementUser.Size = new System.Drawing.Size(918, 521);
            this.TabManagementUser.TabIndex = 9;
            this.TabManagementUser.Text = "Quản lý tài khoản";
            this.TabManagementUser.UseVisualStyleBackColor = true;
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
            this.tcManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBackFormManagement;
        private System.Windows.Forms.TabPage TabStatisticsProceeds;
        private System.Windows.Forms.TabControl tcManagement;
        private System.Windows.Forms.TabPage TabBillDetail;
        private System.Windows.Forms.TabPage TabProduct;
        private System.Windows.Forms.TabPage TabCategory;
        private System.Windows.Forms.TabPage TabManagementUser;
    }
}