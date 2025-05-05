using Project_DBMS.Customer;
using Project_DBMS.DTO;
using Project_DBMS.Employee;
using Project_DBMS.Product;
using Project_DBMS.SellTransaction;
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
    public partial class StaffForm: Form
    {
        public static Panel pnSearchInstance;
        public static Panel pnAddInstance1;
        public static Panel pnAddInstance2;
        public static Panel pnAddInstance3;
        public StaffForm()
        {
            InitializeComponent();
            pnSearchInstance = pnSearch;
            pnAddInstance1 = pnAdd1;
            pnAddInstance2 = pnAdd2;
            pnAddInstance3 = pnAdd3;
        }

        private void createSoldTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnSearch.Controls.Clear();
            pnAdd1.Controls.Clear();
            pnAdd2.Controls.Clear();
            pnAdd3.Controls.Clear();

            FindCustomerUC findCustomerUC = new FindCustomerUC();
            findCustomerUC.Dock = DockStyle.Fill;
            pnSearch.Controls.Clear();
            pnSearch.Controls.Add(findCustomerUC);
            
        }

        private void dANHSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnSearch.Controls.Clear();
            pnAdd1.Controls.Clear();
            pnAdd2.Controls.Clear();
            pnAdd3.Controls.Clear();
            CustomerUC customerUC = new CustomerUC();
            customerUC.Dock = DockStyle.Fill;
            pnAdd3.Controls.Clear();
            pnAdd3.Controls.Add(customerUC);
        }

        private void cHỈNHSỬATHÔNGTINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnSearch.Controls.Clear();
            pnAdd1.Controls.Clear();
            pnAdd2.Controls.Clear();
            pnAdd3.Controls.Clear();

            EditAndRemoveCustomer EditAndRemoveCustomer = new EditAndRemoveCustomer();
            EditAndRemoveCustomer.Dock = DockStyle.Fill;
            pnAdd1.Controls.Clear();
            pnAdd1.Controls.Add(EditAndRemoveCustomer);
        }

        private void tHỐNGKÊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnSearch.Controls.Clear();
            pnAdd1.Controls.Clear();
            pnAdd2.Controls.Clear();
            pnAdd3.Controls.Clear();
            StaticticsCustomerUC StaticticsCustomerUC = new StaticticsCustomerUC();
            StaticticsCustomerUC.Dock = DockStyle.Fill;
            pnAdd3.Controls.Clear();
            pnAdd3.Controls.Add(StaticticsCustomerUC);
        }

        private void dANHSÁCHToolStripMenuItem1_Click(object sender, EventArgs e)
        {pnSearch.Controls.Clear();
            pnAdd1.Controls.Clear();
            pnAdd2.Controls.Clear();
            pnAdd3.Controls.Clear();
            ProductUC ProductUC = new ProductUC();
            ProductUC.Dock = DockStyle.Fill;
            pnAdd3.Controls.Clear();
            pnAdd3.Controls.Add(ProductUC);
        }

        private void tHỐNGKÊToolStripMenuItem1_Click(object sender, EventArgs e)
        {pnSearch.Controls.Clear();
            pnAdd1.Controls.Clear();
            pnAdd2.Controls.Clear();
            pnAdd3.Controls.Clear();
            StaticticsProductUC StaticticsProductUC = new StaticticsProductUC();
            StaticticsProductUC.Dock = DockStyle.Fill;
            pnAdd3.Controls.Clear();
            pnAdd3.Controls.Add(StaticticsProductUC);
        }

        private void nHÀCUNGCẤPToolStripMenuItem_Click(object sender, EventArgs e)
        {pnSearch.Controls.Clear();
            pnAdd1.Controls.Clear();
            pnAdd2.Controls.Clear();
            pnAdd3.Controls.Clear();
            SupplierUC SupplierUC = new SupplierUC();
            SupplierUC.Dock = DockStyle.Fill;
            pnAdd3.Controls.Clear();
            pnAdd3.Controls.Add(SupplierUC);
        }

        private void lỊCHSỬGIAODỊCHToolStripMenuItem_Click(object sender, EventArgs e)
        {pnSearch.Controls.Clear();
            pnAdd1.Controls.Clear();
            pnAdd2.Controls.Clear();
            pnAdd3.Controls.Clear();
            SellDetailUC SellDetailUC = new SellDetailUC();
            SellDetailUC.Dock = DockStyle.Fill;
            pnAdd3.Controls.Clear();
            pnAdd3.Controls.Add(SellDetailUC);
        }
    }
}
