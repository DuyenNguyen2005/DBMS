using Project_DBMS.DAO;
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
    public partial class EmployeeForm: Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            dtpDob.Format = DateTimePickerFormat.Custom; 
            dtpDob.CustomFormat = "dd/MM/yyyy";

            LoadEmployee();
        }

        private void LoadEmployee()
        {
            dataGridViewEmployee.DataSource = EmployeeDAO.Instance.GetEmployeeList();
            dataGridViewEmployee.AllowUserToAddRows = false; // Không cho phép thêm hàng mới
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            DateTime dob = dtpDob.Value;
            string phone = txtPhone.Text;
            if (EmployeeDAO.Instance.AddEmployee(name, dob, phone))
            {
                LoadEmployee();
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
            DateTime dob = dtpDob.Value;
            
            if (EmployeeDAO.Instance.UpdateEmployee(id, name, dob, phone))
            {
                LoadEmployee();
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            if (EmployeeDAO.Instance.DeleteEmployee(id))
            {
                LoadEmployee();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewEmployee.DataSource = EmployeeDAO.Instance.SearchEmployee(txtSearch.Text);
        }

        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpDob.Value = DateTime.Parse(dataGridViewEmployee.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtPhone.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
