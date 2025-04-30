using Project_DBMS.DTO;
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
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPasswrod.Text;

            string role = DAO.EmployeeDAO.Instance.LoginDatabase(username, password);

            if (!string.IsNullOrEmpty(role))
            {
                MessageBox.Show($"LOGIN THÀNH CÔNG! Vai trò của bạn: {role}");
                // Sau khi xác thực thành công
                Global.SetGlobalEmpIdD(username);

                // Có thể có nhiều role, nên dùng Contains
                if (role.Contains("Administrator"))
                {
                    using (AdminForm adminForm = new AdminForm())
                    {
                        this.Hide();
                        adminForm.ShowDialog();
                        this.Show();
                    }
                }
                else if (role.Contains("Staff"))
                {
                    using (StaffForm staffForm = new StaffForm())
                    {
                        this.Hide();
                        staffForm.ShowDialog();
                        this.Show();
                    }
                }
                else if (role.Contains("Storekeeper"))
                {
                    using (StorekeeperForm storeForm = new StorekeeperForm())
                    {
                        this.Hide();
                        storeForm.ShowDialog();
                        this.Show();
                    }
                }
                else if (role.Contains("Manager"))
                {
                    using (ManagerForm managerForm = new ManagerForm())
                    {
                        this.Hide();
                        managerForm.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Vai trò không xác định, vui lòng liên hệ quản trị viên.");
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Kiểm tra lại tài khoản hoặc mật khẩu!");
            }
        }

    }
}
