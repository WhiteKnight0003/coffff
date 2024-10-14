using CoffeeApp.DTO;
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
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }
        }

        private ProductDAO() { }

        public List<Product> GetProductByCategoryID(int id)
        {
            List<Product> list = new List<Product>();

            string query = "select * from Product where CategoryID = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product Product = new Product(item);
                list.Add(Product);
            }

            return list;
        }

        public List<Product> GetListProduct()
        {
            List<Product> list = new List<Product>();

            string query = "select p.[ID], p.[Price], p.[Name], p.[CategoryID], c.[CategoryName] as [Thể loại] from [dbo].[product] p inner join [dbo].[category] c on p.CategoryID = c.ID";


            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product Product = new Product(item);
                list.Add(Product);
            }

            return list;
        }

        public List<Product> SearchProductByName(string name)
        {

            List<Product> list = new List<Product>();

            string query = string.Format("SELECT * FROM dbo.Product WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product Product = new Product(item);
                list.Add(Product);
            }

            return list;
        }

        public bool InsertProduct(string name, int id, float price)
        {
            string query = string.Format("INSERT dbo.Product ( Name, CategoryID, Price )VALUES  ( N'{0}', {1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateProduct(int idProduct, string name, int id, float price)
        {
            string query = string.Format("UPDATE dbo.Product SET name = N'{0}', CategoryID = {1}, price = {2} WHERE id = {3}", name, id, price, idProduct);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteProduct(int idProduct)
        {
            BillInfoDAO.Instance.DeleteBillInfoByProductID(idProduct);

            string query = string.Format("Delete Product where id = {0}", idProduct);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
