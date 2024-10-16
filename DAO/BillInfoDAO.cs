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
            using (SqlConnection conn = new SqlConnection("Data Source=TIENCHUNG0003\\SQLEXPRESS;Initial Catalog=coffeeApplication;Persist Security Info=True;User ID=sa;Password=sktt1popo"))
            {
                conn.Open();
                string query = @"
                    select b.ID, DateCheckIn, DateCheckOut, status, u.UserName as [Tên nhân viên], TableID, TotalBill, discount, payment_name from bill b inner join users u on b.UserID = u.ID order by b.ID
                    offset @Offset ROWS
                    fetch next @PageSize rows only";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Offset", (pageNumber - 1) * pageSize); 
                    cmd.Parameters.AddWithValue("@PageSize", pageSize);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                }
                int totalPage = TotalPages(pageSize);
                lblPageNumber.Text = $"Trang {currentPage}/{totalPage}";

                conn.Close();
            }
        }

        public int TotalPages(int pageSize)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=TIENCHUNG0003\\SQLEXPRESS;Initial Catalog=coffeeApplication;Persist Security Info=True;User ID=sa;Password=sktt1popo"))
            {
                conn.Open ();

                string countQuery = "SELECT COUNT(*) FROM bill";
                using (SqlCommand cmd = new SqlCommand (countQuery, conn))
                {
                    int totalRecords = (int)cmd.ExecuteScalar();
                    return (int)Math.Ceiling((double)totalRecords / pageSize);
                }

				conn.Close();
			}
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
