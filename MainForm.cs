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
            productForm.ShowDialog();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm();
            importForm.ShowDialog();
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellForm sellForm = new SellForm();
            sellForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void inventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvenReportForm inventoryReportForm = new InvenReportForm();
            inventoryReportForm.ShowDialog();
        }

        private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleReportForm saleReportForm = new SaleReportForm();
            saleReportForm.ShowDialog();
        }

        private void productStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm productStatisticsForm = new StaticsForm();
            productStatisticsForm.ShowDialog();
        }
    }
}
