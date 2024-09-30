﻿using CoffeeApp.DAO;
using CoffeeApp.DTO;
using CoffeeApp.GUI;
using CoffeeApp.GUI.Login;
using CoffeeApp.GUI.Main;
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
            string username = tbLoginName.Text;
            string password = tbLoginPassword.Text;

            // Console.WriteLine(username+ "   "+ password);
            //Console.WriteLine(DAO.AccountDAO.Instance.HashPassword("123"));

            if (DAO.UserDAO.Instance.checkLogin(username, password))
            {
                
                DataTable data = DAO.UserDAO.Instance.QueryRoleUser(username);
                DataRow row = data.Rows[0];
                UserDTO user = new UserDTO(row);

                formMain = new FormMain(user.UserName, user.RoleID);

                if (user.CodeEmail == "")
                {
                    string verificationCode = await EmailService.SendVerificationCodeAsync(user.Email);
                    this.Hide();
                    FormInputEmail forminputemail = new FormInputEmail(this, formsignup,user.UserName, user.Password, user.Phone, user.Email,user.RoleID, verificationCode); // 0 đại diện cho việc insert
                    forminputemail.ShowDialog();
                }

                if(user.CodeEmail != "")
                {
                    this.Hide();
                    formMain.ShowDialog();
                }
            }

            //        this.Hide();

            //        FormInputEmail forminputemail = new FormInputEmail(this, formsignup);
            //        forminputemail.ShowDialog();

            //        //if (forminputemail.clickCheckCode == true)
            //        //{
            //        //    if(verificationCode == forminputemail.CodeInputEmail())
            //        //    {
            //                forminputemail.Close();
            //                string statusEmail = "Đã xác thực";
            //                int roleID = 1;
            //                if (DAO.UserDAO.Instance.UpdateUser(user.UserName, user.Password, user.Phone, user.Email, forminputemail.CodeInputEmail(), statusEmail, roleID, "", "", "", ""))
            //                {
            //                    MessageBox.Show("Xác thực tài khoản thành công - Đăng nhập thành công");
            //                    this.Hide();
            //                    formMain.ShowDialog();
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Xác thực tài khoản thất bại - Đăng nhập thất bại");
            //                }
            //            }
            //            else
            //            {
            //                forminputemail.clickCheckCode = false;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        this.Hide();
            //        MessageBox.Show("Đăng nhập thành công");
            //        formMain = new FormMain(user.UserName, user.RoleID);
            //        formMain.ShowDialog();
            //    }
            //}    
            //else
            //{
            //    MessageBox.Show("Tên đăng nhập hoặc số điện thoại hoặc mật khẩu sai !");
            //}
        }

        #endregion
    }
}
