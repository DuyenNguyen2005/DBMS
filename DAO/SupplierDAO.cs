using Project_DBMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_DBMS.DAO
{
    public class SupplierDAO
    {
        private static SupplierDAO instance;

        public static SupplierDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SupplierDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private SupplierDAO() { }

        public bool Insert(DTO.Supplier sup)
        {
            string query = "EXEC sp_InsertSupplier @Sup_ID , @Sup_Name , @Sup_Address , @Sup_Phone , @Sup_Email , @Sup_Website , @Sup_JoinDate , @Sup_Status";
            object[] parameters = new object[] { sup.Sup_ID, sup.Sup_Name, sup.Sup_Address, sup.Sup_Phone, sup.Sup_Email, (object)sup.Sup_Website ?? DBNull.Value, sup.Sup_JoinDate, sup.Sup_Status };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool Update(DTO.Supplier sup)
        {
            string query = "EXEC sp_UpdateSupplier @Sup_ID , @Sup_Name , @Sup_Adress , @Sup_Phone , @Sup_Email , @Sup_Website , @Sup_JoinDate , @Sup_Status";
            object[] parameters = new object[] { sup.Sup_ID, sup.Sup_Name, sup.Sup_Address, sup.Sup_Phone, sup.Sup_Email, sup.Sup_Website, sup.Sup_JoinDate, sup.Sup_Status };

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool Delete(string supId)
        {
            string query = "EXEC sp_DeleteSupplier @Sup_ID";
            object[] parameters = new object[] { supId };

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
        public DTO.Supplier GetSupplierbyID(string id)
        {
            string query = "SELECT * FROM Supplier WHERE Sup_ID = @id";
            object[] parameters = { id };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            return data.Rows.Count > 0 ? new DTO.Supplier(data.Rows[0]) : null;
        }
        public string GetSupplierID(string name)
        {
            string query = "SELECT Sup_ID FROM Supplier WHERE Sup_Name COLLATE Vietnamese_CI_AI LIKE N'%' + @name + '%'";
            object[] parameters = { name };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            return data.Rows.Count > 0 ? data.Rows[0]["Sup_ID"].ToString() : null;
        }
        public List<DTO.Supplier> Search(string search)
        {
            string query = "EXEC sp_SearchSupplier @Search";
            object[] parameters = new object[] { search };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            List<DTO.Supplier> suppliers = new List<DTO.Supplier>();
            foreach (DataRow row in data.Rows)
            {
                suppliers.Add(new DTO.Supplier(row));
            }
            return suppliers;
        }
        public List<DTO.Supplier> GetSuppliers()
        {
            string query = "EXEC sp_SearchSupplier";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<DTO.Supplier> suppliers = new List<DTO.Supplier>();
            foreach (DataRow row in data.Rows)
            {
                suppliers.Add(new DTO.Supplier(row));
            }
            return suppliers;
        }
        public DTO.Supplier GetSupplier(string Sup_Name)
        {
            string query = "SELECT TOP 1 * FROM Supplier WHERE Sup_Name COLLATE Vietnamese_CI_AI LIKE N'%' + @Sup_Name + '%'";

            object[] parameters = new object[] { Sup_Name };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            return new DTO.Supplier(data.Rows[0]);
        }
        public string GenerateSupID()
        {
            string supID = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(DataProvider.Instance.connectionSTR))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_GenerateSupID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số OUTPUT cho Sup_ID
                        SqlParameter outputParam = new SqlParameter
                        {
                            ParameterName = "@Sup_ID",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 20,
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputParam);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();

                        // Lấy giá trị từ tham số OUTPUT và trả về
                        supID = outputParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log hoặc xử lý lỗi ở đây
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return supID;
        }

        public bool CheckExistence(string Sup_Name)
        {
            string query = "SELECT * FROM Supplier WHERE Sup_Name = @Sup_Name";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { Sup_Name });

            List<DTO.Supplier> suppliers = new List<DTO.Supplier>();
            foreach (DataRow row in data.Rows)
            {
                suppliers.Add(new DTO.Supplier(row));
            }

            // Correct null/empty check
            return suppliers.Count > 0;        
        }
    }
}
