using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_DBMS.SellTransaction;
using Project_DBMS.DTO;

namespace Project_DBMS.Customer
{
    public partial class FindCustomerUC: UserControl
    {
        public FindCustomerUC()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tên khách hàng từ TextBox
                string customerName = txtName.Text.Trim();

                if (string.IsNullOrEmpty(customerName))
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string SellID = DAO.Sell_TransactionDAO.Instance.GenerateSellID();
                // Kiểm tra sự tồn tại của khách hàng
                if (DAO.CustomerDAO.Instance.CheckExistence(customerName))
                {
                    
                    MessageBox.Show($"Khách hàng '{customerName}' tồn tại trong hệ thống!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddCustomerUC addCustomerUC = new AddCustomerUC(DAO.CustomerDAO.Instance.GetCustomer(customerName));
                    addCustomerUC.Dock = DockStyle.Fill;
                    StaffForm.pnAddInstance1.Controls.Clear();
                    StaffForm.pnAddInstance1.Controls.Add(addCustomerUC);

                    AddSellUC AddSellUC = new AddSellUC(Global.GlobalEmpId, DAO.CustomerDAO.Instance.GetCustomerID(customerName));
                    AddSellUC.Dock = DockStyle.Fill;
                    StaffForm.pnAddInstance2.Controls.Clear();
                    StaffForm.pnAddInstance2.Controls.Add(AddSellUC);
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy khách hàng '{customerName}'.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Thêm customer mới
                    //StaffForm.pnSearchInstance.Controls.Clear();

                    AddCustomerUC addCustomerUC = new AddCustomerUC(customerName);
                    addCustomerUC.Dock = DockStyle.Fill;
                    StaffForm.pnAddInstance1.Controls.Clear();
                    StaffForm.pnAddInstance1.Controls.Add(addCustomerUC);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
