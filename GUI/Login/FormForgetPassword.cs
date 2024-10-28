using CoffeeApp.DTO;
using CoffeeApp.Util;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CoffeeApp.GUI.Login
{
    public partial class FormForgetPassword : Form
    {
        private FormLogin formLogin;
        private string verificationCode;
        private ValidateData validateData;
        public FormForgetPassword(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            validateData = new ValidateData();
        }


        #region Events
        private void linkBackFormLoginToFormForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            formLogin.Show();
        }

        private void cbForgetPasswordViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbForgetPasswordViewPassword.Checked)
                {
                    // bật hiển thị mật khẩu 
                    txbForgetPasswordNewPassword.UseSystemPasswordChar = false;
                    txbForgetPasswordReNewPassword.UseSystemPasswordChar = false;

                    // dùng \0 để mật khẩu đc hiện lên
                    txbForgetPasswordNewPassword.PasswordChar = '\0';
                    txbForgetPasswordReNewPassword.PasswordChar = '\0';
                }
                else
                {
                    // bật hiển thị mật khẩu 
                    txbForgetPasswordNewPassword.UseSystemPasswordChar = true;
                    txbForgetPasswordReNewPassword.UseSystemPasswordChar = true;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ khi có lỗi xảy ra
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSentCodeEmailForgetPassword_Click(object sender, EventArgs e)
        {   
            if(txbForgetPasswordEmail.Text == "")
            {
                lbForgetPasswordEmail.Text = "Email không được để trống";
            }
            else if (!validateData.validateEmail(txbForgetPasswordEmail.Text))
            {
                lbForgetPasswordEmail.Text = "Email không hợp lệ";
            }
            else
            {
               if (DAO.UserDAO.Instance.checkEmail(txbForgetPasswordEmail.Text))
                    verificationCode = await EmailService.SendVerificationCodeAsync(txbForgetPasswordEmail.Text);
                else lbForgetPasswordEmail.Text = "Email không tồn tại";
            }
                
        }
        #endregion

        private void btnConfirmForgetPassword_Click(object sender, EventArgs e)
        {
            if (txbForgetPasswordEmail.Text == "")
            {
                lbForgetPasswordEmail.Text = "Email không được để trống !";
                if(txbForgetPasswordCodeEmail.Text.Trim() == "")
                {
                    lbForgetPasswordCodeEmail.Text = "Mã xác minh không được để trống !";
                    if (txbForgetPasswordNewPassword.Text == "")
                    {
                        lbForgetPasswordNewpassword.Text = "Mật khẩu không được để trống !";
                        if(txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else 
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                    }
                    else
                    {
                        lbForgetPasswordNewpassword.Text = "";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else if(txbForgetPasswordNewPassword.Text != txbForgetPasswordReNewPassword.Text )
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                        else {
                           lbForgetPasswordReNewpassword.Text = "";
                        }
                    }
                }
                else 
                {
                    lbForgetPasswordCodeEmail.Text = "Mã xác nhận không đúng";
                    if (txbForgetPasswordNewPassword.Text == "")
                    {
                        lbForgetPasswordNewpassword.Text = "Mật khẩu không được để trống !";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                    }
                    else
                    {
                        lbForgetPasswordNewpassword.Text = "";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else if (txbForgetPasswordNewPassword.Text != txbForgetPasswordReNewPassword.Text)
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "";
                        }
                    }
                }
            }
            else if (!validateData.validateEmail(txbForgetPasswordEmail.Text))
            {
                lbForgetPasswordEmail.Text = "Email không hợp lệ";
                if (txbForgetPasswordCodeEmail.Text.Trim() == "")
                {
                    lbForgetPasswordCodeEmail.Text = "Mã xác minh không được để trống !";
                    if (txbForgetPasswordNewPassword.Text == "")
                    {
                        lbForgetPasswordNewpassword.Text = "Mật khẩu không được để trống !";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                    }
                    else
                    {
                        lbForgetPasswordNewpassword.Text = "";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else if (txbForgetPasswordNewPassword.Text != txbForgetPasswordReNewPassword.Text)
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "";
                        }
                    }
                }
                else
                {
                    lbForgetPasswordCodeEmail.Text = "Mã xác nhận không đúng";
                    if (txbForgetPasswordNewPassword.Text == "")
                    {
                        lbForgetPasswordNewpassword.Text = "Mật khẩu không được để trống !";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                    }
                    else
                    {
                        lbForgetPasswordNewpassword.Text = "";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else if (txbForgetPasswordNewPassword.Text != txbForgetPasswordReNewPassword.Text)
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "";
                        }
                    }
                }
            }
            else if (!DAO.UserDAO.Instance.checkEmail(txbForgetPasswordEmail.Text))
            {
                lbForgetPasswordEmail.Text = "Email không tồn tại";

                if (txbForgetPasswordCodeEmail.Text.Trim() == "")
                {
                    lbForgetPasswordCodeEmail.Text = "Mã xác minh không được để trống !";
                    if (txbForgetPasswordNewPassword.Text == "")
                    {
                        lbForgetPasswordNewpassword.Text = "Mật khẩu không được để trống !";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                    }
                    else
                    {
                        lbForgetPasswordNewpassword.Text = "";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else if (txbForgetPasswordNewPassword.Text != txbForgetPasswordReNewPassword.Text)
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "";
                        }
                    }
                }
                else
                {
                    lbForgetPasswordCodeEmail.Text = "Mã xác nhận không đúng";
                    if (txbForgetPasswordNewPassword.Text == "")
                    {
                        lbForgetPasswordNewpassword.Text = "Mật khẩu không được để trống !";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                    }
                    else
                    {
                        lbForgetPasswordNewpassword.Text = "";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else if (txbForgetPasswordNewPassword.Text != txbForgetPasswordReNewPassword.Text)
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "";
                        }
                    }
                }
                
            }
            else 
            {
                lbForgetPasswordEmail.Text = "";
                if (txbForgetPasswordCodeEmail.Text.Trim() == "")
                {
                    lbForgetPasswordCodeEmail.Text = "Mã xác minh không được để trống !";
                    if (txbForgetPasswordNewPassword.Text == "")
                    {
                        lbForgetPasswordNewpassword.Text = "Mật khẩu không được để trống !";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                    }
                    else
                    {
                        lbForgetPasswordNewpassword.Text = "";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else if (txbForgetPasswordNewPassword.Text != txbForgetPasswordReNewPassword.Text)
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "";
                        }
                    }
                }
                else if (txbForgetPasswordCodeEmail.Text.Trim() != verificationCode)
                {
                    lbForgetPasswordCodeEmail.Text = "Mã xác nhận không đúng";
                    if (txbForgetPasswordNewPassword.Text == "")
                    {
                        lbForgetPasswordNewpassword.Text = "Mật khẩu không được để trống !";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                    }
                    else
                    {
                        lbForgetPasswordNewpassword.Text = "";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else if (txbForgetPasswordNewPassword.Text != txbForgetPasswordReNewPassword.Text)
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "";
                        }
                    }
                }
                else
                {
                    lbForgetPasswordCodeEmail.Text = "";
                    if (txbForgetPasswordNewPassword.Text == "")
                    {
                        lbForgetPasswordNewpassword.Text = "Mật khẩu không được để trống !";
                        if (txbForgetPasswordReNewPassword.Text == "")
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                    }
                    else
                    {
                        lbForgetPasswordNewpassword.Text = "";
                        if(txbForgetPasswordReNewPassword.Text == "") 
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không được để trống !";
                        }
                        else if (txbForgetPasswordNewPassword.Text != txbForgetPasswordReNewPassword.Text)
                        {
                            lbForgetPasswordReNewpassword.Text = "Mật khẩu không trùng khớp !";
                        }
                        else
                        {
                            lbForgetPasswordReNewpassword.Text = "";

                            DataTable dataTable = DAO.UserDAO.Instance.UserEmail(txbForgetPasswordEmail.Text);
                            UserDTO userDTO = new UserDTO(dataTable.Rows[0]);

                            if(userDTO.Workingstatus == "0")
                            {
                                MessageBox.Show("Tài khoản không hợp lệ ");
                            }
                            else
                            {
                                if (DAO.UserDAO.Instance.UpdateUser(userDTO.UserName, DAO.UserDAO.Instance.HashPassword(txbForgetPasswordNewPassword.Text), userDTO.Phone, userDTO.Email, verificationCode, userDTO.StatusEmail, userDTO.RoleID, userDTO.FullName, userDTO.Address, userDTO.Gender, userDTO.Image, 1))
                                {
                                    MessageBox.Show("Đặt lại mật khẩu thành công -  Nhấn ok để trở về trang đăng nhập");
                                    this.Close();
                                    formLogin.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Đặt lại mật khẩu thất bại");
                                }
                            }
                            
                        }
                    }
                    
                }
            }
        }
    }
}
