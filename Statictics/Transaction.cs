using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS.Statictics
{
    public partial class Transaction: UserControl
    {
        string id;
        public Transaction()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                dtgvTransaction.DataSource = DAO.ImportTransactionDAO.Instance.GetImportTransactions();
            } 
            else if (comboBox1.SelectedIndex == 1)
            {
                dtgvTransaction.DataSource = DAO.Sell_TransactionDAO.Instance.GetSellTransactions();
            }        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng chọn giao dịch cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isDeleted = false;

            if (comboBox1.SelectedIndex == 0)
            {
                isDeleted = DAO.ImportTransactionDAO.Instance.Delete(id);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                isDeleted = DAO.Sell_TransactionDAO.Instance.Delete(id);
            }

            if (isDeleted)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    dtgvTransaction.DataSource = DAO.ImportTransactionDAO.Instance.GetImportTransactions();

                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    dtgvTransaction.DataSource = DAO.Sell_TransactionDAO.Instance.GetSellTransactions();
                }
                dtgvDetail.DataSource = null;
                MessageBox.Show("Xóa giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa giao dịch thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvTransaction.Rows[e.RowIndex];

                object cellValue = null;

                if (comboBox1.SelectedIndex == 0)
                {
                    cellValue = row.Cells["Imp_ID"].Value;
                    dtgvDetail.DataSource = DAO.ImportDetailTransactionDAO.Instance.GetList((string)cellValue);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    cellValue = row.Cells["Sell_ID"].Value;
                    dtgvDetail.DataSource = DAO.SellDetailTransactionDAO.Instance.GetList((string)cellValue);
                }

                if (cellValue != null)
                {
                    id = cellValue.ToString(); // Ép kiểu về string để tránh lỗi
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
