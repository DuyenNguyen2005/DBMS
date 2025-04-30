using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS.ImportTransaciton
{
    public partial class ImportStatictis: UserControl
    {
        public ImportStatictis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.ImportTransactionDAO.Instance.ImportStatistic();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.ImportTransactionDAO.Instance.SupplierImportStatistic();
        }
    }
}
