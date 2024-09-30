using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp.DTO
{
    internal class TableDAO
    {
        private int id;
        private string tableName;
        private StringFormat status;

        public TableDAO(int id, string tableName, StringFormat status)
        {
            this.Id = id;
            this.TableName = tableName;
            this.Status = status;
        }

        public int Id { get => id; set => id = value; }
        public string TableName { get => tableName; set => tableName = value; }
        public StringFormat Status { get => status; set => status = value; }

        //public TableDTO(DataRow row)
        //{
        //    this.Id = row["ID"]
        //}
    }
}
