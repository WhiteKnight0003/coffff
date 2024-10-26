using CoffeeApp.DAO;
using CoffeeApp.DTO;
using CoffeeApp.Util;
using DevExpress.Internal;
using CoffeeApp.Util;
using DevExpress.Xpo.DB.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CoffeeApp.GUI.Main
{
    public partial class FormManagement : Form
    {
        private FormMain formmain;
        private string username;
        private int roleID;
        private Dictionary<int, float> data;
        private System.Drawing.Image showImageUser;
        private ConvertImage convertImage;
        private ValidateData validateData;
        public FormManagement(FormMain formmain, string username, int roleID)
        {
            InitializeComponent();
            this.formmain = formmain;
            this.username = username;
            this.roleID = roleID;
            Decentralization(username, roleID);
            data = new Dictionary<int, float>();
            loadData();
            LoadListProduct();
            AddProductBinding();
            LoadCategoryIntoCombobox();
            BillInfoDAO.Instance.DisplayPage(1, pageSize, currentPage, dgvBillDetails, lblPageNumber);
            ManageAccount_Load();
            Category_Load();
        }
        void ManageAccount_Load()
        {
            string query = "SELECT * FROM dbo.users where Workingstatus = 1";
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery(query);
            dgvUsers.DataSource = data;
            dgvUsers.Columns["password"].Visible = false;
            dgvUsers.Columns["image"].Visible = false;
            dgvUsers.Columns["Workingstatus"].Visible = false;
            cbType.Items.Add("Admin");
            cbType.Items.Add("Staff");
            UnLoaded(false);
        }
        void Category_Load()
        {
            string query = "SELECT * FROM dbo.category where Status =1";
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery(query);

            dgvCategory.DataSource = data;
            dgvCategory.Columns["Status"].Visible = false;
            Unloaded_Category(false);
        }
        private void Unloaded_Category(bool ok)
        {
            txtID_Category.Enabled = ok;
            txtLoai_Category.Enabled = ok;
            richTextBoxMT.Enabled = ok;
            btnLuu_Category.Enabled = ok;
            btnXoa_Category.Enabled = ok;
            btnSua_Category.Enabled = ok;
        }
        private void UnLoaded(bool isEnabled)
        {
            txtTenHT.Enabled = isEnabled;
            txtPhoneNumber.Enabled = isEnabled;
            txtAddress.Enabled = isEnabled;
            rdNam.Enabled = isEnabled;
            rdNu.Enabled = isEnabled;
            txtTenTK.Enabled = isEnabled;
            txtMK.Enabled = isEnabled;
            cbType.Enabled = isEnabled;
            txtEmail.Enabled = isEnabled;
            dtpStartDate.Enabled = isEnabled;
            btnSua_Acc.Enabled = isEnabled;
            btnXoa_Acc.Enabled = isEnabled;
            btnLuu_Acc.Enabled = isEnabled;
            dtpStartDate.Value = DateTime.Today;
        }
        private void ResetValue()
        {
            txtTenHT.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;
            txtTenTK.Text = "";
            txtMK.Text = "";
            cbType.Text = "";
            dtpStartDate.Value = DateTime.Today;
        }
        private void ResetValue_Category()
        {
            txtID_Category.Text = "";
            txtLoai_Category.Text = "";
            richTextBoxMT.Text = "";
            btnThem_Category.Enabled = true;
        }
        private void Decentralization(string username, int roleID)
        {
            // staff
            if (roleID == 2)
            {
                tcManagement.TabPages.Remove(TabStatisticsProceeds);
                tcManagement.TabPages.Remove(TabProduct);
                tcManagement.TabPages.Remove(TabCategory);
                tcManagement.TabPages.Remove(TabManagementUser);
            }
        }

        private void btnBackFormManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            formmain.Show();
        }


        #region Method
        private void loadData()
        {
            this.chartStatistic.Series["DataSeries"].Points.Clear();

            for (int i = 1; i <= 12; i++)
            {
                data.Add(i, 0);
            }

            // năm theo thời gian thực
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                cbChooseYear.Items.Add(i);
            }
        }

        private void cbChooseYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy mục được chọn
            string selectedItem = cbChooseYear.SelectedItem.ToString();

            int year = int.Parse(selectedItem);

            Color[] colors = new Color[]
            {
                Color.Red, Color.Green, Color.Blue, Color.Yellow,
                Color.Orange, Color.Purple, Color.Cyan, Color.Magenta,
                Color.Brown, Color.Gray, Color.LightBlue, Color.LightGreen
            };

            DataTable dataTable = DAO.BillDAO.Instance.GetProceedsByYear(year);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Bill bill = new Bill(row);

                    // lấy ngày
                    DateTime? dateCheckOut = bill.DateCheckOut;


                    //kiểm tra xem biến có kiểu DateTime ? (nullable DateTime) có chứa giá trị hay không
                    if (dateCheckOut.HasValue)
                    {
                        int month = dateCheckOut.Value.Month;
                        data[month] += bill.TotalBill;
                    }
                }
                int i = 0;
                // duyệt dữ liệu  Dictionary và thêm dữ liệu vào biểu đồ
                foreach (KeyValuePair<int, float> kvp in data)
                {
                    // Thêm điểm dữ liệu vào biểu đồ và lưu chỉ số của điểm vừa thêm
                    int index = this.chartStatistic.Series["DataSeries"].Points.AddXY(kvp.Key, kvp.Value);

                    // Lấy đối tượng DataPoint từ chỉ số
                    DataPoint point = this.chartStatistic.Series["DataSeries"].Points[index];

                    point.Color = colors[i % colors.Length];
                    point.LegendText = $"Tháng {kvp.Key}"; // Hiển thị nhãn tháng cho từng cột

                    point.Label = ""; // Đảm bảo không có nhãn hiển thị trên cột
                    ++i;
                }

                // Cập nhật lại giao diện biểu đồ
                this.chartStatistic.Invalidate(); // Vẽ lại biểu đồ nếu cần

            }

            else
            {
                MessageBox.Show($"Không có dữ liệu hóa đơn cho năm {year}");
                this.chartStatistic.Series["DataSeries"].Points.Clear();
                foreach (KeyValuePair<int, float> kvp in data)
                {
                    this.chartStatistic.Series["DataSeries"].Points.AddXY(kvp.Key, 0);
                }
            }
        }






        #endregion
        private void LoadListProduct()
        {
            dtgvProduct.DataSource = ProductDAO.Instance.GetListProduct();
            dtgvProduct.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvProduct.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // Ensure the DataGridView has been populated before accessing columns
            if (dtgvProduct.Columns.Count > 0)
            {
                dtgvProduct.Columns["Name"].DisplayIndex = 0;
                dtgvProduct.Columns["Price"].DisplayIndex = 1;
                dtgvProduct.Columns["ID"].Visible = false;
                dtgvProduct.Columns["CategoryID"].Visible = false;
                dtgvProduct.Columns["Image"].Visible = false;
            }
        }
        private void AddProductBinding()
        {
            txtProductName.DataBindings.Clear();
            txtProductName.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "Name", true, DataSourceUpdateMode.Never));

            txtProductID.DataBindings.Clear();
            txtProductID.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "ID", true, DataSourceUpdateMode.Never));

            nmProductPrice.DataBindings.Clear();
            nmProductPrice.DataBindings.Add(new Binding("Value", dtgvProduct.DataSource, "Price", true, DataSourceUpdateMode.Never));          
        }

        private void LoadCategoryIntoCombobox()
        {
            cbbProductCategory.DataSource = CategoryDAO.Instance.GetListCategory();
            cbbProductCategory.DisplayMember = "Name";
            LoadListProduct();
            AddProductBinding();
        }

        List<Product> SearchProductByName(string name)
        {
            return ProductDAO.Instance.SearchProductByName(name);
        }

        private void LoadListBillDetails()
        {
            dgvBillDetails.DataSource = BillDAO.Instance.GetListBill();
            if (dgvBillDetails.Columns.Count > 0)
            {
                dgvBillDetails.Columns["CustomerID"].Visible = false;
            }
        }

        private void tcManagement_Click(object sender, EventArgs e)
        {
        }
        // show image
        private void ShowProductImage(int id)
        {
            convertImage = new ConvertImage();
            // gọi ảnh lên bằng cách mã hóa chuỗi về ảnh
            string productBase64 = ProductDAO.Instance.GetProductImageFromDatabase(id);
            if (productBase64 == null)
            {
                MessageBox.Show("Không có hình ảnh để hiển thị");
            }
            else
            {
                System.Drawing.Image loadImage = convertImage.Base64ToImage(productBase64);
                // hiển thị ảnh 
                pbImageProduct.Image = loadImage;
            }
        }

        // Phân trang cho chi tiết hóa đơn
        private int currentPage = 1;
        private int pageSize = 10;
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua_Acc.Enabled = true; btnXoa_Acc.Enabled = true;
            txtTenTK.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            txtTenHT.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            txtMK.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
            txtPhoneNumber.Text = dgvUsers.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgvUsers.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = dgvUsers.CurrentRow.Cells[8].Value.ToString();
            string Str = dgvUsers.CurrentRow.Cells[9].Value.ToString();
            DateTime ngaylam;
            if (DateTime.TryParse(Str, out ngaylam))
            {
                dtpStartDate.Value = ngaylam;
            }
            else
            {
                MessageBox.Show("Ngày không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string gioiTinh = dgvUsers.CurrentRow.Cells[11].Value.ToString();
            if (gioiTinh == "Nam")
            {
                rdNam.Checked = true;
                rdNu.Checked = false;
            }
            else if (gioiTinh == "Nữ")
            {
                rdNam.Checked = false;
                rdNu.Checked = true;
            }
            string roleid = dgvUsers.CurrentRow.Cells[10].Value.ToString();
            if (roleid == "1")
            {
                cbType.Text = "Admin";
            }
            else if (roleid == "2")
            {
                cbType.Text = "Staff";
            }
        }
        private void validateInfor(object sender, EventArgs e)
        {
            validateData = new ValidateData();
            if (string.IsNullOrWhiteSpace(txtTenHT.Text))
            {
                errorProvider.SetError(txtTenHT, "Tên hiển thị không được để trống");
                return;
            }
            else
            {
                errorProvider.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                errorProvider.SetError(txtPhoneNumber, "Số điện thoại không được để trống");
                return;
            }
            else if (!validateData.validatePhone(txtPhoneNumber.Text))
            {
                errorProvider.SetError(txtPhoneNumber, "Số điện thoai không hợp lệ");
                return;
            }
            else
            {
                errorProvider.Clear();
            }

            errorProvider.SetError(txtPhoneNumber, "");

            if (string.IsNullOrWhiteSpace(cbType.Text))
            {
                errorProvider.SetError(cbType, "Chức vụ không được để trống");
                return;
            }
            else
            {
                errorProvider.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider.SetError(txtAddress, "Địa chỉ không được để trống");
                return;
            }
            else
            {
                errorProvider.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Email không được để trống");
                return;
            }
            else if (!validateData.validateEmail(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Email không hợp lệ");
                return;
            }
            else
            {
                errorProvider.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtTenTK.Text))
            {
                errorProvider.SetError(txtTenTK, "Tên tài khoản không được để trống");
                return;
            }
            else
            {
                errorProvider.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtMK.Text))
            {
                errorProvider.SetError(txtTenTK, "Mật khẩu không được để trống");
                return;
            }
            else
            {
                errorProvider.Clear();
            }

            if (!rdNam.Checked && !rdNu.Checked)
            {
                errorProvider.SetError(rdNam, "Bạn phải chọn giới tính!");
                return;
            }
            else
            {
                errorProvider.Clear();
            }


            if (dtpStartDate.Value > DateTime.Now)
            {
                errorProvider.SetError(dtpStartDate, "Ngày bắt đầu không hợp lệ!");
                return;
            }
            else
            {
                errorProvider.Clear();
            }
        }
        private void btnHuy_Acc_Click(object sender, EventArgs e)
        {
            btnXoa_Acc.Enabled = false;
            btnSua_Acc.Enabled = false;
            btnThem_Acc.Enabled = true;
            UnLoaded(false);
            ResetValue();
        }

        private void btnXoa_Acc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa tài khoản " + txtTenTK.Text + " này không ? ", "Xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                btnThem_Acc.Enabled = false;
                btnSua_Acc.Enabled = false;
                string querry = "UPDATE users SET ";
                int tt = 0;
                querry += "workingstatus = N'" + tt + "' ";
                querry += "WHERE UserName = N'" + txtTenTK.Text + "'";
                DataTable data2 = DAO.DataProvider.Instance.ExecuteQuery(querry);
                MessageBox.Show("Xóa tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManageAccount_Load();
                ResetValue();
                btnThem_Acc.Enabled = true;
                
            }
        }
        private void btnThem_Acc_Click(object sender, EventArgs e)
        {
            UnLoaded(true);
            btnSua_Acc.Enabled = false;
            btnXoa_Acc.Enabled = false;
            btnLuu_Acc.Enabled = true;
            ResetValue();
        }
        private void btnSua_Acc_Click(object sender, EventArgs e)
        {
            btnLuu_Category.Enabled = true;
            txtTenHT.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtAddress.Enabled = true;
            rdNam.Enabled = true;
            rdNu.Enabled = true;
            txtTenTK.Enabled = false;
            txtMK.Enabled = true;
            cbType.Enabled = true;
            txtEmail.Enabled = false;
            dtpStartDate.Enabled = true;
            btnSua_Acc.Enabled = true;
            btnXoa_Acc.Enabled = false;
            btnLuu_Acc.Enabled = true;
            btnThem_Acc.Enabled = false;
            dtpStartDate.Value = DateTime.Today;
        }
        private async void btnLuu_Acc_Click(object sender, EventArgs e)
        {
            string querry = "";
            validateInfor(sender, e);
            if (errorProvider.GetError(txtTenHT) != "" ||
            errorProvider.GetError(txtPhoneNumber) != "" ||
            errorProvider.GetError(cbType) != "" ||
            errorProvider.GetError(txtAddress) != "" ||
            errorProvider.GetError(txtEmail) != "" ||
            errorProvider.GetError(txtTenTK) != "" ||
            errorProvider.GetError(txtMK) != "" ||
            errorProvider.GetError(rdNam) != "" ||
            errorProvider.GetError(dtpStartDate) != "")
            {
                return; // Nếu có bất kỳ lỗi nào, dừng việc thực hiện tiếp
            }
            if (btnThem_Acc.Enabled == true)
            {
                validateInfor(sender, e);
                string sql = "Select  *  From users  Where  UserName  ='" + txtTenTK.Text + "'";
                DataTable data = DAO.DataProvider.Instance.ExecuteQuery(sql);
                if (data.Rows.Count > 0)
                {
                    errorProvider.SetError(txtTenTK, "Đã có tên tài khoản này!");
                    return;
                }
                errorProvider.Clear();
                UserDAO userDAO = new UserDAO();
                string mk = userDAO.HashPassword(txtMK.Text);

                int roleidd = 0;
                if (cbType.Text == "Admin")
                {
                    roleidd = 1;
                }
                else if (cbType.Text == "Staff")
                {
                    roleidd = 2;
                }
                string gioitinh = "";
                if (rdNam.Checked == true)
                {
                    gioitinh = "Nam";
                }
                else if (rdNu.Checked == true)
                {
                    gioitinh = "Nữ";
                }
                int tt = 1;
                querry = "INSERT  INTO users(userName,fullname,password, phone, email,address,DateWork, RoleID,  gender,workingstatus) VALUES(";
                querry += "N'" + txtTenTK.Text + "',N'" + txtTenHT.Text + "',N'" + mk + "',N'" + txtPhoneNumber.Text + "',N'" + txtEmail.Text + "',N'" + txtAddress.Text + "',N'" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "',N'" + roleidd + "',N'" + gioitinh + "',N'" + tt + "')";
                validateInfor(sender, e);
                DataTable data2 = DAO.DataProvider.Instance.ExecuteQuery(querry);
                MessageBox.Show("Thêm tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (btnSua_Acc.Enabled == true)
            {
                validateInfor(sender, e);
                string mk = dgvUsers.CurrentRow.Cells[3].Value.ToString();
                int roleidd = 0;
                if (cbType.Text == "Admin")
                {
                    roleidd = 1;
                }
                else if (cbType.Text == "Staff")
                {
                    roleidd = 2;
                }
                string gioitinh = "";
                if (rdNam.Checked == true)
                {
                    gioitinh = "Nam";
                }
                else if (rdNu.Checked == true)
                {
                    gioitinh = "Nữ";
                }
                //int tt = 1;
                UserDAO userDAO = new UserDAO();
                querry = "UPDATE users SET ";
                querry += "fullname = N'" + txtTenHT.Text + "', ";
                querry += "phone = N'" + txtPhoneNumber.Text + "', ";
                querry += "address = N'" + txtAddress.Text + "', ";
                querry += "DateWork = N'" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "', ";
                querry += "RoleID = N'" + roleidd + "', ";
                querry += "gender = N'" + gioitinh + "', ";
                //querry += "workingstatus = N'" + tt + "' ";
                string curentpassword = dgvUsers.CurrentRow.Cells[3].Value.ToString();
                if (txtMK.Text != curentpassword)
                {
                    mk = userDAO.HashPassword(txtMK.Text);
                    querry += ",password = N'" + mk + "'";
                }
                querry += "WHERE UserName = N'" + txtTenTK.Text + "'";

                DataTable data2 = DAO.DataProvider.Instance.ExecuteQuery(querry);
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ManageAccount_Load();
            UnLoaded(false);
            btnSua_Acc.Enabled = false;
            btnXoa_Acc.Enabled = false;
            btnThem_Acc.Enabled = true;
            ResetValue();
        }



        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_Category.Text = dgvCategory.CurrentRow.Cells[0].Value.ToString();
            txtLoai_Category.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
            richTextBoxMT.Text = dgvCategory.CurrentRow.Cells[2].Value.ToString();
            btnXoa_Category.Enabled = true;
            btnSua_Category.Enabled = true;

        }
        private void btnAdd_Category_Click(object sender, EventArgs e)
        {
            btnSua_Category.Enabled = false;
            btnXoa_Category.Enabled = false;
            btnLuu_Category.Enabled = true;
            ResetValue_Category();
            txtLoai_Category.Enabled = true;
            richTextBoxMT.Enabled = true;
        }
        private void btnSua__Category_Click(object sender, EventArgs e)
        {
            btnLuu_Category.Enabled = true;
            txtLoai_Category.Enabled = true;
            richTextBoxMT.Enabled = true;
            btnXoa_Category.Enabled = false;
            btnThem_Category.Enabled = false;
        }

        private async void btnSave_Category_Click(object sender, EventArgs e)
        {
            string querry = "";
            if (btnThem_Category.Enabled == true)
            {

                if (string.IsNullOrWhiteSpace(txtLoai_Category.Text))
                {
                    errorProvider.SetError(txtLoai_Category, "Tên loại không được để trống");
                    return;
                }
                else
                {
                    errorProvider.Clear();
                }
                string sql = "Select  *  From category  Where CategoryName  ='" + txtLoai_Category.Text + "'";
                DataTable data = DAO.DataProvider.Instance.ExecuteQuery(sql);
                if (data.Rows.Count > 0)
                {
                    errorProvider.SetError(txtLoai_Category, "Đã có tên loại này!");
                    return;
                }
                errorProvider.Clear();

                querry = "INSERT  INTO category(CategoryName,Description) VALUES(";
                querry += "N'" + txtLoai_Category.Text + "',N'" + richTextBoxMT.Text + "')";
                DataTable data2 = DAO.DataProvider.Instance.ExecuteQuery(querry);
                MessageBox.Show("Thêm loại thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (btnSua_Category.Enabled == true)
            {
                if (string.IsNullOrWhiteSpace(txtLoai_Category.Text))
                {
                    errorProvider.SetError(txtLoai_Category, "Tên loại không được để trống");
                    return;
                }
                else
                {
                    errorProvider.Clear();
                }
                querry = "UPDATE category SET ";
                querry += "CategoryName = N'" + txtLoai_Category.Text + "', ";
                querry += "Description = N'" + richTextBoxMT.Text + "' ";
                querry += "WHERE ID = N'" + txtID_Category.Text + "'";


                DataTable data2 = DAO.DataProvider.Instance.ExecuteQuery(querry);
                MessageBox.Show("Cập nhật loại thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Category_Load();
            Unloaded_Category(false);
            btnSua_Category.Enabled = false;
            btnXoa_Category.Enabled = false;
            btnThem_Category.Enabled = true;
            btnLuu_Category.Enabled = false;
            btnHuy_Category.Enabled = false;
            ResetValue_Category();
        }

        private void btnReset_Category_Click(object sender, EventArgs e)
        {
            btnXoa_Category.Enabled = false;
            btnSua_Category.Enabled = false;
            btnThem_Category.Enabled = true;
            Unloaded_Category(false);
            ResetValue_Category();
        }

        private void btnXoa_Category_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa loại " + txtLoai_Category.Text + " này không ? ", "Xóa loại", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                btnThem_Category.Enabled = false;
                btnSua_Acc.Enabled = false;
                string querry = "UPDATE category SET ";
                int sta = 0;
                querry += "Status = N'" + sta + "' ";
                querry += "WHERE ID = N'" + txtID_Category.Text + "'";
                DataTable data2 = DAO.DataProvider.Instance.ExecuteQuery(querry);
                MessageBox.Show("Xóa loại thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Category_Load();
                ResetValue_Category();

            }
        }

        private void btnTim_Acc_Click(object sender, EventArgs e)
        {
            string searchInput = txtTimAcc.Text.Trim();
            string query = "";
            if (string.IsNullOrEmpty(searchInput))
            {
                query = "SELECT * FROM dbo.users where Workingstatus = 1";
                DataTable data = DAO.DataProvider.Instance.ExecuteQuery(query);
                //MessageBox.Show("Vui lòng nhập tên tài khoản để tìm kiếm.");
                //return;
            }
            query = "SELECT * FROM users WHERE fullname LIKE N'%" + searchInput + "%'";

            DataTable result = DAO.DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                dgvUsers.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản nào.");
            }
        }

        
        // Cac chuc nang cua Bill Details
        private void btnFirst_Click_1(object sender, EventArgs e)
        {
            currentPage = 1;
            BillInfoDAO.Instance.DisplayPage(currentPage, pageSize, currentPage, dgvBillDetails, lblPageNumber);
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                BillInfoDAO.Instance.DisplayPage(currentPage, pageSize, currentPage, dgvBillDetails, lblPageNumber);
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (currentPage < BillInfoDAO.Instance.TotalPages(pageSize))
            {
                currentPage++;
                BillInfoDAO.Instance.DisplayPage(currentPage, pageSize, currentPage, dgvBillDetails, lblPageNumber);
            }
        }

        private void btnLast_Click_1(object sender, EventArgs e)
        {
            currentPage = BillInfoDAO.Instance.TotalPages(pageSize);
            BillInfoDAO.Instance.DisplayPage(currentPage, pageSize, currentPage, dgvBillDetails, lblPageNumber);
        }


        // Dinh dang tien BillDetails
        private void dgvBillDetails_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBillDetails.Columns[e.ColumnIndex].Name == "TotalBill")
            {
                if (e.Value != null)
                {
                    CultureInfo vietnam = new CultureInfo("vi-VN");
                    e.Value = string.Format(vietnam, "{0:C0}", e.Value);
                    e.FormattingApplied = true;
                }
            }
        }

        // Cac chuc nang Product
        private void btnSearchProduct_Click_1(object sender, EventArgs e)
        {
            dtgvProduct.DataSource = SearchProductByName(txtSearchProductName.Text);
        }

        private void btnChooseImageProduct_Click_1(object sender, EventArgs e)
        {
            btnSaveProductImage.Enabled = true;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Thiết lập bộ lọc cho file hình ảnh
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All files (*.*)|*.*";
                openFileDialog.Title = "Chọn hình ảnh sản phẩm";

                // Hiển thị hộp thoại và kiểm tra nếu người dùng đã chọn file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file đã chọn
                    string selectedFilePath = openFileDialog.FileName;

                    // Hiển thị hình ảnh trong PictureBox (giả sử bạn có một PictureBox tên là pictureBoxProduct)
                    pbImageProduct.Image = System.Drawing.Image.FromFile(selectedFilePath);
                    pbImageProduct.Size = new System.Drawing.Size(265, 115);
                    pbImageProduct.SizeMode = PictureBoxSizeMode.Zoom; // Thay đổi kích thước hình ảnh để phù hợp với PictureBox
                }
            }
        }

        private void btnSaveProductImage_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn lưu hình ảnh này không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                btnSaveProductImage.Enabled = false;

                try
                {
                    int productID = int.Parse(txtProductID.Text);
                    if (pbImageProduct.Image != null)
                    {

                        using (MemoryStream ms = new MemoryStream())
                        {
                            pbImageProduct.Image.Save(ms, pbImageProduct.Image.RawFormat);
                            byte[] imageBytes = ms.ToArray();

                            string base64String = Convert.ToBase64String(imageBytes);

                            ProductDAO.Instance.SaveImageToDatabase(productID, base64String);

                            MessageBox.Show("Hình ảnh đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dtgvProduct_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Load categoryName
                DataGridViewRow row = dtgvProduct.Rows[e.RowIndex];
                int categoryID = Convert.ToInt32(row.Cells["CategoryID"].Value);
                string categoryName = CategoryDAO.Instance.GetCategoryNameByID(categoryID);
                cbbProductCategory.Text = categoryName;

                pbImageProduct.Image = null;

                string productIdString = dtgvProduct.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                // Thử chuyển đổi chuỗi sang int
                if (int.TryParse(productIdString, out int productIdInt))
                {
                    ShowProductImage(productIdInt);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một ID sản phẩm hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnViewProduct_Click_1(object sender, EventArgs e)
        {}

        private void btnEditProduct_Click_1(object sender, EventArgs e)
        {
            string name = txtProductName.Text;
            int categoryID = (cbbProductCategory.SelectedItem as Category).ID;
            float price = (float)nmProductPrice.Value;
            int id = Convert.ToInt32(txtProductID.Text);

            if (ProductDAO.Instance.UpdateProduct(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListProduct();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
            LoadListProduct();
            AddProductBinding();
        }

        private void btnDeleteProduct_Click_1(object sender, EventArgs e)
        {
            string id = txtProductID.Text;
            int idInt = Convert.ToInt32(txtProductID.Text);
            bool res = BillInfoDAO.Instance.CheckProductBeforeDelete(idInt);
            if (res)
            {
                MessageBox.Show("Sản phẩm này đã có trong chi tiết hóa đơn khác, bạn không thể xóa, vui lòng chọn sản phẩm khác", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //int id_2 = Convert.ToInt32((string)txtProductID.Text);
                //if (ProductDAO.Instance.DeleteProduct(id_2))
                //{
                //    MessageBox.Show("Xóa món thành công");
                //    LoadListProduct();
                //}
                //else
                //{
                //    MessageBox.Show("Có lỗi khi xóa thức ăn");
                //}
            }
            LoadListProduct();
            AddProductBinding();
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            string name = txtProductName.Text;
            int categoryID = (cbbProductCategory.SelectedItem as Category).ID;
            float price = (float)nmProductPrice.Value;

            if (ProductDAO.Instance.InsertProduct(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListProduct();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
            LoadListProduct();
            AddProductBinding();
        }

        
    }
}