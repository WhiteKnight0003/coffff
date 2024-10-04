using CoffeeApp.DTO;
using CoffeeApp.GUI.Main;
using CoffeeApp.GUI.Usercontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp.GUI
{   

    public partial class FormMain : Form
    {
        private string username;
        private int roleID;
        public FormMain(string username, int roleID)
        {
            InitializeComponent();
            this.username = username;
            this.roleID = roleID;
            LoadTable();
            Decentralization(username, roleID);
        }

        #region Method
        private void LoadTable()
        {
            DataTable data = DAO.TableDAO.Instance.FullTable();
            foreach (DataRow row in data.Rows)
            {
                TableDTO table = new TableDTO(row);
                TableView tableView = new TableView();
                tableView.btnTableView.Text = $"{table.TableName} {table.Id} \n{table.Status}";
                fltViewTable.Controls.Add(tableView);
            }
        }

        private void Decentralization(string username, int roleID)
        {
            if (roleID == 0)
            {
                quảnLýCửaHàngToolStripMenuItem.Visible = false;
            }
            else if (roleID == 1)
            {
                hóaĐơnToolStripMenuItem.Visible = false;
            }
        }
        #endregion

        #region Events
        private void quảnLýCửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagement fmg = new FormManagement(this, username, roleID);
            this.Hide();
            fmg.ShowDialog();

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagement fmg = new FormManagement(this, username, roleID);
            this.Hide();
            fmg.ShowDialog();
        }
        #endregion
    }
}
