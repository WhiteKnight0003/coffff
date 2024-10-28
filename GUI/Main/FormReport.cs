using Microsoft.Reporting.WinForms;
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
    public partial class FormReport : Form
    {
        private FormMain formMain;
        public FormReport(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {

            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("thang", DateTime.Now.Month.ToString());
            parameters[1] = new ReportParameter("nam", DateTime.Now.Year.ToString());
           

            string comment = "Các sản phẩm bán được nhiều nhất là :  ";
            int max = 0;
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery("USP_GetTotalSoldMonthByProduct");
            if (data.Rows.Count > 0)
            {
                foreach (DataRow i in data.Rows)
                {
                    if (max < int.Parse(i["TotalSold"].ToString()))
                        max = int.Parse(i["TotalSold"].ToString());                   
                }

                foreach (DataRow i in data.Rows)
                {
                    if (max == int.Parse(i["TotalSold"].ToString()))
                        comment += i["Name"].ToString() + "  ";
                }

                parameters[2] = new ReportParameter("comment", comment);
                reportViewer1.LocalReport.SetParameters(parameters);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("SoutOutProduct", data));               
            }
            else
            {
                MessageBox.Show("Tháng này chưa bán được sản phẩm nào");
            }


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMain.Show();
        }

        private void FormReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
