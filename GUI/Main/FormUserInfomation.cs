using CoffeeApp.DTO;
using CoffeeApp.GUI.Login;
using CoffeeApp.Util;
using DevExpress.Data.Filtering;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CoffeeApp.GUI.Main
{
    public partial class FormUserInfomation : Form
    {
        private FormMain formMain;
        private string username;
        private ConvertImage convertImage;
        private ValidateData validateData;
        private string verificationCode;
        private Image showImageUser;
        public FormUserInfomation(FormMain formMain, string username)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.username = username;
            showData();
        }

        #region Method
        private void showData()
        {
            DataTable dataUser = DAO.UserDAO.Instance.QueryUserName(username);
            UserDTO userDTO = new UserDTO(dataUser.Rows[0]);
            DataTable dataRole = DAO.RoleDAO.Instance.QueryRoleName(userDTO.RoleID);
            RoleDTO roleDTO = new RoleDTO(dataRole.Rows[0]);

            tbInfoUserName.Text = userDTO.UserName;
            tbInfoRole.Text = roleDTO.RoleName;

            convertImage = new ConvertImage();
            // gọi ảnh lên bằng cách mã hóa chuỗi về ảnh
            Image loadImage = convertImage.Base64ToImage(userDTO.Image);

            // đánh dấu xem ng dùng đang dùng ảnh nào
            showImageUser = loadImage;

            // hiển thị ảnh 
            pbImageUser.Image = loadImage;


            // Lấy thông tin văn hóa hiện tại và sau đó gọi ToTitleCase để viết hoa ký tự đầu của mỗi từ
           TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo; 
            

            tbInfoFullName.Text = textInfo.ToTitleCase(userDTO.FullName.ToLower());

            tbInfoPhone.Text = userDTO.Phone;
            tbInfoEmail.Text = userDTO.Email;
            tbInfoAddress.Text = textInfo.ToTitleCase(userDTO.Address.ToLower());  

            if (userDTO.Gender.ToLower() == "nam")
            {
                rbSexFeMale.Checked = true;
            }
            else if (userDTO.Gender.ToLower() == "nữ")
            {
                rbSexMale.Checked = true;
            }
        }

        #endregion

        #region Events
        private void btnRefreshInfo_Click(object sender, EventArgs e)
        {
            DataTable dataUser = DAO.UserDAO.Instance.QueryUserName(username);
            UserDTO userDTO = new UserDTO(dataUser.Rows[0]);

            tbInfoFullName.Text = userDTO.FullName;
            tbInfoPhone.Text = userDTO.Phone;
            tbInfoEmail.Text = userDTO.Email;
            tbInfoCodeNewEmail.Text = "";
            tbInfoAddress.Text = userDTO.Address;

            if(userDTO.Gender.ToLower() == "nam") 
                rbSexFeMale.Checked = true;
            else if (userDTO.Gender.ToLower() == "nữ")
            {
                rbSexMale.Checked = true;
            }

            lbValidateAddress.Text = lbValidateEmail.Text = lbValidateFullName.Text = lbValidateGender.Text = lbValidateNewCodeEmail.Text = lbValidatePhone.Text = ""; 
        }

        


        private async void btnInfoSendCodeNewEmail_Click(object sender, EventArgs e)
        {
            validateData = new ValidateData();
            if (tbInfoEmail.Text == "")
            {
                lbValidateEmail.Text = "Email không được để trống !";
            }
            else if (!validateData.validateEmail(tbInfoEmail.Text))
            {
                lbValidateEmail.Text = "Email không hợp lệ !"; 
            }
            else
            {
                // chưa có thì gửi
                if (!DAO.UserDAO.Instance.checkEmail(tbInfoEmail.Text))
                    verificationCode = await EmailService.SendVerificationCodeAsync(tbInfoEmail.Text);
                else
                {
                    lbValidateEmail.Text = "Email đã được xác minh !";
                }
            }
        }

        private void btnUpdateInfoUser_Click(object sender, EventArgs e)
        {
            DataTable data = DAO.UserDAO.Instance.QueryUserName(tbInfoUserName.Text);
            UserDTO user = new UserDTO(data.Rows[0]);
            string sex = "";
            validateData = new ValidateData();
            convertImage = new ConvertImage();

            string ImageToBase64 = convertImage.ImageToBase64(showImageUser, System.Drawing.Imaging.ImageFormat.Png);
            // cập nhật khi mọi thông tin đều oke
            // cần gọi thêm ảnh
            if (tbInfoEmail.Text != "")
            {
                if(tbInfoEmail.Text.ToLower() == user.Email.ToLower())
                {
                    lbValidateEmail.Text = "";
                    lbValidateNewCodeEmail.Text = "";
                    if (tbInfoFullName.Text != "" && tbInfoPhone.Text != "" && validateData.validatePhone(tbInfoPhone.Text) && tbInfoAddress.Text != "" && (rbSexMale.Checked || rbSexFeMale.Checked))
                    {
                        lbValidateFullName.Text = "";
                        lbValidatePhone.Text = "";
                        lbValidateEmail.Text = "";
                        lbValidateGender.Text = "";

                        if (rbSexMale.Checked)
                        {
                            sex = "Nữ";
                        }
                        else if (rbSexFeMale.Checked)
                        {
                            sex = "Nam";
                        }

                        // chưa có đường dẫn ảnh
                        if (MessageBox.Show("Bạn chắc chắn muốn thay đổi thông tin", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            if (DAO.UserDAO.Instance.UpdateUser(username, user.Password, tbInfoPhone.Text, user.Email, user.CodeEmail, user.StatusEmail, user.RoleID, tbInfoFullName.Text, tbInfoAddress.Text, sex, ImageToBase64))
                            {
                                MessageBox.Show("Cập nhật thông tin thành công !");
                            }
                            else MessageBox.Show("Cập nhật thông tin thất bại !");
                        }
                    }
                    // trường hợp email cũ  nhưng những cái khác sai
                    else
                    {
                        if (tbInfoFullName.Text == "")
                        {
                            lbValidateFullName.Text = "Tên đầy đủ không được để trống !";
                            if (tbInfoPhone.Text == "")
                            {                              
                                lbValidatePhone.Text = "Số điện thoại không được để trống !";
                                if (tbInfoAddress.Text == "")
                                {
                                    lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                                else
                                {
                                    lbValidateAddress.Text = "";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                            }
                            else if (!validateData.validatePhone(tbInfoPhone.Text))
                            {
                                lbValidatePhone.Text = "Số điện thoại không hợp lệ !";
                                if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }                              
                            }
                            else
                            {
                                lbValidatePhone.Text = "";
                                if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                            }
                        }
                        else
                        {
                            lbValidateFullName.Text = "";
                            if (tbInfoPhone.Text == "")
                            {
                                lbValidatePhone.Text = "Số điện thoại không được để trống !";
                                if (tbInfoCodeNewEmail.Text == "")
                                {
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                            }
                            else if (!validateData.validatePhone(tbInfoPhone.Text))
                            {
                                lbValidatePhone.Text = "Số điện thoại không hợp lệ !";
                                if (tbInfoCodeNewEmail.Text == "")
                                {
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                lbValidatePhone.Text = "";
                                if (tbInfoCodeNewEmail.Text == "")
                                {
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if (validateData.validateEmail(tbInfoEmail.Text) && !DAO.UserDAO.Instance.checkEmail(tbInfoEmail.Text))
                {
                    lbValidateEmail.Text = "";
                    if (tbInfoFullName.Text != "" && tbInfoPhone.Text != "" && validateData.validatePhone(tbInfoPhone.Text) && tbInfoAddress.Text != "" && (rbSexMale.Checked || rbSexFeMale.Checked) && tbInfoCodeNewEmail.Text!="" && tbInfoCodeNewEmail.Text == verificationCode)
                    {
                        lbValidateFullName.Text = "";
                        lbValidatePhone.Text = "";
                        lbValidateEmail.Text = "";
                        lbValidateNewCodeEmail.Text = "";
                        lbValidateGender.Text = "";

                        if (rbSexMale.Checked)
                        {
                            sex = "Nữ";
                        }
                        else if (rbSexFeMale.Checked)
                        {
                            sex = "Nam";
                        }

                        // chưa có đường dẫn ảnh
                        if (MessageBox.Show("Bạn chắc chắn muốn thay đổi thông tin", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            if (DAO.UserDAO.Instance.UpdateUser(username, user.Password, tbInfoPhone.Text, tbInfoEmail.Text, verificationCode, "Đã xác thực", user.RoleID, tbInfoFullName.Text, tbInfoAddress.Text, sex, ImageToBase64))
                            {
                                MessageBox.Show("Cập nhật thông tin thành công !");
                            }
                            else MessageBox.Show("Cập nhật thông tin thất bại !");
                        }
                    }

                    // trường hợp email mới  nhưng những cái khác sai
                    else
                    {
                        if (tbInfoFullName.Text == "")
                        {
                            lbValidateFullName.Text = "Tên đầy đủ không được để trống !";
                            if (tbInfoPhone.Text == "")
                            {
                                lbValidatePhone.Text = "Số điện thoại không được để trống !";
                                if (tbInfoCodeNewEmail.Text == "")
                                {
                                    lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                                else if(tbInfoCodeNewEmail.Text == verificationCode)
                                {
                                    lbValidateNewCodeEmail.Text = "";
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    lbValidateNewCodeEmail.Text = "Mã code không đúng !";
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                            }
                            else if (!validateData.validatePhone(tbInfoPhone.Text))
                            {
                                lbValidatePhone.Text = "Số điện thoại không hợp lệ !";
                                if (tbInfoCodeNewEmail.Text == "")
                                {
                                    lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                                else if (tbInfoCodeNewEmail.Text == verificationCode)
                                {
                                    lbValidateNewCodeEmail.Text = "";
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    lbValidateNewCodeEmail.Text = "Mã code không đúng !";
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                lbValidatePhone.Text = "";
                                if (tbInfoCodeNewEmail.Text == "")
                                {
                                    lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                                else if (tbInfoCodeNewEmail.Text == verificationCode)
                                {
                                    lbValidateNewCodeEmail.Text = "";
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    lbValidateNewCodeEmail.Text = "Mã code không đúng !";
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            lbValidateFullName.Text = "";
                            if (tbInfoPhone.Text == "")
                            {
                                lbValidatePhone.Text = "Số điện thoại không được để trống !";
                                if (tbInfoCodeNewEmail.Text == "")
                                {
                                    lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    lbValidateNewCodeEmail.Text = "Mã code không hợp lệ !";
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                            }
                            else if (!validateData.validatePhone(tbInfoPhone.Text))
                            {
                                lbValidatePhone.Text = "Số điện thoại không hợp lệ !";
                                if (tbInfoCodeNewEmail.Text == "")
                                {
                                    lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    lbValidateNewCodeEmail.Text = "Mã code không hợp lệ !";
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                lbValidatePhone.Text = "";
                                if (tbInfoCodeNewEmail.Text == "")
                                {
                                    lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    lbValidateNewCodeEmail.Text = "Mã code không hợp lệ !";
                                    if (tbInfoAddress.Text == "")
                                    {
                                        lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        lbValidateAddress.Text = "";
                                        if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                        {
                                            lbValidateGender.Text = "Giới tính không được để trống !";
                                        }
                                        else
                                        {
                                            lbValidateGender.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                
                //  email khoong hợp lệ
                else
                {
                    lbValidateEmail.Text = "Email không hợp lệ !";
                    if(tbInfoFullName.Text == "")
                    {
                        lbValidateFullName.Text = "Tên đầy đủ không được để trống !";
                        if (tbInfoPhone.Text == "")
                        {
                            lbValidatePhone.Text = "Số điện thoại không được để trống !";
                            if (tbInfoCodeNewEmail.Text == "")
                            {
                                lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                                if(tbInfoAddress.Text == "")
                                {
                                    lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                    if(!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else {
                                        lbValidateGender.Text = "";
                                    }
                                }
                                else
                                {
                                    lbValidateAddress.Text = "";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                lbValidateNewCodeEmail.Text = "Mã code không hợp lệ !";
                                if (tbInfoAddress.Text == "")
                                {
                                    lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                                else
                                {
                                    lbValidateAddress.Text = "";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                            }
                        }
                        else if(!validateData.validatePhone(tbInfoPhone.Text))
                        {
                            lbValidatePhone.Text = "Số điện thoại không hợp lệ !";
                            if (tbInfoCodeNewEmail.Text == "")
                            {
                                lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                                if (tbInfoAddress.Text == "")
                                {
                                    lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                                else
                                {
                                    lbValidateAddress.Text = "";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                lbValidateNewCodeEmail.Text = "Mã code không hợp lệ !";
                                if (tbInfoAddress.Text == "")
                                {
                                    lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                                else
                                {
                                    lbValidateAddress.Text = "";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                            }
                        }
                        else
                        {
                            lbValidatePhone.Text = "";
                            if (tbInfoCodeNewEmail.Text == "")
                            {
                                lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                                if (tbInfoAddress.Text == "")
                                {
                                    lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                                else
                                {
                                    lbValidateAddress.Text = "";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                lbValidateNewCodeEmail.Text = "Mã code không hợp lệ !";
                                if (tbInfoAddress.Text == "")
                                {
                                    lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                                else
                                {
                                    lbValidateAddress.Text = "";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        lbValidateFullName.Text = "";
                        if (tbInfoPhone.Text == "")
                        {
                            lbValidatePhone.Text = "Số điện thoại không được để trống !";
                            if (tbInfoCodeNewEmail.Text == "")
                            {
                                lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                                if (tbInfoAddress.Text == "")
                                {
                                    lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                                else
                                {
                                    lbValidateAddress.Text = "";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                lbValidateNewCodeEmail.Text = "Mã code không hợp lệ !";
                                if (tbInfoAddress.Text == "")
                                {
                                    lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                                else
                                {
                                    lbValidateAddress.Text = "";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                            }
                        }
                        else if (!validateData.validatePhone(tbInfoPhone.Text))
                        {
                            lbValidatePhone.Text = "Số điện thoại không hợp lệ !";
                            if (tbInfoCodeNewEmail.Text == "")
                            {
                                lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                                if (tbInfoAddress.Text == "")
                                {
                                    lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                                else
                                {
                                    lbValidateAddress.Text = "";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                lbValidateNewCodeEmail.Text = "Mã code không hợp lệ !";
                                if (tbInfoAddress.Text == "")
                                {
                                    lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                                else
                                {
                                    lbValidateAddress.Text = "";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                            }
                        }
                        else
                        {
                            lbValidatePhone.Text = "";
                            if (tbInfoCodeNewEmail.Text == "")
                            {
                                lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                                if (tbInfoAddress.Text == "")
                                {
                                    lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                                else
                                {
                                    lbValidateAddress.Text = "";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                            }
                            else
                            {
                                lbValidateNewCodeEmail.Text = "Mã code không hợp lệ !";
                                if (tbInfoAddress.Text == "")
                                {
                                    lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                                else
                                {
                                    lbValidateAddress.Text = "";
                                    if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                    {
                                        lbValidateGender.Text = "Giới tính không được để trống !";
                                    }
                                    else
                                    {
                                        lbValidateGender.Text = "";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else 
            {
                lbValidateEmail.Text = "Email không được để trống !";
                if (tbInfoFullName.Text == "")
                {
                    lbValidateFullName.Text = "Tên đầy đủ không được để trống !";
                    if (tbInfoPhone.Text == "")
                    {
                        lbValidatePhone.Text = "Số điện thoại không được để trống !";
                        if (tbInfoCodeNewEmail.Text == "")
                        {
                            lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                            if (tbInfoAddress.Text == "")
                            {
                                lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                            else
                            {
                                lbValidateAddress.Text = "";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                        }
                        else
                        {
                            lbValidateNewCodeEmail.Text = "Mã code không hợp lệ !";
                            if (tbInfoAddress.Text == "")
                            {
                                lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                            else
                            {
                                lbValidateAddress.Text = "";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                        }
                    }
                    else if (!validateData.validatePhone(tbInfoPhone.Text))
                    {
                        lbValidatePhone.Text = "Số điện thoại không hợp lệ !";
                        if (tbInfoCodeNewEmail.Text == "")
                        {
                            lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                            if (tbInfoAddress.Text == "")
                            {
                                lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                            else
                            {
                                lbValidateAddress.Text = "";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                        }
                        else
                        {
                            lbValidateNewCodeEmail.Text = "Mã code không hợp lệ !";
                            if (tbInfoAddress.Text == "")
                            {
                                lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                            else
                            {
                                lbValidateAddress.Text = "";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                        }
                    }
                    else
                    {
                        lbValidatePhone.Text = "";
                        if (tbInfoCodeNewEmail.Text == "")
                        {
                            lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                            if (tbInfoAddress.Text == "")
                            {
                                lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                            else
                            {
                                lbValidateAddress.Text = "";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                        }
                        else
                        {
                            lbValidateNewCodeEmail.Text = "Mã code không hợp lệ !";
                            if (tbInfoAddress.Text == "")
                            {
                                lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                            else
                            {
                                lbValidateAddress.Text = "";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                        }
                    }
                }
                else
                {
                    lbValidateFullName.Text = "";
                    if (tbInfoPhone.Text == "")
                    {
                        lbValidatePhone.Text = "Số điện thoại không được để trống !";
                        if (tbInfoCodeNewEmail.Text == "")
                        {
                            lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                            if (tbInfoAddress.Text == "")
                            {
                                lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                            else
                            {
                                lbValidateAddress.Text = "";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                        }
                        else
                        {
                            lbValidateNewCodeEmail.Text = "Mã code không hợp lệ !";
                            if (tbInfoAddress.Text == "")
                            {
                                lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                            else
                            {
                                lbValidateAddress.Text = "";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                        }
                    }
                    else if (!validateData.validatePhone(tbInfoPhone.Text))
                    {
                        lbValidatePhone.Text = "Số điện thoại không hợp lệ !";
                        if (tbInfoCodeNewEmail.Text == "")
                        {
                            lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                            if (tbInfoAddress.Text == "")
                            {
                                lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                            else
                            {
                                lbValidateAddress.Text = "";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                        }
                        else
                        {
                            lbValidateNewCodeEmail.Text = "Mã code không hợp lệ !";
                            if (tbInfoAddress.Text == "")
                            {
                                lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                            else
                            {
                                lbValidateAddress.Text = "";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                        }
                    }
                    else
                    {
                        lbValidatePhone.Text = "";
                        if (tbInfoCodeNewEmail.Text == "")
                        {
                            lbValidateNewCodeEmail.Text = "Mã code không được để trống !";
                            if (tbInfoAddress.Text == "")
                            {
                                lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                            else
                            {
                                lbValidateAddress.Text = "";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                        }
                        else
                        {
                            lbValidateNewCodeEmail.Text = "Mã code không hợp lệ !";
                            if (tbInfoAddress.Text == "")
                            {
                                lbValidateAddress.Text = "Địa chỉ không được để trống !";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                            else
                            {
                                lbValidateAddress.Text = "";
                                if (!rbSexMale.Checked && !rbSexFeMale.Checked)
                                {
                                    lbValidateGender.Text = "Giới tính không được để trống !";
                                }
                                else
                                {
                                    lbValidateGender.Text = "";
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion

        private void btnChooseImageUser_Click(object sender, EventArgs e)
        {
            convertImage = new ConvertImage();

            OpenFileDialog dlgOpen = new OpenFileDialog();

            // Thiết lập bộ lọc file: chỉ cho phép chọn các file hình ảnh với các đuôi phổ biến hoặc tất cả các file
            // Image Files là phần mô tả(description) mà người dùng sẽ nhìn thấy trong hộp thoại OpenFileDialog
            dlgOpen.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif;*.tiff|All Files|*.*";

            // Hiển thị hộp thoại và kiểm tra nếu người dùng đã chọn file
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file được chọn
                string filePath = dlgOpen.FileName;

                // lấy ảnh vừa được chọn
                showImageUser = convertImage.ImageToPath(filePath);

                // hiển thị ảnh mới 
                pbImageUser.Image = convertImage.ResizeImage(showImageUser, 200, 200);

            }

        }

        // về trang bán hàng
        private void btnBackMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMain.Show();
        }

        // đóng chương trình khi nhấn x
        private void FormUserInfomation_FormClosed(object sender, FormClosedEventArgs e)
        {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                Application.Exit();
        }

    }
}
