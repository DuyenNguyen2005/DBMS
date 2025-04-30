using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_DBMS.DTO;
using Project_DBMS.DAO;
using System.Xml.Linq;
using Project_DBMS.SellTransaction;
using Project_DBMS.ImportTransaciton;

namespace Project_DBMS.Supplier
{
    public partial class AddSupplierUC: UserControl
    {
        public AddSupplierUC()
        {
            InitializeComponent();
        }
        public AddSupplierUC(string Sup_ID)
        {
            InitializeComponent();
            buttonSave.Visible = false;
            LoadSupplier(Sup_ID);
        }

        public AddSupplierUC(string Sup_Name, bool isName)
        {
            InitializeComponent();
            labelSupID.Visible = false;
            textBoxSupID.Visible = false;
            dateTimePickerJoinDate.Enabled = false;
            checkBoxStatus.Enabled = false;
            textBoxSupName.Text = Sup_Name;

            AutoFillSupplierForm();
        }
        public AddSupplierUC(DTO.Supplier supplier)
        {
            InitializeComponent();
            labelSupID.Visible = false;
            textBoxSupID.Visible = false;
            dateTimePickerJoinDate.Enabled = false;
            checkBoxStatus.Enabled = false;
            LoadSupplier(supplier.Sup_ID);
            buttonSave.Visible = false;
        }

        void LoadSupplier(string Sup_ID)
        {
            try
            {
                List<DTO.Supplier> supplierList = DAO.SupplierDAO.Instance.Search(Sup_ID);

                //if (supplierList == null || supplierList.Count == 0) // Kiểm tra danh sách rỗng
                //{
                //    MessageBox.Show("Không tìm thấy nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                DTO.Supplier supplier = supplierList[0]; // Lấy nhà cung cấp đầu tiên

                // Gán giá trị vào UI, kiểm tra null trước khi gán
                textBoxSupID.Text = supplier.Sup_ID ?? "";
                textBoxSupName.Text = supplier.Sup_Name ?? "";
                textBoxSupAddress.Text = supplier.Sup_Address ?? "";
                textBoxSupEmail.Text = supplier.Sup_Email ?? "";
                textBoxSupPhone.Text = supplier.Sup_Phone ?? "";
                textBoxSupWebsite.Text = supplier.Sup_Website ?? "";

                dateTimePickerJoinDate.Value = supplier.Sup_JoinDate != null ? supplier.Sup_JoinDate : DateTime.Today;

                checkBoxStatus.Checked = Convert.ToBoolean(supplier.Sup_Status);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Loại bỏ khoảng trắng và kiểm tra dữ liệu đầu vào
                string id = DAO.SupplierDAO.Instance.GenerateSupID();
                string name = textBoxSupName.Text.Trim();
                string address = textBoxSupAddress.Text.Trim();
                string phone = textBoxSupPhone.Text.Trim();
                string email = textBoxSupEmail.Text.Trim();
                string website = string.IsNullOrEmpty(textBoxSupWebsite.Text) ? null : textBoxSupWebsite.Text.Trim();

                // Tạo nhà cung cấp mới
                DTO.Supplier supplier = new DTO.Supplier()
                {
                    Sup_ID = id,
                    Sup_Address = address,
                    Sup_Name = name,
                    Sup_Email = email,
                    Sup_Phone = phone,
                    Sup_Website = website, // Website có thể null
                    Sup_JoinDate = dateTimePickerJoinDate.Value,
                    Sup_Status = checkBoxStatus.Checked
                };


                // Thêm khách hàng vào cơ sở dữ liệu
                bool isInserted = SupplierDAO.Instance.Insert(supplier);
                if (isInserted)
                {
                    MessageBox.Show($"Thêm nhà cung cấp '{name}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddImportUC AddImportUC = new AddImportUC(Emp_ID: Global.GlobalEmpId, Sup_ID: id);
                    AddImportUC.Dock = DockStyle.Fill;
                    StorekeeperForm.pnAddInstance2.Controls.Clear();
                    StorekeeperForm.pnAddInstance2.Controls.Add(AddImportUC);

                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp thất bại! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AutoFillSupplierForm()
        {
            var randomSupplier = GenerateRandomSupplier();

            //txtSupID.Text = randomSupplier.Sup_ID;
            //txtSupName.Text = randomSupplier.Sup_Name;
            textBoxSupAddress.Text = randomSupplier.Sup_Address;
            textBoxSupPhone.Text = randomSupplier.Sup_Phone;
            textBoxSupEmail.Text = randomSupplier.Sup_Email;
            textBoxSupWebsite.Text = randomSupplier.Sup_Website;
            dateTimePickerJoinDate.Value = randomSupplier.Sup_JoinDate;
            checkBoxStatus.Checked = randomSupplier.Sup_Status;
        }
        public DTO.Supplier GenerateRandomSupplier()
        {
            Random random = new Random();
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Sup_ID: "SUP" + random 6 số
            // supId = "SUP" + random.Next(100000, 999999).ToString();

            // Sup_Name: Tên random từ 5-10 chữ cái
            string supName = "Supplier " + new string(Enumerable.Range(0, random.Next(5, 10))
                .Select(_ => letters[random.Next(letters.Length)]).ToArray());

            // Sup_Address: "Đường " + random chữ
            string supAddress = "Đường " + new string(Enumerable.Range(0, random.Next(10, 20))
                .Select(_ => (char)('A' + random.Next(0, 26))).ToArray());

            // Sup_Phone: "0" + [1-9] + 8 số
            string supPhone = "0" + random.Next(1, 10).ToString() + random.Next(10000000, 99999999).ToString();

            // Sup_Email: random + @gmail.com
            string emailName = new string(Enumerable.Range(0, random.Next(5, 10))
                .Select(_ => letters.ToLower()[random.Next(letters.Length)]).ToArray());
            string supEmail = emailName + "@gmail.com";

            // Sup_Website
            string[] domains = { "com", "net", "org" };
            string websiteName = new string(Enumerable.Range(0, random.Next(5, 10))
                .Select(_ => letters.ToLower()[random.Next(letters.Length)]).ToArray());
            string supWebsite = "https://" + websiteName + "." + domains[random.Next(domains.Length)];

            // Sup_JoinDate: random từ 2000 đến nay
            DateTime startDate = new DateTime(2000, 1, 1);
            int range = (DateTime.Today - startDate).Days;
            DateTime supJoinDate = startDate.AddDays(random.Next(range));

            // Sup_Status
            //bool supStatus = random.Next(0, 2) == 1;
            bool supStatus = true;
            return new DTO.Supplier
            {
                //Sup_ID = supId,
                Sup_Name = supName,
                Sup_Address = supAddress,
                Sup_Phone = supPhone,
                Sup_Email = supEmail,
                Sup_Website = supWebsite,
                Sup_JoinDate = supJoinDate,
                Sup_Status = supStatus
            };
        }
    }
}
