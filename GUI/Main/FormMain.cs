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
            FillingFood();
            this.username = username;
            this.roleID = roleID;
        }

        private void quảnLýCửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagement fmg = new FormManagement(this);
            this.Hide();
            fmg.ShowDialog();

        }

        #region Method
        private void FillingFood()
        {
            DataTable data = DAO.ProductDAO.Instance.FullFood();
            foreach (DataRow row in data.Rows)
            {
                ProductDTO producDTO = new ProductDTO(row); 
                FoodView foodView = new FoodView();
                foodView.lbNameFood.Text = producDTO.Name;
                foodView.lbDescriptFood.Text = producDTO.Description;
                foodView.lbCashFood.Text = producDTO.Price.ToString();
                flowLayoutPanel1.Controls.Add(foodView);
            }
        }

        #endregion
    }
}
