using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    public class Product
    {
        public string Imp_ID { get; set; }
        public string Pro_ID { get; set; }
        public string Pro_Name { get; set; }
        public decimal Pro_Price { get; set; }
        public int Pro_Quantity { get; set; }
        public int Pro_MaxQuantity { get; set; }
        public string Pro_Type { get; set; }
        public string Pro_Description { get; set; }
        public string Pro_Status { get; set; }
        public string Sup_ID { get; set; }

        public Product(string Pro_Name, decimal Pro_Price, int Pro_Quantity, int Pro_MaxQuantity, string Pro_Type, string Sup_ID, string Pro_Description, string Pro_Status)
        {
            this.Pro_Name = Pro_Name;
            this.Pro_Price = Pro_Price;
            this.Pro_Quantity = Pro_Quantity;
            this.Pro_MaxQuantity=Pro_MaxQuantity;
            this.Pro_Type = Pro_Type;
            this.Sup_ID = Sup_ID;
            this.Pro_Description = Pro_Description;
            this.Pro_Status = Pro_Status;
        }
        public Product(string pro_ID, string pro_Name, decimal pro_Price, int pro_Quantity, int pro_MaxQuantity, string pro_Type, string sup_ID, string pro_Description, string pro_Status)
        {
            this.Pro_ID = pro_ID;
            this.Pro_Name = pro_Name;
            this.Pro_Price = pro_Price;
            this.Pro_Quantity = pro_Quantity;
            this.Pro_MaxQuantity = pro_MaxQuantity;
            this.Pro_Type = pro_Type;
            this.Sup_ID = sup_ID;
            this.Pro_Description = pro_Description;
            this.Pro_Status = pro_Status;
        }
        public Product(string Pro_ID)
        {
            this.Pro_ID = Pro_ID;
        }
        public Product(string pro_ID = null, string pro_Name = null, decimal? pro_Price = null, int? pro_Quantity = null, int? pro_MaxQuantity = null, string pro_Type = null, string sup_ID = null, string pro_Description = null, string pro_Status = null)
        {
            this.Pro_ID = pro_ID;
            this.Pro_Name = pro_Name;
            this.Pro_Price = pro_Price ?? 0m;
            this.Pro_Quantity = pro_Quantity ?? 0;
            this.Pro_MaxQuantity = pro_MaxQuantity ?? 0;
            this.Pro_Type = pro_Type;
            this.Sup_ID = sup_ID;
            this.Pro_Description = pro_Description;
            this.Pro_Status = pro_Status;
        }
       
        public Product(DataRow row)
        {
            Pro_ID = row["Pro_ID"]?.ToString();
            Pro_Name = row["Pro_Name"]?.ToString();
            Pro_Price = row["Pro_Price"] != DBNull.Value ? Convert.ToDecimal(row["Pro_Price"]) : 0m;
            Pro_Quantity = row["Pro_Quantity"] != DBNull.Value ? Convert.ToInt32(row["Pro_Quantity"]) : 0;
            Pro_MaxQuantity = row["Pro_MaxQuantity"] != DBNull.Value ? Convert.ToInt32(row["Pro_MaxQuantity"]) : 0;
            Pro_Type = row["Pro_Type"]?.ToString();
            Sup_ID = row["Sup_ID"]?.ToString();
            Pro_Description = row["Pro_Description"]?.ToString();
            Pro_Status = row["Pro_Status"]?.ToString();
        }
        public Product(string pro_ID, int pro_Quantity) : this(pro_ID)
        {
            Pro_Quantity = pro_Quantity;
        }

        public Product(string pro_ID, decimal pro_Price, int pro_Quantity) : this(pro_ID)
        {
            Pro_Price = pro_Price;
            Pro_Quantity = pro_Quantity;
        }
    }
}
