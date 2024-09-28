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

namespace CoffeeApp.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance=value; }
        }

        public AccountDAO() { }


        /*
         * Create proc USP_Login
            @UserName nvarchar(100), @Password nvarchar(100)
            As
            Begin
	            SELECT * from [User] where UserName = @UserName and Password = @Password
            end
         */

           private string HashPassword(string password)
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

        //public bool Login(string username, string password)
        //{
        //    string haspass = HashPassword(password); // mã hóa pass trước
        //    string query = " USP_Login @username , @password";
        //    DataTable resData = DataProvider.Instance.ExcuteQuery(query, new object[] { username, haspass});


        //    return resData.Rows.Count > 0; // số dòng trả ra
        //}
        public bool Login(string usernameOrPhone, string password)
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
            DataTable resData = DataProvider.Instance.ExcuteQuery(query,  parameters.ToArray());


            return resData.Rows.Count > 0; // số dòng trả ra
        }

        //public bool CheckName(string username)
        //{
        //    string query = "USP_UserName @username";
        //    DataTable res = DataProvider.Instance.ExcuteQuery(query, new object[] { username });
        //    return res.Rows.Count > 0;
        //}

        //public bool InsertUser(string username, string displayname, string password, int role)
        //{
        //    string haspass = HashPassword(password);

        //    string query = string.Format("Insert [User] (UserName, DisplayName, Password, RoleId) values (N'{0}',N'{1}', N'{2}',{3}) ", username, displayname, haspass, role);

        //    int res = DataProvider.Instance.ExecutenonQuery(query);

        //    return res > 0;
        //}
    }
}
