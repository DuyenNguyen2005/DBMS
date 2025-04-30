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

namespace Project_DBMS.SellTransaction
{
    public partial class SellDetailUC: UserControl
    {
        public SellDetailUC()
        {
            InitializeComponent();
            dtgvValuable.DataSource = DAO.Sell_TransactionDAO.Instance.GetHistory(Global.GlobalEmpId);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
