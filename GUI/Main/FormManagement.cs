using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp.GUI.Main
{
    public partial class FormManagement : Form
    {
        private FormMain formmain;
        public FormManagement(FormMain formmain)
        {
            InitializeComponent();
            this.formmain = formmain;
        }

        private void btnBackFormManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            formmain.Show();
        }
    }
}
