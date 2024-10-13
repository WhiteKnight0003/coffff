using CoffeeApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
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

        public FormManagement(FormMain formmain ,string username, int roleID)
        {
            InitializeComponent();
            this.formmain = formmain;
            this.username = username;
            this.roleID = roleID;
            Decentralization(username, roleID);
            data = new Dictionary<int, float>();
            loadData();
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
    }
}
