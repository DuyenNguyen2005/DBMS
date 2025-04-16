using Project_DBMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DAO
{
    class ProductDAO
    {
        public static ProductDAO instance;
        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return instance; }
            private set { instance = value; }
        }
        private ProductDAO() { }
        // Add Product
        public bool AddProduct(string name, decimal price, int quantity, string type, int supplier_id)
        {
            string query = "EXEC AddProduct @name , @price , @quantity , @type , @supplier_id";
            object[] parameters = new object[] { name, price, quantity, type, supplier_id };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        // Update Product
        public bool UpdateProduct(int id, string name, decimal price, int quantity, string type, int supplier_id)
        {
            string query = "EXEC UpdateProduct @id, @name , @price, @quantity, @type, @supplier_id";
            object[] parameters = new object[] { id, name, price, quantity, type, supplier_id };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        // Delete Product
        public bool DeleteProduct(int id)
        {
            string query = "EXEC DeleteProduct @id";
            object[] parameters = new object[] { id };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        //Get Product by ID
        public Product GetProductById(int id)
        {
            string query = "EXEC GetProductById @id";
            object[] parameters = new object[] { id };
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                return new Product(data.Rows[0]);
            }
            return null;
        }
        // Get All Products
        public List<Product> GetProductList()
        {
            string query = "EXEC GetProductList";
            var data = DataProvider.Instance.ExecuteQuery(query);
            List<Product> products = new List<Product>();
            foreach (DataRow item in data.Rows)
            {
                products.Add(new Product(item));
            }
            return products;
        }
        // Search Product
        public List<Product> SearchProduct(string keyword)
        {
            string query = "EXEC SearchProduct @Keyword";
            object[] parameters = new object[] { keyword };
            List<Product> products = new List<Product>();
            var data = DataProvider.Instance.ExecuteQuery(query, parameters);
            foreach (DataRow item in data.Rows)
            {
                products.Add(new Product(item));
            }
            return products;
        }

        ////Get Best Selling Products
        //public List<Product> GetBestSellingProducts(int top)
        //{
        //    string query = "EXEC GetBestSellingProducts @top";
        //    object[] parameters = new object[] { top };
        //    List<Product> products = new List<Product>();
        //    var data = DataProvider.Instance.ExecuteQuery(query, parameters);
        //    foreach (DataRow item in data.Rows)
        //    {
        //        products.Add(new Product(item));
        //    }
        //    return products;
        //}

        // pu

    }
}
