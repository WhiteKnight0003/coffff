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

		private void validateEmail(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txbForgetPasswordEmail.Text))
			{
				errorProvider.SetError(txbForgetPasswordEmail, "Email không được để trống !");
				return;
			}
			else if (!validateData.validateEmail(txbForgetPasswordEmail.Text))
			{
				errorProvider.SetError(txbForgetPasswordEmail, "Email không đúng định dạng !");
				return;
			}
			else
			{
				if (DAO.UserDAO.Instance.checkEmail(txbForgetPasswordEmail.Text))
				{
					errorProvider.Clear();				
				}

				else
				{
					errorProvider.SetError(txbForgetPasswordEmail, "Email không tồn tại !");
					return;
				}
			}
		}
		private async void btnSentCodeEmailForgetPassword_Click(object sender, EventArgs e)
		{
			validateEmail(sender, e);
			if(DAO.UserDAO.Instance.checkEmail(txbForgetPasswordEmail.Text))
				verificationCode = await EmailService.SendVerificationCodeAsync(txbForgetPasswordEmail.Text);
		}
		#endregion

		private void validateInfo(object sender, EventArgs e)
		{

			validateEmail(sender, e);


			if (string.IsNullOrWhiteSpace(txbForgetPasswordCodeEmail.Text.Trim()))
			{
				errorProvider.SetError(txbForgetPasswordCodeEmail, "Mã xác minh không được để trống !");
				return;
			}
			else if (txbForgetPasswordCodeEmail.Text.Trim() != verificationCode)
			{
				errorProvider.SetError(txbForgetPasswordCodeEmail, "Mã xác nhận không đúng !");
				return;
			}
			else
			{
				errorProvider.Clear();
			}


			if (string.IsNullOrWhiteSpace(txbForgetPasswordNewPassword.Text))
			{
				errorProvider.SetError(txbForgetPasswordNewPassword, "Mật khẩu mới không được để trống !");
				return;
			}
			else
			{
				errorProvider.Clear();
			}

			if (string.IsNullOrWhiteSpace(txbForgetPasswordReNewPassword.Text))
			{
				errorProvider.SetError(txbForgetPasswordReNewPassword, "Mật khẩu xác nhận không được để trống !");
				return;
			}
			else if (txbForgetPasswordNewPassword.Text != txbForgetPasswordReNewPassword.Text)
			{
				errorProvider.SetError(txbForgetPasswordReNewPassword, "Mật khẩu không trùng khớp !");
				return;
			}
			else
			{
				errorProvider.Clear();
			}
		}
		private void btnConfirmForgetPassword_Click(object sender, EventArgs e)
		{
			validateInfo(sender, e);
			if (DAO.UserDAO.Instance.checkEmail(txbForgetPasswordEmail.Text) && txbForgetPasswordCodeEmail.Text.Trim() == verificationCode && txbForgetPasswordNewPassword.Text == txbForgetPasswordReNewPassword.Text)
			{
				errorProvider.Clear();

				DataTable dataTable = DAO.UserDAO.Instance.UserEmail(txbForgetPasswordEmail.Text);
				UserDTO userDTO = new UserDTO(dataTable.Rows[0]);

				if (userDTO.Workingstatus == "0")
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
