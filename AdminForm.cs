using Project_DBMS.Customer;
using Project_DBMS.Employee;
using Project_DBMS.ImportTransaciton;
using Project_DBMS.Product;
using Project_DBMS.Supplier;
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
    public partial class AdminForm: Form
    {
        public static Panel pnAddInstance;
        public AdminForm()
        {
            InitializeComponent();
            pnAddInstance = pnDisplay;
        }
        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeUC employeeUC = new AddEmployeeUC(); // Khởi tạo UserControl
            employeeUC.Dock = DockStyle.Fill; // Tự động căn chỉnh kích thước

            pnDisplay.Controls.Clear(); // Xóa UserControl trước đó (nếu có)
            pnDisplay.Controls.Add(employeeUC); // Thêm UserControl mới
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisplayUC displayAndSearchUC = new DisplayUC();
            displayAndSearchUC.Dock = DockStyle.Fill;
            pnDisplay.Controls.Clear();
            pnDisplay.Controls.Clear();
            pnDisplay.Controls.Add(displayAndSearchUC);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AccountUC accountUC = new AccountUC();
            accountUC.Dock = DockStyle.Fill;
            pnDisplay.Controls.Clear();
            pnDisplay.Controls.Clear();
            pnDisplay.Controls.Add(accountUC);
        }

    }
}
