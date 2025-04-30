using Project_DBMS.ImportTransaciton;
using Project_DBMS.Product;
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
    public partial class StorekeeperForm: Form
    {
        public static Panel pnSearchInstance;
        public static Panel pnAddInstance1;
        public static Panel pnAddInstance2;
        public static Panel pnAddInstance3;
        public static Panel pnAddInstance4;
        public StorekeeperForm()
        {
            InitializeComponent();
            pnSearchInstance = pnSearch;
            pnAddInstance1 = pnAdd1;
            pnAddInstance2 = pnAdd2;
            pnAddInstance3 = pnAdd3;
            pnAddInstance4 = pnAdd4;
        }

        public StorekeeperForm(string Emp_ID)
        {
            InitializeComponent();
            pnSearchInstance = pnSearch;
            pnAddInstance1 = pnAdd1;
            pnAddInstance2 = pnAdd2;
            pnAddInstance3 = pnAdd3;
            pnAddInstance4 = pnAdd4;
        }

        private void createSoldTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindSuppllierUC findSuppllierUC = new FindSuppllierUC();    
            findSuppllierUC.Dock = DockStyle.Fill;
            pnSearch.Controls.Clear();
            pnSearch.Controls.Add(findSuppllierUC);
        }

        private void cHỈNHSỬATHÔNGTINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAndRemoveSupplierUC EditAndRemoveSupplierUC = new EditAndRemoveSupplierUC();
            EditAndRemoveSupplierUC.Dock = DockStyle.Fill;
            pnAdd1.Controls.Clear();
            pnAdd1.Controls.Add(EditAndRemoveSupplierUC);
        }

        private void dANHSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierUC SupplierUC = new SupplierUC();
            SupplierUC.Dock = DockStyle.Fill;
            pnAdd3.Controls.Clear();
            pnAdd3.Controls.Add(SupplierUC);
        }

        private void tHỐNGKÊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportStatictis ImportStatictis = new ImportStatictis();
            ImportStatictis.Dock = DockStyle.Fill;
            pnAdd3.Controls.Clear();
            pnAdd3.Controls.Add(ImportStatictis);
        }

        private void tHÊMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductUC AddProductUC = new AddProductUC();
            AddProductUC.Dock = DockStyle.Fill;
            pnAdd1.Controls.Clear();
            pnAdd1.Controls.Add(AddProductUC);
        }

        private void cHỈNHSỬATHÔNGTINToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditAndRemoveProductUC1 EditAndRemoveProductUC1 = new EditAndRemoveProductUC1();
            EditAndRemoveProductUC1.Dock = DockStyle.Fill;
            pnAdd1.Controls.Clear();
            pnAdd1.Controls.Add(EditAndRemoveProductUC1);
        }

        private void dANHSÁCHToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductUC ProductUC = new ProductUC();
            ProductUC.Dock = DockStyle.Fill;
            pnAdd3.Controls.Clear();
            pnAdd3.Controls.Add(ProductUC);
        }

        private void tHỐNGKÊToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StaticticsProductUC StaticticsProductUC = new StaticticsProductUC();
            StaticticsProductUC.Dock = DockStyle.Fill;
            pnAdd3.Controls.Clear();
            pnAdd3.Controls.Add(StaticticsProductUC);
        }

        private void lỊCHSỬNHẬPHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellUC importUC = new SellUC();
            importUC.Dock = DockStyle.Fill;
            pnAdd3.Controls.Clear();
            pnAdd3.Controls.Add(importUC);
        }
    }
}
