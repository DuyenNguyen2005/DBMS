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
    public partial class SellForm: Form
    {
        public SellForm()
        {
            InitializeComponent();
        }

        private void SellForm_Load(object sender, EventArgs e)
        {
            LoadSell();
        }
        void LoadSell()
        {
            // Load sell data into the DataGridView
            dataGridViewSell.DataSource = DAO.Sell_TransactionDAO.Instance.GetSellTransactionList();
            dataGridViewSell.AllowUserToAddRows = false;
        }
        private void dataGridViewSell_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSell.Rows[e.RowIndex];
                txtId.Text = row.Cells["Sell_ID"].Value.ToString();
                txtPro_Name.Text = DAO.ProductDAO.Instance.GetProductById(int.Parse(row.Cells["Pro_ID"].Value.ToString())).Pro_Name.ToString();
                txtCus_Name.Text = DAO.CustomerDAO.Instance.GetCustomerByID(int.Parse(row.Cells["Cus_ID"].Value.ToString())).Cus_Name.ToString();
                txtEmp_Name.Text = DAO.EmployeeDAO.Instance.GetEmployeeByID(int.Parse(row.Cells["Emp_ID"].Value.ToString())).Emp_Name.ToString();
                txtSell_Quantity.Text = row.Cells["Sell_Quantity"].Value.ToString();
                txrSell_Price.Text = row.Cells["Sell_Price"].Value.ToString();
                txtSell_Discount.Text = row.Cells["Sell_Discount"].Value.ToString();
                dtpSell.Value = DateTime.Parse(row.Cells["Sell_Date"].Value.ToString());
            }    
        }
        // Add Sell Transaction
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int pro_id = DAO.ProductDAO.Instance.GetProductIdByName(txtPro_Name.Text);
            int cus_id = DAO.CustomerDAO.Instance.GetCustomerByName(txtCus_Name.Text).Cus_ID;
            int emp_id = DAO.EmployeeDAO.Instance.GetEmployeeByName(txtEmp_Name.Text).Emp_ID;
            int sell_quantity = int.Parse(txtSell_Quantity.Text);
            decimal sell_price = decimal.Parse(txrSell_Price.Text);
            decimal discount = decimal.Parse(txtSell_Discount.Text);

            if(DAO.Sell_TransactionDAO.Instance.AddSellTransaction(pro_id, cus_id, emp_id, sell_quantity,discount,sell_price ))
            {
                MessageBox.Show("Thêm thành công");
                LoadSell();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            int pro_id = DAO.ProductDAO.Instance.GetProductIdByName(txtPro_Name.Text);
            int cus_id = DAO.CustomerDAO.Instance.GetCustomerByName(txtCus_Name.Text).Cus_ID;
            int emp_id = DAO.EmployeeDAO.Instance.GetEmployeeByName(txtEmp_Name.Text).Emp_ID;
            int sell_quantity = int.Parse(txtSell_Quantity.Text);
            decimal sell_price = decimal.Parse(txrSell_Price.Text);
            decimal discount = decimal.Parse(txtSell_Discount.Text);

            if (DAO.Sell_TransactionDAO.Instance.UpdateSellTransaction(id, pro_id, cus_id, emp_id, sell_quantity, discount, sell_price))
            {
                MessageBox.Show("Sửa thành công");
                LoadSell();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            if (DAO.Sell_TransactionDAO.Instance.DeleteSellTransaction(id))
            {
                MessageBox.Show("Xóa thành công");
                LoadSell();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewSell.DataSource = DAO.Import_TransactionDAO.Instance.SearchImportTransaction(txtSearch.Text);
        }

        
    }
}
