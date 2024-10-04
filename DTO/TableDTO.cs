using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp.DTO
{
    internal class TableDTO
    {
        private int id;
        private string tableName;
        private string status;

        public TableDTO(int id, string tableName, string status)
        {
            this.Id = id;
            this.TableName = tableName;
            this.Status = status;
        }

        public int Id { get => id; set => id = value; }
        public string TableName { get => tableName; set => tableName = value; }
        public string Status { get => status; set => status = value; }

        public TableDTO(DataRow row)
        {
            this.Id = int.Parse(row["ID"].ToString());
            this.TableName = row["TableName"].ToString();
            this.status = row["status"].ToString();
        }
    }
}
