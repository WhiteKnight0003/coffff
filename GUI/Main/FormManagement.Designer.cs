using System.Windows.Forms;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnBackFormManagement = new Guna.UI2.WinForms.Guna2Button();
            this.TabStatisticsProceeds = new System.Windows.Forms.TabPage();
            this.cbChooseYear = new System.Windows.Forms.ComboBox();
            this.chartStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tcManagement = new System.Windows.Forms.TabControl();
            this.TabBillDetail = new System.Windows.Forms.TabPage();
            this.panelBillDetailsCenter = new System.Windows.Forms.Panel();
            this.dgvBillDetails = new System.Windows.Forms.DataGridView();
            this.panelBillDetailsFooter = new System.Windows.Forms.Panel();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.TabProduct = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtgvProduct = new System.Windows.Forms.DataGridView();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.panelProductLeft = new System.Windows.Forms.Panel();
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
            this.btnSearchProduct = new System.Windows.Forms.Button();
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
            this.btnTim_Acc = new System.Windows.Forms.Button();
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
            this.txtTimAcc = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtTenHT = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabStatisticsProceeds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).BeginInit();
            this.tcManagement.SuspendLayout();
            this.TabBillDetail.SuspendLayout();
            this.panelBillDetailsCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
            this.panelBillDetailsFooter.SuspendLayout();
            this.TabProduct.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            this.panelProductLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmProductPrice)).BeginInit();
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
            this.btnBackFormManagement.Location = new System.Drawing.Point(547, 4);
            this.btnBackFormManagement.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.TabStatisticsProceeds.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TabStatisticsProceeds.Name = "TabStatisticsProceeds";
            this.TabStatisticsProceeds.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TabStatisticsProceeds.Size = new System.Drawing.Size(687, 420);
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
            this.cbChooseYear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbChooseYear.MaxDropDownItems = 10;
            this.cbChooseYear.Name = "cbChooseYear";
            this.cbChooseYear.Size = new System.Drawing.Size(119, 28);
            this.cbChooseYear.TabIndex = 1;
            this.cbChooseYear.Text = "Chọn Năm";
            this.cbChooseYear.SelectedIndexChanged += new System.EventHandler(this.cbChooseYear_SelectedIndexChanged);
            // 
            // chartStatistic
            // 
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.Title = "Tháng";
            chartArea3.AxisY.Title = "Doanh thu";
            chartArea3.Name = "ChartArea1";
            this.chartStatistic.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartStatistic.Legends.Add(legend3);
            this.chartStatistic.Location = new System.Drawing.Point(0, 5);
            this.chartStatistic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chartStatistic.Name = "chartStatistic";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "DataSeries";
            this.chartStatistic.Series.Add(series3);
            this.chartStatistic.Size = new System.Drawing.Size(529, 413);
            this.chartStatistic.TabIndex = 0;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Biểu đồ thông kê doanh thu theo năm";
            this.chartStatistic.Titles.Add(title3);
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
            this.tcManagement.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tcManagement.Name = "tcManagement";
            this.tcManagement.SelectedIndex = 0;
            this.tcManagement.Size = new System.Drawing.Size(695, 450);
            this.tcManagement.TabIndex = 0;
            this.tcManagement.SelectedIndexChanged += new System.EventHandler(this.tcManagement_SelectedIndexChanged);
            this.tcManagement.Click += new System.EventHandler(this.tcManagement_Click);
            // 
            // TabBillDetail
            // 
            this.TabBillDetail.Controls.Add(this.panelBillDetailsCenter);
            this.TabBillDetail.Controls.Add(this.panelBillDetailsFooter);
            this.TabBillDetail.Location = new System.Drawing.Point(4, 26);
            this.TabBillDetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TabBillDetail.Name = "TabBillDetail";
            this.TabBillDetail.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TabBillDetail.Size = new System.Drawing.Size(687, 420);
            this.TabBillDetail.TabIndex = 6;
            this.TabBillDetail.Text = "Chi tiết hóa đơn";
            this.TabBillDetail.UseVisualStyleBackColor = true;
            // 
            // panelBillDetailsCenter
            // 
            this.panelBillDetailsCenter.Controls.Add(this.dgvBillDetails);
            this.panelBillDetailsCenter.Location = new System.Drawing.Point(2, 2);
            this.panelBillDetailsCenter.Name = "panelBillDetailsCenter";
            this.panelBillDetailsCenter.Size = new System.Drawing.Size(679, 365);
            this.panelBillDetailsCenter.TabIndex = 3;
            // 
            // dgvBillDetails
            // 
            this.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetails.Location = new System.Drawing.Point(-1, 25);
            this.dgvBillDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBillDetails.Name = "dgvBillDetails";
            this.dgvBillDetails.RowHeadersWidth = 62;
            this.dgvBillDetails.Size = new System.Drawing.Size(681, 337);
            this.dgvBillDetails.TabIndex = 2;
            this.dgvBillDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBillDetails_CellFormatting_1);
            // 
            // panelBillDetailsFooter
            // 
            this.panelBillDetailsFooter.Controls.Add(this.lblPageNumber);
            this.panelBillDetailsFooter.Controls.Add(this.btnLast);
            this.panelBillDetailsFooter.Controls.Add(this.btnNext);
            this.panelBillDetailsFooter.Controls.Add(this.btnPrevious);
            this.panelBillDetailsFooter.Controls.Add(this.btnFirst);
            this.panelBillDetailsFooter.Location = new System.Drawing.Point(4, 367);
            this.panelBillDetailsFooter.Name = "panelBillDetailsFooter";
            this.panelBillDetailsFooter.Size = new System.Drawing.Size(678, 52);
            this.panelBillDetailsFooter.TabIndex = 2;
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(564, 19);
            this.lblPageNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(47, 17);
            this.lblPageNumber.TabIndex = 11;
            this.lblPageNumber.Text = "label1";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(443, 5);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(84, 45);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = "&Cuối";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(296, 5);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 45);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "&Tiếp";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(149, 5);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(84, 45);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "&Trước";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click_1);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(2, 5);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(84, 45);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "&Đầu ";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click_1);
            // 
            // TabProduct
            // 
            this.TabProduct.Controls.Add(this.panel4);
            this.TabProduct.Controls.Add(this.panelProductLeft);
            this.TabProduct.Location = new System.Drawing.Point(4, 26);
            this.TabProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TabProduct.Name = "TabProduct";
            this.TabProduct.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TabProduct.Size = new System.Drawing.Size(687, 420);
            this.TabProduct.TabIndex = 7;
            this.TabProduct.Text = "Sản phẩm";
            this.TabProduct.UseVisualStyleBackColor = true;
            this.TabProduct.Click += new System.EventHandler(this.TabProduct_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.dtgvProduct);
            this.panel4.Controls.Add(this.btnEditProduct);
            this.panel4.Controls.Add(this.btnDeleteProduct);
            this.panel4.Controls.Add(this.btnAddProduct);
            this.panel4.Location = new System.Drawing.Point(2, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 412);
            this.panel4.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(265, 1);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 42);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduct.Location = new System.Drawing.Point(3, 47);
            this.dtgvProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.RowHeadersWidth = 62;
            this.dtgvProduct.Size = new System.Drawing.Size(345, 365);
            this.dtgvProduct.TabIndex = 10;
            this.dtgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProduct_CellClick_1);
            this.dtgvProduct.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvProduct_CellFormatting);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(178, 1);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(83, 42);
            this.btnEditProduct.TabIndex = 8;
            this.btnEditProduct.Text = "&Sửa";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click_1);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(91, 0);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(83, 42);
            this.btnDeleteProduct.TabIndex = 7;
            this.btnDeleteProduct.Text = "&Xóa";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click_1);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(5, 0);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(83, 42);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "&Thêm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click_1);
            // 
            // panelProductLeft
            // 
            this.panelProductLeft.Controls.Add(this.btnSaveProductImage);
            this.panelProductLeft.Controls.Add(this.txtProductID);
            this.panelProductLeft.Controls.Add(this.lblProductID);
            this.panelProductLeft.Controls.Add(this.pbImageProduct);
            this.panelProductLeft.Controls.Add(this.btnChooseImageProduct);
            this.panelProductLeft.Controls.Add(this.cbbProductCategory);
            this.panelProductLeft.Controls.Add(this.nmProductPrice);
            this.panelProductLeft.Controls.Add(this.txtProductName);
            this.panelProductLeft.Controls.Add(this.lblProductPrice);
            this.panelProductLeft.Controls.Add(this.lblProductCategory);
            this.panelProductLeft.Controls.Add(this.lblProductName);
            this.panelProductLeft.Controls.Add(this.txtSearchProductName);
            this.panelProductLeft.Controls.Add(this.btnSearchProduct);
            this.panelProductLeft.Location = new System.Drawing.Point(352, 7);
            this.panelProductLeft.Name = "panelProductLeft";
            this.panelProductLeft.Size = new System.Drawing.Size(334, 407);
            this.panelProductLeft.TabIndex = 6;
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
            this.btnSaveProductImage.Location = new System.Drawing.Point(31, 192);
            this.btnSaveProductImage.Margin = new System.Windows.Forms.Padding(1);
            this.btnSaveProductImage.Name = "btnSaveProductImage";
            this.btnSaveProductImage.Size = new System.Drawing.Size(127, 46);
            this.btnSaveProductImage.TabIndex = 48;
            this.btnSaveProductImage.Text = "Lưu ảnh";
            this.btnSaveProductImage.Click += new System.EventHandler(this.btnSaveProductImage_Click_1);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(109, 263);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(204, 24);
            this.txtProductID.TabIndex = 47;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(28, 263);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(30, 17);
            this.lblProductID.TabIndex = 46;
            this.lblProductID.Text = "ID:";
            // 
            // pbImageProduct
            // 
            this.pbImageProduct.ImageRotate = 0F;
            this.pbImageProduct.Location = new System.Drawing.Point(31, 51);
            this.pbImageProduct.Margin = new System.Windows.Forms.Padding(1);
            this.pbImageProduct.Name = "pbImageProduct";
            this.pbImageProduct.Size = new System.Drawing.Size(288, 139);
            this.pbImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageProduct.TabIndex = 45;
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
            this.btnChooseImageProduct.Location = new System.Drawing.Point(193, 192);
            this.btnChooseImageProduct.Margin = new System.Windows.Forms.Padding(1);
            this.btnChooseImageProduct.Name = "btnChooseImageProduct";
            this.btnChooseImageProduct.Size = new System.Drawing.Size(127, 46);
            this.btnChooseImageProduct.TabIndex = 44;
            this.btnChooseImageProduct.Text = "Thay đổi ảnh";
            this.btnChooseImageProduct.Click += new System.EventHandler(this.btnChooseImageProduct_Click_1);
            // 
            // cbbProductCategory
            // 
            this.cbbProductCategory.FormattingEnabled = true;
            this.cbbProductCategory.Location = new System.Drawing.Point(109, 339);
            this.cbbProductCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbProductCategory.Name = "cbbProductCategory";
            this.cbbProductCategory.Size = new System.Drawing.Size(204, 25);
            this.cbbProductCategory.TabIndex = 43;
            // 
            // nmProductPrice
            // 
            this.nmProductPrice.Location = new System.Drawing.Point(109, 375);
            this.nmProductPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmProductPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmProductPrice.Name = "nmProductPrice";
            this.nmProductPrice.Size = new System.Drawing.Size(204, 24);
            this.nmProductPrice.TabIndex = 42;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(109, 301);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(204, 24);
            this.txtProductName.TabIndex = 41;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(28, 377);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(35, 17);
            this.lblProductPrice.TabIndex = 40;
            this.lblProductPrice.Text = "Giá:";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(28, 339);
            this.lblProductCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(78, 17);
            this.lblProductCategory.TabIndex = 39;
            this.lblProductCategory.Text = "Danh mục:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(28, 301);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(71, 17);
            this.lblProductName.TabIndex = 38;
            this.lblProductName.Text = "Tên món:";
            // 
            // txtSearchProductName
            // 
            this.txtSearchProductName.Location = new System.Drawing.Point(31, 15);
            this.txtSearchProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchProductName.Name = "txtSearchProductName";
            this.txtSearchProductName.Size = new System.Drawing.Size(201, 24);
            this.txtSearchProductName.TabIndex = 37;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(236, 5);
            this.btnSearchProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(83, 42);
            this.btnSearchProduct.TabIndex = 36;
            this.btnSearchProduct.Text = "&Tìm";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click_1);
            // 
            // TabCategory
            // 
            this.TabCategory.Controls.Add(this.panel3);
            this.TabCategory.Controls.Add(this.panel2);
            this.TabCategory.Location = new System.Drawing.Point(4, 26);
            this.TabCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TabCategory.Name = "TabCategory";
            this.TabCategory.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TabCategory.Size = new System.Drawing.Size(687, 420);
            this.TabCategory.TabIndex = 8;
            this.TabCategory.Text = "Loại sản phẩm";
            this.TabCategory.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvCategory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(379, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 414);
            this.panel3.TabIndex = 1;
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(4, 38);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 62;
            this.dgvCategory.RowTemplate.Height = 28;
            this.dgvCategory.Size = new System.Drawing.Size(296, 222);
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
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 414);
            this.panel2.TabIndex = 0;
            // 
            // txtLoai_Category
            // 
            this.txtLoai_Category.Location = new System.Drawing.Point(114, 85);
            this.txtLoai_Category.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLoai_Category.Name = "txtLoai_Category";
            this.txtLoai_Category.Size = new System.Drawing.Size(195, 24);
            this.txtLoai_Category.TabIndex = 3;
            // 
            // txtID_Category
            // 
            this.txtID_Category.Location = new System.Drawing.Point(114, 38);
            this.txtID_Category.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID_Category.Name = "txtID_Category";
            this.txtID_Category.Size = new System.Drawing.Size(195, 24);
            this.txtID_Category.TabIndex = 3;
            // 
            // richTextBoxMT
            // 
            this.richTextBoxMT.Location = new System.Drawing.Point(114, 131);
            this.richTextBoxMT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxMT.Name = "richTextBoxMT";
            this.richTextBoxMT.Size = new System.Drawing.Size(195, 112);
            this.richTextBoxMT.TabIndex = 2;
            this.richTextBoxMT.Text = "";
            // 
            // btnHuy_Category
            // 
            this.btnHuy_Category.Location = new System.Drawing.Point(151, 354);
            this.btnHuy_Category.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy_Category.Name = "btnHuy_Category";
            this.btnHuy_Category.Size = new System.Drawing.Size(67, 35);
            this.btnHuy_Category.TabIndex = 1;
            this.btnHuy_Category.Text = "Hủy";
            this.btnHuy_Category.UseVisualStyleBackColor = true;
            this.btnHuy_Category.Click += new System.EventHandler(this.btnReset_Category_Click);
            // 
            // btnXoa_Category
            // 
            this.btnXoa_Category.Location = new System.Drawing.Point(285, 295);
            this.btnXoa_Category.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa_Category.Name = "btnXoa_Category";
            this.btnXoa_Category.Size = new System.Drawing.Size(67, 35);
            this.btnXoa_Category.TabIndex = 1;
            this.btnXoa_Category.Text = "Xóa";
            this.btnXoa_Category.UseVisualStyleBackColor = true;
            this.btnXoa_Category.Click += new System.EventHandler(this.btnXoa_Category_Click);
            // 
            // btnSua_Category
            // 
            this.btnSua_Category.Location = new System.Drawing.Point(194, 295);
            this.btnSua_Category.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua_Category.Name = "btnSua_Category";
            this.btnSua_Category.Size = new System.Drawing.Size(67, 35);
            this.btnSua_Category.TabIndex = 1;
            this.btnSua_Category.Text = "Sửa";
            this.btnSua_Category.UseVisualStyleBackColor = true;
            this.btnSua_Category.Click += new System.EventHandler(this.btnSua__Category_Click);
            // 
            // btnThem_Category
            // 
            this.btnThem_Category.Location = new System.Drawing.Point(106, 295);
            this.btnThem_Category.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem_Category.Name = "btnThem_Category";
            this.btnThem_Category.Size = new System.Drawing.Size(67, 35);
            this.btnThem_Category.TabIndex = 1;
            this.btnThem_Category.Text = "Thêm";
            this.btnThem_Category.UseVisualStyleBackColor = true;
            this.btnThem_Category.Click += new System.EventHandler(this.btnAdd_Category_Click);
            // 
            // btnLuu_Category
            // 
            this.btnLuu_Category.Location = new System.Drawing.Point(17, 295);
            this.btnLuu_Category.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu_Category.Name = "btnLuu_Category";
            this.btnLuu_Category.Size = new System.Drawing.Size(67, 35);
            this.btnLuu_Category.TabIndex = 1;
            this.btnLuu_Category.Text = "Lưu";
            this.btnLuu_Category.UseVisualStyleBackColor = true;
            this.btnLuu_Category.Click += new System.EventHandler(this.btnSua__Category_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(47, 40);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // TabManagementUser
            // 
            this.TabManagementUser.Controls.Add(this.panel);
            this.TabManagementUser.Controls.Add(this.panel1);
            this.TabManagementUser.Location = new System.Drawing.Point(4, 26);
            this.TabManagementUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TabManagementUser.Name = "TabManagementUser";
            this.TabManagementUser.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TabManagementUser.Size = new System.Drawing.Size(687, 420);
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
            this.panel.Location = new System.Drawing.Point(2, 3);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(683, 278);
            this.panel.TabIndex = 2;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(193, 145);
            this.rdNu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(46, 21);
            this.rdNu.TabIndex = 5;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(119, 146);
            this.rdNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(56, 21);
            this.rdNam.TabIndex = 5;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(484, 148);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(107, 24);
            this.dtpStartDate.TabIndex = 4;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(484, 106);
            this.cbType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(107, 25);
            this.cbType.TabIndex = 3;
            // 
            // btnXoa_Acc
            // 
            this.btnXoa_Acc.Location = new System.Drawing.Point(285, 231);
            this.btnXoa_Acc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa_Acc.Name = "btnXoa_Acc";
            this.btnXoa_Acc.Size = new System.Drawing.Size(69, 32);
            this.btnXoa_Acc.TabIndex = 2;
            this.btnXoa_Acc.Text = "Xóa";
            this.btnXoa_Acc.UseVisualStyleBackColor = true;
            this.btnXoa_Acc.Click += new System.EventHandler(this.btnXoa_Acc_Click);
            // 
            // btnSua_Acc
            // 
            this.btnSua_Acc.Location = new System.Drawing.Point(111, 231);
            this.btnSua_Acc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua_Acc.Name = "btnSua_Acc";
            this.btnSua_Acc.Size = new System.Drawing.Size(69, 32);
            this.btnSua_Acc.TabIndex = 2;
            this.btnSua_Acc.Text = "Sửa";
            this.btnSua_Acc.UseVisualStyleBackColor = true;
            this.btnSua_Acc.Click += new System.EventHandler(this.btnSua_Acc_Click);
            // 
            // btnTim_Acc
            // 
            this.btnTim_Acc.Location = new System.Drawing.Point(464, 231);
            this.btnTim_Acc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTim_Acc.Name = "btnTim_Acc";
            this.btnTim_Acc.Size = new System.Drawing.Size(69, 32);
            this.btnTim_Acc.TabIndex = 2;
            this.btnTim_Acc.Text = "Tìm";
            this.btnTim_Acc.UseVisualStyleBackColor = true;
            this.btnTim_Acc.Click += new System.EventHandler(this.btnTim_Acc_Click);
            // 
            // btnHuy_Acc
            // 
            this.btnHuy_Acc.Location = new System.Drawing.Point(375, 231);
            this.btnHuy_Acc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy_Acc.Name = "btnHuy_Acc";
            this.btnHuy_Acc.Size = new System.Drawing.Size(69, 32);
            this.btnHuy_Acc.TabIndex = 2;
            this.btnHuy_Acc.Text = "Hủy";
            this.btnHuy_Acc.UseVisualStyleBackColor = true;
            this.btnHuy_Acc.Click += new System.EventHandler(this.btnHuy_Acc_Click);
            // 
            // btnLuu_Acc
            // 
            this.btnLuu_Acc.Location = new System.Drawing.Point(197, 231);
            this.btnLuu_Acc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu_Acc.Name = "btnLuu_Acc";
            this.btnLuu_Acc.Size = new System.Drawing.Size(69, 32);
            this.btnLuu_Acc.TabIndex = 2;
            this.btnLuu_Acc.Text = "Lưu";
            this.btnLuu_Acc.UseVisualStyleBackColor = true;
            this.btnLuu_Acc.Click += new System.EventHandler(this.btnLuu_Acc_Click);
            // 
            // btnThem_Acc
            // 
            this.btnThem_Acc.Location = new System.Drawing.Point(22, 231);
            this.btnThem_Acc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem_Acc.Name = "btnThem_Acc";
            this.btnThem_Acc.Size = new System.Drawing.Size(69, 32);
            this.btnThem_Acc.TabIndex = 2;
            this.btnThem_Acc.Text = "Thêm";
            this.btnThem_Acc.UseVisualStyleBackColor = true;
            this.btnThem_Acc.Click += new System.EventHandler(this.btnThem_Acc_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(335, 106);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(109, 17);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Loại Tài Khoản";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(19, 66);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(100, 17);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Số Điện Thoại";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(19, 21);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(96, 17);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Tên Hiển Thị";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(19, 148);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 17);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Giới Tính";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 187);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 17);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(335, 148);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(131, 17);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Ngày Bắt Đầu Làm";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(19, 108);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 17);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Địa Chỉ";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(335, 60);
            this.lblMK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(74, 17);
            this.lblMK.TabIndex = 1;
            this.lblMK.Text = "Mật Khẩu";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(335, 20);
            this.lblAccountName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(106, 17);
            this.lblAccountName.TabIndex = 1;
            this.lblAccountName.Text = "Tên Tài Khoản";
            // 
            // txtTimAcc
            // 
            this.txtTimAcc.Location = new System.Drawing.Point(539, 237);
            this.txtTimAcc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimAcc.Name = "txtTimAcc";
            this.txtTimAcc.Size = new System.Drawing.Size(127, 24);
            this.txtTimAcc.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 185);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 24);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(120, 66);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(147, 24);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // txtTenHT
            // 
            this.txtTenHT.Location = new System.Drawing.Point(119, 20);
            this.txtTenHT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenHT.Name = "txtTenHT";
            this.txtTenHT.Size = new System.Drawing.Size(147, 24);
            this.txtTenHT.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(119, 108);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(147, 24);
            this.txtAddress.TabIndex = 0;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(484, 58);
            this.txtMK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(147, 24);
            this.txtMK.TabIndex = 0;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(484, 20);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(147, 24);
            this.txtTenTK.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 279);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 138);
            this.panel1.TabIndex = 1;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 28;
            this.dgvUsers.Size = new System.Drawing.Size(683, 127);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 452);
            this.Controls.Add(this.btnBackFormManagement);
            this.Controls.Add(this.tcManagement);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManagement";
            this.TabStatisticsProceeds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).EndInit();
            this.tcManagement.ResumeLayout(false);
            this.TabBillDetail.ResumeLayout(false);
            this.panelBillDetailsCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).EndInit();
            this.panelBillDetailsFooter.ResumeLayout(false);
            this.panelBillDetailsFooter.PerformLayout();
            this.TabProduct.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            this.panelProductLeft.ResumeLayout(false);
            this.panelProductLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmProductPrice)).EndInit();
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
        private Panel panelBillDetailsFooter;
        private Label lblPageNumber;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
        private Panel panelBillDetailsCenter;
        private DataGridView dgvBillDetails;
        private Panel panelProductLeft;
        private Guna.UI2.WinForms.Guna2Button btnSaveProductImage;
        private TextBox txtProductID;
        private Label lblProductID;
        private Guna.UI2.WinForms.Guna2PictureBox pbImageProduct;
        private Guna.UI2.WinForms.Guna2Button btnChooseImageProduct;
        private ComboBox cbbProductCategory;
        private NumericUpDown nmProductPrice;
        private TextBox txtProductName;
        private Label lblProductPrice;
        private Label lblProductCategory;
        private Label lblProductName;
        private TextBox txtSearchProductName;
        private Button btnSearchProduct;
        private Panel panel4;
        private DataGridView dtgvProduct;
        private Button btnEditProduct;
        private Button btnDeleteProduct;
        private Button btnAddProduct;
        private Button btnSave;
    }
}