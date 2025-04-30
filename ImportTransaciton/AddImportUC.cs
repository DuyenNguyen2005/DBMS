using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_DBMS.ImportTransaciton
{
    public partial class AddImportUC: UserControl
    {
        public AddImportUC()
        {
            InitializeComponent();
        }

        public AddImportUC(string Imp_ID, string Emp_ID, string Sup_ID)
        {
            InitializeComponent();
            txtSup_ID.Text = Sup_ID;
            txtEmp_ID.Text = Emp_ID;
            txtImp_ID.Text = Imp_ID;
        }
        public AddImportUC(string Emp_ID, string Sup_ID)
        {
            InitializeComponent();
            txtSup_ID.Text = Sup_ID;
            txtEmp_ID.Text = Emp_ID;
            txtImp_ID.Text = DAO.ImportTransactionDAO.Instance.GenerateImpID(); ;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng ImpTransaction từ dữ liệu nhập
                DTO.Import_Transaction ImpTransaction = new DTO.Import_Transaction(
                    txtImp_ID.Text,        // chú ý đúng textbox ID bán hàng
                    txtEmp_ID.Text,
                    txtSup_ID.Text,
                    DateTime.Now
                );

                // Gọi DAO insert
                if (DAO.ImportTransactionDAO.Instance.Insert(ImpTransaction))
                {
                    MessageBox.Show("Thêm giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Load giao diện chi tiết bán hàng
                    AddImportDetailUC addImpDetailUC = new AddImportDetailUC(txtImp_ID.Text, txtSup_ID.Text);
                    addImpDetailUC.Dock = DockStyle.Fill;
                    StorekeeperForm.pnAddInstance3.Controls.Clear();
                    StorekeeperForm.pnAddInstance3.Controls.Add(addImpDetailUC);
                }
                else
                {
                    MessageBox.Show("Không thể thêm giao dịch! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
