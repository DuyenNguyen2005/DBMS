using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS.Customer
{
    public partial class StaticticsCustomerUC: UserControl
    {
        public StaticticsCustomerUC()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.CustomerDAO.Instance.RecentCustomerPurchases();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.CustomerDAO.Instance.VIPCustomers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.CustomerDAO.Instance.TopMonthlyCustomers();
        }
    }
}
