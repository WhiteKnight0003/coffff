using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp.DAO
{
    internal class RoleDAO
    {
        private static RoleDAO instance;

        public static RoleDAO Instance
        {
            get { if (instance == null) instance = new RoleDAO(); return instance; }
            private set { instance = value; }
        }
        public RoleDAO() { }

        public DataTable QueryRoleName(int roleID)
        {
            string query = "USP_Roleid @roleID";
            return DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { roleID });
        }
    }
}
