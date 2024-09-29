using CoffeeApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Web.Security;

namespace CoffeeApp.BUS
{
    internal class UserBUS
    {
        private static UserBUS instance;

        public static UserBUS Instance
        {
            get { if (instance == null) instance = new UserBUS(); return instance; }
            private set { instance = value; }
        }

        public bool checkLogin(string usernameOrPhone, string password)
        {
            return DAO.UserDAO.Instance.checkLogin(usernameOrPhone, password);
        }

        public bool checkUserName(string username)
        {
            return DAO.UserDAO.Instance.checkUserName(username);
        }

        public bool checkEmail(string email)
        {
            return DAO.UserDAO.Instance.checkUserName(email);
        }
        public bool checkPhone(string phone)
        {
            return DAO.UserDAO.Instance.checkUserName(phone);
        }

        public bool InsertUser(string userName, string passWord, string phone, string email, string codeEmail, string status, int roleID)
        {
            return DAO.UserDAO.Instance.InsertUser(userName, passWord, phone, email, codeEmail, status, roleID);
        }

       
    }
}
