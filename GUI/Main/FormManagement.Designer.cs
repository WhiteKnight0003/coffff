﻿using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLoai_Category = new System.Windows.Forms.TextBox();
            this.txtID_Category = new System.Windows.Forms.TextBox();
            this.richTextBoxMT = new System.Windows.Forms.RichTextBox();
            this.btnHuy_Category = new System.Windows.Forms.Button();
            this.btnXoa_Category = new System.Windows.Forms.Button();
            this.btnSua_Category = new System.Windows.Forms.Button();
            this.btnThem_Category = new System.Windows.Forms.Button();
            this.btnLuu_Category = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.TabManagementUser = new System.Windows.Forms.TabPage();
            this.panel = new System.Windows.Forms.Panel();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnXoa_Acc = new System.Windows.Forms.Button();
            this.btnSua_Acc = new System.Windows.Forms.Button();
            this.btnHuy_Acc = new System.Windows.Forms.Button();
            this.btnLuu_Acc = new System.Windows.Forms.Button();
            this.btnThem_Acc = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtTenHT = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTim_Acc = new System.Windows.Forms.Button();
            this.txtTimAcc = new System.Windows.Forms.TextBox();
            this.TabStatisticsProceeds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).BeginInit();
            this.tcManagement.SuspendLayout();
            this.TabBillDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
            this.TabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            this.TabCategory.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.panel2.SuspendLayout();
            this.TabManagementUser.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            this.btnBackFormManagement.Location = new System.Drawing.Point(821, 6);
            this.btnBackFormManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBackFormManagement.Name = "btnBackFormManagement";
            this.btnBackFormManagement.Size = new System.Drawing.Size(224, 32);
            this.btnBackFormManagement.TabIndex = 1;
            this.btnBackFormManagement.Text = "Về trang bán hàng";
            this.btnBackFormManagement.Click += new System.EventHandler(this.btnBackFormManagement_Click);
            // 
            // TabStatisticsProceeds
            // 
            this.TabStatisticsProceeds.Controls.Add(this.cbChooseYear);
            this.TabStatisticsProceeds.Controls.Add(this.chartStatistic);
            this.TabStatisticsProceeds.Location = new System.Drawing.Point(4, 34);
            this.TabStatisticsProceeds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabStatisticsProceeds.Name = "TabStatisticsProceeds";
            this.TabStatisticsProceeds.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabStatisticsProceeds.Size = new System.Drawing.Size(1034, 654);
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
            this.cbChooseYear.Location = new System.Drawing.Point(829, 121);
            this.cbChooseYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbChooseYear.MaxDropDownItems = 10;
            this.cbChooseYear.Name = "cbChooseYear";
            this.cbChooseYear.Size = new System.Drawing.Size(176, 40);
            this.cbChooseYear.TabIndex = 1;
            this.cbChooseYear.Text = "Chọn Năm";
            this.cbChooseYear.SelectedIndexChanged += new System.EventHandler(this.cbChooseYear_SelectedIndexChanged);
            // 
            // chartStatistic
            // 
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.Title = "Tháng";
            chartArea2.AxisY.Title = "Doanh thu";
            chartArea2.Name = "ChartArea1";
            this.chartStatistic.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStatistic.Legends.Add(legend2);
            this.chartStatistic.Location = new System.Drawing.Point(0, 8);
            this.chartStatistic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartStatistic.Name = "chartStatistic";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "DataSeries";
            this.chartStatistic.Series.Add(series2);
            this.chartStatistic.Size = new System.Drawing.Size(793, 636);
            this.chartStatistic.TabIndex = 0;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Biểu đồ thông kê doanh thu theo năm";
            this.chartStatistic.Titles.Add(title2);
            // 
            // tcManagement
            // 
            this.tcManagement.Controls.Add(this.TabStatisticsProceeds);
            this.tcManagement.Controls.Add(this.TabBillDetail);
            this.tcManagement.Controls.Add(this.TabProduct);
            this.tcManagement.Controls.Add(this.TabCategory);
            this.tcManagement.Controls.Add(this.TabManagementUser);
            this.tcManagement.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcManagement.Location = new System.Drawing.Point(3, 6);
            this.tcManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcManagement.Name = "tcManagement";
            this.tcManagement.SelectedIndex = 0;
            this.tcManagement.Size = new System.Drawing.Size(1042, 692);
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
            this.TabBillDetail.Location = new System.Drawing.Point(4, 34);
            this.TabBillDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabBillDetail.Name = "TabBillDetail";
            this.TabBillDetail.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabBillDetail.Size = new System.Drawing.Size(1034, 654);
            this.TabBillDetail.TabIndex = 6;
            this.TabBillDetail.Text = "Chi tiết hóa đơn";
            this.TabBillDetail.UseVisualStyleBackColor = true;
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(500, 388);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(68, 25);
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
            this.dgvBillDetails.RowHeadersWidth = 62;
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
            this.TabProduct.Location = new System.Drawing.Point(4, 34);
            this.TabProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabProduct.Name = "TabProduct";
            this.TabProduct.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabProduct.Size = new System.Drawing.Size(1034, 654);
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
            this.txtProductID.Size = new System.Drawing.Size(183, 32);
            this.txtProductID.TabIndex = 34;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(414, 254);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(44, 25);
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
            this.cbbProductCategory.Size = new System.Drawing.Size(182, 33);
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
            this.nmProductPrice.Size = new System.Drawing.Size(183, 32);
            this.nmProductPrice.TabIndex = 13;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(500, 296);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(183, 32);
            this.txtProductName.TabIndex = 11;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(414, 392);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(53, 25);
            this.lblProductPrice.TabIndex = 10;
            this.lblProductPrice.Text = "Giá:";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(414, 347);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(116, 25);
            this.lblProductCategory.TabIndex = 9;
            this.lblProductCategory.Text = "Danh mục:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(414, 299);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(103, 25);
            this.lblProductName.TabIndex = 8;
            this.lblProductName.Text = "Tên món:";
            // 
            // txtSearchProductName
            // 
            this.txtSearchProductName.Location = new System.Drawing.Point(412, 14);
            this.txtSearchProductName.Name = "txtSearchProductName";
            this.txtSearchProductName.Size = new System.Drawing.Size(192, 32);
            this.txtSearchProductName.TabIndex = 6;
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduct.Location = new System.Drawing.Point(7, 52);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.RowHeadersWidth = 62;
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
            this.TabCategory.Controls.Add(this.panel3);
            this.TabCategory.Controls.Add(this.panel2);
            this.TabCategory.Location = new System.Drawing.Point(4, 34);
            this.TabCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabCategory.Name = "TabCategory";
            this.TabCategory.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabCategory.Size = new System.Drawing.Size(1034, 654);
            this.TabCategory.TabIndex = 8;
            this.TabCategory.Text = "Loại sản phẩm";
            this.TabCategory.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvCategory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(572, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 646);
            this.panel3.TabIndex = 1;
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(6, 58);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 62;
            this.dgvCategory.RowTemplate.Height = 28;
            this.dgvCategory.Size = new System.Drawing.Size(444, 341);
            this.dgvCategory.TabIndex = 0;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtLoai_Category);
            this.panel2.Controls.Add(this.txtID_Category);
            this.panel2.Controls.Add(this.richTextBoxMT);
            this.panel2.Controls.Add(this.btnHuy_Category);
            this.panel2.Controls.Add(this.btnXoa_Category);
            this.panel2.Controls.Add(this.btnSua_Category);
            this.panel2.Controls.Add(this.btnThem_Category);
            this.panel2.Controls.Add(this.btnLuu_Category);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 646);
            this.panel2.TabIndex = 0;
            // 
            // txtLoai_Category
            // 
            this.txtLoai_Category.Location = new System.Drawing.Point(171, 131);
            this.txtLoai_Category.Name = "txtLoai_Category";
            this.txtLoai_Category.Size = new System.Drawing.Size(291, 32);
            this.txtLoai_Category.TabIndex = 3;
            // 
            // txtID_Category
            // 
            this.txtID_Category.Location = new System.Drawing.Point(171, 58);
            this.txtID_Category.Name = "txtID_Category";
            this.txtID_Category.Size = new System.Drawing.Size(291, 32);
            this.txtID_Category.TabIndex = 3;
            // 
            // richTextBoxMT
            // 
            this.richTextBoxMT.Location = new System.Drawing.Point(171, 202);
            this.richTextBoxMT.Name = "richTextBoxMT";
            this.richTextBoxMT.Size = new System.Drawing.Size(291, 170);
            this.richTextBoxMT.TabIndex = 2;
            this.richTextBoxMT.Text = "";
            // 
            // btnHuy_Category
            // 
            this.btnHuy_Category.Location = new System.Drawing.Point(226, 545);
            this.btnHuy_Category.Name = "btnHuy_Category";
            this.btnHuy_Category.Size = new System.Drawing.Size(101, 54);
            this.btnHuy_Category.TabIndex = 1;
            this.btnHuy_Category.Text = "Hủy";
            this.btnHuy_Category.UseVisualStyleBackColor = true;
            this.btnHuy_Category.Click += new System.EventHandler(this.btnReset_Category_Click);
            // 
            // btnXoa_Category
            // 
            this.btnXoa_Category.Location = new System.Drawing.Point(427, 454);
            this.btnXoa_Category.Name = "btnXoa_Category";
            this.btnXoa_Category.Size = new System.Drawing.Size(101, 54);
            this.btnXoa_Category.TabIndex = 1;
            this.btnXoa_Category.Text = "Xóa";
            this.btnXoa_Category.UseVisualStyleBackColor = true;
            this.btnXoa_Category.Click += new System.EventHandler(this.btnXoa_Category_Click);
            // 
            // btnSua_Category
            // 
            this.btnSua_Category.Location = new System.Drawing.Point(291, 454);
            this.btnSua_Category.Name = "btnSua_Category";
            this.btnSua_Category.Size = new System.Drawing.Size(101, 54);
            this.btnSua_Category.TabIndex = 1;
            this.btnSua_Category.Text = "Sửa";
            this.btnSua_Category.UseVisualStyleBackColor = true;
            this.btnSua_Category.Click += new System.EventHandler(this.btnSua__Category_Click);
            // 
            // btnThem_Category
            // 
            this.btnThem_Category.Location = new System.Drawing.Point(159, 454);
            this.btnThem_Category.Name = "btnThem_Category";
            this.btnThem_Category.Size = new System.Drawing.Size(101, 54);
            this.btnThem_Category.TabIndex = 1;
            this.btnThem_Category.Text = "Thêm";
            this.btnThem_Category.UseVisualStyleBackColor = true;
            this.btnThem_Category.Click += new System.EventHandler(this.btnAdd_Category_Click);
            // 
            // btnLuu_Category
            // 
            this.btnLuu_Category.Location = new System.Drawing.Point(25, 454);
            this.btnLuu_Category.Name = "btnLuu_Category";
            this.btnLuu_Category.Size = new System.Drawing.Size(101, 54);
            this.btnLuu_Category.TabIndex = 1;
            this.btnLuu_Category.Text = "Lưu";
            this.btnLuu_Category.UseVisualStyleBackColor = true;
            this.btnLuu_Category.Click += new System.EventHandler(this.btnSua__Category_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(71, 61);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 25);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // TabManagementUser
            // 
            this.TabManagementUser.Controls.Add(this.panel);
            this.TabManagementUser.Controls.Add(this.panel1);
            this.TabManagementUser.Location = new System.Drawing.Point(4, 34);
            this.TabManagementUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabManagementUser.Name = "TabManagementUser";
            this.TabManagementUser.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabManagementUser.Size = new System.Drawing.Size(1034, 654);
            this.TabManagementUser.TabIndex = 9;
            this.TabManagementUser.Text = "Quản lý tài khoản";
            this.TabManagementUser.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.rdNu);
            this.panel.Controls.Add(this.rdNam);
            this.panel.Controls.Add(this.dtpStartDate);
            this.panel.Controls.Add(this.cbType);
            this.panel.Controls.Add(this.btnXoa_Acc);
            this.panel.Controls.Add(this.btnSua_Acc);
            this.panel.Controls.Add(this.btnTim_Acc);
            this.panel.Controls.Add(this.btnHuy_Acc);
            this.panel.Controls.Add(this.btnLuu_Acc);
            this.panel.Controls.Add(this.btnThem_Acc);
            this.panel.Controls.Add(this.lblRole);
            this.panel.Controls.Add(this.lblPhoneNumber);
            this.panel.Controls.Add(this.lblFullName);
            this.panel.Controls.Add(this.lblGender);
            this.panel.Controls.Add(this.lblEmail);
            this.panel.Controls.Add(this.lblStartDate);
            this.panel.Controls.Add(this.lblAddress);
            this.panel.Controls.Add(this.lblMK);
            this.panel.Controls.Add(this.lblAccountName);
            this.panel.Controls.Add(this.txtTimAcc);
            this.panel.Controls.Add(this.txtEmail);
            this.panel.Controls.Add(this.txtPhoneNumber);
            this.panel.Controls.Add(this.txtTenHT);
            this.panel.Controls.Add(this.txtAddress);
            this.panel.Controls.Add(this.txtMK);
            this.panel.Controls.Add(this.txtTenTK);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(3, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1028, 427);
            this.panel.TabIndex = 2;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(289, 223);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(66, 29);
            this.rdNu.TabIndex = 5;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(179, 225);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(82, 29);
            this.rdNam.TabIndex = 5;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(726, 227);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(158, 32);
            this.dtpStartDate.TabIndex = 4;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(726, 163);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(158, 33);
            this.cbType.TabIndex = 3;
            // 
            // btnXoa_Acc
            // 
            this.btnXoa_Acc.Location = new System.Drawing.Point(428, 355);
            this.btnXoa_Acc.Name = "btnXoa_Acc";
            this.btnXoa_Acc.Size = new System.Drawing.Size(103, 49);
            this.btnXoa_Acc.TabIndex = 2;
            this.btnXoa_Acc.Text = "Xóa";
            this.btnXoa_Acc.UseVisualStyleBackColor = true;
            this.btnXoa_Acc.Click += new System.EventHandler(this.btnXoa_Acc_Click);
            // 
            // btnSua_Acc
            // 
            this.btnSua_Acc.Location = new System.Drawing.Point(167, 355);
            this.btnSua_Acc.Name = "btnSua_Acc";
            this.btnSua_Acc.Size = new System.Drawing.Size(103, 49);
            this.btnSua_Acc.TabIndex = 2;
            this.btnSua_Acc.Text = "Sửa";
            this.btnSua_Acc.UseVisualStyleBackColor = true;
            this.btnSua_Acc.Click += new System.EventHandler(this.btnSua_Acc_Click);
            // 
            // btnHuy_Acc
            // 
            this.btnHuy_Acc.Location = new System.Drawing.Point(563, 355);
            this.btnHuy_Acc.Name = "btnHuy_Acc";
            this.btnHuy_Acc.Size = new System.Drawing.Size(103, 49);
            this.btnHuy_Acc.TabIndex = 2;
            this.btnHuy_Acc.Text = "Hủy";
            this.btnHuy_Acc.UseVisualStyleBackColor = true;
            this.btnHuy_Acc.Click += new System.EventHandler(this.btnHuy_Acc_Click);
            // 
            // btnLuu_Acc
            // 
            this.btnLuu_Acc.Location = new System.Drawing.Point(296, 355);
            this.btnLuu_Acc.Name = "btnLuu_Acc";
            this.btnLuu_Acc.Size = new System.Drawing.Size(103, 49);
            this.btnLuu_Acc.TabIndex = 2;
            this.btnLuu_Acc.Text = "Lưu";
            this.btnLuu_Acc.UseVisualStyleBackColor = true;
            this.btnLuu_Acc.Click += new System.EventHandler(this.btnLuu_Acc_Click);
            // 
            // btnThem_Acc
            // 
            this.btnThem_Acc.Location = new System.Drawing.Point(33, 355);
            this.btnThem_Acc.Name = "btnThem_Acc";
            this.btnThem_Acc.Size = new System.Drawing.Size(103, 49);
            this.btnThem_Acc.TabIndex = 2;
            this.btnThem_Acc.Text = "Thêm";
            this.btnThem_Acc.UseVisualStyleBackColor = true;
            this.btnThem_Acc.Click += new System.EventHandler(this.btnThem_Acc_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(503, 163);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(163, 25);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Loại Tài Khoản";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(28, 101);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(146, 25);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Số Điện Thoại";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(28, 33);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(139, 25);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Tên Hiển Thị";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(28, 227);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(104, 25);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Giới Tính";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 288);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 25);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(503, 227);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(194, 25);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Ngày Bắt Đầu Làm";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(28, 166);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 25);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Địa Chỉ";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(503, 92);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(109, 25);
            this.lblMK.TabIndex = 1;
            this.lblMK.Text = "Mật Khẩu";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(503, 30);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(157, 25);
            this.lblAccountName.TabIndex = 1;
            this.lblAccountName.Text = "Tên Tài Khoản";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(179, 285);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 32);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(180, 101);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(219, 32);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // txtTenHT
            // 
            this.txtTenHT.Location = new System.Drawing.Point(179, 30);
            this.txtTenHT.Name = "txtTenHT";
            this.txtTenHT.Size = new System.Drawing.Size(219, 32);
            this.txtTenHT.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(179, 166);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(219, 32);
            this.txtAddress.TabIndex = 0;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(726, 89);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(219, 32);
            this.txtMK.TabIndex = 0;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(726, 30);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(219, 32);
            this.txtTenTK.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 213);
            this.panel1.TabIndex = 1;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 28;
            this.dgvUsers.Size = new System.Drawing.Size(1028, 196);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnTim_Acc
            // 
            this.btnTim_Acc.Location = new System.Drawing.Point(696, 355);
            this.btnTim_Acc.Name = "btnTim_Acc";
            this.btnTim_Acc.Size = new System.Drawing.Size(103, 49);
            this.btnTim_Acc.TabIndex = 2;
            this.btnTim_Acc.Text = "Tìm";
            this.btnTim_Acc.UseVisualStyleBackColor = true;
            this.btnTim_Acc.Click += new System.EventHandler(this.btnTim_Acc_Click);
            // 
            // txtTimAcc
            // 
            this.txtTimAcc.Location = new System.Drawing.Point(809, 364);
            this.txtTimAcc.Name = "txtTimAcc";
            this.txtTimAcc.Size = new System.Drawing.Size(189, 32);
            this.txtTimAcc.TabIndex = 0;
            // 
            // FormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 695);
            this.Controls.Add(this.btnBackFormManagement);
            this.Controls.Add(this.tcManagement);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.TabCategory.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TabManagementUser.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnXoa_Acc;
        private System.Windows.Forms.Button btnSua_Acc;
        private System.Windows.Forms.Button btnHuy_Acc;
        private System.Windows.Forms.Button btnLuu_Acc;
        private System.Windows.Forms.Button btnThem_Acc;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtTenHT;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private Panel panel3;
        private Panel panel2;
        private Button btnXoa_Category;
        private Button btnSua_Category;
        private Button btnThem_Category;
        private Button btnLuu_Category;
        private Label label3;
        private Label label2;
        private Label lblID;
        private TextBox txtLoai_Category;
        private TextBox txtID_Category;
        private RichTextBox richTextBoxMT;
        private DataGridView dgvCategory;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private Label lblMK;
        private TextBox txtMK;
        private ErrorProvider errorProvider;
        private Button btnHuy_Category;
        private Button btnTim_Acc;
        private TextBox txtTimAcc;
    }
}