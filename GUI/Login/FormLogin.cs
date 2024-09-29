using CoffeeApp.DAO;
using CoffeeApp.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp
{
    public partial class FormLogin : Form
    {
        int countViewPassword = 0;
        public FormLogin()
        {
            InitializeComponent();
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
            FormSignUp fsu = new FormSignUp();
            this.Hide();
            fsu.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbLoginName.Text;
            string password = tbLoginPassword.Text;

           // Console.WriteLine(username+ "   "+ password);
            //Console.WriteLine(DAO.AccountDAO.Instance.HashPassword("123"));

            if (BUS.UserBUS.Instance.checkLogin(username, password))
            {
                FormMain fm = new FormMain(1,1);
                this.Hide();
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        #endregion
    }
}
