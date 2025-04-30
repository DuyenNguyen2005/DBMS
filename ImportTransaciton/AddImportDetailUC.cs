using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms.DataVisualization.Charting;
using Project_DBMS.Supplier;
using Project_DBMS.Product;

namespace Project_DBMS.ImportTransaciton
{
    public partial class AddImportDetailUC: UserControl
    {
        string Imp_ID;
        string Pro_ID;
        string Sup_ID;
        public AddImportDetailUC()
        {
            InitializeComponent();
        }

        public AddImportDetailUC(string Imp_ID, string Sup_ID)
        {
            InitializeComponent();
            this.Imp_ID = Imp_ID;
            this.Sup_ID = Sup_ID;
        }
        private void AddImportDetailUC_Load(object sender, EventArgs e)
        {
            dtgvValuable.DataSource = DAO.ProductDAO.Instance.GetProducts_Imp(Sup_ID);
            dtgvValuable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvValuable.MultiSelect = true; // Cho phép chọn nhiều dòng

            dtgvSelected.DataSource = DAO.ImportDetailTransactionDAO.Instance.GetList(Imp_ID);
            dtgvSelected.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvSelected.MultiSelect = true;
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
                            bool isDeleted = DAO.ImportDetailTransactionDAO.Instance.Delete(Imp_ID, selectedProID);

                            if (isDeleted)
                                deleteCount++;
                        }
                    }

                    // Cập nhật lại danh sách
                    dtgvSelected.DataSource = DAO.ImportDetailTransactionDAO.Instance.GetList(Imp_ID);
                    dtgvValuable.DataSource = DAO.ProductDAO.Instance.GetProducts_Imp(Sup_ID);


                    MessageBox.Show($"Đã xóa {deleteCount} sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateTotalAmount();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int Imp_Quantity = (int)nmdQuantity.Value;
                decimal Imp_Price = (decimal)nmImp_Price.Value;

                if (Imp_Quantity <= 0 || Imp_Price <= 0)
                {
                    MessageBox.Show("Số lượng và đơn giá phải lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int insertCount = 0;

                List<string> productIDs = new List<string>();

                // Nếu có chọn nhiều dòng
                if (dtgvValuable.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dtgvValuable.SelectedRows)
                    {
                        string selectedProID = row.Cells["Pro_ID"].Value?.ToString();
                        if (!string.IsNullOrEmpty(selectedProID))
                        {
                            productIDs.Add(selectedProID);
                        }
                    }
                }
                // Nếu không chọn dòng nào nhưng có Pro_ID đã được gán trước
                else if (!string.IsNullOrEmpty(Pro_ID))
                {
                    productIDs.Add(Pro_ID);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (DAO.ImportDetailTransactionDAO.Instance.Insert(Imp_ID, new DTO.Product(Pro_ID, Imp_Price, Imp_Quantity)))
                    insertCount++;

                dtgvValuable.DataSource = DAO.ProductDAO.Instance.GetProducts_Imp(Sup_ID);
                dtgvSelected.DataSource = DAO.ImportDetailTransactionDAO.Instance.GetList(Imp_ID);
                UpdateTotalAmount();

                MessageBox.Show($"Đã thêm mới {insertCount} sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int imp_quantity = (int)nmdQuantity.Value;
                decimal imp_price = (decimal)nmImp_Price.Value;

                if (imp_quantity <= 0)
                {
                    MessageBox.Show("Số lượng nhập phải lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (imp_price <= 0)
                {
                    MessageBox.Show("Đơn giá phải lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Pro_ID))
                {
                    MessageBox.Show("Chưa chọn sản phẩm để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isUpdated = DAO.ImportDetailTransactionDAO.Instance.Update(Imp_ID, new DTO.Product(Pro_ID, imp_price, imp_quantity));

                if (isUpdated)
                {
                    dtgvValuable.DataSource = DAO.ProductDAO.Instance.GetProducts_Imp(Sup_ID);
                    dtgvSelected.DataSource = DAO.ImportDetailTransactionDAO.Instance.GetList(Imp_ID);
                    UpdateTotalAmount();
                    MessageBox.Show("Cập nhật giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật. Kiểm tra lại thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi từ CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtgvValuable.DataSource = DAO.ProductDAO.Instance.GetProducts_Imp(Sup_ID, Imp_ID);
        }

        private void UpdateTotalAmount()
        {
            try
            {
                decimal totalAmount = DAO.ImportDetailTransactionDAO.Instance.GetTotalAmount(Imp_ID);
                lbAmout.Text = $"Tổng tiền: {totalAmount:N0} đ"; // format số đẹp có dấu phẩy
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tính tổng tiền: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            dtgvValuable.DataSource = DAO.ProductDAO.Instance.GetProducts_Imp(Sup_ID);
            dtgvValuable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvValuable.MultiSelect = true; // 
        }

        private void dtgvValuable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvValuable.Rows[e.RowIndex];

                // Extract values from the selected row
                Pro_ID = row.Cells["Pro_ID"].Value?.ToString() ?? "";
                //txtSearch.Text = row.Cells["Pro_ID"].Value?.ToString() ?? "";
            }
        }

        private void dtgvSelected_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvSelected.Rows[e.RowIndex];

                // Assuming nmdQuantity is a NumericUpDown control
                nmdQuantity.Value = Convert.ToInt16(row.Cells["Imp_Quantity"].Value);
                Pro_ID = row.Cells["Pro_ID"].Value?.ToString() ?? "";
                nmImp_Price.Value = Convert.ToDecimal(row.Cells["Imp_Price"].Value);
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
                        bool isDeleted = DAO.ImportTransactionDAO.Instance.Delete(Imp_ID);
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
