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

namespace Project_DBMS.Product
{
    public partial class AddProduct : UserControl
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            LoadProductList();
            LoadCombobox();

            btnRandomProduct_Click();
        }

        private void LoadProductList()
        {
            try
            {
                dataGridViewProducts.DataSource = ProductDAO.Instance.GetProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách sản phẩm: {ex.Message}");
            }
        }

        private void LoadCombobox()
        {
            try
            {
                var suppliers = SupplierDAO.Instance.GetSuppliers();

                if (suppliers.Count > 0)
                {
                    comboBoxSupID.DataSource = suppliers;
                    comboBoxSupID.DisplayMember = "Sup_Name";
                    comboBoxSupID.ValueMember = "Sup_ID";
                    comboBoxSupID.SelectedIndex = 0; // Đặt giá trị mặc định
                }
                else
                {
                    MessageBox.Show("Không có nhà cung cấp nào để chọn.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách nhà cung cấp: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu comboBox trước khi lấy giá trị
                if (comboBoxSupID.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp!");
                    return;
                }

                DTO.Product pro = new DTO.Product
                {
                    Pro_ID = ProductDAO.Instance.GenerateProID(),
                    Pro_Name = textBoxProName.Text.Trim(),
                    Pro_Price = numericUpDownPrice.Value, // Sử dụng Value thay vì Text
                    Pro_Quantity = (int)numericUpDownQuantity.Value,
                    Pro_MaxQuantity = (int)numericUpDownMaxQuantity.Value,
                    Pro_Type = textBoxProType.Text.Trim(),
                    Sup_ID = comboBoxSupID.SelectedValue.ToString(), // Kiểm tra nếu null
                    Pro_Description = textBoxDescription.Text.Trim(),
                    Pro_Status = comboBoxStatus.SelectedItem?.ToString() ?? "Chưa xác định" // Tránh lỗi null
                };

                if (ProductDAO.Instance.Insert(pro))
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    LoadProductList();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại!");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi định dạng dữ liệu: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            textBoxProID.Clear();
            textBoxProName.Clear();
            numericUpDownPrice.Value = 0;
            numericUpDownQuantity.Value = 0;
            numericUpDownMaxQuantity.Value = 0;
            textBoxProType.Clear();
            comboBoxSupID.SelectedIndex = 0;
            textBoxDescription.Clear();
            comboBoxStatus.SelectedIndex = 0; // Đặt giá trị mặc định thay vì SelectedValue = false
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Product pro = new DTO.Product
                {
                    Pro_ID = textBoxProID.Text,
                    Pro_Name = textBoxProName.Text,
                    Pro_Price = numericUpDownPrice.Value, // Sử dụng Value thay vì Text
                    Pro_Quantity = (int)numericUpDownQuantity.Value,
                    Pro_MaxQuantity = (int)numericUpDownMaxQuantity.Value,
                    Pro_Type = textBoxProType.Text.Trim(),
                    Sup_ID = comboBoxSupID.SelectedValue.ToString(), // Kiểm tra nếu null
                    Pro_Description = textBoxDescription.Text.Trim(),
                    Pro_Status = comboBoxStatus.SelectedItem?.ToString() ?? "Chưa xác định" // Tránh lỗi null
                };

                // Update the product in the database
                if (ProductDAO.Instance.Update(pro))
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!");
                    LoadProductList();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm thất bại!");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi định dạng dữ liệu: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string proId = textBoxProID.Text;
                if (string.IsNullOrEmpty(proId))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để xóa!");
                    return;
                }

                // Delete the product from the database
                if (ProductDAO.Instance.Delete(proId))
                {
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    LoadProductList();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text;

            // Search for products based on the entered text
            dataGridViewProducts.DataSource = ProductDAO.Instance.Search(searchValue);
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];

                textBoxProID.Text = row.Cells["Pro_ID"].Value?.ToString();
                textBoxProName.Text = row.Cells["Pro_Name"].Value?.ToString();
                numericUpDownPrice.Text = row.Cells["Pro_Price"].Value?.ToString();
                numericUpDownQuantity.Text = row.Cells["Pro_Quantity"].Value?.ToString();
                numericUpDownMaxQuantity.Text = row.Cells["Pro_MaxQuantity"].Value?.ToString();
                textBoxProType.Text = row.Cells["Pro_Type"].Value?.ToString();
                comboBoxSupID.SelectedValue = row.Cells["Sup_ID"].Value?.ToString();
                textBoxDescription.Text = row.Cells["Pro_Description"].Value?.ToString();
                comboBoxStatus.SelectedValue = row.Cells["Pro_Status"].Value?.ToString() == "1";
            }
        }

        private void btnRandomProduct_Click()
        {
            try
            {
                Random rnd = new Random();

                // Random tên sản phẩm
                string[] sampleNames = { "Laptop", "Phone", "Tablet", "Monitor", "Keyboard", "Mouse", "Charger", "Speaker" };
                string randomName = sampleNames[rnd.Next(sampleNames.Length)] + " " + rnd.Next(100, 999).ToString();

                // Random loại
                string[] sampleTypes = { "Electronics", "Accessories", "Office", "Home", "Gaming" };
                string randomType = sampleTypes[rnd.Next(sampleTypes.Length)];

                // Random mô tả
                string[] sampleDescriptions = { "New", "High Quality", "Limited Edition", "Eco-Friendly", "Best Seller" };
                string randomDesc = sampleDescriptions[rnd.Next(sampleDescriptions.Length)] + " product with warranty.";

                // Random giá
                decimal randomPrice = rnd.Next(50, 1000) + rnd.Next(0, 99) / 100m;

                // Random số lượng
                int randomMaxQuantity = rnd.Next(50, 500);
                int randomQuantity = randomMaxQuantity;

                // Random trạng thái
                string randomStatus = "In Stock";

                // Random Supplier
                if (comboBoxSupID.Items.Count == 0)
                {
                    MessageBox.Show("Không có nhà cung cấp nào để chọn.");
                    return;
                }
                comboBoxSupID.SelectedIndex = rnd.Next(comboBoxSupID.Items.Count);

                // Set form fields
                textBoxProName.Text = randomName;
                textBoxProType.Text = randomType;
                numericUpDownPrice.Value = randomPrice;
                numericUpDownQuantity.Value = randomQuantity;
                numericUpDownMaxQuantity.Value = randomMaxQuantity;
                textBoxDescription.Text = randomDesc;
                comboBoxStatus.SelectedItem = randomStatus;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi random: " + ex.Message);
            }
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
