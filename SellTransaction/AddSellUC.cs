using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_DBMS.ImportTransaciton;
using Project_DBMS.DTO;

namespace Project_DBMS.SellTransaction
{
    public partial class AddSellUC : UserControl
    {
        public AddSellUC()
        {
            InitializeComponent();
        }
        public AddSellUC(string Emp_ID, string Cus_ID)
        {
            InitializeComponent();
            txtCusID.Text = Cus_ID;
            txtEmp_ID.Text = Emp_ID;
            txtImp_ID.Text = DAO.Sell_TransactionDAO.Instance.GenerateSellID();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng sellTransaction từ dữ liệu nhập
                DTO.Sell_Transaction sellTransaction = new DTO.Sell_Transaction(
                    txtImp_ID.Text,        // chú ý đúng textbox ID bán hàng
                    txtCusID.Text,
                    Global.GlobalEmpId,
                    DateTime.Now            // hoặc bạn cho phép chọn Sell_Date
                );

                // Gọi DAO insert
                if (DAO.Sell_TransactionDAO.Instance.Insert(sellTransaction))
                {
                    MessageBox.Show("Thêm giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Load giao diện chi tiết bán hàng
                    AddSellDetailUC addSellDetailUC = new AddSellDetailUC(txtImp_ID.Text);
                    addSellDetailUC.Dock = DockStyle.Fill;
                    StaffForm.pnAddInstance3.Controls.Clear();
                    StaffForm.pnAddInstance3.Controls.Add(addSellDetailUC);
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
