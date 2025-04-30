using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Project_DBMS.Supplier;
using Project_DBMS.DTO;
using Project_DBMS.Product;

namespace Project_DBMS.ImportTransaciton
{
    public partial class SellUC: UserControl
    {
        public SellUC()
        {
            InitializeComponent();
            dataGridViewDetails.DataSource = DAO.ImportTransactionDAO.Instance.GetHistory(Global.GlobalEmpId);
        }
    }
}
