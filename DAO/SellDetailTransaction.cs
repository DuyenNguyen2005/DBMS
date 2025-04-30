using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS.DAO
{
    public class SellDetailTransactionDAO
    {
        private static SellDetailTransactionDAO instance;
        public static SellDetailTransactionDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SellDetailTransactionDAO();
                return instance;
            }
        }

        private SellDetailTransactionDAO() { }

        // INSERT
        public bool Insert(string Sell_ID, string pro_ID, int Sell_Quantity)
        {
            string query = "EXEC sp_InsertSellDetailTransaction @Sell_ID , @Pro_ID , @Sell_Quantity";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Sell_ID, pro_ID, Sell_Quantity });

            return result > 0;
        }

        // UPDATE
        public bool Update(string Sell_ID, string pro_ID, int Sell_Quantity)
        {
            string query = "EXEC sp_UpdateSellDetailTransaction @Sell_ID , @Pro_ID , @Sell_Quantity";
            int result = DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { Sell_ID, pro_ID, Sell_Quantity });
            return result > 0;
        }

        // DELETE
        public bool Delete(string Sell_ID, string pro_ID)
        {
            string query = "EXEC sp_DeleteSellDetailTransaction @Sell_ID , @Pro_ID";
            int result = DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { Sell_ID, pro_ID });
            return result > 0;
        }
        public DataTable GetList(string Sell_ID)
        {
            string query = "SELECT Sell_ID , Pro_ID , Sell_Quantity FROM SellDetailTransaction WHERE Sell_ID = @Sell_ID";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Sell_ID });
        }

        public bool Exists(string sellID, string proID)
        {
            string query = "SELECT COUNT(*) FROM SellDetailTransaction WHERE Sell_ID = @sellID AND Pro_ID = @proID";
            int count = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { sellID, proID });
            return count > 0;
        }

        public bool IncreaseQuantity(string sellID, string proID, int quantity)
        {
            string query = "UPDATE SellDetailTransaction SET Sell_Quantity = Sell_Quantity + @quantity WHERE Sell_ID = @sellID AND Pro_ID = @proID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { quantity, sellID, proID });
            return result > 0;
        }

        public decimal GetTotalAmount(string sellID)
        {
            string query = "EXEC GetTotalAmountBySellID @Sell_ID";
            return (decimal)DataProvider.Instance.ExecuteScalar(query, new object[] { sellID });
        }

    }
}
