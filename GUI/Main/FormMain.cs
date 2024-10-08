using CoffeeApp.DAO;
using CoffeeApp.DTO;
using CoffeeApp.GUI.Main;
using CoffeeApp.GUI.Usercontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = CoffeeApp.DTO.Menu;

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
            loadPayment();
            LoadCategory();
            LoadComboboxTable(cbSwitchTable);
            Decentralization(username, roleID);
        }

        #region Method
        void loadPayment()
        {
            var p = Enum.GetValues(typeof(Payment));
            cbPayment.DataSource = p;
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadProductListByCategoryID(int id)
        {
            List<Product> listProduct = ProductDAO.Instance.GetProductByCategoryID(id);
            cbProduct.DataSource = listProduct;
            cbProduct.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.ProductName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
                lsvBill.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lsvBill.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;

            txbTotalPrice.Text = totalPrice.ToString("c", culture);

        }

        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        private void Decentralization(string username, int roleID)
        {
            if (roleID == 2)
            {
                ManageShopToolStripMenuItem.Visible = false;
            }
            else if (roleID == 1)
            {
                BillToolStripMenuItem.Visible = false;
            }
        }
        #endregion

        #region Events
        private void ManageShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagement fmg = new FormManagement(this, username, roleID);
            this.Hide();
            fmg.ShowDialog();

        }

        private void BillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagement fmg = new FormManagement(this, username, roleID);
            this.Hide();
            fmg.ShowDialog();
        }

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadProductListByCategoryID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            UserDTO user = UserDAO.Instance.GetByUserName(username);

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbProduct.SelectedItem as Product).ID;
            int count = (int)nmProductCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID,user.Id);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);

            LoadTable();
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            string paymentName = cbPayment.SelectedItem as string;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDisCount.Value;

            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice, paymentName);
                    ShowBill(table.ID);

                    LoadTable();
                }
            }
        }
        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            UserDTO user = UserDAO.Instance.GetByUserName(username);
            int id1 = (lsvBill.Tag as Table).ID;

            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2, user.Id);
                LoadTable();
            }
        }
        #endregion

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
