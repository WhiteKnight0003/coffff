using CoffeeApp.GUI.Login;
using CoffeeApp.GUI.Main;
using CoffeeApp.Util;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CoffeeApp.GUI
{
    public partial class FormSignUp : Form
    {
        private FormLogin formLogin;
        private FormMain formMain;
        private ValidateData validateData;
        public FormSignUp(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            validateData = new ValidateData();
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

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtSignUpUserName.Text;
            string email = txtSignUpEmail.Text;
            string phone = txtSignUpPhone.Text;
            string password = txSignUpPassword.Text;
            string repassword = txSignUpRePassword.Text;

            // đúng hết
            if(!DAO.UserDAO.Instance.checkUserName(username) && !DAO.UserDAO.Instance.checkEmail(email) && validateData.validateEmail(email) && !DAO.UserDAO.Instance.checkPhone(phone) && validateData.validatePhone(phone) && password!="" && password == repassword)
            {
                lbValidateUserName.Text = lbValidatePhone.Text = lbValidateEmail.Text = lbValidatePassword.Text = lbValidateRePassword.Text = "";
                string verificationCode = await EmailService.SendVerificationCodeAsync(email);
                this.Hide();
                FormInputEmail forminputemail = new FormInputEmail(formLogin, this,username, DAO.UserDAO.Instance.HashPassword(password), phone, email,1, verificationCode); // 0 đại diện cho việc insert
                forminputemail.ShowDialog();               
            }
            else
            {
                if (DAO.UserDAO.Instance.checkUserName(username))
                {
                    lbValidateUserName.Text = "Tên đăng nhập đã tồn tại !";
                    if (DAO.UserDAO.Instance.checkEmail(email))
                    {
                        lbValidateEmail.Text = "Email đã tồn tại !";
                        if (DAO.UserDAO.Instance.checkPhone(phone))
                        {
                            lbValidatePhone.Text = "Số điện thoại đã tồn tại !";
                            if(password == "")
                            {
                                lbValidatePassword.Text = "Mật khẩu không được để trống";
                                if (repassword == "")
                                {
                                    lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                }
                                else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                            }
                            else {
                                lbValidatePassword.Text = "";
                                if (repassword == "")
                                {
                                    lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                }

                                else if(password != repassword)
                                {
                                    lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                     lbValidateRePassword.Text = "";
                                }
                            }
                        }
                        else
                        {
                            if (!validateData.validatePhone(phone))
                            {
                                lbValidatePhone.Text = "Số điện thoại chỉ bao gồm 10 số";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                lbValidatePhone.Text = "";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }
                            
                        }
                    }
                    else if (!validateData.validateEmail(email))
                    {
                        lbValidateEmail.Text = "Email chưa đúng định dạng";
                        if (DAO.UserDAO.Instance.checkPhone(phone))
                        {
                            lbValidatePhone.Text = "Số điện thoại đã tồn tại !";
                            if (password == "")
                            {
                                lbValidatePassword.Text = "Mật khẩu không được để trống";
                                if (repassword == "")
                                {
                                    lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                }
                                else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                            }
                            else
                            {
                                lbValidatePassword.Text = "";
                                if (repassword == "")
                                {
                                    lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                }

                                else if (password != repassword)
                                {
                                    lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidateRePassword.Text = "";
                                }
                            }
                        }
                        else
                        {
                            if (!validateData.validatePhone(phone))
                            {
                                lbValidatePhone.Text = "Số điện thoại chỉ bao gồm 10 số";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                lbValidatePhone.Text = "";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }

                        }
                    }
                    else if(email == "")
                    {
                        lbValidateEmail.Text = "Email không được để trống ";
                        if (DAO.UserDAO.Instance.checkPhone(phone))
                        {
                            lbValidatePhone.Text = "Số điện thoại đã tồn tại !";
                            if (password == "")
                            {
                                lbValidatePassword.Text = "Mật khẩu không được để trống";
                                if (repassword == "")
                                {
                                    lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                }
                                else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                            }
                            else
                            {
                                lbValidatePassword.Text = "";
                                if (repassword == "")
                                {
                                    lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                }

                                else if (password != repassword)
                                {
                                    lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidateRePassword.Text = "";
                                }
                            }
                        }
                        else
                        {
                            if (!validateData.validatePhone(phone))
                            {
                                lbValidatePhone.Text = "Số điện thoại chỉ bao gồm 10 số";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                lbValidatePhone.Text = "";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }

                        }
                    }
                    else
                    {
                        lbValidateEmail.Text = "";
                        if (DAO.UserDAO.Instance.checkPhone(phone))
                        {
                            lbValidatePhone.Text = "Số điện thoại đã tồn tại !";
                            if (password == "")
                            {
                                lbValidatePassword.Text = "Mật khẩu không được để trống";
                                if (repassword == "")
                                {
                                    lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                }
                                else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                            }
                            else
                            {
                                lbValidatePassword.Text = "";
                                if (repassword == "")
                                {
                                    lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                }

                                else if (password != repassword)
                                {
                                    lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidateRePassword.Text = "";
                                }
                            }
                        }
                        else
                        {
                            if (!validateData.validatePhone(phone))
                            {
                                lbValidatePhone.Text = "Số điện thoại chỉ bao gồm 10 số";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                lbValidatePhone.Text = "";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }

                        }
                    }
                }
                else
                {
                    if(username == "")
                    {
                        lbValidateUserName.Text = "Tên đăng nhập không được để trống";
                        if (DAO.UserDAO.Instance.checkEmail(email))
                        {
                            lbValidateEmail.Text = "Email đã tồn tại !";
                            if (DAO.UserDAO.Instance.checkPhone(phone))
                            {
                                lbValidatePhone.Text = "Số điện thoại đã tồn tại !";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                if (!validateData.validatePhone(phone))
                                {
                                    lbValidatePhone.Text = "Số điện thoại chỉ bao gồm 10 số";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    lbValidatePhone.Text = "";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }

                            }
                        }
                        else if (!validateData.validateEmail(email))
                        {
                            lbValidateEmail.Text = "Email chưa đúng định dạng";
                            if (DAO.UserDAO.Instance.checkPhone(phone))
                            {
                                lbValidatePhone.Text = "Số điện thoại đã tồn tại !";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                if (!validateData.validatePhone(phone))
                                {
                                    lbValidatePhone.Text = "Số điện thoại chỉ bao gồm 10 số";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    lbValidatePhone.Text = "";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }

                            }
                        }
                        else if (email == "")
                        {
                            lbValidateEmail.Text = "Email không được để trống ";
                            if (DAO.UserDAO.Instance.checkPhone(phone))
                            {
                                lbValidatePhone.Text = "Số điện thoại đã tồn tại !";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                if (!validateData.validatePhone(phone))
                                {
                                    lbValidatePhone.Text = "Số điện thoại chỉ bao gồm 10 số";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    lbValidatePhone.Text = "";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }

                            }
                        }
                        else
                        {
                            lbValidateEmail.Text = "";
                            if (DAO.UserDAO.Instance.checkPhone(phone))
                            {
                                lbValidatePhone.Text = "Số điện thoại đã tồn tại !";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                if (!validateData.validatePhone(phone))
                                {
                                    lbValidatePhone.Text = "Số điện thoại chỉ bao gồm 10 số";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    lbValidatePhone.Text = "";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }

                            }
                        }
                    }
                    else
                    {
                        lbValidateUserName.Text = "";
                        if (DAO.UserDAO.Instance.checkEmail(email))
                        {
                            lbValidateEmail.Text = "Email đã tồn tại !";
                            if (DAO.UserDAO.Instance.checkPhone(phone))
                            {
                                lbValidatePhone.Text = "Số điện thoại đã tồn tại !";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                if (!validateData.validatePhone(phone))
                                {
                                    lbValidatePhone.Text = "Số điện thoại chỉ bao gồm 10 số";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    lbValidatePhone.Text = "";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }

                            }
                        }
                        else if (!validateData.validateEmail(email))
                        {
                            lbValidateEmail.Text = "Email chưa đúng định dạng";
                            if (DAO.UserDAO.Instance.checkPhone(phone))
                            {
                                lbValidatePhone.Text = "Số điện thoại đã tồn tại !";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                if (!validateData.validatePhone(phone))
                                {
                                    lbValidatePhone.Text = "Số điện thoại chỉ bao gồm 10 số";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    lbValidatePhone.Text = "";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }

                            }
                        }
                        else if (email == "")
                        {
                            lbValidateEmail.Text = "Email không được để trống ";
                            if (DAO.UserDAO.Instance.checkPhone(phone))
                            {
                                lbValidatePhone.Text = "Số điện thoại đã tồn tại !";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                if (!validateData.validatePhone(phone))
                                {
                                    lbValidatePhone.Text = "Số điện thoại chỉ bao gồm 10 số";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    lbValidatePhone.Text = "";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }

                            }
                        }
                        else
                        {
                            lbValidateEmail.Text = "";
                            if (DAO.UserDAO.Instance.checkPhone(phone))
                            {
                                lbValidatePhone.Text = "Số điện thoại đã tồn tại !";
                                if (password == "")
                                {
                                    lbValidatePassword.Text = "Mật khẩu không được để trống";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }
                                    else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                }
                                else
                                {
                                    lbValidatePassword.Text = "";
                                    if (repassword == "")
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                    }

                                    else if (password != repassword)
                                    {
                                        lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidateRePassword.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                if (!validateData.validatePhone(phone))
                                {
                                    lbValidatePhone.Text = "Số điện thoại chỉ bao gồm 10 số";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    lbValidatePhone.Text = "";
                                    if (password == "")
                                    {
                                        lbValidatePassword.Text = "Mật khẩu không được để trống";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }
                                        else lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                    }
                                    else
                                    {
                                        lbValidatePassword.Text = "";
                                        if (repassword == "")
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không được để trống";
                                        }

                                        else if (password != repassword)
                                        {
                                            lbValidateRePassword.Text = "Mật khẩu không trùng khớp";
                                        }
                                        else
                                        {
                                            lbValidateRePassword.Text = "";
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }
        }
        #endregion

        private void linkBackFormLoginToFormSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            formLogin.Show();
        }
    }
}
