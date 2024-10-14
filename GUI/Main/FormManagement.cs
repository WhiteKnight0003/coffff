using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using CoffeeApp.DAO;
using CoffeeApp.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CoffeeApp.GUI.Main
{
    public partial class FormManagement : Form
    {
        private FormMain formmain;
        private string username;
        private int roleID;

        public FormManagement(FormMain formmain ,string username, int roleID)
        {
            InitializeComponent();
            this.formmain = formmain;
            this.username = username;
            this.roleID = roleID;
            Decentralization(username, roleID);
        }

        private void Decentralization(string username, int roleID)
        {
            // staff
            if (roleID == 2)
            {
                tcManagement.TabPages.Remove(TabStatisticsProceeds);
                tcManagement.TabPages.Remove(TabProduct);
                tcManagement.TabPages.Remove(TabCategory);
                tcManagement.TabPages.Remove(TabManagementUser);
            }
        }

        private void btnBackFormManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            formmain.Show();
        }

        private void TabProduct_Click(object sender, EventArgs e)
        {

        }

        private void LoadListProduct()
        {
            dtgvProduct.DataSource = ProductDAO.Instance.GetListProduct();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            LoadListProduct();
            AddProductBinding();
            LoadCategoryIntoCombobox();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text;
            int categoryID = (cbbProductCategory.SelectedItem as Category).ID;
            float price = (float)nmProductPrice.Value;

            if(ProductDAO.Instance.InsertProduct(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListProduct();
                //if(insertProduct != null)
                //{
                //    insertProduct(this, new EventArgs());
                //}    
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            } 
                
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text;
            int categoryID = (cbbProductCategory.SelectedItem as Category).ID;
            float price = (float)nmProductPrice.Value;
            int id = Convert.ToInt32(txtProductID.Text);

            if (ProductDAO.Instance.UpdateProduct(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListProduct();
                //if (updateProduct != null)
                //{
                //    updateProduct(this, new EventArgs());
                //}
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((string)txtProductID.Text);
            if (ProductDAO.Instance.DeleteProduct(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListProduct();
                //if (deleteProduct != null)
                //{
                //    deleteProduct(this, new EventArgs());
                //}
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }

        //private event EventHandler insertProduct;
        //public event EventHandler InsertProduct
        //{
        //    add { insertProduct += value; }
        //    remove { insertProduct -= value; }
        //}

        //private event EventHandler deleteProduct;
        //public event EventHandler DeleteProduct
        //{
        //    add { deleteProduct += value; }
        //    remove { deleteProduct -= value; }
        //}

        //private event EventHandler updateProduct;
        //public event EventHandler UpdateProduct
        //{
        //    add { updateProduct += value; }
        //    remove { updateProduct -= value; }
        //}

        private void cbbProductCategory_Click(object sender, EventArgs e)
        {

        }

        private void AddProductBinding()
        {
            txtProductName.DataBindings.Clear();
            txtProductName.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "Name", true, DataSourceUpdateMode.Never));

            txtProductID.DataBindings.Clear();
            txtProductID.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "ID", true, DataSourceUpdateMode.Never));

            nmProductPrice.DataBindings.Clear();
            nmProductPrice.DataBindings.Add(new Binding("Value", dtgvProduct.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        private void LoadCategoryIntoCombobox()
        {
            cbbProductCategory.DataSource = CategoryDAO.Instance.GetListCategory();
            cbbProductCategory.DisplayMember = "Name";
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvProduct.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvProduct.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category category = CategoryDAO.Instance.GetCategoryByID(id);

                    cbbProductCategory.SelectedItem = category;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbbProductCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i; break;
                        }
                        i++;
                    }

                    cbbProductCategory.SelectedIndex = index;
                }
            }
            catch { }
        }


        // Chi tiet hoa don
        private void LoadListBillDetails()
        {
            dgvBillDetails.DataSource = BillDAO.Instance.GetListBill();
        }

        private void dgvBillDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillDetails();
        }

        List<Product> SearchProductByName(string name)
        {
            return ProductDAO.Instance.SearchProductByName(name);
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            dtgvProduct.DataSource = SearchProductByName(txtSearchProductName.Text);
        }
    }
}
