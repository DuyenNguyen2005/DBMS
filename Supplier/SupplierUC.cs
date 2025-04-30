using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_DBMS.DAO;

namespace Project_DBMS.Supplier
{
    public partial class SupplierUC: UserControl
    {
        public SupplierUC()
        {
            InitializeComponent();
            dataGridView1.DataSource = DAO.SupplierDAO.Instance.GetSuppliers();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nếu không phải click vào row header hoặc ngoài vùng dữ liệu thì mới xử lý
                if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBoxSupID.Text = row.Cells["Sup_ID"].Value?.ToString();
                textBoxSupName.Text = row.Cells["Sup_Name"].Value?.ToString();
                textBoxSupAddress.Text = row.Cells["Sup_Address"].Value?.ToString();
                textBoxSupPhone.Text = row.Cells["Sup_Phone"].Value?.ToString();
                textBoxSupEmail.Text = row.Cells["Sup_Email"].Value?.ToString();
                textBoxSupWebsite.Text = row.Cells["Sup_Website"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["Sup_JoinDate"].Value?.ToString(), out DateTime joinDate))
                {
                    dateTimePickerJoinDate.Value = joinDate;
                }

                if (bool.TryParse(row.Cells["Sup_Status"].Value?.ToString(), out bool status))
                {
                    checkBoxStatus.Checked = status;
                }
                else
                {
                    // Trường hợp nếu Sup_Status kiểu int 0/1
                    checkBoxStatus.Checked = row.Cells["Sup_Status"].Value?.ToString() == "1";
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchKeyword = txtSearch.Text.Trim();
                List<DTO.Supplier> suppliers = SupplierDAO.Instance.Search(searchKeyword);

                dataGridView1.DataSource = suppliers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm nhà cung cấp: {ex.Message}");
            }
        }
        //public SupplierUC()
        //{
        //    InitializeComponent();
        //    AutoFillSupplierForm();
        //    LoadSuppliers();
        //}

            //// Nạp danh sách nhà cung cấp
            //private void LoadSuppliers()
            //{
            //    try
            //    {
            //        dataGridViewSuppliers.DataSource = SupplierDAO.Instance.GetSuppliers();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Lỗi khi tải danh sách nhà cung cấp: {ex.Message}");
            //    }
            //}

            //// Xử lý thêm nhà cung cấp
            //private void btnAdd_Click(object sender, EventArgs e)
            //{
            //    try
            //    {
            //        DTO.Supplier newSup = new DTO.Supplier
            //        {
            //            Sup_ID = SupplierDAO.Instance.GenerateSupID(),
            //            Sup_Name = txtSupName.Text.Trim(),
            //            Sup_Email = txtSupEmail.Text.Trim(),
            //            Sup_Address = txtSupAddress.Text.Trim(),
            //            Sup_Phone = txtSupPhone.Text.Trim(),
            //            Sup_Website = txtSupWebsite.Text.Trim(),
            //            Sup_JoinDate = dateTimePickerSupJoinDate.Value,
            //            Sup_Status = true
            //        };

            //        string message = $"Xác nhận thêm nhà cung cấp:\n\n" +
            //                         $"ID: {newSup.Sup_ID}\n" +
            //                         $"Tên: {newSup.Sup_Name}\n" +
            //                         $"Email: {newSup.Sup_Email}\n" +
            //                         $"Địa chỉ: {newSup.Sup_Address}\n" +
            //                         $"Điện thoại: {newSup.Sup_Phone}\n" +
            //                         $"Website: {newSup.Sup_Website}\n" +
            //                         $"Ngày tham gia: {newSup.Sup_JoinDate.ToShortDateString()}\n" +
            //                         $"Trạng thái: {newSup.Sup_Status}";

            //        DialogResult result = MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //        if (result == DialogResult.Yes)
            //        {
            //            if (SupplierDAO.Instance.Insert(newSup))
            //            {
            //                MessageBox.Show("Thêm nhà cung cấp thành công!");
            //                LoadSuppliers();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Thêm nhà cung cấp thất bại!");
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Lỗi khi thêm nhà cung cấp: {ex.Message}");
            //    }
            //}

            //// Sửa thông tin nhà cung cấp
            //private void btnEdit_Click(object sender, EventArgs e)
            //{
            //    if (string.IsNullOrEmpty(txtSupID.Text))
            //    {
            //        MessageBox.Show("Vui lòng chọn nhà cung cấp để sửa!");
            //        return;
            //    }

            //    try
            //    {
            //        DTO.Supplier editSup = new DTO.Supplier
            //        {
            //            Sup_ID = txtSupID.Text.Trim(),
            //            Sup_Name = txtSupName.Text.Trim(),
            //            Sup_Email = txtSupEmail.Text.Trim(),
            //            Sup_Address = txtSupAddress.Text.Trim(),
            //            Sup_Phone = txtSupPhone.Text.Trim(),
            //            Sup_Website = txtSupWebsite.Text.Trim(),
            //            Sup_JoinDate = dateTimePickerSupJoinDate.Value,
            //            Sup_Status = chkSupStatus.Checked
            //        };

            //        if (SupplierDAO.Instance.Update(editSup))
            //        {
            //            MessageBox.Show("Cập nhật nhà cung cấp thành công!");
            //            LoadSuppliers();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Cập nhật nhà cung cấp thất bại!");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Lỗi khi cập nhật nhà cung cấp: {ex.Message}");
            //    }
            //}

            //// Xóa nhà cung cấp
            //private void btnDelete_Click(object sender, EventArgs e)
            //{
            //    if (string.IsNullOrEmpty(txtSupID.Text))
            //    {
            //        MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa!");
            //        return;
            //    }

            //    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo);

            //    if (result == DialogResult.Yes)
            //    {
            //        try
            //        {
            //            string supId = txtSupID.Text.Trim();
            //            if (SupplierDAO.Instance.Delete(supId))
            //            {
            //                MessageBox.Show("Xóa nhà cung cấp thành công!");
            //                LoadSuppliers();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Xóa nhà cung cấp thất bại!");
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show($"Lỗi khi xóa nhà cung cấp: {ex.Message}");
            //        }
            //    }
            //}
            

            


    }
}
