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
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dgvBillDetails = new System.Windows.Forms.DataGridView();
            this.TabProduct = new System.Windows.Forms.TabPage();
            this.nmProductPrice = new System.Windows.Forms.NumericUpDown();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.cbbProductCategory = new System.Windows.Forms.ComboBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblIDProduct = new System.Windows.Forms.Label();
            this.txtSearchProductName = new System.Windows.Forms.TextBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.dtgvProduct = new System.Windows.Forms.DataGridView();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.TabCategory = new System.Windows.Forms.TabPage();
            this.TabManagementUser = new System.Windows.Forms.TabPage();
            this.tcManagement.SuspendLayout();
            this.TabBillDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
            this.TabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
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
            this.btnBackFormManagement.Location = new System.Drawing.Point(731, 5);
            this.btnBackFormManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackFormManagement.Name = "btnBackFormManagement";
            this.btnBackFormManagement.Size = new System.Drawing.Size(199, 26);
            this.btnBackFormManagement.TabIndex = 1;
            this.btnBackFormManagement.Text = "Về trang bán hàng";
            this.btnBackFormManagement.Click += new System.EventHandler(this.btnBackFormManagement_Click);
            // 
            // TabStatisticsProceeds
            // 
            this.TabStatisticsProceeds.Location = new System.Drawing.Point(4, 26);
            this.TabStatisticsProceeds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabStatisticsProceeds.Name = "TabStatisticsProceeds";
            this.TabStatisticsProceeds.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabStatisticsProceeds.Size = new System.Drawing.Size(917, 524);
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
            this.tcManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcManagement.Name = "tcManagement";
            this.tcManagement.SelectedIndex = 0;
            this.tcManagement.Size = new System.Drawing.Size(925, 554);
            this.tcManagement.TabIndex = 0;
            // 
            // TabBillDetail
            // 
            this.TabBillDetail.Controls.Add(this.btnViewBill);
            this.TabBillDetail.Controls.Add(this.dgvBillDetails);
            this.TabBillDetail.Location = new System.Drawing.Point(4, 26);
            this.TabBillDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabBillDetail.Name = "TabBillDetail";
            this.TabBillDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabBillDetail.Size = new System.Drawing.Size(917, 524);
            this.TabBillDetail.TabIndex = 6;
            this.TabBillDetail.Text = "Chi tiết hóa đơn";
            this.TabBillDetail.UseVisualStyleBackColor = true;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(392, 6);
            this.btnViewBill.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(123, 46);
            this.btnViewBill.TabIndex = 1;
            this.btnViewBill.Text = "Xem";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dgvBillDetails
            // 
            this.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetails.Location = new System.Drawing.Point(8, 59);
            this.dgvBillDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBillDetails.Name = "dgvBillDetails";
            this.dgvBillDetails.Size = new System.Drawing.Size(893, 446);
            this.dgvBillDetails.TabIndex = 0;
            this.dgvBillDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillDetails_CellContentClick);
            // 
            // TabProduct
            // 
            this.TabProduct.Controls.Add(this.nmProductPrice);
            this.TabProduct.Controls.Add(this.txtProductName);
            this.TabProduct.Controls.Add(this.txtProductID);
            this.TabProduct.Controls.Add(this.cbbProductCategory);
            this.TabProduct.Controls.Add(this.lblProductPrice);
            this.TabProduct.Controls.Add(this.lblProductCategory);
            this.TabProduct.Controls.Add(this.lblProductName);
            this.TabProduct.Controls.Add(this.lblIDProduct);
            this.TabProduct.Controls.Add(this.txtSearchProductName);
            this.TabProduct.Controls.Add(this.btnSearchProduct);
            this.TabProduct.Controls.Add(this.dtgvProduct);
            this.TabProduct.Controls.Add(this.btnViewProduct);
            this.TabProduct.Controls.Add(this.btnEditProduct);
            this.TabProduct.Controls.Add(this.btnDeleteProduct);
            this.TabProduct.Controls.Add(this.btnAddProduct);
            this.TabProduct.Location = new System.Drawing.Point(4, 26);
            this.TabProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabProduct.Name = "TabProduct";
            this.TabProduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabProduct.Size = new System.Drawing.Size(917, 524);
            this.TabProduct.TabIndex = 7;
            this.TabProduct.Text = "Sản phẩm";
            this.TabProduct.UseVisualStyleBackColor = true;
            this.TabProduct.Click += new System.EventHandler(this.TabProduct_Click);
            // 
            // nmProductPrice
            // 
            this.nmProductPrice.Location = new System.Drawing.Point(651, 268);
            this.nmProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nmProductPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmProductPrice.Name = "nmProductPrice";
            this.nmProductPrice.Size = new System.Drawing.Size(251, 24);
            this.nmProductPrice.TabIndex = 14;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(651, 135);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(249, 24);
            this.txtProductName.TabIndex = 13;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(651, 68);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(249, 24);
            this.txtProductID.TabIndex = 12;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // cbbProductCategory
            // 
            this.cbbProductCategory.FormattingEnabled = true;
            this.cbbProductCategory.Location = new System.Drawing.Point(651, 203);
            this.cbbProductCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbbProductCategory.Name = "cbbProductCategory";
            this.cbbProductCategory.Size = new System.Drawing.Size(249, 25);
            this.cbbProductCategory.TabIndex = 11;
            this.cbbProductCategory.Click += new System.EventHandler(this.cbbProductCategory_Click);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(539, 271);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(35, 17);
            this.lblProductPrice.TabIndex = 10;
            this.lblProductPrice.Text = "Giá:";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(539, 203);
            this.lblProductCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(78, 17);
            this.lblProductCategory.TabIndex = 9;
            this.lblProductCategory.Text = "Danh mục:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(539, 135);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(71, 17);
            this.lblProductName.TabIndex = 8;
            this.lblProductName.Text = "Tên món:";
            // 
            // lblIDProduct
            // 
            this.lblIDProduct.AutoSize = true;
            this.lblIDProduct.Location = new System.Drawing.Point(539, 68);
            this.lblIDProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDProduct.Name = "lblIDProduct";
            this.lblIDProduct.Size = new System.Drawing.Size(30, 17);
            this.lblIDProduct.TabIndex = 7;
            this.lblIDProduct.Text = "ID:";
            // 
            // txtSearchProductName
            // 
            this.txtSearchProductName.Location = new System.Drawing.Point(543, 12);
            this.txtSearchProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchProductName.Name = "txtSearchProductName";
            this.txtSearchProductName.Size = new System.Drawing.Size(253, 24);
            this.txtSearchProductName.TabIndex = 6;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(805, 6);
            this.btnSearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(103, 41);
            this.btnSearchProduct.TabIndex = 5;
            this.btnSearchProduct.Text = "Tìm";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.AllowUserToOrderColumns = true;
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduct.Location = new System.Drawing.Point(8, 68);
            this.dtgvProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.Size = new System.Drawing.Size(481, 428);
            this.dtgvProduct.TabIndex = 4;
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.Location = new System.Drawing.Point(384, 6);
            this.btnViewProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(103, 41);
            this.btnViewProduct.TabIndex = 3;
            this.btnViewProduct.Text = "Xem";
            this.btnViewProduct.UseVisualStyleBackColor = true;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(259, 6);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(103, 41);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.Text = "Sửa";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(133, 6);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(103, 41);
            this.btnDeleteProduct.TabIndex = 1;
            this.btnDeleteProduct.Text = "Xóa";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(8, 6);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(103, 41);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // TabCategory
            // 
            this.TabCategory.Location = new System.Drawing.Point(4, 26);
            this.TabCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabCategory.Name = "TabCategory";
            this.TabCategory.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabCategory.Size = new System.Drawing.Size(917, 524);
            this.TabCategory.TabIndex = 8;
            this.TabCategory.Text = "Loại sản phẩm";
            this.TabCategory.UseVisualStyleBackColor = true;
            // 
            // TabManagementUser
            // 
            this.TabManagementUser.Location = new System.Drawing.Point(4, 26);
            this.TabManagementUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabManagementUser.Name = "TabManagementUser";
            this.TabManagementUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabManagementUser.Size = new System.Drawing.Size(917, 524);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManagement";
            this.tcManagement.ResumeLayout(false);
            this.TabBillDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).EndInit();
            this.TabProduct.ResumeLayout(false);
            this.TabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
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
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dtgvProduct;
        private System.Windows.Forms.TextBox txtSearchProductName;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblIDProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.ComboBox cbbProductCategory;
        private System.Windows.Forms.NumericUpDown nmProductPrice;
        private System.Windows.Forms.DataGridView dgvBillDetails;
        private System.Windows.Forms.Button btnViewBill;
    }
}