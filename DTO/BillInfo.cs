using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp.DTO
{
    internal class BillInfo
    {
        public BillInfo(int id, int billID, int productID, int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.ProductID = productID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID = (int)row["BillID"];
            this.ProductID = (int)row["productid"];
            this.Count = (int)row["count"];
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int productID;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        private int billID;

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
