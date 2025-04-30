using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS.Product
{
    public partial class StaticticsProductUC: UserControl
    {
        public StaticticsProductUC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.ProductDAO.Instance.ProductInventoryStatus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.ProductDAO.Instance.ProductInOutSummary();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.ProductDAO.Instance.vw_Top5BestSellingProductsByMonth();
        }
    }
}
