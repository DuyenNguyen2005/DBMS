using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS.Customer
{
    public partial class EditAndRemoveCustomer: UserControl
    {
        public EditAndRemoveCustomer()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tên khách hàng từ TextBox
                string id = txtid.Text;

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Kiểm tra sự tồn tại của khách hàng
                if (DAO.CustomerDAO.Instance.CheckExistencebyID(id))
                {
                    txtName.Clear();
                    txtPhone.Clear();
                    txtAddress.Clear();
                    MessageBox.Show($"Khách hàng với'{id}' tồn tại trong hệ thống!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DTO.Customer customer = DAO.CustomerDAO.Instance.GetCustomerbyID(id);
                    txtName.Text = customer.Cus_Name.ToString();
                    txtPhone.Text = customer.Cus_Phone.ToString();
                    txtAddress.Text = customer.Cus_Address.ToString();

                }
                else
                {
                    MessageBox.Show($"Không tìm thấy khách hàng với '{id}'.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtid.Text;
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;

                if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DTO.Customer cus = new DTO.Customer()
                {
                    Cus_ID = id,
                    Cus_Name = name,
                    Cus_Phone = phone,
                    Cus_Address = address
                };

                bool isUpdated = DAO.CustomerDAO.Instance.Update(cus);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtid.Text;

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng nhập ID khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool isDeleted = DAO.CustomerDAO.Instance.Delete(id);

                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtid.Clear();
                        txtName.Clear();
                        txtPhone.Clear();
                        txtAddress.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
