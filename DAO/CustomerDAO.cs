using Project_DBMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DAO
{
    class CustomerDAO
    {
        public static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            private set { instance = value; }
        }

        private CustomerDAO() { }

        // Add Customer
        public bool AddCustomer(string name, string phone, string address)
        {
            string query = "EXEC AddCustomer @Cus_Name , @Cus_Phone , @Cus_Address";
            object[] parameters = new object[] { name, phone, address };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return result > 0;
        }

        // Update Customer
        public bool UpdateCustomer(int id, string name, string phone, string address)
        {
            string query = "EXEC UpdateCustomer @id , @name , @phone , @address";
            object[] parameters = new object[] { id, name, phone, address };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Delete Customer
        public bool DeleteCustomer(int id)
        {
            string query = "EXEC DeleteCustomer @id";
            object[] parameters = new object[] { id };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Search Customer
        public List<Customer> SearchCustomer(string keyword)
        {
            string query = "EXEC SearchCustomer @Keyword";
            object[] parameters = new object[] { keyword };
            List<Customer> customers = new List<Customer>();
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            foreach (DataRow item in data.Rows)
            {
                customers.Add(new Customer(item));
            }
            return customers;
        }

        // Get Customers List
        public List<Customer> GetCustomerList()
        {
            string query = "EXEC GetCustomerList";
            List<Customer> customers = new List<Customer>();
            var data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                customers.Add(new Customer(item));
            }
            return customers;
        }

        // Get Customer by ID
        public Customer GetCustomerByID(int id)
        {
            string query = "SELECT * FROM Customer WHERE Cus_ID = @id";
            object[] parameters = new object[] { id };
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                return new Customer(data.Rows[0]);
            }
            return null;
        }
        public Customer GetCustomerByName(string name)
        {
            string query = "SELECT * FROM Customer WHERE Cus_Name = @name";
            object[] parameters = new object[] { name };
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                return new Customer(data.Rows[0]);
            }
            return null;
        }

        // Get Loyal Customer
        public List<Customer> GetLoyalCustomers(int MinTransactions)
        {
            string query = "SELECT * FROM GetLoyalCustomers(@MinTransactions)";
            List<Customer> customers = new List<Customer>();
            object[] parameters = new object[] { MinTransactions };
            var data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                customers.Add(new Customer(item));
            }
            return customers;
        }

        
    }
}
