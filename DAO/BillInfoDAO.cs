using CoffeeApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp.DAO
{
    internal class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }

        public void DeleteBillInfoByProductID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.BillDetails WHERE productID = " + id);
        }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillDetails WHERE billID = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }

        public void InsertBillInfo(int idBill, int idProduct, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idProduct , @count", new object[] { idBill, idProduct, count });
        }

        public void DisplayPage(int pageNumber, int pageSize, int currentPage, DataGridView dataGridView, Label lblPageNumber)
        {
            // Tính toán Offset
            int offset = (pageNumber - 1) * pageSize;

            // Câu truy vấn SQL có sử dụng OFFSET và FETCH
            string query = @"
            select b.ID, DateCheckIn, DateCheckOut, status, u.UserName as [Tên nhân viên], TableID, TotalBill, discount, payment_name 
            from bill b 
            inner join users u on b.UserID = u.ID 
            order by b.ID
            offset @Offset ROWS
            fetch next @PageSize rows only";

            // Tham số truyền vào truy vấn
            object[] parameters = { offset, pageSize };

            // Gọi phương thức ExecuteQuery từ class DataProvider để lấy dữ liệu
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, parameters);

            // Gán dữ liệu vào DataGridView
            dataGridView.DataSource = dt;

            // Tính toán và hiển thị số trang
            int totalPage = TotalPages(pageSize);
            lblPageNumber.Text = $"Trang {currentPage}/{totalPage}";
        }

        public int TotalPages(int pageSize)
        {
            // Câu truy vấn để đếm tổng số bản ghi trong bảng bill
            string countQuery = "SELECT COUNT(*) FROM bill";

            // Gọi phương thức ExecuteScalar từ class DataProvider để lấy tổng số bản ghi
            object result = DataProvider.Instance.ExecuteScalar(countQuery);

            // Chuyển đổi kết quả trả về từ object sang int
            int totalRecords = Convert.ToInt32(result);

            // Tính toán và trả về tổng số trang
            return (int)Math.Ceiling((double)totalRecords / pageSize);
        }


        public bool CheckProductBeforeDelete(int productID)
        {
            string query = "select * from billdetails where ProductID = " + productID;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return true;
            }
            else return false;

        }
    }
}