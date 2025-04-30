using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS.Employee
{
    public partial class AccountUC: UserControl
    {
        public AccountUC()
        {
            InitializeComponent();       
        }

        private void btnListAcount_Click(object sender, EventArgs e)
        {
            dtgvDisplay.DataSource = DAO.EmployeeDAO.Instance.ListAccount();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgvDisplay.DataSource = DAO.EmployeeDAO.Instance.ModiFiedTime();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
               
                // Kiểm tra nếu tên tài khoản hợp lệ
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Vui lòng chọn một tài khoản hợp lệ để đặt lại mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gọi phương thức đặt lại mật khẩu
                string result = DAO.EmployeeDAO.Instance.ResertPaswword(textBox1.Text.ToString());

                // Kiểm tra kết quả
                if (!string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Đổi mật khẩu thành công! Mật khẩu mới là: " + result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đặt lại mật khẩu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dtgvDisplay.DataSource = DAO.EmployeeDAO.Instance.SearchAccount(textBox1.Text);
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu không click vào header
            {
                DataGridViewRow row = dtgvDisplay.Rows[e.RowIndex]; // Lấy hàng được click
                textBox1.Text = row.Cells["Username"].Value?.ToString(); // Lấy giá trị Username
            }
        }
    }
}
