using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeeApp.GUI
{
    partial class FormMain
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.ManageShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.lbTotalCash = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.nmProductCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.nmDisCount = new System.Windows.Forms.NumericUpDown();
            this.cbSwitchTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.msMenu.SuspendLayout();
            this.flpTable.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmProductCount)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageShopToolStripMenuItem,
            this.BillToolStripMenuItem,
            this.thôngTinCáNhanToolStripMenuItem,
            this.ReportToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(8, 0, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(916, 39);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // ManageShopToolStripMenuItem
            // 
            this.ManageShopToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ManageShopToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageShopToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ManageShopToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ManageShopToolStripMenuItem.Name = "ManageShopToolStripMenuItem";
            this.ManageShopToolStripMenuItem.ShowShortcutKeys = false;
            this.ManageShopToolStripMenuItem.Size = new System.Drawing.Size(171, 27);
            this.ManageShopToolStripMenuItem.Text = "Quản lý cửa hàng";
            this.ManageShopToolStripMenuItem.Click += new System.EventHandler(this.ManageShopToolStripMenuItem_Click);
            // 
            // BillToolStripMenuItem
            // 
            this.BillToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BillToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.BillToolStripMenuItem.Name = "BillToolStripMenuItem";
            this.BillToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.BillToolStripMenuItem.Text = "Hóa đơn";
            this.BillToolStripMenuItem.Click += new System.EventHandler(this.BillToolStripMenuItem_Click);
            // 
            // thôngTinCáNhanToolStripMenuItem
            // 
            this.thôngTinCáNhanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinCáNhanToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinCáNhanToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.thôngTinCáNhanToolStripMenuItem.Name = "thôngTinCáNhanToolStripMenuItem";
            this.thôngTinCáNhanToolStripMenuItem.Size = new System.Drawing.Size(187, 27);
            this.thôngTinCáNhanToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // ReportToolStripMenuItem
            // 
            this.ReportToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem";
            this.ReportToolStripMenuItem.Size = new System.Drawing.Size(86, 27);
            this.ReportToolStripMenuItem.Text = "Báo cáo";
            this.ReportToolStripMenuItem.Click += new System.EventHandler(this.ReportToolStripMenuItem_Click);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Controls.Add(this.flowLayoutPanel1);
            this.flpTable.Location = new System.Drawing.Point(0, 42);
            this.flpTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(449, 561);
            this.flpTable.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(11, 10);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txbTotalPrice);
            this.guna2Panel1.Controls.Add(this.lsvBill);
            this.guna2Panel1.Controls.Add(this.lbTotalCash);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Location = new System.Drawing.Point(452, 128);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(460, 375);
            this.guna2Panel1.TabIndex = 2;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(288, 346);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(159, 22);
            this.txbTotalPrice.TabIndex = 3;

			// txbTotalPrice
			// 
			this.txbTotalPrice.Location = new System.Drawing.Point(216, 281);
			this.txbTotalPrice.Name = "txbTotalPrice";
			this.txbTotalPrice.Size = new System.Drawing.Size(120, 20);
			this.txbTotalPrice.TabIndex = 3;
			// 
			// lsvBill
			// 
			this.lsvBill.Columns.Add("ProductName", -2, HorizontalAlignment.Left);
			this.lsvBill.Columns.Add("Count", -2, HorizontalAlignment.Left);
			this.lsvBill.Columns.Add("Price", -2, HorizontalAlignment.Left);
			this.lsvBill.Columns.Add("TotalPrice", -2, HorizontalAlignment.Left);
			this.lsvBill.HideSelection = false;
			this.lsvBill.Location = new System.Drawing.Point(3, 4);
			this.lsvBill.Name = "lsvBill";
			this.lsvBill.Size = new System.Drawing.Size(339, 273);
			this.lsvBill.TabIndex = 2;
			this.lsvBill.UseCompatibleStateImageBehavior = false;
			this.lsvBill.View = System.Windows.Forms.View.Details;
			// 

			// 
			// lbTotalCash
			// 
			this.lbTotalCash.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalCash.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCash.Location = new System.Drawing.Point(301, 347);
            this.lbTotalCash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTotalCash.Name = "lbTotalCash";
            this.lbTotalCash.Size = new System.Drawing.Size(3, 2);
            this.lbTotalCash.TabIndex = 1;
            this.lbTotalCash.Text = null;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(141, 346);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(112, 27);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Tổng tiền : ";
            // 
            // ProductName
            // 
            this.ProductName.Width = 82;
            // 
            // Quantity
            // 
            this.Quantity.Width = 82;
            // 
            // Price
            // 
            this.Price.Width = 81;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Width = 82;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnAddProduct);
            this.guna2Panel2.Controls.Add(this.nmProductCount);
            this.guna2Panel2.Controls.Add(this.cbProduct);
            this.guna2Panel2.Controls.Add(this.cbCategory);
            this.guna2Panel2.Location = new System.Drawing.Point(452, 42);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(457, 80);
            this.guna2Panel2.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(339, 21);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(109, 38);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // nmProductCount
            // 
            this.nmProductCount.BackColor = System.Drawing.Color.Transparent;
            this.nmProductCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmProductCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nmProductCount.Location = new System.Drawing.Point(257, 21);
            this.nmProductCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmProductCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmProductCount.Name = "nmProductCount";
            this.nmProductCount.Size = new System.Drawing.Size(75, 38);
            this.nmProductCount.TabIndex = 3;
            // 
            // cbProduct
            // 
            this.cbProduct.BackColor = System.Drawing.Color.Transparent;
            this.cbProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbProduct.ItemHeight = 30;
            this.cbProduct.Location = new System.Drawing.Point(4, 41);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(229, 36);
            this.cbProduct.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategory.ItemHeight = 30;
            this.cbCategory.Location = new System.Drawing.Point(3, 4);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(231, 36);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.cbPayment);
            this.guna2Panel3.Controls.Add(this.button2);
            this.guna2Panel3.Controls.Add(this.btnSwitchTable);
            this.guna2Panel3.Controls.Add(this.nmDisCount);
            this.guna2Panel3.Controls.Add(this.cbSwitchTable);
            this.guna2Panel3.Controls.Add(this.btnCheckOut);
            this.guna2Panel3.Location = new System.Drawing.Point(452, 510);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(461, 94);
            this.guna2Panel3.TabIndex = 4;
            // 
            // cbPayment
            // 
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Location = new System.Drawing.Point(196, 52);
            this.cbPayment.Margin = new System.Windows.Forms.Padding(4);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(135, 24);
            this.cbPayment.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Giảm giá";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(20, 12);
            this.btnSwitchTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(115, 28);
            this.btnSwitchTable.TabIndex = 4;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // nmDisCount
            // 
            this.nmDisCount.Location = new System.Drawing.Point(271, 12);
            this.nmDisCount.Margin = new System.Windows.Forms.Padding(4);
            this.nmDisCount.Name = "nmDisCount";
            this.nmDisCount.Size = new System.Drawing.Size(81, 22);
            this.nmDisCount.TabIndex = 3;
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.BackColor = System.Drawing.Color.Transparent;
            this.cbSwitchTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSwitchTable.DropDownHeight = 100;
            this.cbSwitchTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSwitchTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSwitchTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSwitchTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSwitchTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSwitchTable.IntegralHeight = false;
            this.cbSwitchTable.ItemHeight = 30;
            this.cbSwitchTable.Location = new System.Drawing.Point(4, 47);
            this.cbSwitchTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(149, 36);
            this.cbSwitchTable.TabIndex = 2;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(364, 21);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(92, 58);
            this.btnCheckOut.TabIndex = 0;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 602);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMaincs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.flpTable.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmProductCount)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem ManageShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2Button btnAddProduct;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmProductCount;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2ComboBox cbProduct;
        private Guna.UI2.WinForms.Guna2ComboBox cbSwitchTable;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTotalCash;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.ToolStripMenuItem BillToolStripMenuItem;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.NumericUpDown nmDisCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader TotalPrice;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ComboBox cbPayment;
        private ToolStripMenuItem ReportToolStripMenuItem;
    }
}