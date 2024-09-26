using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        #endregion
    }
}
