using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_DBMS.Customer;
using Project_DBMS.ImportTransaciton;
using Project_DBMS.DTO;

namespace Project_DBMS.Supplier
{
    public partial class FindSuppllierUC: UserControl
    {
        public FindSuppllierUC()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tên khách hàng từ TextBox
                string supplierName = txtName.Text.Trim();

                if (string.IsNullOrEmpty(supplierName))
                {
                    MessageBox.Show("Vui lòng nhập tên nhà cung cấp để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra sự tồn tại của khách hàng
                if (DAO.SupplierDAO.Instance.CheckExistence(supplierName))
                {

                    MessageBox.Show($"Nhà cung cấp'{supplierName}' tồn tại trong hệ thống!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddSupplierUC AddSupplierUC = new AddSupplierUC(DAO.SupplierDAO.Instance.GetSupplier(supplierName));
                    AddSupplierUC.Dock = DockStyle.Fill;
                    StorekeeperForm.pnAddInstance1.Controls.Clear();
                    StorekeeperForm.pnAddInstance1.Controls.Add(AddSupplierUC);

                    AddImportUC AddImportUC = new AddImportUC(Emp_ID : Global.GlobalEmpId, Sup_ID : DAO.SupplierDAO.Instance.GetSupplierID(supplierName));
                    AddImportUC.Dock = DockStyle.Fill;
                    StorekeeperForm.pnAddInstance2.Controls.Clear();
                    StorekeeperForm.pnAddInstance2.Controls.Add(AddImportUC);

                }
                else
                {
                    MessageBox.Show($"Không tìm thấy nhà cung cấp '{supplierName}'.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    AddSupplierUC AddSupplierUC = new AddSupplierUC(supplierName,true);
                    AddSupplierUC.Dock = DockStyle.Fill;
                    StorekeeperForm.pnAddInstance1.Controls.Clear();
                    StorekeeperForm.pnAddInstance1.Controls.Add(AddSupplierUC);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
