using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS.Product
{
    public partial class AddProductUC: UserControl
    {
        public AddProductUC()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSupID.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng sản phẩm từ dữ liệu nhập vào
                DTO.Product newProduct = new DTO.Product
                {
                    Pro_ID = DAO.ProductDAO.Instance.GenerateProID(),
                    Pro_Name = txtname.Text,
                    Pro_Price = numericUpDownPrice.Value,
                    Pro_Quantity = (int?)numericUpDownQuantity.Value ?? 0,
                    Pro_MaxQuantity = (int)numericUpDownMaxQuantity.Value,
                    Pro_Type = txttpe.Text,
                    Pro_Description = txtDesciption.Text,
                    Sup_ID = comboBoxSupID.SelectedValue.ToString(),
                };

                // Gọi phương thức Insert để thêm sản phẩm mới vào cơ sở dữ liệu
                bool isInserted = DAO.ProductDAO.Instance.Insert(newProduct);

                // Kiểm tra kết quả và thông báo
                MessageBox.Show(isInserted ? "Thêm sản phẩm thành công!" : "Thêm sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, isInserted ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProductUC_Load(object sender, EventArgs e)
        {
            comboBoxSupID.DataSource = DAO.SupplierDAO.Instance.GetSuppliers();
            comboBoxSupID.DisplayMember = "Sup_Name";
            comboBoxSupID.ValueMember = "Sup_ID";
        }
    }
}
