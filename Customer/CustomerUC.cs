using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_DBMS.DAO;
using Project_DBMS.DTO;

namespace Project_DBMS.Customer
{
    public partial class CustomerUC: UserControl
    {
        public CustomerUC()
        {
            InitializeComponent();
            LoadCustomer();
        }
        void LoadCustomer()
        {
            dataGridViewCustomers.DataSource = DAO.CustomerDAO.Instance.GetCustomers();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DTO.Customer customer = new DTO.Customer()
            {
                Cus_ID = DAO.CustomerDAO.Instance.GenerateCusID(),
                Cus_Name = txtName.Text,
                Cus_Address = txtAddress.Text,
                Cus_Phone = txtPhone.Text,
            };
            // Thêm vào cơ sở dữ liệu
            if (CustomerDAO.Instance.Insert(customer))
            {
                LoadCustomer();
                MessageBox.Show($"Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearForm();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DTO.Customer customer = new DTO.Customer()
            {
                Cus_ID = txtCustomerID.Text,
                Cus_Name = txtName.Text,
                Cus_Address = txtAddress.Text,
                Cus_Phone = txtPhone.Text,
            };
            // Thêm vào cơ sở dữ liệu
            if (CustomerDAO.Instance.Update(customer))
            {
                LoadCustomer();
                MessageBox.Show($"Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearForm();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Thêm vào cơ sở dữ liệu
            if (CustomerDAO.Instance.Delete(txtCustomerID.Text))
            {
                LoadCustomer();
                MessageBox.Show($"Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearForm();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCustomers.Rows[e.RowIndex];

                // Kiểm tra nếu ô không rỗng trước khi truy xuất giá trị
                txtCustomerID.Text = row.Cells["Cus_ID"].Value.ToString();
                txtName.Text = row.Cells["Cus_Name"].Value.ToString();
                txtAddress.Text = row.Cells["Cus_Address"].Value.ToString();
                txtPhone.Text = row.Cells["Cus_Phone"].Value.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCustomers.DataSource = DAO.CustomerDAO.Instance.Search(textBox1.Text);
        }

        private void dataGridViewCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
