using Project_DBMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProductDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private ProductDAO() { }

        public bool Insert(DTO.Product pro)
        {
            string query = "EXEC sp_InsertProduct @Pro_ID , @Pro_Name , @Pro_Price , @Pro_Quantity , @Pro_MaxQuantity , @Pro_Type , @Pro_Description , @Sup_ID";
            object[] parameters = { pro.Pro_ID, pro.Pro_Name, pro.Pro_Price, pro.Pro_Quantity, pro.Pro_MaxQuantity, pro.Pro_Type, pro.Pro_Description, pro.Sup_ID };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Update(DTO.Product pro)
        {
            string query = "EXEC sp_UpdateProduct @Pro_ID , @Pro_Name , @Pro_Price , @Pro_Quantity , @Pro_MaxQuantity , @Pro_Type , @Pro_Description  , @Sup_ID";
            object[] parameters = { pro.Pro_ID, pro.Pro_Name, pro.Pro_Price, pro.Pro_Quantity, pro.Pro_MaxQuantity, pro.Pro_Type, pro.Pro_Description, pro.Sup_ID };

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool Delete(string proId)
        {
            string query = "EXEC sp_DeleteProduct @Pro_ID";
            object[] parameters = { proId };

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public List<DTO.Product> Search(string search)
        {
            string query = "EXEC sp_SearchProduct @Search";
            object[] parameters = { search };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            List<DTO.Product> products = new List<DTO.Product>();
            foreach (DataRow row in data.Rows)
            {
                products.Add(new DTO.Product(row));
            }
            return products;
        }
        public DTO.Product GetProduct(string proid)
        {
            string query = "SELECT * FROM Product WHERE Pro_ID = @id";
            object[] parameters = { proid };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            return data.Rows.Count > 0 ? new DTO.Product(data.Rows[0]) : null;
        }
        public DataTable GetProducts()
        {
            string query = "EXEC sp_SearchProduct";

            return  DataProvider.Instance.ExecuteQuery(query);

        }
        public DataTable GetProducts_Sell()
        {
            string query = "SELECT Pro_ID , Pro_Name , Pro_Quantity , Pro_Price , Pro_Status FROM Product";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetProducts_Imp(string Sup_ID)
        {
            string query = "SELECT Pro_ID , Pro_Name , Pro_Quantity , Pro_Price , Pro_Status FROM Product WHERE Sup_ID = @Sup_ID";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { Sup_ID });
        }
        public DataTable GetProducts_Imp(string Sup_ID, string Imp_ID)
        {
            string query = "SELECT Pro_ID , Pro_Name , Pro_Quantity , Pro_Price , Pro_Status FROM Product WHERE Sup_ID = @Sup_ID";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { Sup_ID, Imp_ID});
        }
        public string GenerateProID()
        {
            string proID = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(DataProvider.Instance.connectionSTR))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_GenerateProID", conn)) // Sửa tên sp
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số OUTPUT
                        SqlParameter outputParam = new SqlParameter
                        {
                            ParameterName = "@Pro_ID",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 20,
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputParam);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();

                        // Kiểm tra nếu có kết quả trả về
                        proID = outputParam.Value != DBNull.Value ? outputParam.Value.ToString() : null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tạo mã sản phẩm: " + ex.Message);
            }

            return proID;
        }
        public List<DTO.Product> GetStatusProduct()
        {
            string query = "EXEC sp_SearchProduct";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<DTO.Product> products = new List<DTO.Product>();
            foreach (DataRow row in data.Rows)
            {
                products.Add(new DTO.Product(row));
            }
            return products;
        }

        public DataTable ProductInOutSummary()
        {
            string query = "SELECT*FROM [dbo].[ProductInOutSummary]";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable ProductInventoryStatus()
        {
            string query = "SELECT*FROM [dbo].[ProductInventoryStatus]";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable vw_Top5BestSellingProductsByMonth()
        {
            string query = "SELECT*FROM vw_Top5BestSellingProductsByMonth";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable RevenueStatistic()
        {
            string query = "SELECT*FROM RevenueStatistic";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int GetTotalSoldQuantity(string proId)
        {
            string query = @"
        SELECT SUM(ISNULL(sdt.Sell_Quantity, 0))
        FROM SellDetailTransaction sdt
        LEFT JOIN Product p ON sdt.Pro_ID = p.Pro_ID
        WHERE sdt.Pro_ID = @Pro_ID";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { proId });

            // Kiểm tra kết quả trả về
            if (result != null && result != DBNull.Value)
                return Convert.ToInt32(result);
            return 0;
        }

    }
}
