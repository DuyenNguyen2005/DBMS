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
    public partial class CustomerForm: Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            if (DAO.CustomerDAO.Instance.AddCustomer(name, phone, address))
            {
                LoadCustomer();
                MessageBox.Show("Thêm thành công");
                
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            if (DAO.CustomerDAO.Instance.UpdateCustomer(id, name, phone, address))
            {
                MessageBox.Show("Sửa thành công");
                LoadCustomer();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            if (DAO.CustomerDAO.Instance.DeleteCustomer(id  ))
            {
                LoadCustomer();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        void LoadCustomer()
        {
            dataGridViewCustomer.DataSource = DAO.CustomerDAO.Instance.GetCustomerList();
            dataGridViewCustomer.AllowUserToAddRows = false; // Không cho phép thêm hàng mới
        }

        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPhone.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAddress.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCustomer.DataSource = DAO.CustomerDAO.Instance.SearchCustomer(txtSearch.Text);
        }
    }
}
