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
    public partial class SupplierForm: Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadSupplier();
        }

        private void LoadSupplier()
        {
            dataGridViewSupplier.DataSource = DAO.SupplierDAO.Instance.GetSupplierList();
            dataGridViewSupplier.AllowUserToAddRows = false; // Không cho phép thêm hàng mới
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;

            if (DAO.SupplierDAO.Instance.AddSupplier(name, phone))
            {
                LoadSupplier();
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
            if (DAO.SupplierDAO.Instance.DeleteSupplier(id))
            {
                LoadSupplier();
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
            string phone = txtPhone.Text;

            if (DAO.SupplierDAO.Instance.UpdateSupplier(id, name, phone))
            {
                MessageBox.Show("Sửa thành công");
                LoadSupplier();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void dataGridViewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridViewSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridViewSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPhone.Text = dataGridViewSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewSupplier.DataSource = DAO.SupplierDAO.Instance.SearchSupplier(txtSearch.Text);
        }
    }
}
