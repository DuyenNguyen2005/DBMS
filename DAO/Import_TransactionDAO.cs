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
    public class ImportTransactionDAO
    {
        private static ImportTransactionDAO instance;

        public static ImportTransactionDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImportTransactionDAO();
                return instance;
            }
            private set { instance = value; }
        }

        #region Import Transacion
        private ImportTransactionDAO() { }

        public bool Insert(DTO.Import_Transaction importTransaction)
        {
            try
            {
                // Insert into ImportTransaction
                string queryImport = "EXEC sp_InsertImportTransaction @Imp_ID , @Emp_ID , @Sup_ID ,  @Imp_Date";
            object[] parameter = new object[] { importTransaction.Imp_ID, importTransaction.Emp_ID, importTransaction.Sup_ID , importTransaction.Imp_Date};

            int result = DataProvider.Instance.ExecuteNonQuery(queryImport, parameter);
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
        public bool Delete(string impID)
        {
            string query = "EXEC sp_DeleteImportTransaction @Imp_ID";
            object[] parameters = { impID };

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public List<DTO.Import_Transaction> Search(string search)
        {
            string query = "EXEC sp_SearchImportTransaction @Search";
            object[] parameters = { search };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            List<DTO.Import_Transaction> imports = new List<DTO.Import_Transaction>();
            foreach (DataRow row in data.Rows)
            {
                imports.Add(new DTO.Import_Transaction(row));
            }
            return imports;
        }

        public List<DTO.Import_Transaction> GetImportTransactions()
        {
            string query = "EXEC sp_SearchImportTransaction";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<DTO.Import_Transaction> imports = new List<DTO.Import_Transaction>();
            foreach (DataRow row in data.Rows)
            {
                imports.Add(new DTO.Import_Transaction(row));
            }
            return imports;
        }
        public string GenerateImpID()
        {
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectionSTR))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_GenerateImp_ID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số OUTPUT cho Sup_ID
                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@Imp_ID",
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
        public DataTable SupplierImportStatistic ()
        {
            string query = "SELECT*FROM [dbo].[SupplierImportStatistic]";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable ImportStatistic()
        {
            string query = "SELECT*FROM [dbo].[ImportStatistic]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetHistory(String Emp_ID)
        {
            string query = "SELECT*FROM vw_ImportHistory_ByEmployee WHERE Emp_ID = @Emp_ID";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {Emp_ID});
        }
        #endregion
    }
}
