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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbSignUpPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSignUpUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSignUpEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImage = global::CoffeeApp.Properties.Resources.th;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Location = new System.Drawing.Point(271, 32);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(484, 387);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.tbSignUpUserName);
            this.guna2Panel2.Controls.Add(this.tbSignUpEmail);
            this.guna2Panel2.Controls.Add(this.tbSignUpPhone);
            this.guna2Panel2.Location = new System.Drawing.Point(78, 32);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(448, 387);
            this.guna2Panel2.TabIndex = 1;
            // 
            // tbSignUpPhone
            // 
            this.tbSignUpPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSignUpPhone.DefaultText = "";
            this.tbSignUpPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSignUpPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSignUpPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSignUpPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSignUpPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSignUpPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSignUpPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSignUpPhone.Location = new System.Drawing.Point(73, 171);
            this.tbSignUpPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSignUpPhone.Name = "tbSignUpPhone";
            this.tbSignUpPhone.PasswordChar = '\0';
            this.tbSignUpPhone.PlaceholderText = "Số điện thoại";
            this.tbSignUpPhone.SelectedText = "";
            this.tbSignUpPhone.Size = new System.Drawing.Size(288, 22);
            this.tbSignUpPhone.TabIndex = 0;
            // 
            // tbSignUpUserName
            // 
            this.tbSignUpUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSignUpUserName.DefaultText = "";
            this.tbSignUpUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSignUpUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSignUpUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSignUpUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSignUpUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSignUpUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSignUpUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSignUpUserName.Location = new System.Drawing.Point(73, 71);
            this.tbSignUpUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSignUpUserName.Name = "tbSignUpUserName";
            this.tbSignUpUserName.PasswordChar = '\0';
            this.tbSignUpUserName.PlaceholderText = "Tên đăng nhập";
            this.tbSignUpUserName.SelectedText = "";
            this.tbSignUpUserName.Size = new System.Drawing.Size(288, 22);
            this.tbSignUpUserName.TabIndex = 0;
            // 
            // tbSignUpEmail
            // 
            this.tbSignUpEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSignUpEmail.DefaultText = "";
            this.tbSignUpEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSignUpEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSignUpEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSignUpEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSignUpEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSignUpEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSignUpEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSignUpEmail.Location = new System.Drawing.Point(73, 122);
            this.tbSignUpEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSignUpEmail.Name = "tbSignUpEmail";
            this.tbSignUpEmail.PasswordChar = '\0';
            this.tbSignUpEmail.PlaceholderText = "Email";
            this.tbSignUpEmail.SelectedText = "";
            this.tbSignUpEmail.Size = new System.Drawing.Size(288, 22);
            this.tbSignUpEmail.TabIndex = 0;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = global::CoffeeApp.Properties.Resources.th;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí";
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox tbSignUpUserName;
        private Guna.UI2.WinForms.Guna2TextBox tbSignUpEmail;
        private Guna.UI2.WinForms.Guna2TextBox tbSignUpPhone;
    }
}