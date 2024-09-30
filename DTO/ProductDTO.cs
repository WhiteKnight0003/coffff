using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp.DTO
{


    internal class ProductDTO
    {
        private int id;
        private float price;
        private string name;
        private string description;
        private string image;
        private int categoryID;

        public ProductDTO(int id, float price, string name, string description, string image, int categoryID)
        {
            this.id = id;
            this.price = price;
            this.name = name;
            this.description = description;
            this.image = image;
            this.categoryID = categoryID;
        }

        public int Id { get => id; set => id = value; }
        public float Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Image { get => image; set => image = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }

        public ProductDTO(DataRow row)
        {
            this.Id = int.Parse(row["Id"].ToString());
            this.Price = float.Parse(row["Price"].ToString());
            this.Name = row["Name"].ToString();
            this.Description = row["Description"].ToString();
            this.Image = row["Image"].ToString();
            this.CategoryID = int.Parse(row["CategoryID"].ToString());
        }
    }
}
