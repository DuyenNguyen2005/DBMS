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

namespace Project_DBMS.Product
{
    public partial class EditAndRemoveProductUC1: UserControl
    {
        public EditAndRemoveProductUC1()
        {
            InitializeComponent();
            comboBoxSupID.DataSource = DAO.SupplierDAO.Instance.GetSuppliers();
            comboBoxSupID.DisplayMember = "Sup_Name";
            comboBoxSupID.ValueMember = "Sup_ID";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string proID = txtProid.Text.Trim();

                if (string.IsNullOrEmpty(proID))
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DTO.Product product = DAO.ProductDAO.Instance.GetProduct(proID);

                if (product == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hiển thị thông tin sản phẩm lên các control
                txtname.Text = product.Pro_Name;
                numericUpDownPrice.Value = product.Pro_Price;
                numericUpDownQuantity.Value = product.Pro_Quantity;
                numericUpDownMaxQuantity.Value = product.Pro_MaxQuantity;
                txttpe.Text = product.Pro_Type;
                txtDesciption.Text = product.Pro_Description;
                comboBoxSupID.SelectedValue = product.Sup_ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Product updatedProduct = new DTO.Product
                {
                    Pro_ID = txtProid.Text.Trim(),
                    Pro_Name = txtname.Text.Trim(),
                    Pro_Price = numericUpDownPrice.Value,
                    Pro_Quantity = (int)numericUpDownQuantity.Value,
                    Pro_MaxQuantity = (int)numericUpDownMaxQuantity.Value,
                    Pro_Type = txttpe.Text.Trim(),
                    Pro_Description = txtDesciption.Text.Trim(),
                    Sup_ID = comboBoxSupID.SelectedValue.ToString()
                };

                bool result = DAO.ProductDAO.Instance.Update(updatedProduct);

                if (result)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string proId = txtProid.Text.Trim();

                if (string.IsNullOrEmpty(proId))
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    bool result = DAO.ProductDAO.Instance.Delete(proId);

                    if (result)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Xóa form sau khi xóa thành công
                        ClearProductForm();
                    }
                    else if(DAO.ProductDAO.Instance.GetTotalSoldQuantity(proId) > 0)
                    {
                        MessageBox.Show("Không thể xóa sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearProductForm()
        {
            txtProid.Clear();
            txtname.Clear();
            numericUpDownPrice.Value = 0;
            numericUpDownQuantity.Value = 0;
            numericUpDownMaxQuantity.Value = 0;
            txttpe.Clear();
            txtDesciption.Clear();
            comboBoxSupID.SelectedIndex = -1;
        }

    }
}
