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
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm();
            importForm.Show();
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellForm sellForm = new SellForm();
            sellForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void inventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvenReportForm inventoryReportForm = new InvenReportForm();
            inventoryReportForm.Show();
        }

        private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleReportForm saleReportForm = new SaleReportForm();
            saleReportForm.Show();
        }

        private void productStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm productStatisticsForm = new StaticsForm();
            productStatisticsForm.Show();
        }
    }
}
