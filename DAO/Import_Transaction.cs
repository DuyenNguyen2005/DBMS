using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DAO
{
    class Import_Transaction
    {
        public static Import_Transaction instance;
        public static Import_Transaction Instance
        {
            get { if (instance == null) instance = new Import_Transaction(); return instance; }
            private set { instance = value; }
        }

        private Import_Transaction() { }
        // Add Import Transaction
        public bool AddImportTransaction(int id, string date, int supplierId, int employeeId)
        {
            string query = "EXEC AddImportTransaction @id, @date, @supplierId, @employeeId";
            object[] parameters = new object[] { id, date, supplierId, employeeId };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        // Update Import Transaction
        public bool DeleteImportTransaction(int id) {
            string query = "EXEC DeleteImportTransaction @id";
            object[] parameters = new object[] { id };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        // Get Import Transaction by ID
        //public ImportTransaction GetImportTransactionById(int id)
        //{
        //    string query = "EXEC GetImportTransactionById @id";
        //    object[] parameters = new object[] { id };
        //    var data = DataProvider.Instance.ExecuteQuery(query, parameters);
        //    if (data.Rows.Count > 0)
        //    {
        //        return new ImportTransaction(data.Rows[0]);
        //    }
        //    return null;
        //}
        //// Get All Import Transactions
        //public List<ImportTransaction> GetAllImportTransactions()
        //{
        //    string query = "EXEC GetAllImportTransactions";
        //    var data = DataProvider.Instance.ExecuteQuery(query);
        //    List<ImportTransaction> transactions = new List<ImportTransaction>();
        //    foreach (DataRow item in data.Rows)
        //    {
        //        transactions.Add(new ImportTransaction(item));
        //    }
        //    return transactions;
        //}
        //// Search Import Transaction
        //public List<ImportTransaction> SearchImportTransaction(string keyword)
        //{
        //    string query = "EXEC SearchImportTransaction @Keyword";
        //    object[] parameters = new object[] { keyword };
        //    List<ImportTransaction> transactions = new List<ImportTransaction>();
        //    var data = DataProvider.Instance.ExecuteQuery(query, parameters);
        //    foreach (DataRow item in data.Rows)
        //    {
        //        transactions.Add(new ImportTransaction(item));
        //    }
        //    return transactions;
        //}

    }
}
