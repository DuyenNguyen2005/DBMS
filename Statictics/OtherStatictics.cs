using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS.Statictics
{
    public partial class OtherStatictics: UserControl
    {
        public OtherStatictics()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dtgvTransaction.DataSource = DAO.EmployeeDAO.Instance.EmployeeSalesStatistic();
                    break;
                case 1:
                    dtgvTransaction.DataSource = DAO.ImportTransactionDAO.Instance.ImportStatistic();
                    break;
                case 2:
                    dtgvTransaction.DataSource = DAO.ProductDAO.Instance.ProductInOutSummary();
                    break;
                case 3:
                    dtgvTransaction.DataSource = DAO.ProductDAO.Instance.ProductInventoryStatus();
                    break;
                case 4:
                    dtgvTransaction.DataSource = DAO.CustomerDAO.Instance.RecentCustomerPurchases();
                    break;
                case 5:
                    dtgvTransaction.DataSource = DAO.ProductDAO.Instance.RevenueStatistic();
                    break;
                case 6:
                    dtgvTransaction.DataSource = DAO.ImportTransactionDAO.Instance.SupplierImportStatistic();
                    break;
                case 7:
                    dtgvTransaction.DataSource = DAO.CustomerDAO.Instance.TopMonthlyCustomers();
                    break;
                case 8:
                    dtgvTransaction.DataSource = DAO.CustomerDAO.Instance.VIPCustomers();
                    break;
                case 9:
                    dtgvTransaction.DataSource = DAO.ProductDAO.Instance.vw_Top5BestSellingProductsByMonth();
                    break;
            }
        }
    }
}
