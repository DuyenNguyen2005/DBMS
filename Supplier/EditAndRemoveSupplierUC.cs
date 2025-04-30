using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS.Supplier
{
    public partial class EditAndRemoveSupplierUC: UserControl
    {
        public EditAndRemoveSupplierUC()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Supplier supplier = DAO.SupplierDAO.Instance.GetSupplierbyID(textBoxSupID.Text);

                if (supplier == null)
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                textBoxSupName.Text = supplier.Sup_Name ?? string.Empty;
                textBoxSupAddress.Text = supplier.Sup_Address ?? string.Empty;
                textBoxSupPhone.Text = supplier.Sup_Phone ?? string.Empty;
                textBoxSupEmail.Text = supplier.Sup_Email ?? string.Empty;
                textBoxSupWebsite.Text = supplier.Sup_Website ?? string.Empty;
                dateTimePickerJoinDate.Value = supplier.Sup_JoinDate;
                checkBoxStatus.Checked = supplier.Sup_Status; // Nếu Sup_Status là kiểu bool
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditAndRemoveSupplierUC_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Supplier supplier = new DTO.Supplier
                {
                    Sup_ID = textBoxSupID.Text.Trim(),
                    Sup_Name = textBoxSupName.Text.Trim(),
                    Sup_Address = textBoxSupAddress.Text.Trim(),
                    Sup_Phone = textBoxSupPhone.Text.Trim(),
                    Sup_Email = textBoxSupEmail.Text.Trim(),
                    Sup_Website = textBoxSupWebsite.Text.Trim(),
                    Sup_JoinDate = dateTimePickerJoinDate.Value,
                    Sup_Status = checkBoxStatus.Checked
                };

                bool success = DAO.SupplierDAO.Instance.Update(supplier);
                if (success)
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại. Vui lòng kiểm tra lại thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string supId = textBoxSupID.Text.Trim();

                if (string.IsNullOrEmpty(supId))
                {
                    MessageBox.Show("Vui lòng nhập mã nhà cung cấp cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool success = DAO.SupplierDAO.Instance.Delete(supId);
                    if (success)
                    {
                        MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Xóa trắng giao diện sau khi xóa
                        textBoxSupID.Clear();
                        textBoxSupName.Clear();
                        textBoxSupAddress.Clear();
                        textBoxSupPhone.Clear();
                        textBoxSupEmail.Clear();
                        textBoxSupWebsite.Clear();
                        checkBoxStatus.Checked = false;
                        dateTimePickerJoinDate.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa. Nhà cung cấp có thể đang được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
