using Project_DBMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DAO
{
    class Sell_TransactionDAO
    {
        public static Sell_TransactionDAO instance;
        public static Sell_TransactionDAO Instance
        {
            get { if (instance == null) instance = new Sell_TransactionDAO(); return instance; }
            private set { instance = value; }
        }

        private Sell_TransactionDAO() { }
        // Add Sell Transaction
        public bool AddSellTransaction(int pro_id, int cus_id, int emp_id, int quantity, decimal discount, decimal price)
        {
            string query = "EXEC AddSellTransaction @Pro_ID , @Cus_ID , @Emp_ID , @Sell_Quantity , @Sell_Discount";
            object[] parameters = new object[] { pro_id, cus_id, emp_id, quantity, discount, price };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        // Update Sell Transaction
        public bool UpdateSellTransaction(int id, int pro_id, int cus_id, int emp_id, int quantity, decimal price, decimal discount)
        {
            string query = "EXEC UpdateSellTransaction @Sell_ID , @Pro_ID , @Cus_ID , @Emp_ID , @Sell_Quantity , @Sell_Price , @Sell_Discount";
            object[] parameters = new object[] { id, pro_id, cus_id, emp_id, quantity, price, discount };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        // Delete Sell Transaction
        public bool DeleteSellTransaction(int id)
        {
            string query = "EXEC DeleteSellTransaction @id";
            object[] parameters = new object[] { id };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        //Get Sell Transaction by ID
        public Sell_Transaction GetSellTransactionById(int Sell_ID)
        {
            string query = "SELECT * FROM Sell_Transaction WHERE Sell_ID = @Sell_ID";
            object[] parameters = new object[] { Sell_ID };
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                return new Sell_Transaction(data.Rows[0]);
            }
            return null;
        }

        // Get All Sell Transactions
        public List<Sell_Transaction> GetSellTransactionList()
        {
            string query = "EXEC GetSellTransactionList";
            var data = DataProvider.Instance.ExecuteQuery(query);
            List<Sell_Transaction> transactions = new List<Sell_Transaction>();
            foreach (DataRow item in data.Rows)
            {
                transactions.Add(new Sell_Transaction(item));
            }
            return transactions;
        }
        // Search Sell Transaction
        public List<Sell_Transaction> SearchSellTransaction(string keyword)
        {
            string query = "EXEC SearchSellTransaction @Keyword";
            object[] parameters = new object[] { keyword };
            List<Sell_Transaction> transactions = new List<Sell_Transaction>();
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            foreach (DataRow item in data.Rows)
            {
                transactions.Add(new Sell_Transaction(item));
            }
            return transactions;
        }

    }

}
