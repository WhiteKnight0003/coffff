using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using CoffeeApp.DTO;

namespace CoffeeApp.DAO
{
    internal class UserDAO
    {
        private static UserDAO instance;

        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return instance; }
            private set { instance=value; }
        }

        public UserDAO() { }

        public string HashPassword(string password)
            {
            //  SHA256 hoặc SHA512. Những thuật toán này không phải là "mã hóa" mà là "băm", tức là chúng chuyển đổi mật khẩu thành một chuỗi giá trị không thể đảo ngược

            byte[] passwordByte = ASCIIEncoding.ASCII.GetBytes(password); // chuyển password thành 1 mảng byte
            // Băm mật khẩu
            SHA256 sha256 = new SHA256Managed();
            byte[] hashBytes = sha256.ComputeHash(passwordByte);

            // Chuyển đổi mảng byte thành chuỗi hexa (để lưu trữ)
            StringBuilder hashStringBuilder = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                hashStringBuilder.Append(b.ToString("x2")); // Chuyển byte thành chuỗi hexa
            }

            // Trả về chuỗi băm
            return hashStringBuilder.ToString();
        }

        public bool checkUserName(string username)
        {
            // string query = $"select * from users where UserName=N'{username}'";
            string query = "USP_UserName @username";
            return DAO.DataProvider.Instance.ExecuteQuery(query, new object[] {username}).Rows.Count>0;
        }

        public bool checkEmail(string email)
        {
            //string query = $"select * from users where Email=N'{email}'";
            string query = "USP_Email @email";
            return DAO.DataProvider.Instance.ExecuteQuery(query, new object[] {email}).Rows.Count > 0;
        }

        public bool checkPhone(string phone)
        {
            // string query = $"select * from users where phone=N'{phone}'";
            string query = "USP_Phone @phone";
            return DAO.DataProvider.Instance.ExecuteQuery(query, new object[] {phone}).Rows.Count > 0;
        }


        public DataTable UserEmail(string email)
        {
            //string query = $"select * from users where Email=N'{email}'";
            //return DAO.DataProvider.Instance.ExcuteQuery(query);
            string query = "USP_Email @email";
            return DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { email });
        }

        public DataTable QueryRoleUser(string username)
        {
            // string query = $"select * from Users where username = N'{username}'";
            string query = "USP_UserName @username";        
            return DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { username });
        }

        public UserDTO GetByUserName(string username)
        {
            // string query = $"select * from Users where username = N'{username}'";
            string query = "USP_UserName @username";
            DataTable dt =  DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            DataRow dr = dt.Rows[0];
            UserDTO res = new UserDTO(dr);
            return res;
        }

        public DataTable QueryUserEmail(string email)
        {
            //string query = $"select * from users where Email=N'{email}'";
            //return DAO.DataProvider.Instance.ExcuteQuery(query);
            string query = "USP_Email @email";
            return DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { email });
        }

        public DataTable QueryUserName(string username)
        {
            // string query = $"select * from Users where username = N'{username}'";
            string query = "USP_UserName @username";
            return DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { username });
        }


        public DataTable FullUsers()
        {
            //string query = $"select * from Users ";
            string query = "USP_Users";
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] {});
            return data;
        }

        public bool checkLogin(string usernameOrPhone, string password)
        {
            string haspass = HashPassword(password); // mã hóa pass trước

            string phone = null;
            string username = null;


            if (usernameOrPhone.All(char.IsDigit)) // nếu đây là số điện thoại
            {
                phone = usernameOrPhone;
            }
            else
            {
                username = usernameOrPhone;
            }
            string query = "USP_Login @username , @password , @phone";

            // Tạo danh sách các tham số để truyền vào
            var parameters = new List<object>();

            // Thêm username vào danh sách nếu không null
            if (username != null)
                parameters.Add(username);
            else
                parameters.Add(DBNull.Value); // Truyền giá trị null cho @username nếu username không có

            // Thêm password (luôn có giá trị)
            parameters.Add(haspass);

            // Thêm phone vào danh sách nếu không null
            if (phone != null)
                parameters.Add(phone);
            else
                parameters.Add(DBNull.Value); // Truyền giá trị null cho @phone nếu phone không có
            DataTable resData = DataProvider.Instance.ExecuteQuery(query,  parameters.ToArray());


            return resData.Rows.Count > 0; // số dòng trả ra
        }

       

        public bool InsertUser(string userName, string passWord,string phone , string email,string codeEmail, string statusEmail, int roleID, string fullName, string address, string gender, string image, int workingStatus)
        {
            try
            {
                DAO.DataProvider.Instance.ExecuteNonQuery($"INSERT INTO users(UserName, Password, Phone, email, codeEmail, statusEmail, RoleID , fullName , address , gender , image , workingStatus) " +
                    $"VALUES (N'{userName}', N'{passWord}', N'{phone}', N'{email}', N'{codeEmail}', N'{statusEmail}', {roleID} , N'{fullName}', N'{address}', N'{gender}', N'{image}' ,{workingStatus})");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateUser(string userName, string passWord, string phone, string email, string codeEmail, string statusEmail, int roleID, string fullName, string address, string gender, string image, int workingStatus)
        {
            try
            {
                DAO.DataProvider.Instance.ExecuteNonQuery($"UPDATE users SET userName = N'{userName}', password = N'{passWord}',phone= N'{phone}', Email = N'{email}', codeEmail = N'{codeEmail}',statusEmail=N'{statusEmail}', roleID = {roleID}, fullname = N'{fullName}', address = N'{address}' , gender=N'{gender}', image = N'{image}', workingStatus = {workingStatus} WHERE username = N'{userName}'");

            }
            catch
            {
                return false;
            }
            return true;
        }


    }
}
