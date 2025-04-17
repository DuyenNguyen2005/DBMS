using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS
{
    public partial class ProductForm: Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void LoadProduct()
        {
            dataGridViewProduct.DataSource = DAO.ProductDAO.Instance.GetProductList();  
            dataGridViewProduct.AllowUserToAddRows = false; // Không cho phép thêm hàng mới
        }
        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridViewProduct.CurrentRow.Cells["Pro_ID"].Value.ToString();
            txtName.Text = dataGridViewProduct.CurrentRow.Cells["Pro_Name"].Value.ToString();
            txtPrice.Text = dataGridViewProduct.CurrentRow.Cells["Pro_Price"].Value.ToString();
            txtQuantity.Text = dataGridViewProduct.CurrentRow.Cells["Pro_Quantity"].Value.ToString();
            txtType.Text = dataGridViewProduct.CurrentRow.Cells["Pro_Type"].Value.ToString();
            txtSupplierId.Text = dataGridViewProduct.CurrentRow.Cells["Sup_ID"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            string type = txtType.Text;
            int supplier_id = int.Parse(txtSupplierId.Text);

            if (DAO.ProductDAO.Instance.AddProduct(name, price, quantity, type, supplier_id))
            {
                LoadProduct();
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            if (DAO.ProductDAO.Instance.DeleteProduct(id))
            {
                LoadProduct();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string name = txtName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            string type = txtType.Text;
            int supplier_id = int.Parse(txtSupplierId.Text);

            if (DAO.ProductDAO.Instance.UpdateProduct(id, name, price, quantity, type, supplier_id))
            {
                MessageBox.Show("Sửa thành công");
                LoadProduct();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewProduct.DataSource = DAO.ProductDAO.Instance.SearchProduct(txtSearch.Text);
        }
    }
}
