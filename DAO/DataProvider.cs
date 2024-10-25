using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;


namespace CoffeeApp.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance;

        internal static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }

            private set => DataProvider.instance = value;
        }

        public DataProvider() { }

        //string sqlConnect = "Data Source=(local);Initial Catalog=QLChoThueNha_BTL;Persist Security Info=True;User ID=sa;Password=nam123;Trust Server Certificate=True";
        //private String connectionStr = "Data Source=DESKTOP-671LI2L\\SQLEXPRESS;Initial Catalog=coffeeApplication;User ID=sa;Password=123456";
        //private String connectionStr = "Data Source=TIENCHUNG0003\\SQLEXPRESS;Initial Catalog=coffeeApplication;Persist Security Info=True;User ID=sa;Password=sktt1popo";
        //private String connectionStr = "Data Source=HIDDENLOVE\\SQLEXPRESS;Initial Catalog=coffeeApplication;Persist Security Info=True;User ID=sa;Password=Trongan-13";
        private String connectionStr = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=coffeeApplication;Integrated Security=True;";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            // đổ data ra table
            DataTable data = new DataTable();

            // gọi hàm và nó tự giải phóng bộ nhớ 
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open(); // mở kết nối ra

                // truy vấn
                SqlCommand command = new SqlCommand(query, connection);

                // command.Parameters.AddWithValue("@userName", id); truyền 1 tham số

                // câu lệnh sql có nhiều trường
                if (parameter != null)
                {
                    string[] listPara = query.Split(' '); // cắt hết các đối tượng ra theo khoảng trắng
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@')) // kiểm tra xem có chứa dấu @ không => nếu có thì có chứa parameter
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                //trung gian để lấy data
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // đổ dữ liệu lấy ra vào table
                adapter.Fill(data);

                // đóng kết nối
                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null) // kết quả khi bn insert, delete, update thì nó sẽ trả ra số dòng thành công
        {

            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@')) // tìm từ cáo dấu @
                        {
                            command.Parameters.AddWithValue(item, parameter[i]); // tìm thành công , gán 1 parameter được truyền vào cho nó
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery(); // trả về số dòng thành công

                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null) // phù hợp cho việc select count * - giống như kiểu trâ về  số lượng bản ghi hoặc một giá trị cụ thể từ một cột
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                data = command.ExecuteScalar();

                connection.Close(); // đóng kết nối
            }
            return data;
        }

    }
}