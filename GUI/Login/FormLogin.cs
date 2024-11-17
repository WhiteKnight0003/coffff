using CoffeeApp.DAO;
using CoffeeApp.DTO;
using CoffeeApp.GUI;
using CoffeeApp.GUI.Login;
using CoffeeApp.GUI.Main;
using CoffeeApp.Util;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CoffeeApp
{
    public partial class FormLogin : Form
    {
        int countViewPassword = 0;
        private FormSignUp formsignup;
        private FormMain formMain;
        private ConvertImage convertImage;
        public FormLogin()
        {
            InitializeComponent();
            formsignup = new FormSignUp(this);
        }


        //  	Chạy các sự kiện như click , …..
        #region Events  

        // ẩn hiện mật khẩu ở phần đăng nhập
        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            try
            {
                ++countViewPassword;
                if (countViewPassword % 2 == 1)
                {
                    tbLoginPassword.UseSystemPasswordChar = false;
                    tbLoginPassword.PasswordChar = '\0';// Hiển thị ký tự rõ ràng                 
                    btnViewPassword.Image = Properties.Resources.visibility_off;
                }

                else
                {
                    tbLoginPassword.UseSystemPasswordChar = true;
                    btnViewPassword.Image = Properties.Resources.visibility;

                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ khi có lỗi xảy ra
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            formsignup.ShowDialog();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbLoginName.Text.Trim();
            string password = tbLoginPassword.Text.Trim();

            // Console.WriteLine(username+ "   "+ password);
            //Console.WriteLine(DAO.AccountDAO.Instance.HashPassword("123"));

            if (DAO.UserDAO.Instance.checkLogin(username, password))
            {
                
                DataTable data = DAO.UserDAO.Instance.QueryRoleUser(username);
                DataRow row = data.Rows[0];
                UserDTO user = new UserDTO(row);

                if(user.Workingstatus == "1")
                {
                    formMain = new FormMain(this, user.UserName, user.RoleID);

                    if (user.CodeEmail == "")
                    {
                        string verificationCode = await EmailService.SendVerificationCodeAsync(user.Email);
                        this.Hide();
                        FormInputEmail forminputemail = new FormInputEmail(this, formsignup, user.UserName, user.Password, user.Phone, user.Email, user.RoleID, verificationCode, user.Image); // 0 đại diện cho việc insert
                        forminputemail.ShowDialog();
                    }

                    if (user.CodeEmail != "")
                    {
                        this.Hide();
                        MessageBox.Show("Đăng nhập thành công");
                        formMain.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại , vui lòng thử lại với tài khoản khác");
                }

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc số điện thoại hoặc mật khẩu sai !");
            }

          
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            FormForgetPassword formForgetPassword = new FormForgetPassword(this);
            this.Hide();
            formForgetPassword.ShowDialog();
        }

        #endregion


        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        public string getUsername()
        {
            return tbLoginName.Text;
        }

        public void setUsername(string s)
        {
            tbLoginName.Text = s;
        }
        public string getPassword()
        {
            return tbLoginPassword.Text;
        }
        public void setPassword(string s)
        {
            tbLoginPassword.Text = s;
        }
    }
}
