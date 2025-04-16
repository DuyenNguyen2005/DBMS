using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    class Product
    {
        public int Pro_ID { get; set; }
        public string Pro_Name { get; set; }
        public decimal Pro_Price { get; set; }
        public int Pro_Quantity { get; set; }
        public string Pro_Type { get; set; }
        public int Sup_ID { get; set; }
        public Product(int Pro_ID, string Pro_Name, decimal Pro_Price, int Pro_Quantity, string Pro_Type, int Sup_ID)
        {
            this.Pro_ID = Pro_ID;
            this.Pro_Name = Pro_Name;
            this.Pro_Price = Pro_Price;
            this.Pro_Quantity = Pro_Quantity;
            this.Pro_Type = Pro_Type;
            this.Sup_ID = Sup_ID;
        }

        public Product(DataRow row)
        {
            Pro_ID = (int)row["Pro_ID"];
            Pro_Name = row["Pro_Name"].ToString();
            Pro_Price = (decimal)row["Pro_Price"];
            Pro_Quantity = (int)row["Pro_Quantity"];
            Pro_Type = row["Pro_Type"].ToString();
            Sup_ID = (int)row["Pro_Supplier_ID"];
        }
    }
}
