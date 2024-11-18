using CoffeeApp.DTO;
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
        private bool isSignUp = false;
        private ConvertImage convertImage;
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

		private void validateInfo(object sender, EventArgs e)
        {
			string username = txtSignUpUserName.Text.Trim();
			string email = txtSignUpEmail.Text.Trim();
			string phone = txtSignUpPhone.Text.Trim();
			string password = txSignUpPassword.Text.Trim();
			string repassword = txSignUpRePassword.Text.Trim();

			if (DAO.UserDAO.Instance.checkUserName(username))
			{
				errorProvider.SetError(txtSignUpUserName, "Tên đăng nhập đã tồn tại !");
				return;		
			}
			else
			{
				if (string.IsNullOrWhiteSpace(username))
				{
					errorProvider.SetError(txtSignUpUserName, "Tên đăng nhập không được để trống !");
					return;
				}
				else
				{
				errorProvider.Clear();
				}
			}


			if (DAO.UserDAO.Instance.checkEmail(email))
			{
				errorProvider.SetError(txtSignUpEmail, "Email đã tồn tại !");
				return;
			}
			else if (string.IsNullOrWhiteSpace(email))
			{
				errorProvider.SetError(txtSignUpEmail, "Email không được để trống !");
				return;
			}
			else if (!validateData.validateEmail(email))
			{
				errorProvider.SetError(txtSignUpEmail, "Email chưa đúng định dạng !");
				return;
			}			
			else
			{
				errorProvider.Clear();
			}


			if (DAO.UserDAO.Instance.checkPhone(phone))
			{
				errorProvider.SetError(txtSignUpPhone, "Số điện thoại đã tồn tại !");
				return;
			}
			else
			{
				if (string.IsNullOrWhiteSpace(phone))
				{
					errorProvider.SetError(txtSignUpPhone, "Số điện thoại không được để trống !");
					return;
				}
				else if (!validateData.validatePhone(phone))
				{
					errorProvider.SetError(txtSignUpPhone, "Số điện thoại chỉ bao gồm 10 số và phải bắt đầu bằng đầu số 03 , 05, 07 hoặc 09  !");
					return;
				}
				else
				{
					errorProvider.Clear();
				}

			}

			if (string.IsNullOrWhiteSpace(password))
			{
				errorProvider.SetError(txSignUpPassword, "Mật khẩu mới không được để trống !");
				return;
			}
			else
			{
				errorProvider.Clear();
			}

			if (repassword == "")
			{
				errorProvider.SetError(txSignUpRePassword, "Mật khẩu xác nhận không được để trống !");
				return;
			}
			else if (repassword  != password){
				errorProvider.SetError(txSignUpRePassword, "Mật khẩu không trùng khớp !");
				return;
			}
			else
			{
				errorProvider.Clear();
			}				
		}


        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtSignUpUserName.Text.Trim();
            string email = txtSignUpEmail.Text.Trim();
            string phone = txtSignUpPhone.Text.Trim();
            string password = txSignUpPassword.Text.Trim();
            string repassword = txSignUpRePassword.Text.Trim();

			validateInfo(sender, e);
            // đúng hết
            if(!DAO.UserDAO.Instance.checkUserName(username) && !DAO.UserDAO.Instance.checkEmail(email) && validateData.validateEmail(email) && !DAO.UserDAO.Instance.checkPhone(phone) && validateData.validatePhone(phone) && password!="" && password == repassword)
            {
           
                string verificationCode = await EmailService.SendVerificationCodeAsync(email);

                convertImage = new ConvertImage();
                Image img = Properties.Resources.Image_Default;
                Image reimg = convertImage.ResizeImage(img, 200, 200);
                string Imgbase64String = convertImage.ImageToBase64(reimg, System.Drawing.Imaging.ImageFormat.Png);
                Console.WriteLine(Imgbase64String);

                this.Hide();

				UserDTO newUser = new UserDTO();
				newUser.UserName =username;
				newUser.Email = email;
				newUser.Phone = phone;
				newUser.RoleID = 2;
				newUser.Workingstatus = "1";
				newUser.Password = DAO.UserDAO.Instance.HashPassword(password);
				newUser.Image = Imgbase64String;

				
				FormInputEmail forminputemail = new FormInputEmail(formLogin, this,newUser, verificationCode); // 0 đại diện cho việc insert
                forminputemail.ShowDialog();               
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
