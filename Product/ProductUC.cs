using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Project_DBMS.Supplier;

namespace Project_DBMS.Product
{
    public partial class ProductUC: UserControl
    {
        public ProductUC()
        {
            InitializeComponent();
        }

        private void ProductUC_Load(object sender, EventArgs e)
        {
            dataGridViewProducts.DataSource = DAO.ProductDAO.Instance.GetProducts();
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];

                textBoxProID.Text = row.Cells["Pro_ID"].Value?.ToString();
                textBoxProName.Text = row.Cells["Pro_Name"].Value?.ToString();
                txtPricce.Text = row.Cells["Pro_Price"].Value?.ToString();
                txtQuantity.Text = row.Cells["Pro_Quantity"].Value?.ToString();
                txtMaxquantity.Text = row.Cells["Pro_MaxQuantity"].Value?.ToString();
                textBoxProType.Text = row.Cells["Pro_Type"].Value?.ToString();
                txtxSupID.Text = row.Cells["Sup_ID"].Value?.ToString();
                textBoxDescription.Text = row.Cells["Pro_Description"].Value?.ToString();
                txtStatus.Text = row.Cells["Pro_Status"].Value?.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewProducts.DataSource = DAO.ProductDAO.Instance.Search(txtSearch.Text.Trim());
        }

        private void dataGridViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];

                // Kiểm tra nếu cột "Sup_ID" tồn tại và không bị null
                string supId = row.Cells["Sup_ID"].Value?.ToString() ?? "";
                if (string.IsNullOrEmpty(supId))
                {
                    MessageBox.Show("Không tìm thấy Mã Nhà Cung Cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Khởi tạo UserControl và thêm vào Panel
                AddSupplierUC addSupplierUC = new AddSupplierUC(supId);
                addSupplierUC.Dock = DockStyle.Fill;

                if (StaffForm.pnAddInstance2 == null)
                {
                    MessageBox.Show("Không tìm thấy panel để hiển thị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                StaffForm.pnAddInstance2.Controls.Clear();
                StaffForm.pnAddInstance2.Controls.Add(addSupplierUC);
            }
        }

    }
}
