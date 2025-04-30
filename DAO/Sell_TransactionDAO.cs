using Project_DBMS.DTO;
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
        public bool Insert(DTO.Sell_Transaction sellTransaction)
        {
            try
            {
                string query = "EXEC [sp_InsertSellTransaction] @Sell_ID , @Cus_ID , @Emp_ID , @Sell_Date";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                {
            sellTransaction.Sell_ID,
            sellTransaction.Cus_ID,
            sellTransaction.Emp_ID,
            sellTransaction.Sell_Date
                });

                return result > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Delete Sell Transaction
        public bool Delete(string sellID)
        {
            string query = "EXEC sp_DeleteSellTransaction @Sell_ID";
            object[] parameters = { sellID };

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        // Search Sell Transaction
        public List<DTO.Sell_Transaction> Search(string search)
        {
            string query = "EXEC sp_SearchSellTransaction @Search";
            object[] parameters = { search };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            List<DTO.Sell_Transaction> Sells = new List<DTO.Sell_Transaction>();
            foreach (DataRow row in data.Rows)
            {
                Sells.Add(new DTO.Sell_Transaction(row));
            }
            return Sells;
        }
        public List<DTO.Sell_Transaction> GetSellTransactions()
        {
            string query = "EXEC sp_SearchSellTransaction";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<DTO.Sell_Transaction> Sells = new List<DTO.Sell_Transaction>();
            foreach (DataRow row in data.Rows)
            {
                Sells.Add(new DTO.Sell_Transaction(row));
            }
            return Sells;
        }
        public string GenerateSellID()
        {
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectionSTR))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_GenerateSell_ID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số OUTPUT cho Sup_ID
                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@Sell_ID",
                        SqlDbType = SqlDbType.NVarChar,
                        Size = 20,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    // Thực thi stored procedure
                    command.ExecuteNonQuery();

                    // Lấy giá trị từ tham số OUTPUT và trả về
                    return outputParam.Value.ToString();
                }
            }
        }
        public DataTable GetHistory(string emp_id)
        {
            string query = "SELECT * FROM vw_SellHistory_ByEmployee WHERE Emp_ID = @Emp_ID";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { emp_id });
        }
    }

}
