using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp.GUI
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
         
        }

       

        // -	ở trong là những dữ liệu cần đc load liên tục
        #region Method
        
        #endregion


        // -	Chạy các sự kiện như click , …..
        #region Events

        private void cbViewSignUpPassword_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbViewSignUpPassword.Checked)
                {
                    // bật hiển thị mật khẩu 
                    txSignUpPassword.UseSystemPasswordChar = false;
                    txSignUpRePassword.UseSystemPasswordChar = false;

                    // dùng \0 để mật khẩu đc hiện lên
                    txSignUpPassword.PasswordChar = '\0';
                    txSignUpRePassword.PasswordChar = '\0';
                }
                else
                {
                    // bật hiển thị mật khẩu 
                    txSignUpPassword.UseSystemPasswordChar = true;
                    txSignUpRePassword.UseSystemPasswordChar = true;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ khi có lỗi xảy ra
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtSignUpUserName.Text;
            string email = txtSignUpEmail.Text;
            string phone = txtSignUpPhone.Text;
            string password = txSignUpPassword.Text;
            string repassword = txSignUpRePassword.Text;

            //if(validateEmail(email))
            if (BUS.UserBUS.Instance.checkUserName(username))
            {
                lbValidateUserName.Text = "Tên đăng nhập đã tồn tại";
                if (BUS.UserBUS.Instance.checkEmail(email))
                {
                    lbValidateEmail.Text = "Email đã tồn tại";
                    if (BUS.UserBUS.Instance.checkPhone(phone))
                    {
                        lbValidatePhone.Text = "Số điện thoại đã tồn tại";
                        if (password == "")
                        {
                            lbValidatePassword.Text = "Mật khẩu không được để trống";
                            if (repassword == "")
                            {
                                lbValidateRePassword.Text = "Mật khẩu không được để trống";
                            }
                        }
                    }
                }
            }
            
        }
        #endregion

        private bool validateEmail(string email)
        {
            string pattern = @"^[\w!#$%&'*+/=?^_`{|}~-]+(?:\.[\w!#$%&'*+/=?^_`{|}~-]+)*@(?:[\w](?:[\w-]*[\w])?\.)+[\w](?:[\w-]*[\w])?$";
            if(Regex.IsMatch(email, pattern))   
                return true;
            return false;
        }

       
    }
}
