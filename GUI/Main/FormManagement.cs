using CoffeeApp.DAO;
using CoffeeApp.DTO;
using CoffeeApp.Util;
using DevExpress.Internal;
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

        public FormManagement(FormMain formmain ,string username, int roleID)
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
                data.Add(i,0);
            }

            // năm theo thời gian thực
            for(int i=2000; i<= DateTime.Now.Year; i++)
            {
                cbChooseYear.Items.Add(i);
            }
        }


        //private void loadDataChart()
        //{

        //}
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
            if(dataTable.Rows.Count > 0)
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
        private void btnViewProduct_Click(object sender, EventArgs e)
        {
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
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

        private void btnDeleteProduct_Click(object sender, EventArgs e)
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

        private void btnAddProduct_Click(object sender, EventArgs e)
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

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            dtgvProduct.DataSource = SearchProductByName(txtSearchProductName.Text);
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

        // Chọn ảnh
        private void btnChooseImageProduct_Click(object sender, EventArgs e)
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

        private void dtgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        // Lưu ảnh cho sản phẩm
        private void btnSaveProductImage_Click(object sender, EventArgs e)
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

        // Load ảnh cho các sản phẩm
        private void dtgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
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

        // Phân trang cho chi tiết hóa đơn
        private int currentPage = 1;
        private int pageSize = 10;

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            BillInfoDAO.Instance.DisplayPage(currentPage, pageSize, currentPage, dgvBillDetails, lblPageNumber);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(currentPage > 1)
            {
                currentPage--;
                BillInfoDAO.Instance.DisplayPage(currentPage, pageSize, currentPage, dgvBillDetails, lblPageNumber);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < BillInfoDAO.Instance.TotalPages(pageSize))
            {
                currentPage++;
                BillInfoDAO.Instance.DisplayPage(currentPage, pageSize, currentPage, dgvBillDetails, lblPageNumber);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = BillInfoDAO.Instance.TotalPages(pageSize);
            BillInfoDAO.Instance.DisplayPage(currentPage, pageSize, currentPage, dgvBillDetails, lblPageNumber);
        }


        // Định dạng tiền
        private void dgvBillDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
    }

}
