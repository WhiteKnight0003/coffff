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
        private string Imgbase64String;

        public FormInputEmail(FormLogin formLogin, FormSignUp formsignup, string username, string password, string phone, string email,int roleID, string verificationCode, string Imgbase64String)
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
            this.Imgbase64String = Imgbase64String;
        }

        private void btnGetCodeEmail_Click(object sender, EventArgs e)
        {
            if(txbCodeEmail.Text.Trim() != verificationCode)
            {
                lbErrorEqualCodeEmail.Text = "Mã xác minh chưa đúng";
            }
            else
            {
                if (DAO.UserDAO.Instance.checkUserName(username))
                {
                    UserDTO userDTO = DAO.UserDAO.Instance.GetByUserName(username);
                    if (DAO.UserDAO.Instance.UpdateUser(username,password,phone, email, txbCodeEmail.Text, "Đã xác thực",roleID,userDTO.FullName,userDTO.Address,userDTO.Gender,Imgbase64String))
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
                    if(DAO.UserDAO.Instance.InsertUser( username, password, phone, email, txbCodeEmail.Text, "Đã xác thực",2, "", "", "", Imgbase64String))
                    {
                        MessageBox.Show("Đăng kí tài khoản thành công - nhấn ok để về trang đăng nhập");
                        this.Close();
                        formLogin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng kí tài khoản thất bại");
                        this.Close();
                        formsignup.Show();
                    }
                   
                }
                
            }
        }

        private void btnExitCodeEmail_Click(object sender, EventArgs e)
        {
            if (!DAO.UserDAO.Instance.checkUserName(username))
            {
                if (DAO.UserDAO.Instance.InsertUser(username, password, phone, email, "", "Chưa xác thực", 2, "", "", "", Imgbase64String))
                {
                    MessageBox.Show("Tài khoản đã được đăng kí nhưng chưa được xác minh - nhấn oke để về trang đăng nhập");
                    this.Close();
                    formLogin.Show();
                }
                else
                {
                    MessageBox.Show("Đăng kí tài khoản thất bại");
                    this.Close();
                    formsignup.Show();
                }
            }
            else
            {
                this.Hide();
                formLogin.Show();
            }
        }

        private async void btnReSendCodeEmail_Click(object sender, EventArgs e)
        {
            verificationCode = await EmailService.SendVerificationCodeAsync(email);
        }
    }
}
