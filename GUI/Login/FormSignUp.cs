﻿using CoffeeApp.GUI.Login;
using CoffeeApp.GUI.Main;
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

        public FormSignUp(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
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
            if(!DAO.UserDAO.Instance.checkUserName(username) && !DAO.UserDAO.Instance.checkEmail(email) && validateEmail(email) && !DAO.UserDAO.Instance.checkPhone(phone) && password!="" && password == repassword)
            {
                string verificationCode = await EmailService.SendVerificationCodeAsync(email);
                this.Hide();
                FormInputEmail forminputemail = new FormInputEmail(formLogin, this,username, DAO.UserDAO.Instance.HashPassword(password), phone, email,1, verificationCode); // 0 đại diện cho việc insert
                forminputemail.ShowDialog();
            }
            else
            {
                if (DAO.UserDAO.Instance.checkUserName(username))
                {
                    if (DAO.UserDAO.Instance.checkEmail(email))
                    {
                        if (DAO.UserDAO.Instance.checkPhone(phone))
                        {

                        }
                    }
                    else if (validateEmail(email))
                    {
                        if (DAO.UserDAO.Instance.checkPhone(phone))
                        {

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
