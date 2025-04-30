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
    public class ImportDetailTransactionDAO
    {
        private static ImportDetailTransactionDAO instance;
        public static ImportDetailTransactionDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImportDetailTransactionDAO();
                return instance;
            }
        }

        private ImportDetailTransactionDAO() { }

        // INSERT
        public bool Insert(string imp_ID, DTO.Product product)
        {
            try
            {
                string query = "EXEC sp_InsertImportDetailTransaction @Imp_ID , @Pro_ID , @Imp_Quantity , @Imp_Price";
                int result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { imp_ID, product.Pro_ID, product.Pro_Quantity, product.Pro_Price });

                return result > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // UPDATE
        public bool Update(string imp_ID, DTO.Product product)
        {
            try
            {
                string query = "EXEC sp_UpdateImportDetailTransaction @Imp_ID , @Pro_ID , @Imp_Quantity , @Imp_Price";
                int result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { imp_ID, product.Pro_ID, product.Pro_Quantity, product.Pro_Price });

                return result > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // DELETE
        public bool Delete(string imp_ID, string pro_ID)
        {
            string query = "EXEC sp_DeleteImportDetailTransaction @Imp_ID , @Pro_ID";
            int result = DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { imp_ID, pro_ID });
            return result > 0;
        }

        // SEARCH
        public DataTable Search(string imp_ID = null, string pro_ID = null, int? imp_Quantity = null, decimal? imp_Price = null)
        {
            try
            {
                string query = "EXEC sp_SearchImportDetailTransaction @Imp_ID , @Pro_ID , @Imp_Quantity , @Imp_Price";
                return DataProvider.Instance.ExecuteQuery(query, new object[] { imp_ID, pro_ID, imp_Quantity, imp_Price });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm giao dịch nhập hàng: {ex.Message}");
                return new DataTable(); // Trả về bảng rỗng nếu có lỗi
            }
        }
        public DataTable Search(string imp_ID)
        {
            try
            {
                string query = "EXEC sp_SearchImportDetailTransaction @Imp_ID";
                DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { imp_ID });

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy giao dịch nhập hàng!");
                }

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm giao dịch nhập hàng: {ex.Message}");
                return new DataTable();
            }
        }

        public decimal GetTotalAmount(string ImpID)
        {
            string query = "EXEC GetTotalAmountByImpID @Imp_ID";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { ImpID });

            return result != null && result != DBNull.Value ? Convert.ToDecimal(result) : 0;
        }


        public DataTable GetList(string Imp_ID)
        {
            string query = "SELECT Imp_ID , Pro_ID , Imp_Quantity , Imp_Price FROM ImportDetailTransaction WHERE Imp_ID = @Imp_ID";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Imp_ID });
        }

        public bool Exists(string Imp_ID, string proID)
        {
            string query = "SELECT COUNT(*) FROM ImportDetailTransaction WHERE Imp_ID = @ImpID AND Pro_ID = @proID";
            int count = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { Imp_ID, proID });
            return count > 0;
        }

        public bool IncreaseQuantity(string Imp_ID, string proID, int quantity)
        {
            string query = "UPDATE ImportDetailTransaction SET Imp_Quantity = Imp_Quantity + @quantity WHERE Imp_ID = @ImpID AND Pro_ID = @proID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { quantity, Imp_ID, proID });
            return result > 0;
        }
    }
}
