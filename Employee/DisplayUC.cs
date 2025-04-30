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
using System.Data.SqlClient;

namespace Project_DBMS.Employee
{
    public partial class DisplayUC: UserControl
    {
        public DisplayUC()
        {
            InitializeComponent();
        }

        private void DisplayAndSearchUC_Load(object sender, EventArgs e)
        {
            dgvResult.DataSource = DAO.EmployeeDAO.Instance.GetEmployees();
            txtEmpID.Enabled = false;
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvResult.Rows[e.RowIndex];

                // Điền thông tin vào các TextBox
                txtEmpID.Text = row.Cells["Emp_ID"].Value.ToString();
                txtEmpName.Text = row.Cells["Emp_Name"].Value.ToString();
                txtAddress.Text = row.Cells["Emp_Address"].Value.ToString();
                txtPhone.Text = row.Cells["Emp_Phone"].Value.ToString();
                txtEmail.Text = row.Cells["Emp_Email"].Value.ToString();
                cboPosition.Text = row.Cells["Emp_Position"].Value.ToString();
                txtSalary.Text = Convert.ToDecimal(row.Cells["Emp_Salary"].Value).ToString("F2");
                dtpHireDate.Text = Convert.ToDateTime(row.Cells["Emp_HireDate"].Value).ToString("MM-dd-yyyy");
                dtpEmpDOB.Text = Convert.ToDateTime(row.Cells["Emp_DOB"].Value).ToString("MM-dd-yyyy");

                // Xử lý RadioButton giới tính
                if (row.Cells["Emp_Gender"].Value.ToString() == "M")
                {
                    rdMale.Checked = true;
                    rdFemale.Checked = false;
                }
                else
                {
                    rdMale.Checked = false;
                    rdFemale.Checked = true;
                }

                // Xử lý trạng thái nhân viên
                chkStatus.Checked = Convert.ToBoolean(row.Cells["Emp_Status"].Value);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            txtEmpName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtSalary.Clear();
            cboPosition.SelectedIndex = 0;
            rdFemale.Checked = false;
            rdMale.Checked = false;
            dtpEmpDOB.Value = DateTime.Now;
            dtpHireDate.Value = DateTime.Now;
            txtEmpID.Clear();
            chkStatus.Checked = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            dgvResult.DataSource = DAO.EmployeeDAO.Instance.Search(keyword);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string emp_id = txtEmpID.Text.Trim();
                string name = txtEmpName.Text.Trim();
                DateTime dob = dtpEmpDOB.Value;
                string gender = rdFemale.Checked ? "F" : rdMale.Checked ? "M" : null;
                string address = txtAddress.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();
                string position = cboPosition.Text;
                bool status = true;
                if(!chkStatus.Checked)
                {
                    status = false;
                }    
                DateTime hireDate = dtpHireDate.Value;
                decimal salary;

                // Kiểm tra dữ liệu nhập
                if (string.IsNullOrWhiteSpace(emp_id))
                {
                    MessageBox.Show("Vui lòng nhập ID nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(gender))
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!email.Contains("@"))
                {
                    MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSalary.Text) || !decimal.TryParse(txtSalary.Text, out salary))
                {
                    MessageBox.Show("Lương phải là một số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng Employee
                DTO.Employee newEmployee = new DTO.Employee(emp_id, name, dob, gender, address, phone, email, position, hireDate, status, salary);

                // Thực hiện cập nhật
                if (EmployeeDAO.Instance.Update(newEmployee))
                {
                    MessageBox.Show("Cập nhập nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Cập nhập nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy ID nhân viên cần xóa
                string emp_id = txtEmpID.Text.Trim();

                // Kiểm tra nếu ID bị trống
                if (string.IsNullOrWhiteSpace(emp_id))
                {
                    MessageBox.Show("Vui lòng nhập ID nhân viên cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Xác nhận trước khi xóa
                DialogResult confirmDelete = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên {emp_id}?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmDelete == DialogResult.Yes)
                {
                    // Thực hiện xóa
                    if (DAO.EmployeeDAO.Instance.Delete(emp_id))
                    {
                        DAO.EmployeeDAO.Instance.DeleteAccount(emp_id);
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Xóa dữ liệu trong giao diện
                        ClearForm();

                        // Cập nhật danh sách nhân viên sau khi xóa
                        dgvResult.DataSource = DAO.EmployeeDAO.Instance.GetEmployees();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
