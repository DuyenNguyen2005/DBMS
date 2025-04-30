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
using Project_DBMS.DTO;
using Project_DBMS.SellTransaction;

namespace Project_DBMS.Customer
{
    public partial class AddCustomerUC: UserControl
    {
        public AddCustomerUC()
        {
            InitializeComponent();
        }
        public AddCustomerUC(string Cus_Name)
        {
            InitializeComponent();
            txtName.Text = Cus_Name;
        }
        public AddCustomerUC(DTO.Customer customer)
        {
            InitializeComponent();
            txtName.Text = customer.Cus_Name;
            txtPhone.Text = customer.Cus_Phone;
            txtAddress.Text = customer.Cus_Address;

            btnAdd.Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Loại bỏ khoảng trắng và kiểm tra dữ liệu đầu vào
                string name = txtName.Text.Trim();
                string address = txtAddress.Text.Trim();
                string phone = txtPhone.Text.Trim();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra số điện thoại có hợp lệ không
                if (!phone.All(char.IsDigit) || phone.Length < 9 || phone.Length > 15)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Clear();
                    return;
                }else if (DAO.CustomerDAO.Instance.CheckPhoneExistence(phone))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Clear();
                    return;
                }

                // Tạo khách hàng mới
                DTO.Customer customer = new DTO.Customer()
                {
                    Cus_ID = DAO.CustomerDAO.Instance.GenerateCusID(),
                    Cus_Name = name,
                    Cus_Address = address,
                    Cus_Phone = phone,
                };

                // Thêm khách hàng vào cơ sở dữ liệu
                bool isInserted = CustomerDAO.Instance.Insert(customer);
                if (isInserted)
                {
                    MessageBox.Show($"Thêm khách hàng '{name}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddSellUC AddSellUC = new AddSellUC(Global.GlobalEmpId, customer.Cus_ID);
                    AddSellUC.Dock = DockStyle.Fill;
                    StaffForm.pnAddInstance2.Controls.Clear();
                    StaffForm.pnAddInstance2.Controls.Add(AddSellUC);
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
