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
using System.Data.SqlClient;

namespace Project_DBMS
{
    public partial class AddEmployeeUC: UserControl
    {
        public AddEmployeeUC()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ giao diện người dùng
                string id = EmployeeDAO.Instance.GenerateEmpID(cboEmpPosition.Text.ToString());
                string name = txtEmpName.Text.Trim();
                DateTime dob = dtpEmpDOB.Value;
                string gender = rdFemale.Checked ? "F" : "M";
                string address =  txtEmpAddress.Text.Trim();
                string phone =  txtEmpPhone.Text.Trim();
                string email = txtEmpEmail.Text.Trim();
                string position = cboEmpPosition.Text;
                DateTime hireDate = dtpEmpHireDate.Value;
                decimal salary;

                // Kiểm tra nếu lương không hợp lệ
                if (!decimal.TryParse(txtEmpSalary.Text, out salary))
                {
                    MessageBox.Show("Lương phải là một số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng Employee (ID, DOB, và HireDate sẽ được xử lý bởi trigger)
                DTO.Employee newEmployee = new DTO.Employee(id, name, dob, gender, address, phone, email, position, hireDate, salary);

                // Thêm vào cơ sở dữ liệu
                if (EmployeeDAO.Instance.Insert(newEmployee))
                {
                    string pass = DAO.EmployeeDAO.Instance.CreateNewLogin(id);
                    MessageBox.Show($"Thêm nhân viên thành công!\nTài khỏa: {id} \nMật khẩu là {pass}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    MessageBox.Show(position);
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        // Làm sạch form sau khi thêm nhân viên
        private void ClearForm()
        {
            txtEmpName.Clear();
            txtEmpAddress.Clear();
            txtEmpPhone.Clear();
            txtEmpEmail.Clear();
            txtEmpSalary.Clear();
            cboEmpPosition.SelectedIndex = 0;
            rdFemale.Checked = false;
            rdMale.Checked = false;
            dtpEmpDOB.Value = DateTime.Now;
            dtpEmpHireDate.Value = DateTime.Now;
        }

        private void cboEmpPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoFillEmployeeForm(cboEmpPosition.SelectedIndex);
        }

        private void AutoFillEmployeeForm(int position)
        {
            Random rnd = new Random();

            // Sinh Emp_ID
            switch (position)
            {
                case 0:
                    // Storekeeper
                    cboEmpPosition.SelectedItem = "Storekeeper";
                    break;
                case 1:
                    // Staff
                    cboEmpPosition.SelectedItem = "Staff";
                    break;
                case 2:
                    // Manager
                    cboEmpPosition.SelectedItem = "Manager";
                    break;
                case 3:
                    // Administrator
                    cboEmpPosition.SelectedItem = "Administrator";
                    break;
                default:
                    MessageBox.Show("Vị trí không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }


            // Sinh Emp_Name (chỉ chứa chữ và số, không ký tự đặc biệt)
            txtEmpName.Text = "JohnDoe" + rnd.Next(10, 99);

            // Sinh DOB (18-100 tuổi)
            DateTime today = DateTime.Today;
            int age = rnd.Next(18, 100);
            DateTime dob = today.AddYears(-age);
            dtpEmpDOB.Value = dob;

            // Sinh Gender
            if (rnd.Next(2) == 0)
            {
                rdMale.Checked = true;
                rdFemale.Checked = false;
            }
            else
            {
                rdMale.Checked = false;
                rdFemale.Checked = true;
            }

            // Sinh Address (không để đầu khoảng trắng và không chứa ký tự đặc biệt như số, chữ, dấu cách, dấu phẩy, dấu chấm)
            txtEmpAddress.Text = "District" + rnd.Next(1, 20) + " City";

            // Sinh Phone (bắt đầu bằng 0 + 1-9 + 8 số tiếp theo)
            txtEmpPhone.Text = "0" + rnd.Next(1, 10).ToString() + rnd.Next(10000000, 99999999).ToString();

            // Sinh Email (phải có @, . và không có khoảng trắng)
            txtEmpEmail.Text = "employee" + rnd.Next(1000, 9999).ToString() + "@company.com";

            // Sinh Position (Storekeeper, Staff, Manager, Administrator)
            string[] positions = { "Storekeeper", "Staff", "Manager", "Administrator" };
            cboEmpPosition.SelectedItem = positions[rnd.Next(positions.Length)];

            // Sinh HireDate (từ 50 năm trước đến hiện tại)
            DateTime hireDate = today.AddYears(-rnd.Next(0, 50)).AddDays(-rnd.Next(0, 365));
            if (hireDate > today)
            {
                hireDate = today;
            }
            dtpEmpHireDate.Value = hireDate;

            // Sinh Salary (> 0)
            decimal salary = rnd.Next(300, 10000) + rnd.Next(0, 99) / 100m; // từ 300.00 đến 9999.99
            txtEmpSalary.Text = salary.ToString("0.00");
        }

        private void AddEmployeeUC_Load(object sender, EventArgs e)
        {
            
        }
    }
}
