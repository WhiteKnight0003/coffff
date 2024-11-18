using CoffeeApp.DTO;
using CoffeeApp.GUI.Login;
using CoffeeApp.Util;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CoffeeApp.GUI.Main
{
    public partial class FormInputEmail : Form
    {
        private FormSignUp formsignup;
        private FormLogin formLogin;
        private UserDTO user;
        private string verificationCode;

        public  FormInputEmail(FormLogin formLogin, FormSignUp formsignup, UserDTO user, string verificationCode)
        {
            InitializeComponent();
            this.formLogin = formLogin; 
            this.formsignup= formsignup;
            this.user = user;
            this.verificationCode = verificationCode;
        }

        private void btnGetCodeEmail_Click(object sender, EventArgs e)
        {
            if(txbCodeEmail.Text.Trim() != verificationCode)
            {
                lbErrorEqualCodeEmail.Text = "Mã xác minh chưa đúng";
            }
            else
            {
                if (DAO.UserDAO.Instance.checkUserName(user.UserName))
                {
                    UserDTO userDTO = DAO.UserDAO.Instance.GetByUserName(user.UserName);
                    userDTO.StatusEmail = "Đã xác thực";
                    userDTO.CodeEmail = txbCodeEmail.Text.Trim();

					if (DAO.UserDAO.Instance.UpdateUser(userDTO))
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
                    UserDTO newUser = new UserDTO();
                    newUser.UserName = user.UserName;
                    newUser.Password = user.Password;
					newUser.Email = user.Email;
					newUser.Phone = user.Phone;
                    newUser.StatusEmail = "Đã xác thực";
					newUser.RoleID = 2;
                    newUser.Image = user.Image;
                    newUser.Workingstatus = "1";
                    newUser.Image = user.Image;

					if (DAO.UserDAO.Instance.InsertUser(newUser, txbCodeEmail.Text))
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
            if (!DAO.UserDAO.Instance.checkUserName(user.UserName))
            {
                user.StatusEmail = "Chưa xác thực";
                user.RoleID = 2;
                user.Workingstatus = "1";

				if (DAO.UserDAO.Instance.InsertUser(user,""))
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
            verificationCode = await EmailService.SendVerificationCodeAsync(user.Email);
        }
    }
}
