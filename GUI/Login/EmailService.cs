using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp.GUI.Login
{
    internal class EmailService
    {
        private static string smtpServer = "smtp.gmail.com";
        private static int smtpPort = 587;
        private static string smtpMyEmail = "tienchung2612@gmail.com";
        private static string smtpPassword = "zqmh baev rwnp wbha";
        public static async Task<string> SendVerificationCodeAsync(string recipientEmail)
        {
            // Tạo mã ngẫu nhiên
            Random random = new Random();
            string verificationCode = random.Next(100000, 999999).ToString();

            // cấu hình gmail của bạn
            var smtpClient = new SmtpClient(smtpServer)
            {
                Port = smtpPort,
                Credentials = new NetworkCredential(smtpMyEmail, smtpPassword),
                EnableSsl = true,
            };

            // cấu hình nội dung email
            var mailMessage = new MailMessage()
            {
                From = new MailAddress(smtpMyEmail),
                Subject = "Mã xác thực đăng ký tài khoản",
                Body = $"Mã xác thực của bạn là : {verificationCode}",
                IsBodyHtml = false,
            };

            mailMessage.To.Add(recipientEmail);

            // gửi email bất đồng bộ 
            try
            {
                await smtpClient.SendMailAsync(mailMessage);
                MessageBox.Show("Mã xác thực đã được gửi đến bạn ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gửi email thất bại: {ex.Message}");
            }
            return verificationCode;
        }
    }
}
