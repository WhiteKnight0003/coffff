using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp.DAO
{
    internal class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set { instance = value; }
        }
        public TableDAO() { }

        public DataTable FullTable()
        {
            // string query = $"select * from tablee";
            string query = "USP_Tables";
            DataTable data = DAO.DataProvider.Instance.ExcuteQuery(query, new object[] {});
            return data;
        }
    }
}
