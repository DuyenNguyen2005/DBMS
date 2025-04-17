using Project_DBMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DAO
{
    class Import_TransactionDAO
    {
        public static Import_TransactionDAO instance;
        public static Import_TransactionDAO Instance
        {
            get { if (instance == null) instance = new Import_TransactionDAO(); return instance; }
            private set { instance = value; }
        }

        private Import_TransactionDAO() { }
        // Add Import Transaction
        public bool AddImportTransaction(int sup_id, int pro_id, int quantity, decimal imp_price)
        {
            string query = "EXEC AddImportTransaction @Sup_ID , @Pro_ID , @Imp_Quantity , @Imp_Price";
            object[] parameters = new object[] { sup_id, pro_id, quantity, imp_price };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        // Delete Import Transaction
        public bool DeleteImportTransaction(int id) {
            string query = "EXEC DeleteImportTransaction @Imp_ID";
            object[] parameters = new object[] { id };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        // Update Import Transaction
        public bool UpdateImportTransaction(int id, int sup_id, int pro_id, int quantity, decimal imp_price)
        {
            string query = "EXEC UpdateImportTransaction @Imp_ID , @Sup_ID , @Pro_ID , @Imp_Quantity , @Imp_Price";
            object[] parameters = new object[] { id, sup_id, pro_id, quantity, imp_price };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        //Get Import Transaction by ID
        public Import_Transaction GetImportTransactionById(int Imp_ID)
        {
            string query = "EXEC GetImportTransactionById @Imp_ID";
            object[] parameters = new object[] { Imp_ID };
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                return new Import_Transaction(data.Rows[0]);
            }
            return null;
        }

        // Get All Import Transactions
        public List<Import_Transaction> GetImportTransactionList()
        {
            string query = "EXEC GetImportTransactionList";
            var data = DataProvider.Instance.ExecuteQuery(query);
            List<Import_Transaction> transactions = new List<Import_Transaction>();
            foreach (DataRow item in data.Rows)
            {
                transactions.Add(new Import_Transaction(item));
            }
            return transactions;
        }
        // Search Import Transaction
        public List<Import_Transaction> SearchImportTransaction(string keyword)
        {
            string query = "EXEC SearchImportTransaction @Keyword";
            object[] parameters = new object[] { keyword };
            List<Import_Transaction> transactions = new List<Import_Transaction>();
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            foreach (DataRow item in data.Rows)
            {
                transactions.Add(new Import_Transaction(item));
            }
            return transactions;
        }

    }
}
