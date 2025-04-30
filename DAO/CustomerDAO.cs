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
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private CustomerDAO() { }

        public bool Insert(DTO.Customer cus)
        {
            string query = "EXEC sp_InsertCustomer @Cus_ID ,  @Cus_Name , @Cus_Phone , @Cus_Address";
            object[] parameters = { cus.Cus_ID, cus.Cus_Name, cus.Cus_Phone, cus.Cus_Address };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Update(DTO.Customer cus)
        {
            string query = "EXEC sp_UpdateCustomer @Cus_ID , @Cus_Name , @Cus_Phone , @Cus_Address";
            object[] parameters = { cus.Cus_ID, cus.Cus_Name, cus.Cus_Phone, cus.Cus_Address };

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool Delete(string cusId)
        {
            string query = "EXEC sp_DeleteCustomer @Cus_ID";
            object[] parameters = { cusId };

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public List<DTO.Customer> Search(string search)
        {
            string query = "EXEC sp_SearchCustomer @Search";
            object[] parameters = { search };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            List<DTO.Customer> customers = new List<DTO.Customer>();
            foreach (DataRow row in data.Rows)
            {
                customers.Add(new DTO.Customer(row));
            }
            return customers;
        }
        public DTO.Customer GetCustomer(string name)
        {
            string query = "SELECT TOP 1 * FROM Customer WHERE Cus_Name COLLATE Vietnamese_CI_AI LIKE N'%' + @name + '%'";
            object[] parameters = { name };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            return data.Rows.Count > 0 ? new DTO.Customer(data.Rows[0]) : null;
        }
        public DTO.Customer GetCustomerbyID(string id)
        {
            string query = "SELECT * FROM Customer WHERE Cus_ID = @id";
            object[] parameters = { id };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            return data.Rows.Count > 0 ? new DTO.Customer(data.Rows[0]) : null;
        }
        public string GetCustomerID(string name)
        {
            string query = "SELECT Cus_ID FROM Customer WHERE Cus_Name COLLATE Vietnamese_CI_AI LIKE N'%' + @name + '%'";
            object[] parameters = { name };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            return data.Rows.Count > 0 ? data.Rows[0]["Cus_ID"].ToString() : null;
        }
        public DataTable GetCustomers()
        {
            string query = "EXEC sp_SearchCustomer";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public string GenerateCusID()
        {
            string supID = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(DataProvider.Instance.connectionSTR))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_GenerateCusID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số OUTPUT cho Sup_ID
                        SqlParameter outputParam = new SqlParameter
                        {
                            ParameterName = "@Cus_ID",
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
        public bool CheckExistence(string Cus_Name)
        {
            string query = "SELECT TOP 1 * FROM Customer WHERE Cus_Name = @Cus_Name";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { Cus_Name });

            List<DTO.Customer> customers = new List<DTO.Customer>();
            foreach (DataRow row in data.Rows)
            {
                customers.Add(new DTO.Customer(row));
            }

            // Correct null/empty check
            return customers.Count > 0;
        }
        public bool CheckPhoneExistence(string Cus_Phone)
        {
            string query = "EXEC sp_SearchCustomer @Cus_Phone";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { Cus_Phone });

            List<DTO.Customer> customers = new List<DTO.Customer>();
            foreach (DataRow row in data.Rows)
            {
                customers.Add(new DTO.Customer(row));
            }

            // Correct null/empty check
            return customers.Count > 0;
        }
        public bool CheckExistencebyID(string Cus_ID)
        {
            string query = "EXEC sp_SearchCustomer @Cus_ID";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { Cus_ID });

            List<DTO.Customer> customers = new List<DTO.Customer>();
            foreach (DataRow row in data.Rows)
            {
                customers.Add(new DTO.Customer(row));
            }

            // Correct null/empty check
            return customers.Count > 0;
        }

        public DataTable RecentCustomerPurchases()
        {
            string query = "SELECT * FROM RecentCustomerPurchases";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable VIPCustomers()
        {
            string query = "SELECT * FROM VIPCustomers";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable TopMonthlyCustomers()
        {
            string query = "SELECT * FROM TopMonthlyCustomers";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
