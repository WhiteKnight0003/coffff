using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CoffeeApp.DAO
{
    internal class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return instance; }
            private set { instance = value; }
        }
        public ProductDAO() { }

        public DataTable FullFood()
        {
            //string query = $"select * from product";
            string query = "USP_Product";
            DataTable data = DAO.DataProvider.Instance.ExcuteQuery(query, new object[] {});
            return data;
        }
    }
}
