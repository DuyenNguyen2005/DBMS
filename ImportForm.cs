using Project_DBMS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS
{
    public partial class ImportForm: Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            dtpImport.Format = DateTimePickerFormat.Custom;
            dtpImport.CustomFormat = "dd-MM-yyyy";
            LoadImport();
        }

        private void LoadImport()
        {
            // Load import data into the DataGridView
            dataGridViewImport.DataSource = DAO.Import_TransactionDAO.Instance.GetImportTransactionList();
        }

        private void dataGridViewImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int pro_id = DAO.ProductDAO.Instance.GetProductIdByName(txtName.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            int sup_id = DAO.SupplierDAO.Instance.GetSupplierIdByName(TxtSupplier.Text);
            if (DAO.Import_TransactionDAO.Instance.AddImportTransaction(sup_id, pro_id, quantity, price ))
            {
                LoadImport();
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            if (DAO.Import_TransactionDAO.Instance.DeleteImportTransaction(id))
            {
                LoadImport();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            int sup_id = DAO.SupplierDAO.Instance.GetSupplierIdByName(TxtSupplier.Text);
            int pro_id = DAO.ProductDAO.Instance.GetProductIdByName(txtName.Text);
            int quantity = int.Parse(txtQuantity.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            if (DAO.Import_TransactionDAO.Instance.UpdateImportTransaction(id, sup_id, pro_id, quantity, price))
            {
                MessageBox.Show("Sửa thành công");
                LoadImport();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewImport.DataSource = DAO.Import_TransactionDAO.Instance.SearchImportTransaction(txtSearch.Text);
        }

        private void dataGridViewImport_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewImport.Rows[e.RowIndex];
                txtId.Text = row.Cells["Imp_ID"].Value.ToString();
                //TxtSupplier.Text = (DAO.SupplierDAO.Instance.GetSupplierById(int.Parse(row.Cells["Sup_ID"].Value.ToString()))).Sup_Name.ToString();
                int sup_id = int.Parse(row.Cells["Sup_ID"].Value.ToString());
                TxtSupplier.Text = (DAO.SupplierDAO.Instance.GetSupplierById(sup_id)).Sup_Name.ToString();
                //TxtSupplier.Text = row.Cells["Sup_ID"].Value.ToString();
                txtName.Text = (DAO.ProductDAO.Instance.GetProductById(int.Parse(row.Cells["Pro_ID"].Value.ToString()))).Pro_Name.ToString();
                //txtName.Text = row.Cells["Pro_ID"].Value.ToString();
                txtQuantity.Text = row.Cells["Imp_Quantity"].Value.ToString();
                dtpImport.Value = DateTime.Parse(row.Cells["Imp_Date"].Value.ToString());
                txtPrice.Text = row.Cells["Imp_Price"].Value.ToString();
            }
        }
    }
}
