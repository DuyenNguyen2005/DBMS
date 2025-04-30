using Project_DBMS.Customer;
using Project_DBMS.Product;
using Project_DBMS.Statictics;
using Project_DBMS.Supplier;
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
    public partial class ManagerForm: Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void cHỈNHSỬATHÔNGTINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Xóa control cũ (nếu có)
            EditAndRemoveCustomer control = new EditAndRemoveCustomer();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void tHêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Xóa control cũ (nếu có)
            AddCustomerUC control = new AddCustomerUC();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void dANHSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Xóa control cũ (nếu có)
            ProductUC control = new ProductUC();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void tHÊMMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Xóa control cũ (nếu có)
            AddProductUC control = new AddProductUC();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void cHỈNHSỬATHÔNGTINToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Xóa control cũ (nếu có)
            ProductUC control = new ProductUC();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void dANHSÁCHToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Xóa control cũ (nếu có)
            SupplierUC control = new SupplierUC();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void tHÊMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Xóa control cũ (nếu có)
            AddSupplierUC control = new AddSupplierUC();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void cHỈNHSỬATHÔNGTINToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Xóa control cũ (nếu có)
            EditAndRemoveSupplierUC control = new EditAndRemoveSupplierUC();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void dANHSÁCHToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Xóa control cũ (nếu có)
            SupplierUC control = new SupplierUC();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void lỊCHSỬGIAODỊCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Xóa control cũ (nếu có)
            Transaction control = new Transaction();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void tHỐNGKÊToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Xóa control cũ (nếu có)
            OtherStatictics control = new OtherStatictics();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }
    }
}
