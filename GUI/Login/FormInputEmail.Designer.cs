namespace CoffeeApp.GUI.Main
{
    partial class FormInputEmail
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
            this.btnGetCodeEmail = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txbCodeEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExitCodeEmail = new Guna.UI2.WinForms.Guna2Button();
            this.btnReSendCodeEmail = new Guna.UI2.WinForms.Guna2Button();
            this.lbErrorEqualCodeEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // btnGetCodeEmail
            // 
            this.btnGetCodeEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGetCodeEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGetCodeEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGetCodeEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGetCodeEmail.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCodeEmail.ForeColor = System.Drawing.Color.White;
            this.btnGetCodeEmail.Location = new System.Drawing.Point(415, 155);
            this.btnGetCodeEmail.Name = "btnGetCodeEmail";
            this.btnGetCodeEmail.Size = new System.Drawing.Size(153, 45);
            this.btnGetCodeEmail.TabIndex = 0;
            this.btnGetCodeEmail.Text = "Xác nhận";
            this.btnGetCodeEmail.Click += new System.EventHandler(this.btnGetCodeEmail_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(274, 38);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(239, 25);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Nhập vào mã xác thực email";
            // 
            // txbCodeEmail
            // 
            this.txbCodeEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCodeEmail.DefaultText = "";
            this.txbCodeEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbCodeEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbCodeEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCodeEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCodeEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCodeEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbCodeEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCodeEmail.Location = new System.Drawing.Point(86, 70);
            this.txbCodeEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCodeEmail.Name = "txbCodeEmail";
            this.txbCodeEmail.PasswordChar = '\0';
            this.txbCodeEmail.PlaceholderText = "";
            this.txbCodeEmail.SelectedText = "";
            this.txbCodeEmail.Size = new System.Drawing.Size(641, 48);
            this.txbCodeEmail.TabIndex = 2;
            // 
            // btnExitCodeEmail
            // 
            this.btnExitCodeEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExitCodeEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExitCodeEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExitCodeEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExitCodeEmail.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitCodeEmail.ForeColor = System.Drawing.Color.White;
            this.btnExitCodeEmail.Location = new System.Drawing.Point(574, 155);
            this.btnExitCodeEmail.Name = "btnExitCodeEmail";
            this.btnExitCodeEmail.Size = new System.Drawing.Size(153, 45);
            this.btnExitCodeEmail.TabIndex = 0;
            this.btnExitCodeEmail.Text = "Thoát";
            this.btnExitCodeEmail.Click += new System.EventHandler(this.btnExitCodeEmail_Click);
            // 
            // btnReSendCodeEmail
            // 
            this.btnReSendCodeEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReSendCodeEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReSendCodeEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReSendCodeEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReSendCodeEmail.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.btnReSendCodeEmail.ForeColor = System.Drawing.Color.White;
            this.btnReSendCodeEmail.Location = new System.Drawing.Point(86, 155);
            this.btnReSendCodeEmail.Name = "btnReSendCodeEmail";
            this.btnReSendCodeEmail.Size = new System.Drawing.Size(153, 45);
            this.btnReSendCodeEmail.TabIndex = 0;
            this.btnReSendCodeEmail.Text = "Gửi lại mã";
            // 
            // lbErrorEqualCodeEmail
            // 
            this.lbErrorEqualCodeEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorEqualCodeEmail.ForeColor = System.Drawing.Color.Red;
            this.lbErrorEqualCodeEmail.Location = new System.Drawing.Point(86, 126);
            this.lbErrorEqualCodeEmail.Name = "lbErrorEqualCodeEmail";
            this.lbErrorEqualCodeEmail.Size = new System.Drawing.Size(3, 2);
            this.lbErrorEqualCodeEmail.TabIndex = 3;
            this.lbErrorEqualCodeEmail.Text = null;
            // 
            // FormInputEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 230);
            this.Controls.Add(this.lbErrorEqualCodeEmail);
            this.Controls.Add(this.txbCodeEmail);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnReSendCodeEmail);
            this.Controls.Add(this.btnExitCodeEmail);
            this.Controls.Add(this.btnGetCodeEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInputEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xác nhận email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnGetCodeEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txbCodeEmail;
        private Guna.UI2.WinForms.Guna2Button btnExitCodeEmail;
        private Guna.UI2.WinForms.Guna2Button btnReSendCodeEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbErrorEqualCodeEmail;
    }
}