using CoffeeApp.DTO;
using CoffeeApp.GUI.Login;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CoffeeApp.GUI.Main
{
    public partial class FormInputEmail : Form
    {
        private FormSignUp formsignup;
        private FormLogin formLogin;
        private string username;
        private string password;
        private string phone;
        private string email;
        private string verificationCode;
        private int roleID;

        public FormInputEmail(FormLogin formLogin, FormSignUp formsignup, string username, string password, string phone, string email,int roleID, string verificationCode)
        {
            InitializeComponent();
            this.formLogin = formLogin; 
            this.formsignup= formsignup;
            this.username = username;
            this.password = password;
            this.phone = phone;
            this.email = email;
            this.verificationCode = verificationCode;
            this.roleID = roleID; 
        }

        private void btnGetCodeEmail_Click(object sender, EventArgs e)
        {
            if(txbCodeEmail.Text != verificationCode)
            {
                lbErrorEqualCodeEmail.Text = "Mã xác minh chưa đúng";
            }
            else
            {
                if (DAO.UserDAO.Instance.checkUserName(username))
                {
                    if (DAO.UserDAO.Instance.UpdateUser(username,password,phone, email, txbCodeEmail.Text, "Đã xác thực",roleID,"","","",""))
                    {
                        MessageBox.Show("Tài khoản đã được xác minh -  Nhấn Ok để quay về trang đăng nhập ");                      
                    }
                    else
                    {
                        MessageBox.Show("Xác minh thất bại");
                    }
                    this.Close();
                    formLogin.Show();
                }
                else
                {
                    if(DAO.UserDAO.Instance.InsertUser(username, password, phone, email, txbCodeEmail.Text, "Đã xác thực",1, "", "", "", ""))
                    {
                        MessageBox.Show("Đăng kí tài khoản thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đăng kí tài khoản thất bại");
                    }
                    this.Close();
                    formsignup.ShowDialog();
                }
                
            }
        }

        private void btnExitCodeEmail_Click(object sender, EventArgs e)
        {
            if (!DAO.UserDAO.Instance.checkUserName(username))
            {
                if (DAO.UserDAO.Instance.InsertUser(username, password, phone, email, "", "Chưa xác thực", 1, "", "", "", ""))
                {
                    MessageBox.Show("Tài khoản chưa được xác minh");
                }
                else
                {
                    MessageBox.Show("Đăng kí tài khoản thất bại");
                }
            }
            this.Close();
            formLogin.Show();
        }
    }
}
