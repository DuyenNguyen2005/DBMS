using Project_DBMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DAO
{
    class EmployeeDAO
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
        private EmployeeDAO() { }

        // Add Employee
        public bool AddEmployee(string name, DateTime dob, string phone)
        {
            string query = "EXEC AddEmployee @name , @dob , @phone";
            object[] parameters = new object[] { name, dob, phone };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return result > 0;
        }

        // Update Employee
        public bool UpdateEmployee(int id, string name, DateTime dob, string phone)
        {
            string query = "EXEC UpdateEmployee @id , @name , @phone, @dob";
            object[] parameters = new object[] { id, name, phone, dob };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Delete Employee
        public bool DeleteEmployee(int id)
        {
            string query = "EXEC DeleteEmployee @id";
            object[] parameters = new object[] { id };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Search Employee
        public List<Employee> SearchEmployee(string keyword)
        {
            string query = "EXEC SearchEmployee @Keyword";
            object[] parameters = new object[] { keyword };
            List<Employee> Employees = new List<Employee>();
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            foreach (DataRow item in data.Rows)
            {
                Employees.Add(new Employee(item));
            }
            return Employees;
        }

        // Get Employees List
        public List<Employee> GetEmployeeList()
        {
            string query = "EXEC GetEmployeeList";
            List<Employee> Employees = new List<Employee>();
            var data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Employees.Add(new Employee(item));
            }
            return Employees;
        }

        // Get Employee by ID
        public Employee GetEmployeeByID(int id)
        {
            string query = "EXEC GetEmployeeByID @id";
            object[] parameters = new object[] { id };
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                return new Employee(data.Rows[0]);
            }
            return null;
        }

        // Get Top Employee
        public List<Employee> GetTopEmployee(DateTime startDate, DateTime endDate, int top)
        {
            string query = "EXEC GetTopEmployee @startDate, @endDate, @top";
            object[] parameters = new object[] { startDate, endDate, top };
            List<Employee> Employees = new List<Employee>();
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            foreach (DataRow item in data.Rows)
            {
                Employees.Add(new Employee(item));
            }
            return Employees;
        }

        //Get Age Employee
        public int GetAgeEmployee(int id)
        {
            string query = "EXEC GetAgeEmployee @id";
            object[] parameters = new object[] { id };
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                return (int)data.Rows[0]["Age"];
            }
            return 0;
        }

        // Get Employee Revenue In Period
        public int GetCountEmployee(int id)
        {
            string query = "EXEC GetCountEmployee @id";
            object[] parameters = new object[] { id };
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                return (int)data.Rows[0]["Count"];
            }
            return 0;
        }
    }
}
