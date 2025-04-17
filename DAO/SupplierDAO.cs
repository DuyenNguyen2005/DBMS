using Project_DBMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DAO
{
    class SupplierDAO
    {
        public static SupplierDAO instance;
        public static SupplierDAO Instance
        {
            get { if (instance == null) instance = new SupplierDAO(); return instance; }
            private set { instance = value; }
        }

        private SupplierDAO() { }
        // Add Supplier
        public bool AddSupplier(string name, string phone)
        {
            string query = "EXEC AddSupplier @Sup_Name , @Sup_Phone";
            object[] parameters = new object[] { name, phone};
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        // Update Supplier
        public bool UpdateSupplier(int id, string name, string phone)
        {
            string query = "EXEC UpdateSupplier @id , @name , @phone , @address";
            object[] parameters = new object[] { id, name, phone};
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        // Delete Supplier
        public bool DeleteSupplier(int id)
        {
            string query = "EXEC DeleteSupplier @id";
            object[] parameters = new object[] { id };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Search Supplier
        public List<Supplier> SearchSupplier(string keyword)
        {
            string query = "EXEC SearchSupplier @Keyword";
            object[] parameters = new object[] { keyword };
            List<Supplier> suppliers = new List<Supplier>();
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            foreach (DataRow item in data.Rows)
            {
                suppliers.Add(new Supplier(item));
            }
            return suppliers;
        }
        // Get Supplier by ID
        public Supplier GetSupplierById(int Sup_ID)
        {
            string query = "SELECT * FROM Supplier WHERE Sup_ID = @Sup_ID";
            object[] parameters = new object[] { Sup_ID };
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                return new Supplier(data.Rows[0]);
            }
            return null;
        }
        // Get Supplier by Name
        public int GetSupplierIdByName(string supplierName)
        {
            string query = "SELECT Sup_ID FROM Supplier WHERE Sup_Name = @name";
            object[] parameters = new object[] { supplierName };
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["Sup_ID"]);
            }
            return -1; // hoặc throw exception nếu cần
        }

        // Get All Suppliers
        public List<Supplier> GetSupplierList()
        {
            string query = "EXEC GetSupplierList";
            var data = DataProvider.Instance.ExecuteQuery(query);
            List<Supplier> suppliers = new List<Supplier>();
            foreach (DataRow item in data.Rows)
            {
                suppliers.Add(new Supplier(item));
            }
            return suppliers;
        }
    }
}
