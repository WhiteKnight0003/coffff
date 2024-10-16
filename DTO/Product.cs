using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp.DTO
{
    internal class Product
    {
        public Product(int id, string name, int categoryID, float price, string image, string description)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
            this.Image = image;
            this.Description = description; 
        }

        public Product(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.CategoryID = (int)row["CategoryID"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
            this.Description= row["Description"].ToString();
            this.Image=row["Image"].ToString();
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private int categoryID;

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        
        private string image;
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
