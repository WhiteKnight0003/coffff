using CoffeeApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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

            string query = "select * from Product where Status = 1 and CategoryID = " + id;

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

            string query = "select * from Product where Status = 1";

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

        public bool InsertProduct(string name, int id, float price, string base64 = "")
        {
            string query = string.Format("INSERT dbo.Product ( Name, CategoryID, Price, Image )VALUES  ( N'{0}', {1}, {2}, N'{3}')", name, id, price, base64);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateProduct(int idProduct, string name, int id, float price)
        {
            string query = string.Format("UPDATE dbo.Product SET name = N'{0}', CategoryID = {1}, price = {2} WHERE id = {3}", name, id, price, idProduct);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool HideProductWhenDelete(int idProduct)
        {
            string query = string.Format("UPDATE dbo.Product SET Status = 0 WHERE id = {0}", idProduct);
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

        public string GetProductImageFromDatabase(int productId)
        {
            string query = "select Image from product where ID = " + productId;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            string result;
            if(data.Rows.Count > 0)
            {
                result = data.Rows[0]["Image"].ToString();
                if (result.Equals(""))
                {
                    return "iVBORw0KGgoAAAANSUhEUgAAAMwAAADACAMAAAB/Pny7AAAAaVBMVEX///8AAADb29s2NjZMTEzx8fHNzc37+/sqKipERESLi4vIyMj19fXt7e1BQUHh4eHT09OdnZ3CwsIICAi2traEhIRTU1OkpKR0dHRZWVkUFBQ8PDwbGxtfX1+RkZF7e3tra2sjIyOtra2T3lIFAAANGklEQVR4nO1d57qqOhBVuggiSFFUQN//Ia9Ykkkhhb7Pd9e/vY0xi0ySqWGzecM9xufD7bRdD05eXheRu9GF7ZyXHnoXTnEY6FAJksvSQxaiMtSnx8iWHq0MXhGqksmXHqsCzpEimaUHqoT8+A+R2R7UJG3pYSrC/JfIbO//EpntU4vMw1wVvJIk4ymcnr+21vl5NNaEfdWYkMzJVyVjZqpb+ZxIGsjGku9o73bXdIah9UAYAzK3Qtr+LY4r5fKCD9icpUpa26rS17TnQgDWzcWQtX41yqWNFoQD9jOpAL0aKWwTyyHwMBvponmdL+tdMS+4FSZTyRq/lDhnjkH1RqpFxlrzktls9piML9uo/iczJ/4ns1asi0yQxNn5nBU9N801kdlfvMfbMikfZt1HNV8PmT1hkqioV2wXKyET1lsGTy1362Y1ZI53lst2myn7Jz9YBxmjw1na2FrdrIJMyJ2X99xo9bMKMk0XFwVVHmINZJJuLltP5xfXQIbYk8vcItjUGh2tgAywQraNYQeB7QB6B0WvfosVkAEzkfz+BzwtGpb68mQiPA1AJSvQP8/qR+fyZNIHb3mEKHpqqcvZ8mR8FIUndEu0kryk65sMlieDDpkrcdwf0YSpBCg+WBGZhlgcBtoX1M/N/8mMCkRmR5A5en+RTIU2AELhRzqORtxheTJPtNKhivxHt+aQd2i6OHT0pw5NmMWy/w7cxgqA3GuMsQIyUNH0j1EYGg4wcP6YokmaAPm5OcC//5gJ8G8ZZxtBduGfM5s30a6Ly1mrn1WQ2Rgen4ul5wZcB5mNceBxuWu6NCcl47rKWQMhZ93EWj+2mZSM62T5XT0DNM1vkIl3149rTEcm/ASyS+VDLyjO1nftmJc66ZEKMhkZ4yc3N40nbKSx7/tVnPRLnJqKzB47kC6avvz+mIjM84r7LbUXcl9MQyYm1rK5HzxMNUxBxqbT7JuZBO04PpmIjVCoe4sG4Tw6GYenmmgYJf0BwwejkHFTDhXteF4fBEQoZAwyQczloihokZMmhm6I+YuQDOuMQCbyO7hstwoC+i41elS9DkyD5DICGX4A/IOLdDw/Ab33UM2PFJfhZNIr1aNlgTo7mc2ILTT93AyHse4GkgmKB83FMQC9h2SIMU7o32my2dNPcSgZO6OqC7b5S/ifYGoklSAw3+SqxWZPP8WhZGymTvD+7g78+yTU0cgkDVPjYOI6d4aQiZjeMvQlBKE/ryC/rh4ve/K4DCDjMg8HVxbAjwQZ+i69qSs6/92Og603GbuguzqA5woUplP3jsbsrVszVbA1g4r+2kAyEZMqRuytIXC8dK85jhakMDfhRz8/lSVda92TDHtSUoWfCfihrENH4z5hT6YDuWlWxcXzg6KI/fN9dxtCJqHl4+ZT1ksAl0PH06a1kW9XEhvVpUqz3TA6Jml8fh2hWQ8ybkFlVm4fbDJiBObO5Ntp+y0X4t28A25oOIV0wXHIZDf65/ecXnASRof3uHMdnzRCTQQhqe7NkmGFg//goR3NO0Aien4xpqrYocnYtALTWYlL5C1yPj/SHU3PhiLj0FxO3VGuBNjSDfOpS3hAMl3TpBcIMgEOeX/hxYJfhcNldrQArrxrROfS+lPY3JCMXdHzIi7gDMAAmR2NkDI/YDKDq56mtCIZNkE8l7iU4YDpQ4AIZ7TPxCAO4ksxKRnWNdZILRCw+9J1eLCjT1kb+IFHNUmEC5HZM1syfepzAAXtQig8hJTVnwUS/WbL2k8wLRtM5sm4+ZTkAI6Z2CsIkf2d+V829VSe3S+ZmD71uecgB9CMgr50uJUc0AdhK2kqZkA/fMgwl8+UqjIdgpWWY0Ej9DKQQec22wmL9VsyLhNIzdV/0XnwBI3oEepiaovFfSEINGLBH7wGvqe35JOWUENnzc8h4EI/0VXHwx6EkeGkcVX5de1XceoYUWircnod8nS4voy1TmcYIP8lLCRguhT8nl+4kZNUDb0TPS7ZMzGUhkQL2Mt60g28OGAavhIF51rl8ouWiZHG3Z7ga/Z05BLKfK1HfK8AW9dbpAiH20NFyoLUl13mda2fspVMf0X1WiRiJOCJ5q18J9CUuco7sAtGuHgoL754dFR75QurCISgh1aoCH+ZvCortphTrguHs2hvIttWPRVzcHS+xDQktDzZiZVajD0ogikwhYiGWlltBED44R4QUsYzQgG6agYF6Pa9Qc4D7p9wQT8x4V0VSlnAdyrL0HQsBtziMuj6CeB+vhErQCRlBj/38WEerPxyueTW7kpf2fSByU8pQp/3W/oIAaf09w3Bd+jK5xbX+7l67o2w1WXcMHopA3XDW1QVbyP4fZgNtTA6cjK7pYwjYlYdJ+wgg2Ph35k7Pnkl7J9PTiK/hSJS7v7aeTCEjI+weR47n2iU+vRJdGe7fv9/yNJHCHiXWHpde32Ykc/6VHPmhOj+GFNSaTEm1/u/42Qo8XbZrkMhOpNcmqP8hHMjyoS80mza+RrLXGK8bkRhIwTtCEoUzZyIVOCu1CyMmgrM+HdM/nOiJFIna5sMYFGm0qhkbHpH87lP3CXWfqle5tgiIPIDyOyCcZO06aAuf5xwTz5pWOhf1HDlEIrnyBnn5Fo4cLuG7qlbD7eTW8BdGjoYRiZDCgE32hmCodx6qeluCjdpcKyMXQtA+Ji4BjgMu+t5GzAS8MxueG5HL2wAKvOOtzFDZw5/f1ABPzY0Ohlcv7jlWYUG2PCaAfpgCp4JEoDxS06woPHCyuCEeQzSB6EE/B7a+GRQ5guvUgaKx8DYGZjiX6hyimKg+FZuTzdehhC0eoQKYZDUO6sWRz5wV7/Uqkkqm8JnFXPPQmAmiAwoZOpwMxB+ABvn12qa9bI2oF/uBAe/DXZvgaEF4tnfGydnJbNHE3MSWFBk0F3gMQJpE58bZ+ckAxJQRGURKWFTClI7XZwT9yExJ5kITcxNNDGUrSPItAHm4LvDOclgW0RURkDnD4qOVnzYvBXWGclg/7rwHumE8lyILkIAxNtWM5LB7vVcpPfTZLga3g/YRd/K2YxksE0mdNlqkcFu7VZyZySDVqsnjLJokQGhoWhOMti3bgnbJbR7TEgdy9l+TjLYWhaHn+iKBvGt5dhfXc1JJobPUAC61OQi9HjgQq7cnZEMlm6xHWNQkVpJDWUDup2PzOP3o5KIbUQF0Bsx9xiZnPaMZPDoxO0CKgIluQolQTqSMx8ZG41OFjmlogmSnAgbzfhzPjJ4M5PFHMiCk4ckYcT1MOvZyGDPrcwfS5kAsiwL1LqejwxWZmQOJrIgIpc1Rzv5fT4yWHhkHiaX2M4aWceotTUfGWxlSptC66yUJlrgyxRXSaYAMQt5ThTayc0NG0ubCBpkYMG+/L1TiEw7M9rJcv0Qq5MJgaopT/BCa2bXnsvzvH9GfTcjPK+NtDHa+y4tGaH1MxrwOSOPlYHtTJ5ohWyA+q0xTVPMQgE7U+XPDig08ugtoQEo0R8O7M6Qr1Gg0EjDt1g3Kz5kyinqP2ig8cnzHEHQWhr3cNA+nvx+whe528cByrPaSZset+UXCocS6jdCz8vMisQZFfQzRQbkSTrAIE2+kGcoYevHBRGbk3nYjQgmuwifmqOqHNiBBcmMDTqiiV+/1rPolAt8CUbNS58fC0x6D/pE7DfTA76lI52SDFPPgE43c0Q5w0smmpIME+hDp4f8cjQbQdLwiDSf9nWb05Fhbsww0EcXyTkQmYcvPAkZfLy2wU/2qq/RQK9znCQku68BXEUiaYiH3ypJtt9dHD4Q9A4A7vmoxVMT4VwSMRkciv/mZiZM/f9IYNLisLdJYhCqkgFFVcX38dhOzL0gYigYqw/8tjifSZUMvsnDA7ePh1Hq33feuCiZwxFHaG/CqVEkA24koPI93CCwRwZ78YY4fUuXDDZeRaH4yQBSTUU/r0YG1FNp3GY/HmC4QqAGRFhUuxu52FOw0JtnC/zMBfFzF78lvLsrkBwtf6PzJIDlaHrvO6MBErS8pd6iCwPjQxx2xm2spzIEwltElAEjBdfp7/PsAszR7r1wifs4ZrlptQMwe14WFusAwWVMu1UfMMxX9mETQe3LWk7I3iCCSfrVbkeiOHDCix+UEBA3EIgzMBhQFwYuuWA+oC7YUqj0RwiJ/I1FdDIaRzLZx1e+foSs0roVyxz9FBzyrour9N6CFmFCGvm3eAn9kgMmd6mQzU6Y1qRJfJrD3a8Ggy62y32RwRbFzYP6wnMVMvZByNSoXu8xf3rC9Gwxxc3Oirhw64dL0zoXBjHKMM0uV3pSOitAFwT/xU5leTPvWRVXVXN4sPecvlEvfO7zYAvuHBdA4218c8It2AuzZXgMvIdhQhiZHp3TfZ3T8sU+U7lB54umWOFqIZBUag7v8vyc7b03/eEen/KtwKwklzmsB9Ex7nzNW4ssiVajvSjADaNnw41I5JUT/iUmP7iBkVa15T3K7al8XPMs3oeqt+n9B01Msd+srt2sAAAAAElFTkSuQmCC";
                }
                else
                {
                    return result;
                }
            }
            else
            {
                MessageBox.Show("Không thể lấy được ảnh từ cơ sở dữ liệu");
                return "";
            }
        }

        public void SaveImageToDatabase(int productId, string base64Image)
        {
            string query = "update product set Image = N'"+base64Image+"' where ID = " + productId;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}