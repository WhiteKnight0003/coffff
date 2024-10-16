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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnBackFormManagement = new Guna.UI2.WinForms.Guna2Button();
            this.TabStatisticsProceeds = new System.Windows.Forms.TabPage();
            this.cbChooseYear = new System.Windows.Forms.ComboBox();
            this.chartStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tcManagement = new System.Windows.Forms.TabControl();
            this.TabBillDetail = new System.Windows.Forms.TabPage();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dgvBillDetails = new System.Windows.Forms.DataGridView();
            this.TabProduct = new System.Windows.Forms.TabPage();
            this.btnSaveProductImage = new Guna.UI2.WinForms.Guna2Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.pbImageProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnChooseImageProduct = new Guna.UI2.WinForms.Guna2Button();
            this.cbbProductCategory = new System.Windows.Forms.ComboBox();
            this.nmProductPrice = new System.Windows.Forms.NumericUpDown();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtSearchProductName = new System.Windows.Forms.TextBox();
            this.dtgvProduct = new System.Windows.Forms.DataGridView();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.TabCategory = new System.Windows.Forms.TabPage();
            this.TabManagementUser = new System.Windows.Forms.TabPage();
            this.TabStatisticsProceeds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).BeginInit();
            this.tcManagement.SuspendLayout();
            this.TabBillDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
            this.TabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).BeginInit();
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
            this.btnBackFormManagement.Location = new System.Drawing.Point(548, 4);
            this.btnBackFormManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackFormManagement.Name = "btnBackFormManagement";
            this.btnBackFormManagement.Size = new System.Drawing.Size(149, 21);
            this.btnBackFormManagement.TabIndex = 1;
            this.btnBackFormManagement.Text = "Về trang bán hàng";
            this.btnBackFormManagement.Click += new System.EventHandler(this.btnBackFormManagement_Click);
            // 
            // TabStatisticsProceeds
            // 
            this.TabStatisticsProceeds.Controls.Add(this.cbChooseYear);
            this.TabStatisticsProceeds.Controls.Add(this.chartStatistic);
            this.TabStatisticsProceeds.Location = new System.Drawing.Point(4, 26);
            this.TabStatisticsProceeds.Margin = new System.Windows.Forms.Padding(2);
            this.TabStatisticsProceeds.Name = "TabStatisticsProceeds";
            this.TabStatisticsProceeds.Padding = new System.Windows.Forms.Padding(2);
            this.TabStatisticsProceeds.Size = new System.Drawing.Size(686, 420);
            this.TabStatisticsProceeds.TabIndex = 5;
            this.TabStatisticsProceeds.Text = "Thống kê doanh thu";
            this.TabStatisticsProceeds.UseVisualStyleBackColor = true;
            // 
            // cbChooseYear
            // 
            this.cbChooseYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbChooseYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbChooseYear.DropDownHeight = 250;
            this.cbChooseYear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChooseYear.FormattingEnabled = true;
            this.cbChooseYear.IntegralHeight = false;
            this.cbChooseYear.Location = new System.Drawing.Point(553, 79);
            this.cbChooseYear.Margin = new System.Windows.Forms.Padding(2);
            this.cbChooseYear.MaxDropDownItems = 10;
            this.cbChooseYear.Name = "cbChooseYear";
            this.cbChooseYear.Size = new System.Drawing.Size(119, 28);
            this.cbChooseYear.TabIndex = 1;
            this.cbChooseYear.Text = "Chọn Năm";
            this.cbChooseYear.SelectedIndexChanged += new System.EventHandler(this.cbChooseYear_SelectedIndexChanged);
            // 
            // chartStatistic
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.Title = "Tháng";
            chartArea1.AxisY.Title = "Doanh thu";
            chartArea1.Name = "ChartArea1";
            this.chartStatistic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistic.Legends.Add(legend1);
            this.chartStatistic.Location = new System.Drawing.Point(0, 5);
            this.chartStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.chartStatistic.Name = "chartStatistic";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "DataSeries";
            this.chartStatistic.Series.Add(series1);
            this.chartStatistic.Size = new System.Drawing.Size(529, 414);
            this.chartStatistic.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Biểu đồ thông kê doanh thu theo năm";
            this.chartStatistic.Titles.Add(title1);
            // 
            // tcManagement
            // 
            this.tcManagement.Controls.Add(this.TabStatisticsProceeds);
            this.tcManagement.Controls.Add(this.TabBillDetail);
            this.tcManagement.Controls.Add(this.TabProduct);
            this.tcManagement.Controls.Add(this.TabCategory);
            this.tcManagement.Controls.Add(this.TabManagementUser);
            this.tcManagement.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcManagement.Location = new System.Drawing.Point(2, 4);
            this.tcManagement.Margin = new System.Windows.Forms.Padding(2);
            this.tcManagement.Name = "tcManagement";
            this.tcManagement.SelectedIndex = 0;
            this.tcManagement.Size = new System.Drawing.Size(694, 450);
            this.tcManagement.TabIndex = 0;
            this.tcManagement.Click += new System.EventHandler(this.tcManagement_Click);
            // 
            // TabBillDetail
            // 
            this.TabBillDetail.Controls.Add(this.lblPageNumber);
            this.TabBillDetail.Controls.Add(this.btnLast);
            this.TabBillDetail.Controls.Add(this.btnNext);
            this.TabBillDetail.Controls.Add(this.btnPrevious);
            this.TabBillDetail.Controls.Add(this.btnFirst);
            this.TabBillDetail.Controls.Add(this.dgvBillDetails);
            this.TabBillDetail.Location = new System.Drawing.Point(4, 26);
            this.TabBillDetail.Margin = new System.Windows.Forms.Padding(2);
            this.TabBillDetail.Name = "TabBillDetail";
            this.TabBillDetail.Padding = new System.Windows.Forms.Padding(2);
            this.TabBillDetail.Size = new System.Drawing.Size(686, 420);
            this.TabBillDetail.TabIndex = 6;
            this.TabBillDetail.Text = "Chi tiết hóa đơn";
            this.TabBillDetail.UseVisualStyleBackColor = true;
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(500, 388);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(47, 17);
            this.lblPageNumber.TabIndex = 6;
            this.lblPageNumber.Text = "label1";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(357, 378);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(91, 37);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(239, 378);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 37);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(121, 378);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(91, 37);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(3, 378);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(91, 37);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // dgvBillDetails
            // 
            this.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetails.Location = new System.Drawing.Point(3, 5);
            this.dgvBillDetails.Name = "dgvBillDetails";
            this.dgvBillDetails.Size = new System.Drawing.Size(682, 371);
            this.dgvBillDetails.TabIndex = 1;
            this.dgvBillDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBillDetails_CellFormatting);
            // 
            // TabProduct
            // 
            this.TabProduct.Controls.Add(this.btnSaveProductImage);
            this.TabProduct.Controls.Add(this.txtProductID);
            this.TabProduct.Controls.Add(this.lblProductID);
            this.TabProduct.Controls.Add(this.pbImageProduct);
            this.TabProduct.Controls.Add(this.btnChooseImageProduct);
            this.TabProduct.Controls.Add(this.cbbProductCategory);
            this.TabProduct.Controls.Add(this.nmProductPrice);
            this.TabProduct.Controls.Add(this.txtProductName);
            this.TabProduct.Controls.Add(this.lblProductPrice);
            this.TabProduct.Controls.Add(this.lblProductCategory);
            this.TabProduct.Controls.Add(this.lblProductName);
            this.TabProduct.Controls.Add(this.txtSearchProductName);
            this.TabProduct.Controls.Add(this.dtgvProduct);
            this.TabProduct.Controls.Add(this.btnSearchProduct);
            this.TabProduct.Controls.Add(this.btnViewProduct);
            this.TabProduct.Controls.Add(this.btnEditProduct);
            this.TabProduct.Controls.Add(this.btnDeleteProduct);
            this.TabProduct.Controls.Add(this.btnAddProduct);
            this.TabProduct.Location = new System.Drawing.Point(4, 26);
            this.TabProduct.Margin = new System.Windows.Forms.Padding(2);
            this.TabProduct.Name = "TabProduct";
            this.TabProduct.Padding = new System.Windows.Forms.Padding(2);
            this.TabProduct.Size = new System.Drawing.Size(686, 420);
            this.TabProduct.TabIndex = 7;
            this.TabProduct.Text = "Sản phẩm";
            this.TabProduct.UseVisualStyleBackColor = true;
            // 
            // btnSaveProductImage
            // 
            this.btnSaveProductImage.BackColor = System.Drawing.Color.LightCyan;
            this.btnSaveProductImage.BorderColor = System.Drawing.Color.Transparent;
            this.btnSaveProductImage.BorderThickness = 2;
            this.btnSaveProductImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveProductImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveProductImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveProductImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveProductImage.Enabled = false;
            this.btnSaveProductImage.FillColor = System.Drawing.Color.Transparent;
            this.btnSaveProductImage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveProductImage.ForeColor = System.Drawing.Color.Black;
            this.btnSaveProductImage.Location = new System.Drawing.Point(412, 171);
            this.btnSaveProductImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveProductImage.Name = "btnSaveProductImage";
            this.btnSaveProductImage.Size = new System.Drawing.Size(122, 37);
            this.btnSaveProductImage.TabIndex = 35;
            this.btnSaveProductImage.Text = "Lưu ảnh";
            this.btnSaveProductImage.Click += new System.EventHandler(this.btnSaveProductImage_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(500, 251);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(183, 24);
            this.txtProductID.TabIndex = 34;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(414, 254);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(30, 17);
            this.lblProductID.TabIndex = 33;
            this.lblProductID.Text = "ID:";
            // 
            // pbImageProduct
            // 
            this.pbImageProduct.ImageRotate = 0F;
            this.pbImageProduct.Location = new System.Drawing.Point(412, 52);
            this.pbImageProduct.Margin = new System.Windows.Forms.Padding(2);
            this.pbImageProduct.Name = "pbImageProduct";
            this.pbImageProduct.Size = new System.Drawing.Size(265, 115);
            this.pbImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageProduct.TabIndex = 32;
            this.pbImageProduct.TabStop = false;
            // 
            // btnChooseImageProduct
            // 
            this.btnChooseImageProduct.BackColor = System.Drawing.Color.LightCyan;
            this.btnChooseImageProduct.BorderColor = System.Drawing.Color.Transparent;
            this.btnChooseImageProduct.BorderThickness = 2;
            this.btnChooseImageProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseImageProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseImageProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChooseImageProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChooseImageProduct.FillColor = System.Drawing.Color.Transparent;
            this.btnChooseImageProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnChooseImageProduct.ForeColor = System.Drawing.Color.Black;
            this.btnChooseImageProduct.Location = new System.Drawing.Point(555, 171);
            this.btnChooseImageProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseImageProduct.Name = "btnChooseImageProduct";
            this.btnChooseImageProduct.Size = new System.Drawing.Size(122, 37);
            this.btnChooseImageProduct.TabIndex = 31;
            this.btnChooseImageProduct.Text = "Thay đổi ảnh";
            this.btnChooseImageProduct.Click += new System.EventHandler(this.btnChooseImageProduct_Click);
            // 
            // cbbProductCategory
            // 
            this.cbbProductCategory.FormattingEnabled = true;
            this.cbbProductCategory.Location = new System.Drawing.Point(498, 344);
            this.cbbProductCategory.Name = "cbbProductCategory";
            this.cbbProductCategory.Size = new System.Drawing.Size(182, 25);
            this.cbbProductCategory.TabIndex = 14;
            // 
            // nmProductPrice
            // 
            this.nmProductPrice.Location = new System.Drawing.Point(498, 390);
            this.nmProductPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmProductPrice.Name = "nmProductPrice";
            this.nmProductPrice.Size = new System.Drawing.Size(183, 24);
            this.nmProductPrice.TabIndex = 13;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(500, 296);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(183, 24);
            this.txtProductName.TabIndex = 11;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(414, 392);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(35, 17);
            this.lblProductPrice.TabIndex = 10;
            this.lblProductPrice.Text = "Giá:";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(414, 347);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(78, 17);
            this.lblProductCategory.TabIndex = 9;
            this.lblProductCategory.Text = "Danh mục:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(414, 299);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(71, 17);
            this.lblProductName.TabIndex = 8;
            this.lblProductName.Text = "Tên món:";
            // 
            // txtSearchProductName
            // 
            this.txtSearchProductName.Location = new System.Drawing.Point(412, 14);
            this.txtSearchProductName.Name = "txtSearchProductName";
            this.txtSearchProductName.Size = new System.Drawing.Size(192, 24);
            this.txtSearchProductName.TabIndex = 6;
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduct.Location = new System.Drawing.Point(7, 52);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.Size = new System.Drawing.Size(358, 363);
            this.dtgvProduct.TabIndex = 5;
            this.dtgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProduct_CellClick);
            this.dtgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProduct_CellContentClick);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(610, 5);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(71, 40);
            this.btnSearchProduct.TabIndex = 4;
            this.btnSearchProduct.Text = "Tìm";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.Location = new System.Drawing.Point(294, 6);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(71, 40);
            this.btnViewProduct.TabIndex = 3;
            this.btnViewProduct.Text = "Xem";
            this.btnViewProduct.UseVisualStyleBackColor = true;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(198, 6);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(71, 40);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.Text = "Sửa";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(102, 5);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(71, 40);
            this.btnDeleteProduct.TabIndex = 1;
            this.btnDeleteProduct.Text = "Xóa";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(6, 5);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(71, 40);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // TabCategory
            // 
            this.TabCategory.Location = new System.Drawing.Point(4, 26);
            this.TabCategory.Margin = new System.Windows.Forms.Padding(2);
            this.TabCategory.Name = "TabCategory";
            this.TabCategory.Padding = new System.Windows.Forms.Padding(2);
            this.TabCategory.Size = new System.Drawing.Size(686, 420);
            this.TabCategory.TabIndex = 8;
            this.TabCategory.Text = "Loại sản phẩm";
            this.TabCategory.UseVisualStyleBackColor = true;
            // 
            // TabManagementUser
            // 
            this.TabManagementUser.Location = new System.Drawing.Point(4, 26);
            this.TabManagementUser.Margin = new System.Windows.Forms.Padding(2);
            this.TabManagementUser.Name = "TabManagementUser";
            this.TabManagementUser.Padding = new System.Windows.Forms.Padding(2);
            this.TabManagementUser.Size = new System.Drawing.Size(686, 420);
            this.TabManagementUser.TabIndex = 9;
            this.TabManagementUser.Text = "Quản lý tài khoản";
            this.TabManagementUser.UseVisualStyleBackColor = true;
            // 
            // FormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 452);
            this.Controls.Add(this.btnBackFormManagement);
            this.Controls.Add(this.tcManagement);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManagement";
            this.TabStatisticsProceeds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).EndInit();
            this.tcManagement.ResumeLayout(false);
            this.TabBillDetail.ResumeLayout(false);
            this.TabBillDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).EndInit();
            this.TabProduct.ResumeLayout(false);
            this.TabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistic;
        private System.Windows.Forms.ComboBox cbChooseYear;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dtgvProduct;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtSearchProductName;
        private System.Windows.Forms.ComboBox cbbProductCategory;
        private System.Windows.Forms.NumericUpDown nmProductPrice;
        private System.Windows.Forms.DataGridView dgvBillDetails;
        private Guna.UI2.WinForms.Guna2PictureBox pbImageProduct;
        private Guna.UI2.WinForms.Guna2Button btnChooseImageProduct;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private Guna.UI2.WinForms.Guna2Button btnSaveProductImage;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblPageNumber;
    }
}