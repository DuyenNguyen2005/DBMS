using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Project_DBMS.SellTransaction
{
    public partial class AddSellDetailUC: UserControl
    {
        string Sell_ID;
        string pro_id;
        //int sell_quantity;
        public AddSellDetailUC()
        {
            InitializeComponent();
        }
        public AddSellDetailUC(string Sell_ID)
        {
            InitializeComponent();
            this.Sell_ID = Sell_ID;
        }

        private void SellDetailUC_Load(object sender, EventArgs e)
        {
            dtgvValuable.DataSource = DAO.ProductDAO.Instance.GetProducts_Sell();
            dtgvValuable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvValuable.MultiSelect = true; // Cho phép chọn nhiều dòng

            dtgvSelected.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvSelected.MultiSelect = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int sell_quantity = (int)nmdQuantity.Value;

                if (sell_quantity <= 0)
                {
                    MessageBox.Show("Số lượng bán phải lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int insertCount = 0;
                int updateCount = 0;

                // Nếu có chọn nhiều dòng
                if (dtgvValuable.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dtgvValuable.SelectedRows)
                    {
                        string selectedProID = row.Cells["Pro_ID"].Value?.ToString() ?? "";

                        if (!string.IsNullOrEmpty(selectedProID))
                        {
                            bool isExisted = DAO.SellDetailTransactionDAO.Instance.Exists(Sell_ID, selectedProID);

                            if (isExisted)
                            {
                                if (DAO.SellDetailTransactionDAO.Instance.IncreaseQuantity(Sell_ID, selectedProID, sell_quantity))
                                    updateCount++;
                            }
                            else
                            {
                                if (DAO.SellDetailTransactionDAO.Instance.Insert(Sell_ID, selectedProID, sell_quantity))
                                    insertCount++;
                            }
                        }
                    }
                }
                // Nếu không chọn dòng nào mà có sẵn pro_id (đã click dòng trước đó)
                else if (!string.IsNullOrEmpty(pro_id))
                {
                    bool isExisted = DAO.SellDetailTransactionDAO.Instance.Exists(Sell_ID, pro_id);

                    if (isExisted)
                    {
                        if (DAO.SellDetailTransactionDAO.Instance.IncreaseQuantity(Sell_ID, pro_id, sell_quantity))
                            updateCount++;
                    }
                    else
                    {
                        if (DAO.SellDetailTransactionDAO.Instance.Insert(Sell_ID, pro_id, sell_quantity))
                            insertCount++;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm hoặc chọn sản phẩm trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật lại giao diện
                dtgvValuable.DataSource = DAO.ProductDAO.Instance.GetProducts_Sell();
                dtgvSelected.DataSource = DAO.SellDetailTransactionDAO.Instance.GetList(Sell_ID);

                MessageBox.Show($"Đã thêm mới {insertCount} và cập nhật {updateCount} sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTotalAmount();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi từ cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int sell_quantity = (int)nmdQuantity.Value;

                // Kiểm tra nếu số lượng nhỏ hơn hoặc bằng 0
                if (sell_quantity <= 0)
                {
                    MessageBox.Show("Số lượng bán phải lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi phương thức thêm giao dịch
                bool isInserted = DAO.SellDetailTransactionDAO.Instance.Update(Sell_ID, pro_id, sell_quantity);

                if (isInserted)
                {
                    dtgvValuable.DataSource = DAO.ProductDAO.Instance.GetProducts_Sell();
                    dtgvSelected.DataSource = DAO.SellDetailTransactionDAO.Instance.GetList(Sell_ID);
                    MessageBox.Show("Thêm giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateTotalAmount();
                }
                else
                {
                    MessageBox.Show("Không thể thêm giao dịch. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi từ cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (dtgvSelected.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm đã chọn?",
                                                      "Xác nhận",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int deleteCount = 0;
                    foreach (DataGridViewRow row in dtgvSelected.SelectedRows)
                    {
                        string selectedProID = row.Cells["Pro_ID"].Value?.ToString() ?? "";

                        if (!string.IsNullOrEmpty(selectedProID))
                        {
                            bool isDeleted = DAO.SellDetailTransactionDAO.Instance.Delete(Sell_ID, selectedProID);

                            if (isDeleted)
                                deleteCount++;
                        }
                    }

                    // Cập nhật lại danh sách
                    dtgvSelected.DataSource = DAO.SellDetailTransactionDAO.Instance.GetList(Sell_ID);
                    dtgvValuable.DataSource = DAO.ProductDAO.Instance.GetProducts_Sell();

                    MessageBox.Show($"Đã xóa {deleteCount} sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi từ cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtgvValuable.DataSource = DAO.ProductDAO.Instance.Search(txtSearch.Text);
        }

        private void dtgvValuable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dtgvValuable.Rows[e.RowIndex];

                // Extract values from the selected row
                pro_id= row.Cells["Pro_ID"].Value?.ToString() ?? "";
                //txtSearch.Text = row.Cells["Pro_ID"].Value?.ToString() ?? "";
            }
        }
        private void UpdateTotalAmount()
        {
            try
            {
                decimal totalAmount = DAO.SellDetailTransactionDAO.Instance.GetTotalAmount(Sell_ID);
                lbAmout.Text = $"Tổng tiền: {totalAmount:N0} đ"; // format số đẹp có dấu phẩy
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tính tổng tiền: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvSelected_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvSelected.Rows[e.RowIndex];

                // Assuming nmdQuantity is a NumericUpDown control
                nmdQuantity.Value = Convert.ToInt16(row.Cells["Sell_Quantity"].Value);
                pro_id = row.Cells["Pro_ID"].Value?.ToString() ?? "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvSelected.Rows.Count > 0)
                {
                    // Xác nhận trước khi xóa luôn cả giao dịch
                    DialogResult confirm = MessageBox.Show(
                        "Không còn sản phẩm nào trong giao dịch. Bạn có muốn xóa luôn giao dịch nhập này không?",
                        "Xác nhận xóa giao dịch",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        bool isDeleted = DAO.Sell_TransactionDAO.Instance.Delete(Sell_ID);
                        if (isDeleted)
                        {
                            MessageBox.Show("Giao dịch đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            StorekeeperForm.pnSearchInstance.Controls.Clear();
                            StorekeeperForm.pnAddInstance1.Controls.Clear();
                            StorekeeperForm.pnAddInstance2.Controls.Clear();
                            StorekeeperForm.pnAddInstance3.Controls.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa giao dịch. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    StorekeeperForm.pnSearchInstance.Controls.Clear();
                    StorekeeperForm.pnAddInstance1.Controls.Clear();
                    StorekeeperForm.pnAddInstance2.Controls.Clear();
                    StorekeeperForm.pnAddInstance3.Controls.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
