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
    public class EmployeeDAO
    {
        public static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeDAO();
                return instance;
            }
            private set { instance = value; }
        }
        #region LOGIN
        public string CreateNewLogin(string emp_id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DAO.DataProvider.Instance.connectionSTR))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_CreateAccount", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Emp_ID", emp_id); // Truyền emp_id thay vì giá trị cứng

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader["Message"].ToString();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khác: " + ex.Message);
            }

            return null;
        }
        public void DeleteAccount(string empId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DAO.DataProvider.Instance.connectionSTR))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_DeleteAccount", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Emp_ID", empId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string message = reader[0].ToString();
                                MessageBox.Show(message); // Hoặc đưa vào TextBox
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public string ResertPaswword(string empId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DAO.DataProvider.Instance.connectionSTR))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ResetAccountPassword", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Emp_ID", empId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Đọc cột NewPassword
                                return reader["NewPassword"].ToString();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khác: " + ex.Message);
            }

            return null;
        }

        public DataTable ListAccount()
        {
            string query = "Select * from [dbo].[vw_ListAccount]";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable ModiFiedTime()
        {
            return DataProvider.Instance.ExecuteQuery("Select * from [dbo].[vw_ModifiedTimeLogins]");
        }
        public DataTable SearchAccount(string emp_id)
        {
            string query = "Select * from [dbo].[vw_ListAccount] where username = @emp_id";
            object[] parameters = new object[] { emp_id  };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public string LoginDatabase(string username, string password)
        {
            string connectionString = $"Data Source=EOVIEN;Initial Catalog=DBMS_Prọject;User Id={username};Password={password};TrustServerCertificate=True";
            string userRole = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_GetMyRole", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", username); // Thêm tham số @username

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userRole = reader["RoleName"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
                return "";
            }

            return userRole;
        }

        #endregion

        #region Employee
        // Sử dụng DataProvider để thực thi các query
        public bool Insert(DTO.Employee emp)
        {
            string query = "EXEC sp_InsertEmployee @Emp_ID , @Emp_Name , @Emp_DOB , @Emp_Gender , @Emp_Address , @Emp_Phone , @Emp_Email , @Emp_Position , @Emp_HireDate , @Emp_Salary";
            object[] parameters = { emp.Emp_ID, emp.Emp_Name, emp.Emp_DOB, emp.Emp_Gender, emp.Emp_Address, emp.Emp_Phone, emp.Emp_Email, emp.Emp_Position, emp.Emp_HireDate, emp.Emp_Salary };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;

        }
        public bool Update(DTO.Employee emp)
        {
            string query = "EXEC sp_UpdateEmployee @Emp_ID , @Emp_Name , @Emp_DOB , " +
                          "@Emp_Gender , @Emp_Address , @Emp_Phone , @Emp_Email , " +
                          "@Emp_Position , @Emp_HireDate , @Emp_Status , @Emp_Salary";

            object[] parameters = new object[] { emp.Emp_ID, emp.Emp_Name, emp.Emp_DOB, emp.Emp_Gender, emp.Emp_Address, emp.Emp_Phone, emp.Emp_Email, emp.Emp_Position, emp.Emp_HireDate, emp.Emp_Status, emp.Emp_Salary };

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
        public bool Delete(string empId)
        {
            string query = "EXEC sp_DeleteEmployee @Emp_ID";
            object[] parameters = new object[] { empId };

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
        public List<DTO.Employee> Search(string Search)
        {
            string query = "EXEC sp_SearchEmployee @Search";
            object[] parameters = new object[] { Search };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);
            List<DTO.Employee> employees = new List<DTO.Employee>();
            foreach (DataRow row in data.Rows)
            {
                employees.Add(new DTO.Employee(row));
            }
            return employees;
        }
        public List<DTO.Employee> GetEmployees()
        {
            string query = "EXEC sp_SearchEmployee";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<DTO.Employee> employees = new List<DTO.Employee>();

            foreach (DataRow row in data.Rows)
            {
                employees.Add(new DTO.Employee(row));
            }
            return employees;
        }
        public string GenerateEmpID(string empPosition)
        {
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectionSTR))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_GenerateEmpID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Emp_Position", empPosition);

                    SqlParameter outputIdParam = new SqlParameter("@GeneratedID", SqlDbType.NVarChar, 20)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputIdParam);

                    command.ExecuteNonQuery();
                    return outputIdParam.Value.ToString();
                }
            }
        }

        public DataTable EmployeeSalesStatistic()
        {
            string query = "SELECT * FROM EmployeeSalesStatistic";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        #endregion
    }
}
