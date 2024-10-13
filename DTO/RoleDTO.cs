using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp.DTO
{
    internal class RoleDTO
    {
        private int roleID;
        private string roleName;
        private string creator;

        public RoleDTO(int roleID, string roleName, string creator)
        {
            this.roleID = roleID;
            this.roleName = roleName;
            this.creator = creator;
        }

        public int RoleID { get => roleID; set => roleID = value; }
        public string RoleName { get => roleName; set => roleName = value; }
        public string Creator { get => creator; set => creator = value; }

        public RoleDTO(DataRow row)
        {
            this.RoleID = int.Parse(row["RoleID"].ToString());
            this.RoleName = row["RoleName"].ToString();
            this.Creator = row["Creator"].ToString();
        }
    }
}
