namespace CoffeeApp.GUI
{
    partial class FormSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbSignUpUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSignUpEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSignUpPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txSignUpPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbViewSignUpPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.lbValidateUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbValidateEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txSignUpRePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbValidatePhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbValidateRePassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.SpringGreen;
            this.guna2PictureBox1.Image = global::CoffeeApp.Properties.Resources.bg4;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, -10);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(880, 581);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // tbSignUpUserName
            // 
            this.tbSignUpUserName.BackColor = System.Drawing.Color.Transparent;
            this.tbSignUpUserName.BorderRadius = 10;
            this.tbSignUpUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSignUpUserName.DefaultText = "";
            this.tbSignUpUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSignUpUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSignUpUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSignUpUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSignUpUserName.FillColor = System.Drawing.Color.Black;
            this.tbSignUpUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSignUpUserName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSignUpUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSignUpUserName.Location = new System.Drawing.Point(461, 74);
            this.tbSignUpUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSignUpUserName.Name = "tbSignUpUserName";
            this.tbSignUpUserName.PasswordChar = '\0';
            this.tbSignUpUserName.PlaceholderText = "Tên đăng nhập ";
            this.tbSignUpUserName.SelectedText = "";
            this.tbSignUpUserName.Size = new System.Drawing.Size(321, 40);
            this.tbSignUpUserName.TabIndex = 0;
            // 
            // tbSignUpEmail
            // 
            this.tbSignUpEmail.BackColor = System.Drawing.Color.Transparent;
            this.tbSignUpEmail.BorderRadius = 10;
            this.tbSignUpEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSignUpEmail.DefaultText = "";
            this.tbSignUpEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSignUpEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSignUpEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSignUpEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSignUpEmail.FillColor = System.Drawing.Color.Black;
            this.tbSignUpEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSignUpEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSignUpEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSignUpEmail.Location = new System.Drawing.Point(461, 146);
            this.tbSignUpEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSignUpEmail.Name = "tbSignUpEmail";
            this.tbSignUpEmail.PasswordChar = '\0';
            this.tbSignUpEmail.PlaceholderText = "Email";
            this.tbSignUpEmail.SelectedText = "";
            this.tbSignUpEmail.Size = new System.Drawing.Size(321, 40);
            this.tbSignUpEmail.TabIndex = 1;
            // 
            // tbSignUpPhone
            // 
            this.tbSignUpPhone.BackColor = System.Drawing.Color.Transparent;
            this.tbSignUpPhone.BorderRadius = 10;
            this.tbSignUpPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSignUpPhone.DefaultText = "";
            this.tbSignUpPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSignUpPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSignUpPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSignUpPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSignUpPhone.FillColor = System.Drawing.Color.Black;
            this.tbSignUpPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSignUpPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSignUpPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSignUpPhone.Location = new System.Drawing.Point(461, 218);
            this.tbSignUpPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSignUpPhone.Name = "tbSignUpPhone";
            this.tbSignUpPhone.PasswordChar = '\0';
            this.tbSignUpPhone.PlaceholderText = "Số điện thoại";
            this.tbSignUpPhone.SelectedText = "";
            this.tbSignUpPhone.Size = new System.Drawing.Size(317, 34);
            this.tbSignUpPhone.TabIndex = 2;
            // 
            // txSignUpPassword
            // 
            this.txSignUpPassword.BackColor = System.Drawing.Color.Transparent;
            this.txSignUpPassword.BorderRadius = 10;
            this.txSignUpPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txSignUpPassword.DefaultText = "";
            this.txSignUpPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txSignUpPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txSignUpPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txSignUpPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txSignUpPassword.FillColor = System.Drawing.Color.Black;
            this.txSignUpPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txSignUpPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSignUpPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txSignUpPassword.Location = new System.Drawing.Point(461, 284);
            this.txSignUpPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txSignUpPassword.Name = "txSignUpPassword";
            this.txSignUpPassword.PasswordChar = '●';
            this.txSignUpPassword.PlaceholderText = "Mật khẩu";
            this.txSignUpPassword.SelectedText = "";
            this.txSignUpPassword.Size = new System.Drawing.Size(317, 34);
            this.txSignUpPassword.TabIndex = 3;
            this.txSignUpPassword.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.BackgroundImage = global::CoffeeApp.Properties.Resources.bg3;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(175, 417);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(95, 33);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Đăng kí";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.BackgroundImage = global::CoffeeApp.Properties.Resources.bg3;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(90, 456);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(287, 27);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Hãy điền thông tin của bạn !";
            // 
            // cbViewSignUpPassword
            // 
            this.cbViewSignUpPassword.AutoSize = true;
            this.cbViewSignUpPassword.BackColor = System.Drawing.Color.Transparent;
            this.cbViewSignUpPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbViewSignUpPassword.CheckedState.BorderRadius = 0;
            this.cbViewSignUpPassword.CheckedState.BorderThickness = 0;
            this.cbViewSignUpPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbViewSignUpPassword.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbViewSignUpPassword.ForeColor = System.Drawing.Color.White;
            this.cbViewSignUpPassword.Location = new System.Drawing.Point(645, 391);
            this.cbViewSignUpPassword.Name = "cbViewSignUpPassword";
            this.cbViewSignUpPassword.Size = new System.Drawing.Size(137, 24);
            this.cbViewSignUpPassword.TabIndex = 7;
            this.cbViewSignUpPassword.Text = "Hiện mật khẩu";
            this.cbViewSignUpPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbViewSignUpPassword.UncheckedState.BorderRadius = 0;
            this.cbViewSignUpPassword.UncheckedState.BorderThickness = 0;
            this.cbViewSignUpPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbViewSignUpPassword.UseVisualStyleBackColor = false;
            this.cbViewSignUpPassword.CheckedChanged += new System.EventHandler(this.cbViewSignUpPassword_CheckedChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BorderColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BorderRadius = 20;
            this.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignUp.FillColor = System.Drawing.Color.White;
            this.btnSignUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.Black;
            this.btnSignUp.Location = new System.Drawing.Point(534, 456);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(180, 45);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Đăng Kí";
            // 
            // lbValidateUserName
            // 
            this.lbValidateUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbValidateUserName.ForeColor = System.Drawing.Color.Red;
            this.lbValidateUserName.Location = new System.Drawing.Point(461, 49);
            this.lbValidateUserName.Name = "lbValidateUserName";
            this.lbValidateUserName.Size = new System.Drawing.Size(3, 2);
            this.lbValidateUserName.TabIndex = 9;
            // 
            // lbValidateEmail
            // 
            this.lbValidateEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbValidateEmail.ForeColor = System.Drawing.Color.Red;
            this.lbValidateEmail.Location = new System.Drawing.Point(461, 121);
            this.lbValidateEmail.Name = "lbValidateEmail";
            this.lbValidateEmail.Size = new System.Drawing.Size(3, 2);
            this.lbValidateEmail.TabIndex = 9;
            // 
            // txSignUpRePassword
            // 
            this.txSignUpRePassword.BackColor = System.Drawing.Color.Transparent;
            this.txSignUpRePassword.BorderRadius = 10;
            this.txSignUpRePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txSignUpRePassword.DefaultText = "";
            this.txSignUpRePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txSignUpRePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txSignUpRePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txSignUpRePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txSignUpRePassword.FillColor = System.Drawing.Color.Transparent;
            this.txSignUpRePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txSignUpRePassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSignUpRePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txSignUpRePassword.Location = new System.Drawing.Point(461, 350);
            this.txSignUpRePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txSignUpRePassword.Name = "txSignUpRePassword";
            this.txSignUpRePassword.PasswordChar = '●';
            this.txSignUpRePassword.PlaceholderText = "Nhập lại mật khẩu";
            this.txSignUpRePassword.SelectedText = "";
            this.txSignUpRePassword.Size = new System.Drawing.Size(317, 34);
            this.txSignUpRePassword.TabIndex = 4;
            this.txSignUpRePassword.UseSystemPasswordChar = true;
            // 
            // lbValidatePhone
            // 
            this.lbValidatePhone.BackColor = System.Drawing.Color.Transparent;
            this.lbValidatePhone.ForeColor = System.Drawing.Color.Red;
            this.lbValidatePhone.Location = new System.Drawing.Point(461, 193);
            this.lbValidatePhone.Name = "lbValidatePhone";
            this.lbValidatePhone.Size = new System.Drawing.Size(3, 2);
            this.lbValidatePhone.TabIndex = 9;
            // 
            // lbValidateRePassword
            // 
            this.lbValidateRePassword.BackColor = System.Drawing.Color.Transparent;
            this.lbValidateRePassword.ForeColor = System.Drawing.Color.Red;
            this.lbValidateRePassword.Location = new System.Drawing.Point(461, 325);
            this.lbValidateRePassword.Name = "lbValidateRePassword";
            this.lbValidateRePassword.Size = new System.Drawing.Size(3, 2);
            this.lbValidateRePassword.TabIndex = 9;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = global::CoffeeApp.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 583);
            this.Controls.Add(this.lbValidateRePassword);
            this.Controls.Add(this.lbValidatePhone);
            this.Controls.Add(this.lbValidateEmail);
            this.Controls.Add(this.lbValidateUserName);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.cbViewSignUpPassword);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txSignUpRePassword);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txSignUpPassword);
            this.Controls.Add(this.tbSignUpPhone);
            this.Controls.Add(this.tbSignUpEmail);
            this.Controls.Add(this.tbSignUpUserName);
            this.Controls.Add(this.guna2PictureBox1);
            this.DoubleBuffered = true;
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbSignUpUserName;
        private Guna.UI2.WinForms.Guna2TextBox tbSignUpEmail;
        private Guna.UI2.WinForms.Guna2TextBox tbSignUpPhone;
        private Guna.UI2.WinForms.Guna2TextBox txSignUpPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CheckBox cbViewSignUpPassword;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbValidateUserName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbValidateEmail;
        private Guna.UI2.WinForms.Guna2TextBox txSignUpRePassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbValidatePhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbValidateRePassword;
    }
}