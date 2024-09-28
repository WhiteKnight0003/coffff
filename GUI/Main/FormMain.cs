using CoffeeApp.GUI.Main;
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
        private int id;
        private int roleID;
        public FormMain(int id, int roleID)
        {
            InitializeComponent();
            this.id = id;
            this.roleID = roleID;
        }

        private void quảnLýCửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagement fmg = new FormManagement();
            this.Hide();
            fmg.ShowDialog();

        }
    }
}
