using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp.DTO
{
    public class UserDTO
    {
        private int id;
        private string userName;
        private string fullName;
        private string password;
        private string phone;
        private string address;
        private DateTime dateWork;
        private int roleID;
        private string email;
        private string codeEmail;
        private string statusEmail;
        private string gender;
        private string image;
        private string workingstatus;

        public UserDTO()
        {

        }
        public UserDTO(int id, string userName, string fullName, string password, string phone, string address, DateTime dateWork, int roleID, string email, string codeEmail, string statusEmail, string gender, string image, string workingstatus)
        {
            this.Id = id;
            this.UserName = userName;
            this.FullName = fullName;
            this.Password = password;
            this.Phone = phone;
            this.Address = address;
            this.DateWork = dateWork;
            this.RoleID = roleID;
            this.Email = email;
            this.CodeEmail = codeEmail;
            this.StatusEmail = statusEmail;
            this.Gender = gender;
            this.Image = image;
            this.workingstatus = workingstatus;
        }

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Password { get => password; set => password = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public DateTime DateWork { get => dateWork; set => dateWork = value; }
        public int RoleID { get => roleID; set => roleID = value; }
        public string Email { get => email; set => email = value; }
        public string CodeEmail { get => codeEmail; set => codeEmail = value; }
        public string StatusEmail { get => statusEmail; set => statusEmail = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Image { get => image; set => image = value; }

        public string Workingstatus { get => workingstatus; set => workingstatus = value; }
        public UserDTO(DataRow row)
        {
            this.Id = int.Parse(row["ID"].ToString());
            this.UserName = row["UserName"].ToString();
            this.FullName = row["FullName"].ToString();
            this.Password = row["password"].ToString();
            this.Phone = row["phone"].ToString();
            this.Address = row["address"].ToString();
            this.DateWork = DateTime.Parse( row["DateWork"].ToString());
            this.RoleID = int.Parse(row["RoleID"].ToString());
            this.Email = row["email"].ToString();
            this.CodeEmail = row["codeEmail"].ToString();
            this.StatusEmail = row["statusEmail"].ToString();
            this.Gender = row["gender"].ToString();
            this.Image = row["image"].ToString();
            this.Workingstatus = row["Workingstatus"].ToString();
        }
    }
}
